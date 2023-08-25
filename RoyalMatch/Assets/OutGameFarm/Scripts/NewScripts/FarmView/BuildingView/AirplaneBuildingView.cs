using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AirplaneBuildingView : UpgradeHouseView
{
    //public override void Init(BuildingData _BuildingData)
    //{
    //    base.Init(_BuildingData);
    //    if (txtNameBuilding != null) txtNameBuilding.text = _BuildingData.GetName();
    //}
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (!IsCanUse()) return;
        PopupManagerView.Instance.PopupManager.RequestPopup(new AirplanePopupRequest(BuildingData as AirplaneBuilding));
    }
}
