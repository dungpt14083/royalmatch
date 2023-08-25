using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsLandInfo : ICanSerialize
{
    public IslandId IslandId { get; }

    //public TilesFile IslandTiles { get; private set; }
    //public GridManager GridManager { get; private set; }
    private List<Building> _buildings = new List<Building>();

    public CameraOperator CameraOperator { get; private set; }
    GeneralBalance GeneralBalance { get; set; }

    //THÊM CÁI NÀY VÀO ĐỂ BỌN KIA TRUY CẬP VÀO UPSPEED CONFIG VÀ CÁC WAREHOUSECONFIG:::
    public GeneralProperties GeneralProperties { get; set; }

    public IslandFarmProperties IslandFarmProperties { get; set; }
    //public IslandFarmBalance IslandFarmBalance { get; set; }

    public TileManager TileManager { get; set; }

    public GatherableManager GatherableManager { get; set; }


    public int BuildingCount
    {
        get { return _buildings.Count; }
    }

    private IEnumerator DelayTimeMake(TimeKeeper time,
        PopupManager popupManager)
    {
        yield return new WaitForEndOfFrame();

        //KHÔNG CẦN CHỜ TILEMANAGERVIEW VÌ ĐÂU CHỌC NÓ ĐĂNG KÍ DATA VÀ BÊN TILEMAGER MÀ
        //yield return new WaitUntil(() => TileManagerView.Instance != null);
        //KHÔNG THỂ TỰ ĐỘNG BUILD ban đầu được vì chưa có dữ liệu vào 
        BuildStartBuildings(time, popupManager);
    }


    //DÀNH CHO DATA LƯU KẾT HỢP VS DATA CỦA VIỆC LOAD LOCAL PRO LÊN CÁC TÒA NHÀ ĐÃ LƯU ?
    //ĐOẠN NÀY PHẢI TÁCH RA LLAASYCONFIG CHO NHÀ 
    private void BuildStartBuildings(TimeKeeper time,
        PopupManager popupManager)
    {
        if (IslandFarmProperties == null || GeneralBalance == null) return;
        List<StartBuildingProperties> startBuildings = IslandFarmProperties.StartBuildings;
        int count = startBuildings.Count;
        for (int i = 0; i < count; i++)
        {
            StartBuildingProperties startBuildingProperties = startBuildings[i];

            //TÁCH RA HOẶC RÁC LÀ 1 NƠI TẠO CÁI ĐÓ ???
            BuildingProperties properties2 = null;
            if (startBuildingProperties.IsGatherable)
            {
                properties2 =
                    GeneralProperties.GetProperties<BuildingProperties>(startBuildingProperties.BuildingName);
            }
            else
            {
                properties2 =
                    IslandFarmProperties.GetProperties<BuildingProperties>(startBuildingProperties.BuildingName);
            }


            if (properties2 == null)
            {
                return;
            }
            if (properties2.StringReference=="SmallPond")
            {
                Debug.Log("x");
            }
            //ĐOẠN NÀY PHẢI THÊM ID VÀO 
            PlaceBuilding(new Building(properties2, ConstructionState.Constructed, startBuildingProperties.Position,
                startBuildingProperties.IsFlipped, IslandFarmProperties, GeneralBalance, time, this,
                popupManager, GeneralProperties, startBuildingProperties.ElementId,startBuildingProperties), true);
        }
    }
    public bool PlaceBuildingWithBuidingName(string buildingName, StartBuildingProperties startBuildingProperties, PopupManager popupManager, TimeKeeper time)
    {
        var properties = IslandFarmProperties.GetProperties<BuildingProperties>(buildingName);
        if (properties == null) return false;
        PlaceBuilding(new Building(properties, ConstructionState.Constructed, startBuildingProperties.Position,
                startBuildingProperties.IsFlipped, IslandFarmProperties, GeneralBalance, time, this,
                popupManager, GeneralProperties, startBuildingProperties.ElementId, startBuildingProperties), true);
        return true;
    }
    public bool PlaceBuildingWithProperties(BuildingProperties buildingProperties, GridIndex Position, PopupManager popupManager, TimeKeeper time)
    {
        Debug.Log("PlaceBuildingWithProperties");
        PlaceBuilding(new Building(buildingProperties, ConstructionState.Constructed, Position,
                false, IslandFarmProperties, GeneralBalance, time, this,
                popupManager, GeneralProperties), true);
        return true;
    }
    //THANH TOASN TIỀN CHUNG HAY TIỀN RIÊNG:::
    public bool BuyAndPlaceBuilding(Building building)
    {
        if (GeneralBalance.SpendCurrencies(building.BuildingProperties.ConstructionCost, false, Drain.BuyBuilding))
        {
            //ĐOẠN NÀY PHẢI TẠO ID CHO NÓ MỚI ELEMENT::::
            PlaceBuilding(building);
            return true;
        }

        return false;
    }

    
    
    

    public Building FindBuildingByElementId(int elementId)
    {
        return _buildings.Find(building => building.ElementId == elementId);
    }





    #region DOTHANGNAY NÓ SẼ QUẢN LÍ CẢ GRID CẢ MỞ RỘNG NÊN NÓ SẼ QUẢ LÍ VIỆC CÓ THỂ BỎ TÒA NHÀ VÀO VỊ TRÍ NÀO HAY KHÔNG BLA BLA::

    public bool IsOpenArea(GridArea area, IGridObject ignoreObject = null)
    {
        //PHỚT LÀ GAMEOBJECT TRUYỀN VÀO ẾU CÓ NẾU K THÌ BỎ QUA HẲN LÀ PHỚT LỜ CHÍNH CAI DC REVIEW
        return TileManager.IsOpenArea(area, ignoreObject);
    }

    //TẠM KHÓA VỤ CHECK ĐƯỜNG BAO MAP VÌ COI NHƯ VÔ TẬN:::

    // public bool IsWithinBounds(GridIndex index, GridSize size)
    // {
    //     return GridManager.Area.IsWithinBounds(index, size);
    // }

    // public bool IsWithinBounds(GridIndex index)
    // {
    //     return GridManager.IsWithinBounds(index);
    // }

    public GridIndex FindFreeGridIndex(GridPoint nearGridPoint, GridSize size)
    {
        GridIndex gridIndex = new GridIndex(nearGridPoint - size.Half);
        GridArea gridArea = new GridArea(gridIndex, size);
        if (TileManager.IsOpenArea(gridArea))
        {
            return gridIndex;
        }

        return null;

        //CHỖ TÌM VỊ TRÍ GẦN NHẤT FREE BỎ QUA VÀ LẤY TẠM VỊ TRÍ TÂM CAMERA ĐI
        // int num = (int)nearGridPoint.U;
        // int num2 = (int)nearGridPoint.V;
        // Direction direction = Direction.SE;
        // int num3 = 1;
        // int num4 = 0;
        // GridSize size2 = GridManager.Area.Size;
        // int u = size2.U;
        // while (num3 <= u)
        // {
        //     if (GridManager.IsOpenArea(num, num2, size))
        //     {
        //         return new GridIndex(num, num2);
        //     }
        //
        //     switch (direction)
        //     {
        //         case Direction.NW:
        //             num++;
        //             num4++;
        //             if (num4 == num3)
        //             {
        //                 num4 = 0;
        //                 direction = Direction.NE;
        //             }
        //
        //             break;
        //         case Direction.SE:
        //             num--;
        //             num4++;
        //             if (num4 == num3)
        //             {
        //                 num4 = 0;
        //                 direction = Direction.SW;
        //             }
        //
        //             break;
        //         case Direction.NE:
        //             num2++;
        //             num4++;
        //             if (num4 == num3)
        //             {
        //                 num4 = 0;
        //                 direction = Direction.SE;
        //                 num3++;
        //             }
        //
        //             break;
        //         case Direction.SW:
        //             num2--;
        //             num4++;
        //             if (num4 == num3)
        //             {
        //                 num4 = 0;
        //                 direction = Direction.NW;
        //                 num3++;
        //             }
        //
        //             break;
        //     }
        // }

        //return null;
    }


    public void PlaceBuilding(Building building, bool startBuilding = false)
    {
        // switch (building.Construction.State)
        // {
        //     case ConstructionState.Constructing:
        //         building.Construction.ConstructionFinishedEvent += OnBuildingConstructionFinished;
        //         break;
        //     case ConstructionState.Constructed:
        //         building.Construction.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
        //         break;
        //     default:
        //         break;
        // }

        if (TileManager.RegisterTileElement(building, startBuilding))
        {
            _buildings.Add(building);
            FireBuildingAddedEvent(building);
        }
    }


    public void MoveBuilding(Building building, GridIndex newIndex)
    {
        GridIndex index = building.Area.Index;
        building.MoveTo(newIndex);
        FireBuildingMovedEvent(building, index);
    }

    private void FireBuildingMovedEvent(Building building, GridIndex oldIndex)
    {
        if (this.BuildingMovedEvent != null)
        {
            this.BuildingMovedEvent(building, oldIndex);
        }
    }


    private void OnBuildingConstructionFinished(ContructionSiteStating constructionSite)
    {
        constructionSite.ConstructionFinishedEvent -= OnBuildingConstructionFinished;
        constructionSite.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
        FireBuildingStateChangedEvent(constructionSite.Building);
    }

    private void OnBuildingConstructionCompleted(ContructionSiteStating constructionSite)
    {
        constructionSite.ConstructionCompletedEvent -= OnBuildingConstructionCompleted;
        FireBuildingStateChangedEvent(constructionSite.Building);
    }

    public Building GetBuilding(int index)
    {
        return _buildings[index];
    }

    #region EVENTINGAME

    public delegate void BuildingAddedEventHandler(Building building);

    public delegate void BuildingStateChangedEventHandler(Building building);

    public delegate void BuildingRemovedEventHandler(Building building);

    public delegate void BuildingMovedEventHandler(Building building, GridIndex oldIndex);

    public event BuildingAddedEventHandler BuildingAddedEvent;
    public event BuildingStateChangedEventHandler BuildingStateChangedEvent;
    public event BuildingRemovedEventHandler BuildingRemovedEvent;
    public event BuildingMovedEventHandler BuildingMovedEvent;

    #endregion

    private void FireBuildingAddedEvent(Building building)
    {
        if (this.BuildingAddedEvent != null)
        {
            this.BuildingAddedEvent(building);
        }
    }

    private void FireBuildingStateChangedEvent(Building building)
    {
        if (this.BuildingStateChangedEvent != null)
        {
            this.BuildingStateChangedEvent(building);
        }
    }

    private void FireBuildingRemovedEvent(Building building)
    {
        if (this.BuildingRemovedEvent != null)
        {
            this.BuildingRemovedEvent(building);
        }
    }

    #endregion


    #region CHO VIỆC REMOVEBUILDING ĐƯỢC GỌI:::

    public void RemoveBuilding(Building building)
    {
        // switch (building.Construction.State)
        // {
        //     case ConstructionState.Constructing:
        //         building.Construction.ConstructionFinishedEvent -= OnBuildingConstructionFinished;
        //         break;
        //     case ConstructionState.Constructed:
        //         building.Construction.ConstructionCompletedEvent -= OnBuildingConstructionCompleted;
        //         break;
        // }

        if (building.Gatherable != null)
        {
            //Thì đưa vào trong GatherManager
            if (building.ElementId != 0)
            {
                ObjectiveTrackerSignals.GatherableCollectedEvent.Dispatch(
                    new GatherableCollectedEventData(building.Gatherable));
                GatherableManager.AddCompletedGatherable(building.ElementId);
            }
        }
        if (building.FruitTreeBuilding != null)
        {
            if (building.ElementId != 0)
            {
                ObjectiveTrackerSignals.FruitTreeCollectedEvent.Dispatch(new FruitTreeCollectedEventData(building.FruitTreeBuilding));
                GatherableManager.AddCompletedGatherable(building.ElementId);
            }
        }
        if (building.buildingData != null && building.buildingData is ItemBonus)
        {
            if (building.ElementId != 0)
            {
                ObjectiveTrackerSignals.ItemBonusCollectedEvent.Dispatch(new ItemBonusCollectedEventData(building.buildingData as ItemBonus));
                GatherableManager.AddCompletedGatherable(building.ElementId);
            }
        }
        _buildings.Remove(building);
        TileManager.UnRegisterTileElement(building);
        FireBuildingRemovedEvent(building);
    }

    #endregion


    #region Save And Load Island

    private StorageDictionary _storage;

    //1111111111
    public IsLandInfo(IslandId id, IslandsManager islandsManager, TimeKeeper time,
        PopupManager popupManager, GeneralBalance generalBalance, GeneralProperties generalProperties)
    {
        IslandId = id;
        //IslandTiles = new TilesFile(islandsManager.GetTileFilesName(IslandId));
        //GridManager = new GridManager(IslandTiles.IsBuildable);
        GeneralProperties = generalProperties;

        TileManager = new TileManager(IslandId);
        GatherableManager = new GatherableManager();
        IslandFarmProperties =
            new IslandFarmProperties(GeneralProperties, islandsManager.GetPropertiesFilesName(IslandId));
        GeneralBalance = generalBalance;
        //IslandFarmBalance = new IslandFarmBalance(IslandFarmProperties, GeneralBalance);
        CameraOperator = new CameraOperator();
        Executors.Instance.StartCoroutine(DelayTimeMake(time, popupManager));
    }

    public IsLandInfo(StorageDictionary storage)
    {
        _storage = storage;
        IslandId = (IslandId)_storage.Get("IslandId", 0);
        _buildings = storage.GetModels("Buildings", (StorageDictionary sd) => new Building(sd));
        GatherableManager = new GatherableManager(_storage.GetStorageDict("gatherableManager"));
        //IslandFarmBalance = new IslandFarmBalance(_storage.GetStorageDict("IslandFarmBalance"));
    }


    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("IslandId", (int)IslandId);
        _storage.Set("Buildings", _buildings);
        _storage.Set("gatherableManager", GatherableManager);
        //_storage.Set("IslandFarmBalance", IslandFarmBalance);
        return _storage;
    }


    //NHÀ CŨ NÓ ĐƯỢC ISLANDVIEW GỌI INIT TẠO INSTANCE BUILDING ::: Ở SRIPT NÀY CHỈ QUẢN LÍ TẠO BUILDING DATA THÔI
    public void ResolveDependencies(GameData game)
    {
        GeneralBalance = game.GeneralBalance;


        //IslandTiles = new TilesFile(game.IslandsManager.GetTileFilesName(IslandId));
        //GridManager = new GridManager(IslandTiles.IsBuildable);

        //ĐĂNG KÍ Ở ĐÂY CÒN LẠI NÓ SẼ TỰ LAY Ở NGOÀI MAP ĐỂ MÀ TỪ ĐÓ SẼ INIT CÁC THỨ:::
        TileManager = new TileManager(IslandId);

        GeneralProperties = game.GeneralProperties;

        IslandFarmProperties =
            new IslandFarmProperties(GeneralProperties, game.IslandsManager.GetPropertiesFilesName(IslandId));
        CameraOperator = new CameraOperator();

        //IslandFarmBalance.ResolveDependencies(IslandFarmProperties, GeneralBalance);


        List<IGridObject> list = new List<IGridObject>();
        for (int i = 0; i < _buildings.Count; i++)
        {
            Building building = _buildings[i];
            building.ResolveDependencies(game, this);
            // switch (building.Construction.State)
            // {
            //     case ConstructionState.Constructing:
            //         building.Construction.ConstructionFinishedEvent += OnBuildingConstructionFinished;
            //         break;
            //     case ConstructionState.Constructed:
            //         building.Construction.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
            //         break;
            // }

            list.Add(building);
        }
    }

    #endregion
}