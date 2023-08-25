using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeHouse : BuildingData
{
    protected int _level;
    protected int levelLimit;

    public int Level
    {
        get { return _level; }
        set
        {
            _level = value;
            (BuildingProperties as UpgradeProperties).Level = _level;
        }
    }

    public bool IsMaxLevel
    {
        get { return _level >= levelLimit; }
    }

    public bool CanLevelUp
    {
        get { return !IsMaxLevel; }
    }

    public bool InBuildQueue { get; set; }


    public delegate void LevelUpEventHandler(BuildingData buildingData);

    public event LevelUpEventHandler LevelUpEvent;
    public UpspeedableProcess upgradeProcess;
    public Action<ConstructionState> changeStatusBuilding;


    //ban đầu level 0 và level giới hạn là max 
    public UpgradeHouse(UpgradeProperties upgradeProperties, Building building) : base(upgradeProperties, building)
    {
        Level = 0;
        levelLimit = upgradeProperties.GetMaxLevel();
        //var timeBuildingFake = DateTime.UtcNow.AddSeconds(-40).ToString();
        //DateTime lastTimeBuilding = DateTime.Parse(timeBuildingFake);
        //var timeDeltaBuilding = DateTime.UtcNow - lastTimeBuilding;
        //upgradeProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, timeDeltaBuilding.TotalSeconds,
        //            1.0,
        //            1f, LevelUp, GeneralProperties);
    }

    public UpgradeHouse(StorageDictionary storage) : base(storage)
    {
        _level = storage.Get("Level", 0);
    }

    public void UpdateStatusBuilding()
    {
        if (upgradeProcess != null) changeStatusBuilding?.Invoke(ConstructionState.Constructing);
        else changeStatusBuilding?.Invoke(ConstructionState.Constructed);
    }

    //NÚT CHO ẤN VÀO NÂNG CẤP KHI ĐỦ ĐIỀU KIỆN 
    protected virtual void LevelUp()
    {
        InBuildQueue = false;
        //BẮN TÍN HIỆU KHI MÀ Ở LEVEL 0 BAN ĐẦU H LÊN LEVEL 1:::
        if (Level == 0)
        {
            ObjectiveTrackerSignals.BuildRuinEvent.Dispatch(this);
        }
        var rewards = (BuildingProperties as UpgradeProperties).GetCurrentRewardBuildComplete();
        FarmMapController.Instance.EarnCurrencies(rewards);
        upgradeProcess.CancelAction();
        upgradeProcess = null;
        //GAN LEVEL PROPETIES TỰ ĐỘNG LẤY UPGRADEPROPERTIES RA NGOÀI:::
        Level++;
        Debug.Log("=================> LevelUp");
        FireLevelUpEvent();
        UpdateStatusBuilding();
    }


    private void FireLevelUpEvent()
    {
        if (this.LevelUpEvent != null)
        {
            this.LevelUpEvent(this);
        }
    }


    public bool LevelUpWithGems()
    {
        if (!CanLevelUp)
        {
            Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
            return false;
        }

        if (FarmMapController.Instance.SpendCurrencies((BuildingProperties as UpgradeProperties).NextLevelProperties
                .GemCost))
        {
            LevelUp();
            return true;
        }

        return false;
    }

    public bool LevelUpWithMaterials()
    {
        if (!CanLevelUp)
        {
            Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
            return false;
        }

        if (FarmMapController.Instance.SpendCurrencies((BuildingProperties as UpgradeProperties).NextLevelProperties
                .GemCost))
        {
            LevelUp();
            return true;
        }

        return false;
    }


    public override StorageDictionary Serialize()
    {
        var _storage = base.Serialize();
        _storage.Set("Level", Level);
        return _storage;
    }

    public override void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        base.ResolveDependencies(game, isLandInfo, building);
        Level = _level;
    }


    public override int GetLevel()
    {
        return Level;
    }

    public override int GetLevelLimit()
    {
        //Todo : get level limit from config
        return levelLimit;
    }

    public override Currencies GetMerterials()
    {
        UpgradeProperties upgradeProperties = BuildingProperties as UpgradeProperties;
        if (upgradeProperties == null) return null;
        if (upgradeProperties.CurrentLevelProperties == null) return null;
        if (upgradeProperties.CurrentLevelProperties.BuildingMaterials == null) return null;
        return upgradeProperties.CurrentLevelProperties.BuildingMaterials;
    }


    //LẤY VẬT LIỆU HIỂN THỊ::::DẠNG CURRENCY::NÚT UPDATE GỌI TỚI UPDATE TRỪ TIỀN VÀ UPDATE
    public override bool UpgradeWithMaterials()
    {
        if (!CanLevelUp)
        {
            Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
            return false;
        }

        if (upgradeProcess != null) return false;
        var materials = GetMerterials();
        if (materials != null)
        {
            if (!CheckMaterials(materials)) return false;
            for (int i = 0; i < materials.KeyCount; i++)
            {
                var merterial = materials.GetCurrency(i);
                FarmMapController.Instance.SpendCurrencies(new Currency(merterial.Name, merterial.Amount));
            }
        }

        var timeBuilding =
            TimeSpan.FromSeconds((BuildingProperties as UpgradeProperties).CurrentLevelProperties.timeBuilding);
        InBuildQueue = true;
        upgradeProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
            FarmMapController.Instance.GetTimeKeeper(), timeBuilding.TotalSeconds,
            1.0,
            1f, LevelUp, FarmMapController.Instance.GetGeneralProperties());
        UpdateStatusBuilding();
        return true;
    }


    public bool CheckMaterials(Currencies materials)
    {
        for (int i = 0; i < materials.KeyCount; i++)
        {
            var merterial = materials.GetCurrency(i);
            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(merterial.Name);
            if (currentCountMerterial < merterial.Amount) return false;
        }

        return true;
    }


    public override List<Currency> GetRewards()
    {
        List<Currency> result = new();
        var rewards = (BuildingProperties as UpgradeProperties).GetCurrentRewardBuildComplete();
        for (int i = 0; i < rewards.KeyCount; i++)
        {
            var reward = rewards.GetCurrency(i);
            result.Add(reward);
        }

        return result;
    }


    public override bool IsUpgrade(int levelPlayer)
    {
        var CurrentLevelProperties = (BuildingProperties as UpgradeProperties).CurrentLevelProperties;
        if (CurrentLevelProperties == null) return false;
        if (levelLimit <= Level) return false;
        if ((BuildingProperties as UpgradeProperties).CurrentLevelProperties.levelPlayerRequire >
            levelPlayer) return false;
        return true;
    }

    public bool SpeedUpUpgrade()
    {
        if (upgradeProcess == null) return false;
        LevelUp();
        return true;
    }
}