using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapActionQueueManager : MonoSingleton<MapActionQueueManager>
{
    //List ACTION:::
    private List<MapAction> _actionQueue;
    private PopupManager _popupManager;
    private bool _queueLock;

    public MapAction CurrentAction { get; set; }


    //CHỈ INIT CHO VUI CHỨ CÁI NÀY PHẢI SINGLETION DONDESSTROY SỐNG QUA CÁC SCENE ĐỂ MÀ THỰC HIỆN HÀNH ĐỘNG::::::
    public void Init(PopupManager popupManager)
    {
        _actionQueue = new List<MapAction>();
        CurrentAction = null;
        _popupManager = popupManager;
        this.CheckQueue();
    }
    
    
    //CHO SỰ KIỆN KHI LOADING XONG 1 SCENE 
    //Khi load xong thì check quue xem có quuee nào cần chạy k vậy cái này nos sẽ qua các map:::
    private void OnLoadingFinish(bool initialLoading)
    {
        if (initialLoading)
        {
            this.InitialCheckQueue();
            return;
        }

        this.CheckQueue();
    }
    
    private void InitialCheckQueue()
    {
        if (_actionQueue.Count < 1)
        {
            return;
        }

        this.CheckQueue();
    }




    #region QUEUE TO ACTIONS::

    //ĐƯA ACTION VÀO QUUEUE VÀ CHẠY CHECK QUÊU 
    //Dựa action vào quieue
    public void QueueAction(MapAction action)
    {
        action.MapActionQueueManager = this;
        this._actionQueue.Add(item: action);
        this.CheckQueue();
    }

    //DƯA VÀO VỊ TRÍ NÀO ĐÓ
    public void QueueAction(MapAction action, int position)
    {
        action.MapActionQueueManager = this;
        this._actionQueue.Insert(index: position, item: action);
        this.CheckQueue();
    }

    #endregion
    
 
    
    
    
    
    

    public void CheckQueue()
    {
        //NẾU LOADING ĐANG CHƠI HOẶC QUUE ĐANG LOCK THÌ SẼ KHÔNG LÀM GÌ CẢ:::
        //LOADINGSERVICE ĐANG ISLOADING THÌ SE...:::
        if ( /*static_value_02422123.IsLoading() || */this._queueLock)
        {
            return;
        }

        
        
        //ĐANG CÓ ACTION CHẠY THÌ CŨNG RETURN
        //TUWSC CÓ ACTION VÀ NÓ ISCOMPLETED THÌ CÓ THỂ ĐẨY VÀO 
        //ACTION COMPLETED RỒI THÌ K CHẠY NỮA CHẠY ACTION MỚI CHỨ::: CHỨ K PHẢI LÀ 
        if (this.CurrentAction != null && this.CurrentAction.IsCompleted())
        {
            return;
        }

        //ĐƯA VÔ EXTENSION LẤY RA NGOÀI 
        if (this._actionQueue.Count > 0)
        {
            MapAction nextAction = ExtensionUtils.Dequeue<MapAction>(this._actionQueue);
            this.CurrentAction = nextAction;

            //ẨN THẤT CẢ GIỮ POPUP BẰNG FLASE THÌ ĐÓNG HẾT POPUP Ở NGOÀI MÀN HÌNH
            //TỨC LÀ KHÔNG CÓ GIỮ POPUP Ở LẠI ACTION NÀY KHÔNG CÓ GIỮ POPUP MÀ BẮT ẨN NÓ ĐI
            if (!this.CurrentAction.KeepPopups)
            {
                //this._popupManager.CloseAllOpenPopups();
                //this._mapStateManager.HideAllContexts();
            }
            CurrentAction.Play();
        }
    }
    
    
    
    
    
    
    public void SetLock(bool status)
    {
        this._queueLock = status;
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region CHƯA THASAYS Ý NGHĨA::

    //LẤY POPRUPPOPP  CÁI NÀY TINHSAU ĐI
    public bool ShouldHoldHudForNextPopupAction()
    {
        // PopupManager popupManager = this._popupManager;
        //
        // PopupAction nextPopupAction = this.GetNextPopupAction();
        // if (nextPopupAction != null)
        // {
        //     popupManager = nextPopupAction._dailyLoginService;
        //     if (popupManager != PurchaseFailPopup.Data.__il2cppRuntimeField_typeHierarchyDepth)
        //     {
        //         return true;
        //     }
        // }

        return false;
    }

    //CHO VIỆC LẤY POPUPACTION TRONG QUUE LÀ LOẠI POPUPACTION
    // public PopupAction GetNextPopupAction()
    // {
    //     int count = this._actionQueue.Count;
    //     for (int i = 0; i < count; i++)
    //     {
    //         if (true <= i)
    //         {
    //             throw new System.ArgumentOutOfRangeException();
    //         }
    //     }
    //
    //     return null;
    // }

    #endregion
}