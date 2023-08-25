using UnityEngine.EventSystems;

public class TrainBuildingView : UpgradeHouseView
{
    //public override void Init(BuildingData _BuildingData)
    //{
    //    base.Init(_BuildingData);
    //    //(BuildingData as UpgradeHouse).LevelUpEvent += OnWarehouseLevelUp;
    //    //_sprites =
    //    //    SingletonMonobehaviour<UpgradeBuildingSpritesAssetCollection>.Instance.GetAsset(BuildingData.BuildingProperties
    //    //        .SpriteReference);
    //    //UpdateBuildingSprite();
    //    if (txtNameBuilding != null) txtNameBuilding.text = _BuildingData.GetName();
    //}
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (!IsCanUse()) return;
        PopupManagerView.Instance.PopupManager.RequestPopup(new TrainPopupRequest(BuildingData as TrainBuilding));
    }
}
