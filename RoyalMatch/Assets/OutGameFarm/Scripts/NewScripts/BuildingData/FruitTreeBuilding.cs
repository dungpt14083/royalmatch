using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTreeBuilding : ICanSerialize
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

    public FruitTreeProperties FruitTreeProperties { get; private set; }

    public Currency RemainCostForDestroy;
    public GeneralBalance GeneralBalance { get; private set; }

    public IsLandInfo IsLandInfo { get; private set; }
    
    public Building Building { get; private set; }
    
    public TileManager TileManager { get; private set; }
    public bool IsProcessCollect { get; set; }
    
    
    public PopupManager PopupManager { get; private set; }
    public IslandFarmProperties IslandFarmProperties { get; private set; }
    public GeneralProperties GeneralProperties { get; private set; }
    private TimeKeeper TimeKeeper;

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
    public FruitTreeBuilding(FruitTreeProperties treeProperties, IslandFarmProperties properties, GeneralBalance generalBalance,
        TimeKeeper timeKeeper, PopupManager popupManager, GeneralProperties generalProperties,IsLandInfo isLandInfo,Building building)
    {
        GeneralBalance = generalBalance;
        GeneralProperties = generalProperties;
        TimeKeeper = timeKeeper;
        FruitTreeProperties = treeProperties;
        PopupManager = popupManager;
        RemainCostForDestroy = treeProperties.DestroyCost;
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
        IsProcessCollect = false;
        
    }

    public FruitTreeBuilding(StorageDictionary storage)
    {
        _storage = storage;
    }

    public StorageDictionary Serialize()
    {
        return _storage ??= new StorageDictionary();
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
    }
}
