using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContructionSiteStating : ICanSerialize
{
    public delegate void ConstructionStateEventHandler(ContructionSiteStating contructionSiteStating);

    public event ConstructionStateEventHandler ConstructionFinishedEvent;
    public event ConstructionStateEventHandler ConstructionCompletedEvent;

    private void FireConstructionFinishedEvent()
    {
        if (this.ConstructionFinishedEvent != null)
        {
            this.ConstructionFinishedEvent(this);
        }
    }

    private void FireConstructionCompletedEvent()
    {
        if (this.ConstructionCompletedEvent != null)
        {
            this.ConstructionCompletedEvent(this);
        }
    }

    public BuildingProperties BuildingProperties { get; private set; }

    //public IslandFarmProperties IslandFarmProperties { get; private set; }

    public PopupManager PopupManager { get; private set; }

    public Building Building { get; private set; }
    public ConstructionState State { get; private set; }

    //public IslandFarmBalance IslandFarmBalance { get; private set; }
    public GeneralBalance GeneralBalance { get; private set; }

    public UpspeedableProcess ConstructionProcess { get; private set; }

    public bool CanComplete
    {
        get { return State == ConstructionState.Constructed; }
    }

    public bool CompletionIsFree
    {
        get { return BuildingProperties.BuildingMaterials.IsEmpty(); }
    }


    private void ConstructBuilding()
    {
        ConstructionProcess = null;
        State = ConstructionState.Constructed;
        FireConstructionFinishedEvent();
        Debug.LogError("Da chay het time");
        if (CompletionIsFree)
        {
            CompleteWithMaterials();
        }
    }

    public void CompleteWithMaterials()
    {
        if (!CanComplete)
        {
            Debug.Log("Community building cannot be completed with materials.");
        }
        else if (GeneralBalance.SpendCurrencies(BuildingProperties.BuildingMaterials, false,
                     Drain.SpeedupConstruction))
        {
            CompleteConstruction();
        }
    }

    private void CompleteConstruction()
    {
        State = ConstructionState.Completed;
        Currencies constructionReward = BuildingProperties.ConstructionReward;
        if (!constructionReward.IsEmpty() && GeneralBalance.CanEarnCurrencies(constructionReward))
        {
            GeneralBalance.EarnCurrencies(constructionReward, Building);
        }

        FireConstructionCompletedEvent();
    }


    #region SAVE AND LOAD ::

    protected StorageDictionary _storage;


    public ContructionSiteStating(Building building, IslandFarmProperties islandFarmProperties,
        GeneralBalance generalBalance, TimeKeeper timeKeeper,
        ConstructionState startState,
        PopupManager popupManager, GeneralProperties generalProperties)
    {
        Building = building;
        BuildingProperties = building.BuildingProperties;
        //IslandFarmBalance = islandFarmBalance;
        GeneralBalance = generalBalance;
        PopupManager = popupManager;
        State = startState;

        if (State == ConstructionState.Constructing)
        {
            ConstructionProcess = new UpspeedableProcess(islandFarmProperties, timeKeeper,
                BuildingProperties.ConstructionTimeSeconds,
                1.0, 1f, ConstructBuilding, Drain.SpeedupConstruction,generalBalance, generalProperties);
        }
        else if (State == ConstructionState.Constructed && CompletionIsFree)
        {
            State = ConstructionState.Completed;
        }
    }

    public ContructionSiteStating(StorageDictionary storage)
    {
        _storage = storage;
        State = (ConstructionState)storage.Get("ConstructionState", 0);
        if (State == ConstructionState.Constructing)
        {
            ConstructionProcess = new UpspeedableProcess(storage.GetStorageDict("ConstructionProcess"));
        }
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("ConstructionState", (int)State);
        _storage.SetOrRemove("ConstructionProcess", ConstructionProcess);
        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        Building = building;
        BuildingProperties = building.BuildingProperties;
        //IslandFarmBalance = isLandInfo.IslandFarmBalance;
        PopupManager = game.PopupManager;
        if (ConstructionProcess != null)
        {
            ConstructionProcess.ResolveDependencies(game, isLandInfo, ConstructBuilding);
        }
    }

    #endregion
}