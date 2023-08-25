using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsShopPopupRequest : PopupRequest
{
    public ShopCategory Category { get; private set; }

    //??????
    public BuildingProperties ScrollToBuilding { get; private set; }

    public BuildingsShopPopupRequest(ShopCategory category, BuildingProperties scrollToBuilding)
        : base(typeof(BuildingsShopPopup), false, true, false, true)
    {
        Category = category;
        ScrollToBuilding = scrollToBuilding;
    }
}