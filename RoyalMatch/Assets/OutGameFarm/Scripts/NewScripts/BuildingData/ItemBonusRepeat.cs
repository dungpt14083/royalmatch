using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonusRepeat : ItemBonus
{
    public ItemBonusRepeat(ItemBonusRepeatProperties properties, Building _Building) : base(properties, _Building)
    {
    }
    public ItemBonusRepeat(StorageDictionary storage) : base(storage)
    {
    }
    public override void Collect()
    {
        base.Collect();
        //tao item moi
        ItemBonusManager.Instance.AddGridIndexEmpty(Building.Area.Index);
        ItemBonusRepeatProperties itemBonusRepeatProperties = BuildingProperties as ItemBonusRepeatProperties;
        ItemBonusManager.Instance.CreateItemBonusRepeatProcess(itemBonusRepeatProperties);
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
