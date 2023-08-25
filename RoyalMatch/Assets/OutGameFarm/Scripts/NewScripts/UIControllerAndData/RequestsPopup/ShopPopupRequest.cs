using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPopupRequest : PopupRequest
{
    public ShopPopupRequest()
        : base(typeof(ShopPopup), true, true)
    {
    }
}