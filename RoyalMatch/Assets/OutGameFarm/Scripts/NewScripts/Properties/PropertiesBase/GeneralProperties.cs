using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralProperties : BaseProperties
{
    //Lấy tiền tệ ra ngoài:::
    public GameStartCurrrencysProperties GameStartCurrrencysProperties { get; private set; }

    public GeneralProperties(string nameFile) : base(nameFile)
    {
        GameStartCurrrencysProperties = new GameStartCurrrencysProperties(_propsDict, "game");
    }

    
    
    
    
    
    

    #region GATHERABLEPROPETIES::::

    //CHỈ LÀ BUILDING PROPETIES MÀ THÔI CÒN START THÌ Ở TRONG CÁC ĐẢO:::
    
    
    //thêm list building propeties cho rác nữa
    private List<BuildingProperties> _gatherableProperties;

    public List<string> GatherableNames
    {
        get { return GetBaseKeysWithType("gatherable"); }
    }

    public List<BuildingProperties> GatherableProperties
    {
        get
        {
            if (_gatherableProperties == null)
            {
                _gatherableProperties = GetProperties<BuildingProperties>(GatherableNames);
            }

            return _gatherableProperties;
        }
    }

    #endregion


    
    
    
    
    
    
    
    
    
    
    //TÁCH THẰNG PRODUCT MATERRIAL VÀ SOWING RA ĐỂ NGOÀI LẤY CHỨ K PHẢI TRONG ISLAND NỮA::

    #region ĐƯA PHẦN PROPERTIES KIA RA NGOÀI NÀY HẾT K ĐỂ TRONG ISLANDPROPETIES NỮA Ở ĐÂY TRUY VẤN:::

    private List<SowingMaterialProperties> _sowingMaterialProperties;
    private List<BasicMaterialProperties> _basicMaterialProperties;
    private List<ProductProperties> _productProperties;
    private List<ProductProperties> _itemMapPropertiesList;
    private List<ProductProperties> _allProductProperties;
    private List<ItemBounsProperties> _itemBounsProperties;
    private List<ProductProperties> _onlyCurrencyPropertiesList;

    public List<string> SowingMaterialNames
    {
        get { return GetBaseKeysWithType("sowingMaterial"); }
    }
    public List<string> ItemMapNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemMap"); }
    }

    public List<string> OnlyCurrencyNames
    {
        get { return GetBaseKeysWithTypeWareHouse("currency"); }
    }

    public List<string> BasicMaterialNames
    {
        get { return GetBaseKeysWithType("basicMaterial"); }
    }

    public List<string> ProductNames
    {
        get { return GetBaseKeysWithType("product"); }
    }

    public List<string> Rewards
    {
        get { return GetBaseKeysWithType("Reward"); }
    }

    public List<string> ShopItemsNames
    {
        get { return GetBaseKeysWithTypeShop("tab4"); }
    }

    public List<string> ShopItemsTntAndEnergy
    {
        get { return GetBaseKeysWithTypeShop("tab5"); }
    }

    public List<string> ItemBounsNames
    {
        get { return GetBaseKeysWithType("ItemBonus"); }
    }
    
    public List<string> ItemWeaverNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemWeaver"); }
    }

    public List<string> ItemWorkshopNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemWorkshop"); }
    }
    public List<string> ItemQuaryNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemQuary"); }
    }
    public List<string> ItemFeedFactoryNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemFeedFactory"); }
    }
    public List<string> ItemCowShedNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemCowShed"); }
    }
    public List<string> ItemDairyFactoryNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemDairyFactory"); }
    }
    public List<string> ItemChickenCoopNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemChickenCoop"); }
    }
    public List<string> ItemKitchenNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemKitchen"); }
    }
    public List<string> ItemSeedsNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemSeeds"); }
    }

    public List<string> ItemPigFeedNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemPigFeed"); }
    }
    public List<string> ItemGrillFactoryNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemGrillFactory"); }
    }

    public List<string> ItemBeverageFactoryNames
    {
        get { return GetBaseKeysWithTypeWareHouse("ItemBeverageFactory"); }
    }

    public List<string> ItemFruitNames
    {
        get { return GetBaseKeysWithTypeWareHouse("itemFruit"); }
    }
    public List<string> AllCurrencyNames
    {
        get
        {
            if (!_keysByType.ContainsKey("allCurrencies"))
            {
                _keysByType["allCurrencies"] = new List<string>();
                _keysByType["allCurrencies"].AddRange(GetBaseKeysWithType("sowingMaterial"));
                _keysByType["allCurrencies"].AddRange(ProductNames);
                _keysByType["allCurrencies"].RemoveAll(prod => OnlyCurrencyNames.Contains(prod));
                _keysByType["allCurrencies"].AddRange(ItemMapNames);
                _keysByType["allCurrencies"].AddRange(ItemBounsNames);

            }

            return _keysByType["allCurrencies"];
        }
    }

    public List<SowingMaterialProperties> SowingMaterialProperties
    {
        get
        {
            if (_sowingMaterialProperties == null)
            {
                _sowingMaterialProperties = GetProperties<SowingMaterialProperties>(SowingMaterialNames);
            }

            return _sowingMaterialProperties;
        }
    }

    public List<BasicMaterialProperties> BasicMaterialProperties
    {
        get
        {
            if (_basicMaterialProperties == null)
            {
                _basicMaterialProperties = GetProperties<BasicMaterialProperties>(BasicMaterialNames);
                _basicMaterialProperties.Sort((BasicMaterialProperties a, BasicMaterialProperties b) =>
                    a.UnlockLevel.CompareTo(b.UnlockLevel));
            }

            return _basicMaterialProperties;
        }
    }

    public List<ProductProperties> ProductProperties
    {
        get
        {
            if (_productProperties == null)
            {
                _productProperties = new List<ProductProperties>();
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemWeaverNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemWorkshopNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemQuaryNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemFeedFactoryNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemCowShedNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemDairyFactoryNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemChickenCoopNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemKitchenNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemSeedsNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemPigFeedNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemGrillFactoryNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemBeverageFactoryNames));
                _productProperties.AddRange(GetProperties<ProductProperties>(ItemFruitNames));
           //     _productProperties.RemoveAll(prod => ItemMapNames.Contains(prod.BaseKey));
                _productProperties.RemoveAll(prod => OnlyCurrencyNames.Contains(prod.BaseKey));
            }

            return _productProperties;
        }
    }

    public List<ProductProperties> AllProductProperties
    {
        get
        {
            if (_allProductProperties == null)
            {
                _allProductProperties = new List<ProductProperties>();
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemWeaverNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemWorkshopNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemQuaryNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemFeedFactoryNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemCowShedNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemDairyFactoryNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemChickenCoopNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemKitchenNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemSeedsNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemPigFeedNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemGrillFactoryNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemBeverageFactoryNames));
                _allProductProperties.AddRange(GetProperties<ProductProperties>(ItemFruitNames));
                _allProductProperties.RemoveAll(prod => OnlyCurrencyNames.Contains(prod.BaseKey));
            }

            return _allProductProperties;
        }
    }

    public List<ProductProperties> ItemMapProperties
    {
        get
        {
            if (_itemMapPropertiesList == null)
            {
                _itemMapPropertiesList = GetProperties<ProductProperties>(ItemMapNames);
            }

            return _itemMapPropertiesList;
        }
    }

    public List<ProductProperties> OnlyCurrencyProperties
    {
        get
        {
            if (_onlyCurrencyPropertiesList == null)
            {
                _onlyCurrencyPropertiesList = GetProperties<ProductProperties>(OnlyCurrencyNames);
            }

            return _onlyCurrencyPropertiesList;
        }
    }

    private List<SpeedupProperties> _speedupProperties;

    public List<SpeedupProperties> SpeedupProperties
    {
        get
        {
            if (_speedupProperties == null)
            {
                _speedupProperties = GetProperties<SpeedupProperties>(GetBaseKeysWithType("upspeed"));
                _speedupProperties.Sort((SpeedupProperties a, SpeedupProperties b) =>
                    (a.MinTimeRemainingSeconds == b.MinTimeRemainingSeconds)
                        ? a.MaxTimeRemainingSeconds.CompareTo(b.MaxTimeRemainingSeconds)
                        : a.MinTimeRemainingSeconds.CompareTo(b.MinTimeRemainingSeconds));
            }

            return _speedupProperties;
        }
    }


    public SpeedupProperties GetSpeedupProperties(double remainingSeconds)
    {
        int count = SpeedupProperties.Count;
        for (int i = 0; i < count; i++)
        {
            if (SpeedupProperties[i].InRange(remainingSeconds))
            {
                return SpeedupProperties[i];
            }
        }

        Debug.LogWarningFormat("Could not find speedup properties for '{0}' seconds! - Returning longest speedup cost.",
            remainingSeconds);
        return SpeedupProperties[count - 1];
    }

    public List<SowingMaterialProperties> GetSowingMaterialProperties(string buildingName)
    {
        List<SowingMaterialProperties> list = new List<SowingMaterialProperties>();
        int count = SowingMaterialProperties.Count;

        for (int i = 0; i < count; i++)
        {
            SowingMaterialProperties sowingMaterialProperties = SowingMaterialProperties[i];
            if (sowingMaterialProperties.BuildingNames.Contains(buildingName))
            {
                list.Add(sowingMaterialProperties);
            }
        }

        return list;
    }

    public List<ItemBounsProperties> ItemBounsProperties
    {
        get
        {
            if (_itemBounsProperties == null)
            {
                _itemBounsProperties = GetProperties<ItemBounsProperties>(ItemBounsNames);
            }

            return _itemBounsProperties;
        }
    }

    //HÀM CHO VIỆC LOAD PROPETIES TIỀN TỪ TRONG FILE LÊN
    private Dictionary<string, int> _string_switch_int;

    public override T GetProperties<T>(string baseKey, int level = 1)
    {
        if (_propertiesCache.ContainsKey(baseKey) && _propertiesCache[baseKey] is T)
        {
            return (T)_propertiesCache[baseKey];
        }

        if (!_propsDict.HasBaseKey(baseKey))
        {
            Debug.LogErrorFormat("Properties object with base key '{0}' does not exist.", baseKey);
            return (T)null;
        }

        string value;
        if (!_propsDict.TryGetValue(baseKey, "type", out value))
        {
            Debug.LogErrorFormat("Properties object with base key '{0}' is missing 'type' field.", baseKey);
            return (T)null;
        }

        if (value != null)
        {
            if (_string_switch_int == null)
            {
                Dictionary<string, int> dictionary = new Dictionary<string, int>(58);
                dictionary.Add("sowingMaterial", 1);
                dictionary.Add("upspeed", 2);
                dictionary.Add("product", 3);
                dictionary.Add("Reward", 4);
                dictionary.Add("shopitems", 5);
                dictionary.Add("gatherable", 9);
                dictionary.Add("ItemBonus",10);
                dictionary.Add("itemFruit",11);
                
                _string_switch_int = dictionary;
            }
        }

        int value2;
        if (_string_switch_int.TryGetValue(value, out value2))
        {
            EntityProperties entityProperties;
            switch (value2)
            {
                case 1:
                    entityProperties = new SowingMaterialProperties(_propsDict, baseKey);
                    break;
                case 2:
                    entityProperties = new SpeedupProperties(_propsDict, baseKey);
                    break;
                case 3:
                    entityProperties = new ProductProperties(_propsDict, baseKey);
                    break;
                case 4:
                    entityProperties = new RewardProperties(_propsDict, baseKey);
                    break;
                case 5:
                    entityProperties = new ProductProperties(_propsDict, baseKey);
                    break;
                case 9:
                    entityProperties = new GatherableProperties(_propsDict, baseKey);
                    break;
                case 10:
                    entityProperties = new ItemBounsProperties(_propsDict, baseKey);
                    break;
                case 11:
                    entityProperties = new ProductProperties(_propsDict, baseKey);
                    break;
                
                default:
                    entityProperties = null;
                    break;
            }

            return (T)entityProperties;
        }

        return (T)null;
    }

    #endregion
}