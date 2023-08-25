using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonusChangeStage : ItemBonus
{
    public ItemBonusChangeStage(ItemBonusChangeStageProperties properties, Building _Building) : base(properties, _Building)
    {

    }
    public ItemBonusChangeStage(StorageDictionary storage) : base(storage)
    {
    }

    public override void Collect()
    {
        base.Collect();
        //tao building moi
        var nextStage = (BuildingProperties as ItemBonusChangeStageProperties).nextStage;
        StartBuildingProperties startBuildingProperties = this.Building.StartBuildingProperties;
        startBuildingProperties.SetBuildingName(nextStage);
        FarmMapController.Instance.IsLandInfo.PlaceBuildingWithBuidingName(nextStage, startBuildingProperties, PopupManagerView.Instance.PopupManager, FarmMapController.Instance.TimeKeeper);
    }

    public override StorageDictionary Serialize()
    {
        var _storage = base.Serialize();
        return _storage;
    }
    public override void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        base.ResolveDependencies(game, isLandInfo, building);
    }
}
