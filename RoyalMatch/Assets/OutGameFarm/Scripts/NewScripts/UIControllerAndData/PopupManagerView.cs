using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class PopupManagerView : MonoSingleton<PopupManagerView>
{
    public delegate void PopupShownEventHandler(Popup popup);

    public delegate void PopupHiddenEventHandler(Popup popup);

    //list popup
    [SerializeField] private Popup[] _popups;

    //2 cái này lưu modalbackgound vafinput đầu vào island quản lí
    //[SerializeField] private ModalBackground _modalBackground;
    [SerializeField] private IsLandInput _islandInput;

    public PopupManager PopupManager => _popupManager;

    //lõi quản lí
    private PopupManager _popupManager;

    //list dictionay và thằng popup đang mở 
    private Dictionary<Type, Popup> _popupsDict = new Dictionary<Type, Popup>();
    private List<PopupRequest> _openedPopupRequests = new List<PopupRequest>();

    public event PopupShownEventHandler PopupShownEvent;
    public event PopupHiddenEventHandler PopupHiddenEvent;

    private void FirePopupShownEvent(Popup popup)
    {
        if (this.PopupShownEvent != null)
        {
            this.PopupShownEvent(popup);
        }
    }

    private void FirePopupHiddenEvent(Popup popup)
    {
        if (this.PopupHiddenEvent != null)
        {
            this.PopupHiddenEvent(popup);
        }
    }

    private void OnDestroy()
    {
        if (_popupManager != null)
        {
            _popupManager.CurrentPopupChangedEvent -= OnCurrentPopupChanged;
            _popupManager.PopupClosedEvent -= OnPopupClosed;
            _popupManager.PopupQueueClearedEvent -= OnPopupQueueCleared;
            _popupManager.ClearPopupQueue();
            _popupManager = null;
        }
    }

    public void Init(GameData game, IsLandInfo isLandInfo)
    {
        _popupsDict.Clear();
        _popupManager = game.PopupManager;
        _popupManager.CurrentPopupChangedEvent += OnCurrentPopupChanged;
        _popupManager.PopupClosedEvent += OnPopupClosed;
        _popupManager.PopupQueueClearedEvent += OnPopupQueueCleared;

        //Duyệt qua mảng popop init thông tin vào
        int num = _popups.Length;
        for (int i = 0; i < num; i++)
        {
            Type type = _popups[i].GetType();
            if (!_popupsDict.ContainsKey(type))
            {
                _popups[i].Init(game, isLandInfo);
                _popupsDict.Add(type, _popups[i]);
            }
            else
            {
                Debug.LogErrorFormat("Duplicate entry found! {0} has already been added to PopupManager.", type.Name);
            }
        }
    }

    //NGHE SỰ KIỆN BÊN TẰNG POPUPMANAAGER LÕI KHI CÓ POPUP ĐƯỢC MỞ LÊN
    private void OnCurrentPopupChanged(PopupRequest request)
    {
        Popup popup = GetPopup(request);
        if (!(popup != null))
        {
            return;
        }

        //TRONG LIST NẾU CHUAW CÓ THÌ LÀ CHƯA MỞ
        if (!_openedPopupRequests.Contains(request))
        {
            int count = _openedPopupRequests.Count;
            //XM REUEST SỬ DỤNG NỀN CHẠY THÌ SHOW VÀ SETACTIVE....
            if (request.UseModalBackground)
            {
                // _modalBackground.Show(popup);
                //_modalBackground.transform.SetAsLastSibling();
            }

            //NẾU LÀ LOẠI DISABLE GRIDINPUT TH SẼ GỌI TỚI::ể disable đi
            if (request.DisableGridObjectInteractions)
            {
                _islandInput.DisableIslandInteraction(popup);
            }

            if (request.HideChildPopups)
            {
                //ChangeUnderlyingPopupsVisibility(count, true);
            }

            //_overlayManager.DisableInteractionRequest(popup);
            _openedPopupRequests.Add(request);
        }

        popup.transform.SetAsLastSibling();

        //NÊU POPUP CHƯA OPEN THÌ GỌI VÀO OPEN TRUYỀN REQUEST VÀ BẮN EVENT
        if (!popup.IsOpen)
        {
            popup.Open(request);
            FirePopupShownEvent(popup);
        }
        //NẾU KHÔNG SHOWRING THÌ REFRESH UPDATE
        else if (!popup.IsShowingRequest(request))
        {
            popup.Refresh(request);
            FirePopupShownEvent(popup);
        }
    }


    private Popup GetPopup(PopupRequest request)
    {
        return GetPopup(request.GetPopupType);
    }

    private Popup GetPopup(Type popupType)
    {
        Popup value;
        if (!_popupsDict.TryGetValue(popupType, out value))
        {
            Debug.LogErrorFormat("Requested popup cannot be found: {0}", popupType);
            return null;
        }

        return value;
    }

    private void ChangeUnderlyingPopupsVisibility(int requesterIndex, bool hideUnderlyingPopups)
    {
        for (int num = requesterIndex - 1; num >= 0; num--)
        {
            Popup popup = GetPopup(_openedPopupRequests[num]);
            if (popup.IsOpen)
            {
                popup.gameObject.SetActive(!hideUnderlyingPopups);
            }
        }
    }

    //ĐÓNG POPUP NÀO NAFO:::
    private void OnPopupClosed(PopupRequest request)
    {
        Popup popup = GetPopup(request);
        if ((popup.IsOpen || !request.IsValid) && _openedPopupRequests.Contains(request))
        {
            ClosePopup(popup, request);
        }
        else
        {
            Debug.LogErrorFormat(
                "Wanting to close popup {0} but it is already closed. This should not be happening (bad coding?)",
                request.GetPopupType.Name);
        }

        FirePopupHiddenEvent(popup);
    }

    private void ClosePopup(Popup popup, PopupRequest request)
    {
        int requesterIndex = _openedPopupRequests.IndexOf(request);
        // ...
        if (request.UseModalBackground)
        {
            //_modalBackground.Hide(popup);
        }

        //KHI TẮT POPUP MỚI CHO THAO TÁC TRÊN MÀN HÌNH
        if (request.DisableGridObjectInteractions)
        {
            _islandInput.EnableIslandInteraction(popup);
        }

        if (request.HideChildPopups)
        {
            ChangeUnderlyingPopupsVisibility(requesterIndex, false);
        }

        //_overlayManager.EnableInteractionRequest(popup);
        if (popup.IsOpen)
        {
            popup.Close();
        }

        _openedPopupRequests.Remove(request);
    }

    private void OnPopupQueueCleared()
    {
        for (int num = _openedPopupRequests.Count - 1; num >= 0; num--)
        {
            PopupRequest request = _openedPopupRequests[num];
            Popup popup = GetPopup(request);
            ClosePopup(popup, request);
        }

        _openedPopupRequests.Clear();
    }
}