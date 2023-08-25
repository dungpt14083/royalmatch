using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedupPopupRequest : PopupRequest
{
    public Currency currencyBuy;
    public Action actionSpeedUpComplete;
    public BuildingData buildingData;
    public SpeedupPopupRequest(BuildingData _buildingData, Currency _currencyBuy, Action _actionSpeedUpComplete)
        : base(typeof(BuyItemsPopup), true, true)
    {
        currencyBuy = _currencyBuy;
        actionSpeedUpComplete = _actionSpeedUpComplete;
        buildingData = _buildingData;
    }
}
