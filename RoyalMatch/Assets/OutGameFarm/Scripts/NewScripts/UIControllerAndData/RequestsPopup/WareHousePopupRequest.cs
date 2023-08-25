using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHousePopupRequest : PopupRequest
{
    public WareHouseBuilding Warehouse { get; private set; }

    public WareHousePopupRequest(WareHouseBuilding warehouse)
        : base(typeof(WareHousePopup), true, true)
    {
        Warehouse = warehouse;
    }
}