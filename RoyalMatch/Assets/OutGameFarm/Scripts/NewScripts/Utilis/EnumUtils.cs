using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumUtils : Singleton<EnumUtils>
{
}

#region oldgame

public enum BuildingStage
{
    NotBuilt = 0,
    InProgress = 1,
    Built = 2
}

//type của nafy là nhà hay ô đất hay decor...bla bla
public enum ObjectType
{
    House = 0,
    Factory = 1,
    Special = 2,
    Decor = 3,
    Resources = 4,
    Currency = 5
}

public enum TileType
{
    //Trống là không có gì
    //Trắng là có thể đặt vào, Green loai có thể init vào vị trí
    //Xanh dùng có thể đặt red là không thể đặt
    Empty = 0,
    White = 1,
    Green = 2,
    Red = 3
}

#endregion

public enum ElementType
{
    None = 0,
    Grass = 1,
    Water = 2
}

public enum ConstructionState
{
    Constructing = 0,
    Constructed = 1,
    Completed = 2
}

public enum FarmfieldState
{
    Empty = 0,
    Growing = 1,
    HarvestReady = 2,
    Withered = 3
}

//CÁC LOẠI NHA
public enum ShopCategory
{
    Residential = 1,
    Commercial = 2,
    Community = 3,
    Decoration = 4,
    Special = 5,
    ItemFruit = 6,
    PetHouse = 7,
    ItemMap = 8,
    TntAndEnergy = 9,
    RecallDecoration = 10
}

public enum PreBuilderState
{
    Idle = 0,
    Building = 1,
    Moving = 2
}

//dành cho shop loại item mới đựac biệt và số lượng....,
public enum BadgeType
{
    None = 0,
    BadgeNew = 1,
    BadgeSpecial = 2,
    BadgeNumber = 3
}

//tiền nong chứa product vật liệu và sowing material là hạt giống
[Flags]
public enum CurrencyCategory
{
    None = 0,
    BasicMaterial = 1,
    Product = 2,
    BuildingMaterial = 4,
    SowingMaterial = 8,
    ItemBonus = 10,
    itemFruit = 11
}

public enum CurrencyType
{
    none = 0,
    grass = 1,
    wood = 2,
    stone = 3,
    mission = 4,
    string_ = 5,
    rope = 6,
    cloth = 7,
    woodenplan = 8,
    pallet = 9,
    woodveneer = 10,
    quartzsand = 11,
    cement = 12,
    bricks = 13,
    cowfeed = 14,
    chickenfeed = 15,
    pigfeed = 16,
    milk = 17,
    cream = 18,
    cheese = 19,
    butter = 20,
    tofu = 21,
    soymilk = 22,
    egg = 23,
    bread = 24,
    cookies = 25,
    popcorn = 26,
    cheeseburger = 27,
    cornbread = 28,
    pumpkinbread = 29,
    carrotbread = 30,
    strawbearrybread = 31,
    sandwich = 32,
    cheesecake = 33,
    wheat = 34,
    corn = 35,
    pumpkin = 36,
    carrot = 37,
    soybean = 38,
    strawberry = 39,
    bacon = 40,
    baconwithegg = 41,
    corndog = 42,
    coneydog = 43,
    ricecasserole = 44,
    sandwichcheesewithbacon = 45,
    cornmilk = 46,
    blueberrymilk = 47,
    orangejuice = 48,
    applejuice = 49,
    grapejuice = 50,
    tropicaljuice = 51,
    orange = 52,
    apple = 53,
    grape = 54,

    key = 55,
    shovel = 56,
    pickaxe = 57,
    saw = 58,

    stumpslim = 59,
    stumpnormal = 60,
    stumpbig = 61,

    woodchest = 62,
    bigchest = 63,
    goldchest = 64,
    diamondchest = 65,


    golds = 66,
    gems = 67,
    energy = 68,
    live = 69,

    blueberry = 70,
    redberry = 71,
    pineapple = 72,
    seastar = 73,
    scallops = 74,
    openclam = 75,
    cactusflower = 76,
    mushrooms = 77,
    xp = 78,
    bloomingcherrytree = 79,
    
    paddleitem = 80,
    anchoritem = 81,
    bridgeropesitem = 82,
    flower1item = 83,
    flower2item = 84,
    eggpetitem = 85,
    oldkeyitem = 86,
    rubbishracketitem = 87
}

public enum FarmfieldTemplateType
{
    OneCrop = 0,
    FourCrops = 1,
    FiveCrops = 2,
    SixCrops = 3,
    NineCrops = 4,
    TwelveCrops = 5
}

//NẾU KHONG DÙNG FIREBASE THÌ BỎ QUA HẾT:::
public enum Drain
{
    None = 0,
    BuyBuilding = 3,
    BuyLivestockCrop = 9,
    SpeedupConstruction = 27,
    WarehouseUpgrade = 35,
    DestroyGatherable = 36
}

