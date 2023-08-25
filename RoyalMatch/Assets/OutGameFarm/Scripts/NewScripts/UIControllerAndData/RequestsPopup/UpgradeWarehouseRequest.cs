using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeWarehouseRequest : PopupRequest
{
  public WareHouseBuilding Warehouse { get; private set; }
  private Sprite sprIcon;

  public UpgradeWarehouseRequest(WareHouseBuilding warehouse,Sprite sprIcon) : base(typeof(UpgradeWareHousePopup), true, true)
  {
    Warehouse = warehouse;
    this.sprIcon = sprIcon;
  }

  public Sprite GetSprite()
  {
    return sprIcon;
  }
}
