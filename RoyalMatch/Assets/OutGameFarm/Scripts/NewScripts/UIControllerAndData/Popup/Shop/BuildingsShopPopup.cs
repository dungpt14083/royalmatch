using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BuildingsShopPopup : Popup
{
    //PREFAB TẠO RA ITEM SHOP
    [SerializeField] private BuildingsShopItemView prefabBuildingShopItemView;
    [SerializeField] private Transform holder;

    //data trong shop à?của 1 item trong shop à?cho notific item mới dặc biệt....
    private class ShopBuilding
    {
        public BuildingProperties Props { get; set; }

        //public BadgeType BadgeType { get; set; }

        public ShopBuilding(BuildingProperties props)
        {
            Props = props;
            //BadgeType = badgeType;
        }
    }


    //list data sau khi sort với các loại data :::
    private static Dictionary<ShopCategory, List<BuildingProperties>> _sortedBuildingProps =
        new Dictionary<ShopCategory, List<BuildingProperties>>();

    private static Dictionary<ShopCategory, List<ProductProperties>> _sortedProductProps =
        new Dictionary<ShopCategory, List<ProductProperties>>();
    
    private readonly List<ShopBuilding> _shopBuildings = new List<ShopBuilding>();

    public ShopCategory Category { get; private set; }

    //hiển thị nhà và item nha và ấn vào nó để mua nhà...
    //private readonly Dictionary<GameObject, BuildingsShopItemView> _buildingShopItemViews =
    //new Dictionary<GameObject, BuildingsShopItemView>();
    private readonly List<BuildingsShopItemView> _buildingsShopItemViews = new List<BuildingsShopItemView>();


    //KHI VÀO GAME THÌ TRUYỀN DATA TỚI TẤT CẢ POPUP::
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        base.Init(game, isLandInfo);
        _sortedBuildingProps.Clear();
        AddCategory(ShopCategory.Residential, isLandInfo.IslandFarmProperties.ResidentialBuildingNames);
        AddCategory(ShopCategory.ItemFruit,isLandInfo.IslandFarmProperties.ItemFruitBuildingNames);
        AddCategory(ShopCategory.Commercial, isLandInfo.IslandFarmProperties.CommercialBuildingNames);
        AddCategory(ShopCategory.Community, isLandInfo.IslandFarmProperties.CommunityBuildingNames);
        AddCategory(ShopCategory.Decoration, isLandInfo.IslandFarmProperties.DecorationBuildingNames);
        AddCategory(ShopCategory.Special, isLandInfo.IslandFarmProperties.ShopTabFruitAndFarmField);
        AddCategory(ShopCategory.PetHouse,isLandInfo.IslandFarmProperties.ShopTabPetHouseAndEgg);
        AddCategoryItemShop(ShopCategory.ItemMap,game.GeneralProperties.ShopItemsNames);
        AddCategoryItemShop(ShopCategory.TntAndEnergy,game.GeneralProperties.ShopItemsTntAndEnergy);
        AddCategoryBuildingDecoraion(ShopCategory.RecallDecoration,
            isLandInfo.IslandFarmProperties.WareHouseBuildingDecoration);

    }

    //BỎ DATA VÔ TRONG LIST TỪ GAMEPROP VỚI CÁC LOẠI TÒA NHÀ
    private void AddCategory(ShopCategory category, List<string> buildingNames)
    {
        List<BuildingProperties> list = new List<BuildingProperties>();
        int count = buildingNames.Count;
        for (int i = 0; i < count; i++)
        {
            BuildingProperties properties =
                _isLandInfo.IslandFarmProperties.GetProperties<BuildingProperties>(buildingNames[i]);
            list.Add(properties);
        }

        _sortedBuildingProps.Add(category, _isLandInfo.IslandFarmProperties.SortBuildingByUnlockLevel(list));
    }
    
    private void AddCategoryItemShop(ShopCategory category, List<string> buildingNames)
    {
        List<ProductProperties> list = new List<ProductProperties>();
        int count = buildingNames.Count;
        for (int i = 0; i < count; i++)
        {
            ProductProperties properties =
                _game.GeneralProperties.GetProperties<ProductProperties>(buildingNames[i]);
            list.Add(properties);
        }

        //_sortedProductProps.Add(category,SortProductByUnlockLevel(list));
    }
    private void AddCategoryBuildingDecoraion(ShopCategory category, List<BuildingProperties> buildingNames)
    {
        List<BuildingProperties> list = new List<BuildingProperties>();
        int count = buildingNames.Count;
        for (int i = 0; i < count; i++)
        {
            BuildingProperties properties = buildingNames[i];
            list.Add(properties);
        }

        //_sortedProductProps.Add(category,SortProductByUnlockLevel(list));
    }

    //MỞ REQUEST LÀ BUILDINGSHOPPIPUPREQUEST LÀ REQUEST LOẠI CATEGORY NÀO::
    public override void Open(PopupRequest request)
    {
        SetDefault();
        _buildingsShopItemViews.Clear();
        _shopBuildings.Clear();
        base.Open(request);
        BuildingsShopPopupRequest shopItemsRequest = GetRequest<BuildingsShopPopupRequest>();
        Category = shopItemsRequest.Category;
        //GAME NÀY TẠM K CHECK SỐ LƯỢNG NHÀ TỐI ĐA...
        var list = _sortedBuildingProps[Category];
        int count = list.Count;
        //DUYỆT QUA LIST TẠO ITEM...
        for (int j = 0; j < count; j++)
        {
            BuildingProperties buildingProperties = list[j];
            _shopBuildings.Add(new ShopBuilding(buildingProperties));
        }

        InitBuildingShopItem();
    }

    private void InitBuildingShopItem()
    {
        for (int i = 0; i < _shopBuildings.Count; i++)
        {
            BuildingsShopItemView buildingShopItemView = Instantiate(prefabBuildingShopItemView, holder);
            ShopBuilding shopBuilding = _shopBuildings[i];
            buildingShopItemView.Init(shopBuilding.Props, _game);
        }
    }

    public void OnCloseAllClicked()
    {
        _game.PopupManager.CloseAllOpenPopups();
    }

    private void SetDefault()
    {
        for (int i = holder.childCount - 1; i >= 0; i--)
        {
            if (holder.GetChild(i) != null)
            {
                Destroy(holder.GetChild(i).gameObject);
            }
        }
    }
}