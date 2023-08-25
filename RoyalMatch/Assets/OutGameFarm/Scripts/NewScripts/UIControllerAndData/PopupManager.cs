using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PopupManager
{
    //CÁC SỰ KIỆN NHƯ LÀ REQUEST MỞ ĐÓNG CHANGE CLEAR QUEUE
    public delegate void PopupRequestedEventHandler(PopupRequest request);

    public delegate void PopupOpenedEventHandler(PopupRequest request);

    public delegate void PopupClosedEventHandler(PopupRequest request);

    public delegate void CurrentPopupChangedEventHandler(PopupRequest request);

    public delegate void PopupQueueClearedEventHandler();

    //list queue cho popup và lisst đã mở
    private List<PopupRequest> _popupQueue = new List<PopupRequest>();
    private List<PopupRequest> _openedPopupRequests = new List<PopupRequest>();

    public bool IsShowingPopup
    {
        get { return _popupQueue.Count > 0; }
    }

    public event PopupRequestedEventHandler PopupRequestedEvent;
    public event PopupOpenedEventHandler PopupOpenedEvent;
    public event PopupClosedEventHandler PopupClosedEvent;
    public event CurrentPopupChangedEventHandler CurrentPopupChangedEvent;
    public event PopupQueueClearedEventHandler PopupQueueClearedEvent;

    private void FirePopupRequestedEvent(PopupRequest request)
    {
        if (this.PopupRequestedEvent != null)
        {
            this.PopupRequestedEvent(request);
        }
    }

    private void FirePopupOpenedEvent(PopupRequest request)
    {
        if (this.PopupOpenedEvent != null)
        {
            this.PopupOpenedEvent(request);
        }
    }

    private void FireCurrentPopupChangedEvent(PopupRequest request)
    {
        if (this.CurrentPopupChangedEvent != null)
        {
            this.CurrentPopupChangedEvent(request);
        }
    }

    private void FirePopupQueueClearedEvent()
    {
        if (this.PopupQueueClearedEvent != null)
        {
            this.PopupQueueClearedEvent();
        }
    }

    private void FirePopupClosedEvent(PopupRequest request)
    {
        if (this.PopupClosedEvent != null)
        {
            this.PopupClosedEvent(request);
        }
    }

    //GỦI REQUEST CHO VIỆC 
    public void RequestPopup(PopupRequest request)
    {
        //NEEUS KHÔNG PHẢ ĐANG MỞ VÀ REQUEST UNQUE BẰNG NULL THÌ BỎ VÀO QUIPE VÀ MỞ::
        if (!IsShowingPopup || !request.Enqueue)
        {
            _popupQueue.Add(request);
            FirePopupRequestedEvent(request);
            OpenPopup(request);
        }
        //KHÔNG THÌ INSER VÀO QUE THÔI INSERT ĐẦU TIÊN TRONG QUEUE
        else
        {
            _popupQueue.Insert(0, request);
            FirePopupRequestedEvent(request);
        }
    }

    public void ClearPopupQueue()
    {
        _popupQueue.Clear();
        _openedPopupRequests.Clear();
        FirePopupQueueClearedEvent();
    }

    private void OpenPopup(PopupRequest request)
    {
        if (!_openedPopupRequests.Contains(request))
        {
            //NẾU REQUEST KHÔNG VALIS THÌ BỎ QUA CMNR
            if (!request.IsValid)
            {
                _popupQueue.Remove(request);
                return;
            }

            //CHO VÀO LIST
            _openedPopupRequests.Add(request);
            //BẮN EVEN ĐỂ VIEW BẮT
            FirePopupOpenedEvent(request);
        }
        else if (!request.IsValid)
        {
            ClosePopup(request);
            return;
        }

        FireCurrentPopupChangedEvent(request);
    }


    //ĐÓNG TẤT CẢ POPUP LẠI::
    public void CloseAllOpenPopups()
    {
        List<PopupRequest> list = new List<PopupRequest>(_openedPopupRequests);
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            ClosePopup(list[i]);
        }
    }


    //ĐÓNG TẤT CẢ POPUP LÀ TOP CỦA POP NÀO ĐÓ::

    public void CloseAllPopupsOnTopOf(PopupRequest request)
    {
        int num = _popupQueue.IndexOf(request);
        if (num == -1)
        {
            Debug.LogErrorFormat("Cannot close popup on top of {0} as it hasn't been queued.",
                request.GetPopupType.Name);
        }
        else
        {
            while (_popupQueue.Count > num)
            {
                ClosePopup(_popupQueue[_popupQueue.Count - 1]);
            }
        }
    }


    //ĐÓNG POPUP CLOSSE:::
    public void ClosePopup(PopupRequest request)
    {
        if (request == null)
        {
            Debug.LogError("ClosePopup should not be called with `null`!");
        }
        //NẾU QUEUE VẪN CO REQUEST THÌ SẼ REMOVE ĐI NẾU ....
        else if (IsShowingPopup)
        {
            if (_popupQueue.Contains(request))
            {
                _popupQueue.Remove(request);
                if (_openedPopupRequests.Contains(request))
                {
                    _openedPopupRequests.Remove(request);
                    FirePopupClosedEvent(request);
                }
                else
                {
                    Debug.LogErrorFormat(
                        "Wanting to close popup {0} but it is already closed. This should not be happening (bad coding?)",
                        request.GetPopupType.Name);
                }

                //SAU ĐÓ THÌ MỞ REQUEST VỚI 1 LÙI 1 PHÁT 
                if (_popupQueue.Count > 0)
                {
                    PopupRequest request2 = _popupQueue[_popupQueue.Count - 1];
                    OpenPopup(request2);
                }
            }
            else
            {
                Debug.LogErrorFormat("Cannot close popup as it hasn't been opened: {0}", request.GetPopupType.Name);
            }
        }
    }

    //Đóng popup hiện tại
    public void CloseCurrentPopup()
    {
        if (_popupQueue.Count > 0)
        {
            ClosePopup(_popupQueue[_popupQueue.Count - 1]);
        }
    }

    //l à popup current với type là hiện tại
    public bool IsCurrentPopup(Type popupType)
    {
        if (!IsShowingPopup)
        {
            return false;
        }

        return _popupQueue[_popupQueue.Count - 1].GetPopupType == popupType;
    }

    public bool IsPopupQueued(Type popupType)
    {
        if (!IsShowingPopup)
        {
            return false;
        }

        return _popupQueue.Exists((PopupRequest x) => x.GetPopupType == popupType);
    }
}