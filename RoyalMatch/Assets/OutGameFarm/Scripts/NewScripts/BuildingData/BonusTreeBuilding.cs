using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTreeBuilding : ICanSerialize
{

    public delegate void FillFullDestroyCostEventHandler();

    public delegate void UpdateDestroyCostEventHandler();

    public event FillFullDestroyCostEventHandler FillFullDestroyCostEvent;
    
    public event UpdateDestroyCostEventHandler UpdateDestroyCostEvent;

    private void FireFillFullDestroyCostEventHandler()
    {
        this.FillFullDestroyCostEvent?.Invoke();
    }
    private void FireUpdateDestroyCostEventHandler()
    {
        this.UpdateDestroyCostEvent?.Invoke();
    }
    public BonusTreeProperties BonusTreeProperties { get; private set; }
    public Currency RemainCostForDestroy;
    public GeneralBalance GeneralBalance { get; private set; }
    public IsLandInfo IsLandInfo { get; private set; }
    
    public Building Building { get; private set; }
    
    public TileManager TileManager { get; private set; }
    public bool IsProcessCollect { get; set; }
    private TimeKeeper TimeKeeper;

    
    public PopupManager PopupManager { get; private set; }
    public IslandFarmProperties IslandFarmProperties { get; private set; }
    public GeneralProperties GeneralProperties { get; private set; }
    
    public bool CanSpendCurrencies()
    {
        return GeneralBalance.CanSpendCurrencies(RemainCostForDestroy);
    }
    public bool SpendCostForDestroy()
    {
        if (TileManagerView.Instance != null && TileManagerView.Instance.IsTileReached(Building.Area))
        {
            if (GeneralBalance.SpendCurrencies(RemainCostForDestroy, false, Drain.DestroyGatherable))
            {
                FireFillFullDestroyCostEventHandler();
                IsLandInfo.RemoveBuilding(Building);
                return true;
            }
        }
        else
        {
            Debug.LogError("không phá được");
        }

        return false;
    }

    private StorageDictionary _storage;

    public BonusTreeBuilding(BonusTreeProperties bonusTreeProperties, IslandFarmProperties islandFarmProperties,
        GeneralBalance generalBalance, TimeKeeper timeKeeper, PopupManager popupManager,
        GeneralProperties generalProperties, IsLandInfo isLandInfo, Building building)
    {
        GeneralBalance = generalBalance;
        GeneralProperties = generalProperties;
        TimeKeeper = timeKeeper;
        BonusTreeProperties = bonusTreeProperties;
        PopupManager = popupManager;
        RemainCostForDestroy = BonusTreeProperties.DestroyCost;
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
        IsProcessCollect = false;
    }

    public BonusTreeBuilding(StorageDictionary storage)
    {
        _storage = storage;
    }
    
    public StorageDictionary Serialize()
    {
        return _storage ??= new StorageDictionary();
    }

    public void ResolveDependencies(GameData gameData, IsLandInfo isLandInfo, Building building)
    {
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
    }
}
