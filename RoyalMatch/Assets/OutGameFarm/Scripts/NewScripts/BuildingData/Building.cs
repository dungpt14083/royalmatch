using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : IGridObject, ICanSerialize
{
    #region SAVE AND LOAD DATA

    #endregion

    #region NEWCODE GAME::::::

    public event TileManager.MovedEventHandler MovedEvent;

    public event TileManager.FlippedEventHandler FlippedEvent;
    //public Action<ConstructionState> changeStatusBuilding;

    private void FireMovedEvent()
    {
        if (this.MovedEvent != null)
        {
            this.MovedEvent(this);
        }
    }

    private void FireFlippedEvent()
    {
        if (this.FlippedEvent != null)
        {
            this.FlippedEvent(this);
        }
    }


    private string _buildingName;

    private GridArea _area;

    public GridArea Area
    {
        get { return _area; }
        private set
        {
            if (value.Index != _area.Index)
            {
                _area = value;
                FireMovedEvent();
            }
        }
    }

    public int ElementId { get; private set; }
    public bool IsFlipped { get; private set; }
    public BuildingProperties BuildingProperties { get; private set; }


    //public ContructionSiteStating Construction { get; private set; }
    public DecorationBuilding Decoration { get; private set; }
    public FarmFieldBuilding Farmfield { get; private set; }
    public WareHouseBuilding Warehouse { get; private set; }

    public FruitTreeBuilding FruitTreeBuilding { get; private set; }

    public BonusTreeBuilding BonusTreeBuilding { get; private set; }

    public GatherableBuilding Gatherable { get; private set; }
    public GatherableBuilding Ruin { get; private set; }
    public BuildingData buildingData { get; private set; }

    public StartBuildingProperties StartBuildingProperties { get; private set; }


    public void MoveTo(GridIndex index)
    {
        Area = new GridArea(index, Area.Size);
    }

    public void SetFlippedState(bool isFlipped)
    {
        IsFlipped = isFlipped;
        FireFlippedEvent();
    }


    public void UpdateStatusBuilding()
    {
        switch (BuildingProperties.Type)
        {
            case "warehouse":
                break;
            case "decoration":
                break;
            case "farmfield":

                break;
            case "gatherable":
                break;
            case "bonusTree":
                break;
            //vào
            case "UpgradeHouse":
            case "ProduceHouse":
                (buildingData as UpgradeHouse).UpdateStatusBuilding();
                break;
            default:
                break;
        }
    }


    #region SAVEANDLOAD

    private StorageDictionary _storage;


    //MẶC ĐỊNH ID LÀ 0 CHO BỌN MỚI CỦA BỌN XÂY MỚI SAU NÀY K THAM GIA VÀO HỆ THOOSG NHIỆM VỤ OR REQUIREMENT::
    public Building(BuildingProperties buildingProperties, ConstructionState constructionState, GridIndex index,
        bool isFlipped, IslandFarmProperties islandFarmProperties,
        GeneralBalance generalBalance, TimeKeeper time, IsLandInfo isLandInfo,
        PopupManager popupManager, GeneralProperties generalProperties, int elementId = 0, StartBuildingProperties
            startBuildingProperties = null)
    {
        StartBuildingProperties = startBuildingProperties;
        ElementId = elementId;
        BuildingProperties = buildingProperties;
        _area = new GridArea(index, buildingProperties.BuildingSize);
        IsFlipped = isFlipped;

        // Construction = new ContructionSiteStating(this, islandFarmProperties, generalBalance, time,
        //     constructionState, popupManager, generalProperties);

        switch (BuildingProperties.Type)
        {
            case "warehouse":
                Warehouse = new WareHouseBuilding((WarehouseBuildingProperties)buildingProperties,this);

                return;
            case "decoration":
                Decoration = new DecorationBuilding((DecorationBuildingProperties)buildingProperties);
                return;
            case "farmfield":
                Farmfield = new FarmFieldBuilding((FarmfieldBuildingProperties)buildingProperties /*, Construction*/,
                    islandFarmProperties, generalBalance,
                    time, popupManager, generalProperties);
                return;
            case "gatherable":
                Gatherable = new GatherableBuilding((GatherableProperties)buildingProperties, generalBalance,
                    popupManager, isLandInfo, this);
                return;
            case "itemFruit":
                FruitTreeBuilding = new FruitTreeBuilding((FruitTreeProperties)buildingProperties, islandFarmProperties,
                    generalBalance, time, popupManager, generalProperties, isLandInfo, this);
                return;
            case "bonusTree":
                BonusTreeBuilding = new BonusTreeBuilding((BonusTreeProperties)buildingProperties, islandFarmProperties,generalBalance,time,popupManager,generalProperties,isLandInfo,this);
                return;

            //NẾU ĐÃ LÀ TYPE CHỈ RÕ THÌ K CẦN CÁI VÀO UPDRAE MÀ NÓ CÓ LUÔN Ở TRONG R
            case "UpgradeHouse":
                buildingData = new UpgradeHouse(buildingProperties as UpgradeProperties, this);
                return;
            case "ProduceHouse":
                buildingData = new ProduceHouse(buildingProperties as ProduceProperties, this);
                return;
            case "TrainBuilding":
                buildingData = new TrainBuilding(buildingProperties as TrainProperties, this);
                return;
            case "AirplaneBuilding":
                buildingData = new AirplaneBuilding(buildingProperties as AirplaneProperties, this);
                return;
            case "ItemBonus":
                buildingData = new ItemBonus(buildingProperties as ItemBonusProperties, this);
                return;
            case "ItemBonusChangeStage":
                buildingData = new ItemBonusChangeStage(buildingProperties as ItemBonusChangeStageProperties, this);
                return;
            case "ItemBonusRepeat":
                buildingData = new ItemBonusRepeat(buildingProperties as ItemBonusRepeatProperties, this);
                return;
            default:
                return;
        }
    }


    public Building(StorageDictionary storage)
    {
        _storage = storage;
        _buildingName = storage.Get("Name", "unknown");
        IsFlipped = storage.Get("IsFlipped", false);

        //Construction = new ContructionSiteStating(storage.GetStorageDict("ConstructionSite"));

        _area = new GridArea(new GridIndex(_storage.GetStorageDict("Index")), GridSize.Zero);
        ElementId = storage.Get("ElementId", 0);
        if (storage.Contains("Warehouse"))
        {
            Warehouse = new WareHouseBuilding(storage.GetStorageDict("Warehouse"));
        }

        if (storage.Contains("Decoration"))
        {
            Decoration = new DecorationBuilding(storage.GetStorageDict("Decoration"));
        }

        if (storage.Contains("Farmfield"))
        {
            Farmfield = new FarmFieldBuilding(storage.GetStorageDict("Farmfield"));
        }

        if (storage.Contains("Gatherable"))
        {
            Gatherable = new GatherableBuilding(storage.GetStorageDict("Gatherable"));
        }

        if (storage.Contains("itemFruit"))
        {
            FruitTreeBuilding = new FruitTreeBuilding(storage.GetStorageDict("itemFruit"));
        }


        if (storage.Contains("UpgradeHouse"))
        {
            buildingData = new UpgradeHouse(storage.GetStorageDict("UpgradeHouse"));
        }

        if (storage.Contains("ProduceHouse"))
        {
            buildingData = new ProduceHouse(storage.GetStorageDict("ProduceHouse"));
        }

        if (storage.Contains("TrainBuilding"))
        {
            buildingData = new TrainBuilding(storage.GetStorageDict("TrainBuilding"));
        }

        if (storage.Contains("AirplaneBuilding"))
        {
            buildingData = new AirplaneBuilding(storage.GetStorageDict("AirplaneBuilding"));
        }

        if (storage.Contains("bonusTree"))
        {
            BonusTreeBuilding = new BonusTreeBuilding(storage.GetStorageDict("bonusTree"));
        }
        if (storage.Contains("ItemBonus"))
        {
            buildingData = new ItemBonus(storage.GetStorageDict("ItemBonus"));
        }
        if (storage.Contains("ItemBonusChangeStage"))
        {
            buildingData = new ItemBonusChangeStage(storage.GetStorageDict("ItemBonusChangeStage"));
        }
        if (storage.Contains("ItemBonusRepeat"))
        {
            buildingData = new ItemBonusRepeat(storage.GetStorageDict("ItemBonusRepeat"));
        }
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Index", _area.Index);
        _storage.Set("IsFlipped", IsFlipped);
        _storage.Set("ElementId", ElementId);
        _storage.Set("Name", BuildingProperties.BuildingName);

        //_storage.Set("ConstructionSite", Construction);

        _storage.SetOrRemove("Warehouse", Warehouse);
        _storage.SetOrRemove("Decoration", Decoration);
        _storage.SetOrRemove("Farmfield", Farmfield);
        _storage.SetOrRemove("Gatherable", Gatherable);

        _storage.SetOrRemove("ProduceHouse", buildingData);
        _storage.SetOrRemove("Upgradehouse", buildingData);
        _storage.SetOrRemove("TrainBuilding", buildingData);
        _storage.SetOrRemove("AirplaneBuilding", buildingData);
        _storage.SetOrRemove("ItemBonus", buildingData);
        _storage.SetOrRemove("ItemBonusChangeStage", buildingData);
        _storage.SetOrRemove("ItemBonusRepeat", buildingData);
        _storage.SetOrRemove("bonusTree",BonusTreeBuilding);

        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo)
    {
        BuildingProperties = isLandInfo.IslandFarmProperties.GetProperties<BuildingProperties>(_buildingName);
        _area = new GridArea(_area.Index, BuildingProperties.BuildingSize);

        //Construction.ResolveDependencies(game, isLandInfo, this);

        if (Warehouse != null)
        {
            Warehouse.ResolveDependencies(game, isLandInfo, this);
        }

        if (Decoration != null)
        {
            Decoration.ResolveDependencies(game, this);
        }

        if (Farmfield != null)
        {
            Farmfield.ResolveDependencies(game, isLandInfo, this);
        }

        if (Gatherable != null)
        {
            Gatherable.ResolveDependencies(game, isLandInfo, this);
        }

        if (buildingData != null)
        {
            buildingData.ResolveDependencies(game, isLandInfo, this);
        }

        if (BonusTreeBuilding != null)
        {
            BonusTreeBuilding.ResolveDependencies(game,isLandInfo,this);
        }
    }

    #endregion

    #endregion
}