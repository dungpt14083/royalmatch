using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIVIEW : MonoBehaviour
{
    [SerializeField] private CurrencyView[] currencyViews;

    private FarmIsLandData _farmIsLandData;

    //THANG GIỐNG NHƯ SCENE HOME ẤN VÀO SẼ RA SHOP VÀ KHO CÁC THỨ:::
    public void Init(FarmIsLandData farmIsLandData, GridIgridObjectView gridIgridObjectView)
    {
        _farmIsLandData = farmIsLandData;
        for (int i = 0; i < currencyViews.Length; i++)
        {
            currencyViews[i].Init(_farmIsLandData.GameData.GeneralBalance, _farmIsLandData.GameData.PopupManager);
        }
    }

    public void OnShopButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new ShopPopupRequest());
        }
    }

    public void OnDailyRewardButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new DailyRewardPopupRequest());
        }
    }

    public void OnDailyMissionButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new DailyMissionRequestPopup());
        }
    }

    public void OnEventButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new EventCollectRequestPopup());
        }
    }

    public void OnEventRankButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new EventRankRequestPopup());
        }
    }
    public void OnEventCollectLightBallButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new EventCollectLightBallRequestPopup());
        }
    }
    public void OnEventRaceButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new EventRaceRequestPopup());
        }
    }
    public void OnEventLavalButtonClicked()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.PopupManager.RequestPopup(new EventFindPlayerRequestPopup());
        }
    }
}