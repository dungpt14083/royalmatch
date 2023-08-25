using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuildConfirmPopup : Popup
{
    //kiểm soát mở thằng buid preview....
    [SerializeField] private PreBuilderView preBuilderView;

    private BuildConfirmPopupRequest _confirmRequest;

    public delegate void BuildConfirmedEventHandler(BuildConfirmPopup buildConfirmPopup);

    private BuildConfirmedEventHandler m_BuildConfirmedEvent;
    public event BuildConfirmedEventHandler BuildConfirmedEvent;

   [SerializeField] private Button btnRecall;
   [SerializeField] private Button btnDecoration;
   [SerializeField] private Button btnComfirm; 
    private ItemShop _itemShop;

    private void FireBuildConfirmEvent()
    {
        if (this.BuildConfirmedEvent != null)
        {
            this.BuildConfirmedEvent(this);
        }
    }

    public override void Open(PopupRequest request)
    {
        //mở thì tạo preview ra ngoài::
        base.Open(request);
        btnRecall.gameObject.SetActive(false);
        OnActiveButton(false);
        _confirmRequest = GetRequest<BuildConfirmPopupRequest>();
        if (_confirmRequest.ItemShop != null)
        {
            _itemShop = _confirmRequest.ItemShop;
            OnActiveButton(true);
        }
        
        if (_confirmRequest.Building != null)
        {
            preBuilderView.StartMoving(_confirmRequest.Building, _confirmRequest.spriteRenderer);
            if (_confirmRequest.Building.Decoration != null)
            {
                btnRecall.gameObject.SetActive(true);
            }
        }
        else
        {
            preBuilderView.StartBuilding(_confirmRequest.BuildingProps);
        }
        GameSignals.EnableClickPlaneWhenShowPreBuilding.Dispatch(false);
    }

    public override void Close()
    {
        GameSignals.EnableClickPlaneWhenShowPreBuilding.Dispatch(true);
        preBuilderView.CancelProcess();
        base.Close();
    }

    public void OnConfirmClicked()
    {
        GameSignals.EnableClickPlaneWhenShowPreBuilding.Dispatch(true);
        if (preBuilderView.FinishProcess())
        {
            FireBuildConfirmEvent();
            OnCloseClicked();
        }
    }
    public void OnConfirmDecorationClicked()
    {
        GameSignals.EnableClickPlaneWhenShowPreBuilding.Dispatch(true);
        if (preBuilderView.FinishProcessDecoration())
        {
            FireBuildConfirmEvent();
            if (_itemShop != null)
            {
                _itemShop.RemovePurchasedDecoration();
            }
            OnCloseClicked();
        }
    }
    public void OnFlipClicked()
    {
        preBuilderView.FlipPreviewBuilding();
    }

    public void ReCallDecoration()
    {
        preBuilderView.ReCallDecoration();
        OnCloseClicked();
    }

    private void OnActiveButton(bool isActive)
    {
        btnDecoration.gameObject.SetActive(isActive);
        btnComfirm.gameObject.SetActive(!isActive);
    }
}