using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FarmFieldBuilding : ICanSerialize
{
    public delegate void FieldClearedEventHandler(bool cropsCollected);

    public delegate void CropsAreHarvestReadyEventHandler(FarmFieldBuilding farmFieldBuilding);

    public delegate void CropsStartedGrowingEventHandler();

    public delegate void CropsBecameWitheredEventHandler();

    public event FieldClearedEventHandler FieldClearedEvent;
    public event CropsAreHarvestReadyEventHandler CropsAreHarvestReadyEvent;
    public event CropsStartedGrowingEventHandler CropsStartedGrowingEvent;
    public event CropsBecameWitheredEventHandler CropsBecameWitheredEvent;
    public event Action<bool> FarmCollectEvent;

    private void FireFieldClearedEvent(bool cropsCollected)
    {
        if (this.FieldClearedEvent != null)
        {
            this.FieldClearedEvent(cropsCollected);
        }
    }

    private void FireCropsAreHarvestReadyEvent()
    {
        if (this.CropsAreHarvestReadyEvent != null)
        {
            this.CropsAreHarvestReadyEvent(this);
        }
    }

    private void FireCropsStartedGrowingEvent()
    {
        if (this.CropsStartedGrowingEvent != null)
        {
            this.CropsStartedGrowingEvent();
        }
    }

    private void FireCropsBecameWitheredEvent()
    {
        if (this.CropsBecameWitheredEvent != null)
        {
            this.CropsBecameWitheredEvent();
        }
    }


    //private ContructionSiteStating _construction;

    private IslandFarmProperties IslandFarmProperties;

    public TimeKeeper _timeKeeper { get; private set; }


    public GeneralBalance GeneralBalance { get; private set; }
    public GeneralProperties GeneralProperties { get; private set; }


    public FarmfieldBuildingProperties FarmfieldBuildingProperties { get; private set; }

    public FarmfieldState State { get; private set; }

    public UpspeedableProcess FieldProcess { get; private set; }

    public bool CanGrow
    {
        get
        {
            return /*_construction != null && _construction.State == ConstructionState.Completed &&*/
                   State == FarmfieldState.Empty;
        }
    }

    public Currency Reward { get; private set; }
    public SowingMaterialProperties SowedMaterial { get; private set; }
    public PopupManager PopupManager { get; private set; }

    private float growthTimer;
    
    public void StartGrowing(BasicMaterialProperties cropProp)
    {
        if (CanGrow)
        {
            growthTimer = cropProp.ProductionTimeSeconds;
            Currencies cost = cropProp.Cost;
            if (GeneralBalance.CanSpendCurrencies(cost))
            {
                GeneralBalance.SpendCurrencies(cost, false, Drain.BuyLivestockCrop);

                Reward = new Currency(cropProp.CurrencyName, 1L);
                SowedMaterial =
                    FarmfieldBuildingProperties.SowingMaterialProperties.Find((SowingMaterialProperties c) =>
                        c.CurrencyName == Reward.Name);
                State = FarmfieldState.Growing;
                FieldProcess = new UpspeedableProcess(IslandFarmProperties, _timeKeeper, cropProp.ProductionTimeSeconds,
                    1.0,
                    1f, TransitionFromGrowingToHarvestReady, GeneralProperties);
                
                FireCropsStartedGrowingEvent();
                ObjectiveTrackerSignals.FarmPlantEvent.Dispatch(new FarmPlantEventData(this));
            }
        }
        else
        {
            Debug.LogError("Cannot grow " + cropProp.CurrencyName +
                           " because the farmfield isn't empty. Check 'CanGrow` before calling 'StartGrowing'!");
        }
    }
    private void TransitionFromGrowingToHarvestReady()
    {
        State = FarmfieldState.HarvestReady;
        FireCropsAreHarvestReadyEvent();
        SowingMaterialProperties sowingMaterialProperties =
            FarmfieldBuildingProperties.SowingMaterialProperties.Find((SowingMaterialProperties c) =>
                c.CurrencyName == Reward.Name);
        // if (sowingMaterialProperties != null)
        // {
        //     FieldProcess = new UpspeedableProcess(IslandFarmProperties, _timeKeeper,
        //         sowingMaterialProperties.WitherTimeSeconds, 1.0, 1f, TransitionFromHarvestReadyToWithered,
        //         GeneralProperties);
        //     return;
        // }
    }

    private void TransitionFromHarvestReadyToWithered()
    {
        State = FarmfieldState.Withered;
        FireCropsBecameWitheredEvent();
    }
    

    public bool Collect()
    {
        if (State == FarmfieldState.HarvestReady && FarmMapController.Instance.EarnCurrencies(Reward))
        {
            //THU HOẠCH::::
            ObjectiveTrackerSignals.FarmHarvestEvent.Dispatch(new FarmPlantEventData(this));
            Reward = null;
            FieldProcess.CancelAction();
            State = FarmfieldState.Empty;
            FireFieldClearedEvent(true);
            FarmCollectEvent?.Invoke(true);
            return true;
        }

        // if (State == FarmfieldState.Withered)
        // {
        //     Reward = null;
        //     State = FarmfieldState.Empty;
        //     FireFieldClearedEvent(false);
        //     return true;
        // }

        return false;
    }

    #region saveandload

    private StorageDictionary _storage;


    public FarmFieldBuilding(FarmfieldBuildingProperties farmFieldProps/*, ContructionSiteStating construction*/,
        IslandFarmProperties islandFarmProperties, GeneralBalance generalBalance, TimeKeeper time,
        PopupManager popupmanager, GeneralProperties generalProperties)
    {
        Setup(farmFieldProps/*, construction*/, islandFarmProperties, generalBalance, time, popupmanager,
            generalProperties);
        State = FarmfieldState.Empty;
    }


    public FarmFieldBuilding(StorageDictionary storage)
    {
        _storage = storage;
        State = (FarmfieldState)storage.Get("FarmfieldState", 0);
        if (_storage.Contains("Reward"))
        {
            Reward = new Currency(_storage.GetStorageDict("Reward"));
        }

        if (State == FarmfieldState.Growing || State == FarmfieldState.HarvestReady)
        {
            FieldProcess = new UpspeedableProcess(_storage.GetStorageDict("FieldProcess"));
        }
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("FarmfieldState", (int)State);
        _storage.SetOrRemove("Reward", Reward);
        _storage.SetOrRemove("FieldProcess", FieldProcess);
        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        Setup((FarmfieldBuildingProperties)building.BuildingProperties/*, building.Construction*/,
            isLandInfo.IslandFarmProperties, game.GeneralBalance,
            game.Time,
            game.PopupManager, game.GeneralProperties);

        if (Reward != null)
        {
            SowedMaterial =
                FarmfieldBuildingProperties.SowingMaterialProperties.Find((SowingMaterialProperties c) =>
                    c.CurrencyName == Reward.Name);
        }

        switch (State)
        {
            case FarmfieldState.Growing:
                FieldProcess.ResolveDependencies(game, isLandInfo, TransitionFromGrowingToHarvestReady);
                break;
            case FarmfieldState.HarvestReady:
                FieldProcess.ResolveDependencies(game, isLandInfo, TransitionFromHarvestReadyToWithered);
                break;
        }
    }

    private void Setup(FarmfieldBuildingProperties farmFieldProps/*, ContructionSiteStating construction*/,
        IslandFarmProperties islandFarmProperties, GeneralBalance generalBalance, TimeKeeper time,
        PopupManager popupManager, GeneralProperties generalProperties)
    {
        //_construction = construction;
        FarmfieldBuildingProperties = farmFieldProps;
        IslandFarmProperties = islandFarmProperties;
        _timeKeeper = time;
        PopupManager = popupManager;
        GeneralBalance = generalBalance;
        GeneralProperties = generalProperties;
    }

    #endregion
}