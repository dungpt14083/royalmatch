using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ISLANDINFO
public class BaseIsland : MonoBehaviour
{
    // //TUY LÀ VẪN CÓ THẰNG TILEMAP NHƯNG VẪN CẦN MỘT THẰNG ĐỂ NÓ SẼ LƯU TRU DATA CHỨ K PHẢI MỖI LẦN LOAD LẤY BEHAVIOUR XÉT
    // //CÁC THÔNG SỐ TILE ĐƯỢC ÉP THÀNH FILEJSON TỪ EDITOR 
    // public TilesFile IslandTiles { get; private set; }
    //
    // //Sau khi có data thô về map và xong map rồi thì đến vụ Grid DATA QUN LÍ MẢNG BUILDABLE VÀ CÁC THỨ GAMEOBJECT Ở TRONG MẢNG BLA BLA TRONG CÁC PHẦN TỬ GRID
    // public GridManager GridManager { get; private set; }
    //
    // //PHẦN MỞ RỘNG VS DÂN SỐ VS ĐƯỜNG TẠM THỜI CHƯA ĐỘNG TOI
    // private List<Building> _buildings = new List<Building>();
    //
    // private Balance _balance;
    //
    // public CameraOperator CameraOperator { get; private set; }
    //
    //
    // public BaseIsland(Properties properties, Balance balance, TimeKeeper time, PopupManager popupManager)
    // {
    //     IslandTiles = new TilesFile();
    //     _balance = balance;
    //     GridManager = new GridManager(IslandTiles.IsBuildable);
    //     CameraOperator = new CameraOperator();
    //     //LẤY CÁC TÒA NHÀ BUILD TRƯỚC ĐỂ BUILD RA MAP 
    //     Executors.Instance.StartCoroutine(DelayTimeMake(properties, balance, time, popupManager));
    // }
    //
    // private IEnumerator DelayTimeMake(Properties properties, Balance balance, TimeKeeper time,
    //     PopupManager popupManager)
    // {
    //     yield return new WaitForEndOfFrame();
    //     BuildStartBuildings(properties, balance, time, popupManager);
    // }
    //
    //
    //
    //
    // #region DOTHANGNAY NÓ SẼ QUẢN LÍ CẢ GRID CẢ MỞ RỘNG NÊN NÓ SẼ QUẢ LÍ VIỆC CÓ THỂ BỎ TÒA NHÀ VÀO VỊ TRÍ NÀO HAY KHÔNG BLA BLA::
    //
    // //TRƯỚC KHI MUA PHẢI CHECK XEM THỬ ĐẶT ĐƯỢC VÀO HAY KHÔNG TRUYỀN AREA VÀ THẰNG PREVIEW AREA VÀO VÀ THẰNG ORGION OBJECT VÀO
    // //OK THÌ MỚI OK XÂY
    // public bool IsOpenArea(GridArea area, IGridObject ignoreObject = null)
    // {
    //     //PHỚT LÀ GAMEOBJECT TRUYỀN VÀO ẾU CÓ NẾU K THÌ BỎ QUA HẲN LÀ PHỚT LỜ CHÍNH CAI DC REVIEW
    //     return GridManager.IsOpenArea(area, ignoreObject);
    // }
    //
    //
    // public bool BuyAndPlaceBuilding(Building building)
    // {
    //     if (_balance.SpendCurrencies(building.Props.ConstructionCost, false, Drain.BuyBuilding))
    //     {
    //         //tạm chưa có tiên nong gì thì thằng này luôn true đi
    //         PlaceBuilding(building);
    //         return true;
    //     }
    //
    //     return false;
    // }
    //
    // //xong sau đặt xong thì invoke sự kiện add building lõi vào gridobject mua thì để vào
    // public void PlaceBuilding(Building building)
    // {
    //     //DO THẰNG NÀY NÓ CÓ STATE CONTRUCTED NÊN DELAY MẤY FARM ĐỂ GRIDVIEW INIT XONG THÌ MỚI CÓ THỂ NGHE SỰ KIỆN ĐƯỢC
    //
    //     //dựa vào state của nó vào mà thành đăng kí state cho nó 
    //     switch (building.Construction.State)
    //     {
    //         case ConstructionState.Constructing:
    //             building.Construction.ConstructionFinishedEvent += OnBuildingConstructionFinished;
    //             break;
    //         //nhà xây sẵn rồi từ start nên có cái này
    //         case ConstructionState.Constructed:
    //             building.Construction.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
    //             break;
    //         default:
    //             break;
    //     }
    //
    //     _buildings.Add(building);
    //     GridManager.AddGridObject(building);
    //     FireBuildingAddedEvent(building);
    // }
    //
    //
    // public void MoveBuilding(Building building, GridIndex newIndex)
    // {
    //     GridIndex index = building.Area.Index;
    //     building.MoveTo(newIndex);
    //     FireBuildingMovedEvent(building, index);
    // }
    //
    // //bên gridview nhận sự kiện kết thúc move để hiện lên
    // private void FireBuildingMovedEvent(Building building, GridIndex oldIndex)
    // {
    //     if (this.BuildingMovedEvent != null)
    //     {
    //         this.BuildingMovedEvent(building, oldIndex);
    //     }
    // }
    //
    //
    // //nghe sự kiện xong để xài ây finish
    // private void OnBuildingConstructionFinished(ContructionSiteStating constructionSite)
    // {
    //     constructionSite.ConstructionFinishedEvent -= OnBuildingConstructionFinished;
    //     constructionSite.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
    //     FireBuildingStateChangedEvent(constructionSite.Building);
    // }
    //
    // //Hoàn thiện???
    // private void OnBuildingConstructionCompleted(ContructionSiteStating constructionSite)
    // {
    //     constructionSite.ConstructionCompletedEvent -= OnBuildingConstructionCompleted;
    //     FireBuildingStateChangedEvent(constructionSite.Building);
    // }
    //
    //
    // #region EVENTINGAME
    //
    // public delegate void BuildingAddedEventHandler(Building building);
    //
    // public delegate void BuildingStateChangedEventHandler(Building building);
    //
    // public delegate void BuildingRemovedEventHandler(Building building);
    //
    // public delegate void BuildingMovedEventHandler(Building building, GridIndex oldIndex);
    //
    // public event BuildingAddedEventHandler BuildingAddedEvent;
    // public event BuildingStateChangedEventHandler BuildingStateChangedEvent;
    // public event BuildingRemovedEventHandler BuildingRemovedEvent;
    // public event BuildingMovedEventHandler BuildingMovedEvent;
    //
    // #endregion
    //
    //
    // private void FireBuildingAddedEvent(Building building)
    // {
    //     if (this.BuildingAddedEvent != null)
    //     {
    //         this.BuildingAddedEvent(building);
    //     }
    // }
    //
    // private void FireBuildingStateChangedEvent(Building building)
    // {
    //     if (this.BuildingStateChangedEvent != null)
    //     {
    //         this.BuildingStateChangedEvent(building);
    //     }
    // }
    //
    // #endregion
    //
    // public bool IsWithinBounds(GridIndex index, GridSize size)
    // {
    //     return GridManager.Area.IsWithinBounds(index, size);
    // }
    //
    // public bool IsWithinBounds(GridIndex index)
    // {
    //     return GridManager.IsWithinBounds(index);
    // }
    //
    // public bool IsWithinBounds(GridPoint gridPoint)
    // {
    //     return GridManager.Area.IsWithinBounds(gridPoint);
    // }
    //
    // public GridIndex FindFreeGridIndex(GridPoint nearGridPoint, GridSize size)
    // {
    //     GridIndex gridIndex = new GridIndex(nearGridPoint - size.Half);
    //     GridArea gridArea = new GridArea(gridIndex, size);
    //     if (GridManager.IsOpenArea(gridArea))
    //     {
    //         return gridIndex;
    //     }
    //
    //     int num = (int)nearGridPoint.U;
    //     int num2 = (int)nearGridPoint.V;
    //     Direction direction = Direction.SE;
    //     int num3 = 1;
    //     int num4 = 0;
    //     GridSize size2 = GridManager.Area.Size;
    //     int u = size2.U;
    //     while (num3 <= u)
    //     {
    //         if (GridManager.IsOpenArea(num, num2, size))
    //         {
    //             return new GridIndex(num, num2);
    //         }
    //
    //         switch (direction)
    //         {
    //             case Direction.NW:
    //                 num++;
    //                 num4++;
    //                 if (num4 == num3)
    //                 {
    //                     num4 = 0;
    //                     direction = Direction.NE;
    //                 }
    //
    //                 break;
    //             case Direction.SE:
    //                 num--;
    //                 num4++;
    //                 if (num4 == num3)
    //                 {
    //                     num4 = 0;
    //                     direction = Direction.SW;
    //                 }
    //
    //                 break;
    //             case Direction.NE:
    //                 num2++;
    //                 num4++;
    //                 if (num4 == num3)
    //                 {
    //                     num4 = 0;
    //                     direction = Direction.SE;
    //                     num3++;
    //                 }
    //
    //                 break;
    //             case Direction.SW:
    //                 num2--;
    //                 num4++;
    //                 if (num4 == num3)
    //                 {
    //                     num4 = 0;
    //                     direction = Direction.NW;
    //                     num3++;
    //                 }
    //
    //                 break;
    //         }
    //     }
    //
    //     return null;
    // }
    //
    // #region Save And Load Island
    //
    // //TẠM THỜI CHỈ LƯU MỖI BUILDING K LƯU GÌ KHÁC KHÔNG CÓ MỞ RỘN K CÓ ROADAGENT...::
    //
    // private StorageDictionary _storage;
    //
    // public BaseIsland(StorageDictionary storage)
    // {
    //     _storage = storage;
    //     _buildings = storage.GetModels("Buildings", (StorageDictionary sd) => new Building(sd));
    //     IslandTiles = new TilesFile();
    // }
    //
    // public StorageDictionary Serialize()
    // {
    //     if (_storage == null)
    //     {
    //         _storage = new StorageDictionary();
    //     }
    //
    //     _storage.Set("Buildings", _buildings);
    //     //_storage.Set("OrderGenerator", OrderGenerator);
    //     return _storage;
    // }
    //
    // //NGOÀI DATA LƯU THÌ CẦN BƠM VÀO CÁC THỨ THAM CHIẾU KHÁC THAY VÌ TẠO MỚI TỪ ĐẦU CÓ TRUYỀN CONTRUCTION THÌ CÁI NÀY TRUYỀN XỬ LÍ TRUYỀN SAU::
    // public void ResolveDependencies(GameData game)
    // {
    //     List<IGridObject> list = new List<IGridObject>();
    //     for (int i = 0; i < _buildings.Count; i++)
    //     {
    //         Building building = _buildings[i];
    //         building.ResolveDependencies(game);
    //         switch (building.Construction.State)
    //         {
    //             case ConstructionState.Constructing:
    //                 building.Construction.ConstructionFinishedEvent += OnBuildingConstructionFinished;
    //                 break;
    //             case ConstructionState.Constructed:
    //                 building.Construction.ConstructionCompletedEvent += OnBuildingConstructionCompleted;
    //                 break;
    //         }
    //
    //         list.Add(building);
    //     }
    //
    //     _balance = game.Balance;
    //     //Đưa gameobject vào trong gridmanager để resolve xử lí vào grid hệ
    //     GridManager = new GridManager(IslandTiles.IsBuildable, list);
    //     CameraOperator = new CameraOperator();
    // }

    
}