using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItemsPopupRequest : PopupRequest
{
    public Currencies currencies;
    public long valueBuy;
    public Action actionBuy;
    public BuyItemsPopupRequest(Currency _currencyBuy, Action _actionBuy)
        : base(typeof(BuyItemsPopup), true, true)
    {
        currencies = new Currencies();
        currencies.SetValue(_currencyBuy.Name, _currencyBuy.Amount);
        valueBuy = _currencyBuy.Amount;
        actionBuy = _actionBuy;
    }
    public BuyItemsPopupRequest(Currencies _currencyBuy, long _valueBuy,Action _actionBuy)
        : base(typeof(BuyItemsPopup), true, true)
    {
        currencies = _currencyBuy;
        valueBuy = _valueBuy;
        actionBuy = _actionBuy;
    }
}