//CÁC TUTORIAL TRONG GAME:::
public enum TutorialType
{
    None = 0,
    WelcomeTutorial = 1,
    Farmfield1BuildingTutorial = 2,
    Farmfield1UsageTutorial = 3,
    Farmfield2BuildingTutorial = 4,
    Farmfield2UsageTutorial = 5,
    Farmfield1CollectTutorial = 6,
    Farmfield2CollectTutorial = 7,
}

//CHO NHÂN VẬT DI CHUYỂN::
public enum AgentType
{
    NavmeshAgent,
    FlyAgent,
    TransformSyncAgent
}

//các hành động của người chơi và các animation sẽ từ nó mà ra:::
[Serializable]
public enum AnimationItemType
{
    None,
    Axe,
    Pickaxe,
    Scissor,
    Cup,
    Shovel,
    Bag
}

//cảnh bảo lưu trữ ổ đĩa đầy và tạo thư mục ngoại lệ trái phép:::
public enum StorageWarning
{
    None = 0,
    DiskFull = 1,
    CreateDirectoryUnauthorizedException = 2
}

public enum IslandId
{
    None = -1,
    Island01,
    Island02,
    Island03,
    Island04,
    Count
}

public enum AccessStatus
{
    Blocked = -1,
    NotVisited,
    Accessable
}

//CÁC ĐIỀU KIỆN ĐIỀU KHIỂN NHÂN VẬT NHƯ LÀ VIỆc click vào element g
//Khi mà ng vật sản xuất thì con vật chạy v
//Ruin buildQueue 
//Characterclicked ấn vào di chuyển
public enum IdleConditionType
{
    // Fields
    NoInput = 0,
    ClickTileElement = 1,
    BuyDecoration = 2,
    CharacterClicked = 3,
    ProductionStarted = 4,
    AnimalBaseId = 5,
    ActiveProduction = 6,
    Generic = 7,
    RuinBuildQueue = 8
}


//CÁC LOẠI RÁC
public enum GatherableCategory
{
    None = 0,
    Grass = 1,
    Wood = 2,
    Rock = 3,
    Garbage = 4,
    Treasure = 5,
    Well = 6,
    Fence = 7,
}

public enum TypeTilePlaneValidPreviewBuilder
{
    X1 = 1,
    X2 = 2,
    X3 = 3,
    X4 = 4,
}

//phục vụ cho cây ăn quả
public enum GrowthStageBuilding
{
    GrowingStage1,
    GrowingStage2,
    HarvestReady,
    Withered
}

public enum WareHouseCategory
{
    All,
    ItemMap,
    Product,
    ItemBonus
}

#region REQUIREMENT:::::::VÀ LÀM LẠI HỆ THÔNG ID CỦA VẬT PHẨM::::

//CÁC LOẠI REQUIREMENT yêu caafi PHẢI ĐẠT ĐƯỢC THÌ MỚI LÀM GÌ LM GÌ ĐÓ
[Serializable]
public enum RequirementType
{
    //MỞ BẰNG LEVEL B
    Level = 1,
    Quest = 2,

    //currency này là chỉ gem mà thôi
    Currency = 3,
    SessionCount = 4,
    InAdventure = 11,
    Adventure = 12,
    AdventureComplete = 13,
    CollectGatherableExact = 21,
    CoinAmount = 61,

    //ÍT HƠN SỐ LƯỢNG
    CoinAmountLesser = 62,
    Segment = 81,
    MainHouseStage = 91
}

//CÁC LOẠI TRADE LÀ GÌ LÀ TIỀN HAY ITEM HAY QUEST HAY TASK:::,THẬM CHÍ CÓ CUTSCENE TH NHẬN VÀO ĐỂ TỪ ĐÓ ĐU VÀO TRADE
public enum TradeType
{
    Currency = 1,
    Quest,
    Task,
    Cutscene,
}


[Serializable]
public enum ObjectiveType
{
    // Fields
    CollectGatherableAny = 1,
    CollectGatherableKind = 2,
    CollectGatherableExact = 3,
    CollectGatherableType = 4,
    BuildRuin = 11,
    BuildRuinExact = 12,
    StageRuin = 13,

    FactoryStartProduceItem = 15,
    FactoryCollectProducedItem = 16,

    PlantItem = 21,
    HarvestItem = 22,

    SendOrder = 31,
    OpenOrderBoard = 32,
    AdventureVisit = 41,
    BuyFactory = 51,
    BuyDecoration = 53,
    BuyFarm = 54,
    BuyFruitTree = 58,
    FindGatherable = 61,
    FindRuin = 62,
    FindFarm = 63,
    FindUniqueBuilding = 64,
    FindFactory = 65,
    FindDecoration = 66,
    FindWell = 67,
    FindEnergyWheelBuilding = 68,
    FindTree = 69,
    GatherWell = 71,
    CollectFruitTree = 72,
    CollectEnergyWheelPoint = 81,
    UpgradeFactory = 91,
    WinPuzzle = 101
}

#endregion