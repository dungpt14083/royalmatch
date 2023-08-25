public class ItemBonus : BuildingData
{
    public Building Building { get; private set; }
    public bool IsProcessCollect { get; set; }
    public ItemBonus(ItemBonusProperties properties, Building _Building) :base(properties, _Building)
    {
        Building = _Building;
        IsProcessCollect = false;
    }
    
    public ItemBonus(StorageDictionary storage): base (storage)
    {
    }

    public bool CanSpendCurrencies()
    {
        var cost = (BuildingProperties as ItemBonusProperties).costCollect;
        if (cost == null) return true;
        return FarmMapController.Instance.GetGeneralBalance().CanSpendCurrencies(cost);
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
    public bool SpendCostForDestroy()
    {
        var cost = (BuildingProperties as ItemBonusProperties).costCollect;
        if (cost == null) return true;
        var result = FarmMapController.Instance.SpendCurrencies(cost);
        if (result)
        {
            FarmMapController.Instance.EarnCurrencies((BuildingProperties as ItemBonusProperties).rewards);
            Collect();
        }
        return false;
    }
    public virtual void Collect()
    {
        if (FarmMapController.Instance.IsLandInfo == null) return;
        UnityEngine.Debug.Log("ItemBonus Collect");
        
        FarmMapController.Instance.IsLandInfo.RemoveBuilding(Building);
    }
}
