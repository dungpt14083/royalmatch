using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THỰC CHẤT ĐOẠN NÀY PHẢI TÁCH RA NỮA THÀNH 2 PROPETIES CHO FARM CHÍNH VA FARM PHỤ KIA NHƯNG DO ĐẢO PHỤ CHƯA LÀM NÊN TẠM BỎ QUA DÙNG CHUNG::
public class IslandFarmProperties : BaseProperties
{
    public const string ResidentialTypeKey = "residential";

    public const string CommercialTypeKey = "commercial";

    public const string CommunityTypeKey = "community";

    public const string WarehouseTypeKey = "warehouse";

    public const string DecorationTypeKey = "decoration";

    public const string FarmFieldTypeKey = "farmfield";

    public const string ExpansionTypeKey = "expansion";

    protected List<BuildingProperties> _buildingProperties;

    private List<BuildingProperties> _decorationBuildingProperties;

    private List<BuildingProperties> _specialBuildingProperties;

    public List<BuildingProperties> WareHouseBuildingDecoration = new List<BuildingProperties>();
    // private List<SowingMaterialProperties> _sowingMaterialProperties;
    // private List<BasicMaterialProperties> _basicMaterialProperties;
    // private List<ProductProperties> _productProperties;


    #region CUNG CẤP KEY TRUY VẤN PROPERTIES

    // public List<string> SowingMaterialNames
    // {
    //     get { return GetBaseKeysWithType("sowingMaterial"); }
    // }
    //
    // public List<string> BasicMaterialNames
    // {
    //     get { return GetBaseKeysWithType("basicMaterial"); }
    // }
    //
    // public List<string> ProductNames
    // {
    //     get { return GetBaseKeysWithType("product"); }
    // }

    public List<string> ResidentialBuildingNames
    {
        get { return GetBaseKeysWithType("residential"); }
    }

    public List<string> ItemFruitBuildingNames
    {
        get { return GetBaseKeysWithType("itemFruit"); }
    }
    public List<string> CommercialBuildingNames
    {
        get
        {
            if (_commercialBuildingNames == null)
            {
                _commercialBuildingNames = new List<string>();
                _commercialBuildingNames.AddRange(GetBaseKeysWithType("commercial"));
                _commercialBuildingNames.AddRange(GetBaseKeysWithType("livestockFarm"));
            }

            return _commercialBuildingNames;
        }
    }

    public List<string> CommunityBuildingNames
    {
        get { return GetBaseKeysWithType("community"); }
    }

    public List<string> DecorationBuildingNames
    {
        get { return GetBaseKeysWithType("decoration"); }
    }

    public List<string> PetHouseBuildingNames
    {
        get { return GetBaseKeysWithType("petHouse"); }
    }

    public List<string> SpecialBuildingNames
    {
        get
        {
            if (_specialBuildingNames == null)
            {
                _specialBuildingNames = new List<string>();
                // _specialBuildingNames.AddRange(GetBaseKeysWithType("garage"));
                // _specialBuildingNames.AddRange(GetBaseKeysWithType("marketStand"));
                // _specialBuildingNames.AddRange(GetBaseKeysWithType("saleTruck"));
                _specialBuildingNames.AddRange(GetBaseKeysWithType("farmfield"));
                _specialBuildingNames.AddRange(GetBaseKeysWithType("itemFruit"));
            }

            return _specialBuildingNames;
        }
    }

    public List<string> ShopTabFruitAndFarmField => GetBaseKeysWithTypeShop("tab1");
    public List<string> ShopTabPetHouseAndEgg => GetBaseKeysWithTypeShop("tab3");

    private List<string> _commercialBuildingNames;
    private List<string> _specialBuildingNames;

    // public List<string> AllCurrencyNames
    // {
    //     get
    //     {
    //         if (!_keysByType.ContainsKey("allCurrencies"))
    //         {
    //             _keysByType["allCurrencies"] = new List<string>();
    //             _keysByType["allCurrencies"].AddRange(GetBaseKeysWithType("sowingMaterial"));
    //         }
    //
    //         return _keysByType["allCurrencies"];
    //     }
    // }

    #endregion


    #region CÁC PROPETIES TRONG FARRM

    // public List<SowingMaterialProperties> SowingMaterialProperties
    // {
    //     get
    //     {
    //         if (_sowingMaterialProperties == null)
    //         {
    //             _sowingMaterialProperties = GetProperties<SowingMaterialProperties>(SowingMaterialNames);
    //         }
    //
    //         return _sowingMaterialProperties;
    //     }
    // }
    //
    // public List<BasicMaterialProperties> BasicMaterialProperties
    // {
    //     get
    //     {
    //         if (_basicMaterialProperties == null)
    //         {
    //             _basicMaterialProperties = GetProperties<BasicMaterialProperties>(BasicMaterialNames);
    //             _basicMaterialProperties.Sort((BasicMaterialProperties a, BasicMaterialProperties b) =>
    //                 a.UnlockLevel.CompareTo(b.UnlockLevel));
    //         }
    //
    //         return _basicMaterialProperties;
    //     }
    // }
    //
    // public List<ProductProperties> ProductProperties
    // {
    //     get
    //     {
    //         if (_productProperties == null)
    //         {
    //             _productProperties = GetProperties<ProductProperties>(ProductNames);
    //         }
    //
    //         return _productProperties;
    //     }
    // }

    // private List<SpeedupProperties> _speedupProperties;
    //
    // public List<SpeedupProperties> SpeedupProperties
    // {
    //     get
    //     {
    //         if (_speedupProperties == null)
    //         {
    //             _speedupProperties = GetProperties<SpeedupProperties>(GetBaseKeysWithType("upspeed"));
    //             _speedupProperties.Sort((SpeedupProperties a, SpeedupProperties b) =>
    //                 (a.MinTimeRemainingSeconds == b.MinTimeRemainingSeconds)
    //                     ? a.MaxTimeRemainingSeconds.CompareTo(b.MaxTimeRemainingSeconds)
    //                     : a.MinTimeRemainingSeconds.CompareTo(b.MinTimeRemainingSeconds));
    //         }
    //
    //         return _speedupProperties;
    //     }
    // }

    public List<BuildingProperties> DecorationBuildingProperties
    {
        get
        {
            if (_decorationBuildingProperties == null)
            {
                _decorationBuildingProperties = GetProperties<BuildingProperties>(DecorationBuildingNames);
            }

            return _decorationBuildingProperties;
        }
    }

    #endregion


    #region CÁC NHÀ CÓ SAN TRONG GAME:::

    public List<StartBuildingProperties> StartBuildings
    {
        get { return GetProperties<StartBuildingProperties>(GetBaseKeysWithType("startBuilding")); }
    }

    #endregion

    public List<ItemBonusRepeatProperties> GetItemBonusRepeatProperties()
    {
        return GetProperties<ItemBonusRepeatProperties>(GetBaseKeysWithType("ItemBonusRepeat"));
    }
    #region GATHERABLE:::

    //LIST RÁC THÌ K CẦN NCH PHẦN LIST NÀY K CẦN VÌ K THỂ CÓ CỬA HÀNG MUA RÁC DANH SÁCH RÁC???MÀ CÓ KHI CŨNG CẦN Ở CHỖ ĐÂU ĐÓ NCH TÍNH SAU::
    //NHƯNG KHẢ NĂNG LÀ KHÔNG CẦN
    //TYPE CHỈ ĐỂ CHO CỬA HÀNG
    //CÒN LẠI DỰA VÀO BASEKEY LÀ ĐƯỢC LÀ CÁI THẰNG TN ĐÂU TRONG TẤT CẢ STRING::
    //STARTBUILDING SẼ LẤY BUILDINGNAME LÀM KEY

    /*
    private List<BuildingProperties> _gatherableProperties;

    //LIST BUILDINGname list trn rác với type kia được lọc ra propeties
    public List<string> GatherableNames
    {
        get { return GetBaseKeysWithType("gatherable"); }
    }

    //TẤT CẢ GATHERABLEPROPETIES CỦA CÁC LOẠI GATHERABLE ĐƯỢC LỌC RA ĐÂY:::
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
*/
    #endregion


    #region CÁC HÀM TIỆNISCHO PROPETIES::

    public List<T> SortBuildingByUnlockLevel<T>(List<T> buildings) where T : BuildingProperties
    {
        List<T> list = new List<T>(buildings);
        //list.Sort((T a, T b) => (a.UnlockLevel == b.UnlockLevel) ? a.BuildingName.CompareTo(b.BuildingName) : a.UnlockLevel.CompareTo(b.UnlockLevel));
        return list;
    }

    // public SpeedupProperties GetSpeedupProperties(double remainingSeconds)
    // {
    //     int count = SpeedupProperties.Count;
    //     for (int i = 0; i < count; i++)
    //     {
    //         if (SpeedupProperties[i].InRange(remainingSeconds))
    //         {
    //             return SpeedupProperties[i];
    //         }
    //     }
    //
    //     Debug.LogWarningFormat("Could not find speedup properties for '{0}' seconds! - Returning longest speedup cost.",
    //         remainingSeconds);
    //     return SpeedupProperties[count - 1];
    // }

    // public List<SowingMaterialProperties> GetSowingMaterialProperties(string buildingName)
    // {
    //     List<SowingMaterialProperties> list = new List<SowingMaterialProperties>();
    //     int count = SowingMaterialProperties.Count;
    //
    //     for (int i = 0; i < count; i++)
    //     {
    //         SowingMaterialProperties sowingMaterialProperties = SowingMaterialProperties[i];
    //         if (sowingMaterialProperties.BuildingNames.Contains(buildingName))
    //         {
    //             list.Add(sowingMaterialProperties);
    //         }
    //     }
    //
    //     return list;
    // }

    private Dictionary<string, int> _string_switch_int;

    public override T GetProperties<T>(string baseKey, int level = 0)
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
                dictionary.Add("residential", 0);
                dictionary.Add("community", 1);
                dictionary.Add("commercial", 2);
                dictionary.Add("warehouse", 3);
                dictionary.Add("decoration", 4);
                dictionary.Add("farmfield", 5);
                //dictionary.Add("sowingMaterial", 6);
                dictionary.Add("startBuilding", 7);
                //dictionary.Add("upspeed", 8);
                //dictionary.Add("gatherable", 9);
                dictionary.Add("UpgradeHouse", 10);
                dictionary.Add("ProduceHouse", 11);
                dictionary.Add("TrainBuilding", 12);
                dictionary.Add("AirplaneBuilding", 13);
                dictionary.Add("itemFruit",14);
                dictionary.Add("petHouse",15);
                dictionary.Add("ItemBonus",16);
                dictionary.Add("ItemBonusChangeStage",17);
                dictionary.Add("ItemBonusRepeat", 18);
                dictionary.Add("bonusTree",19);
                _string_switch_int = dictionary;
            }
        }

        int value2;
        if (_string_switch_int.TryGetValue(value, out value2))
        {
            EntityProperties entityProperties;
            switch (value2)
            {
                case 0:
                    entityProperties = new DecorationBuildingProperties(_propsDict, baseKey);
                    break;
                case 3:
                    entityProperties = new WarehouseBuildingProperties(_propsDict, baseKey, level);
                    break;
                case 4:
                    entityProperties = new DecorationBuildingProperties(_propsDict, baseKey);
                    break;
                case 5:
                    entityProperties = new FarmfieldBuildingProperties(GeneralProperties, _propsDict, baseKey);
                    break;
                // case 6:
                //     entityProperties = new SowingMaterialProperties(_propsDict, baseKey);
                //     break;
                case 7:
                    entityProperties = new StartBuildingProperties(_propsDict, baseKey);
                    break;
                // case 8:
                //     entityProperties = new SpeedupProperties(_propsDict, baseKey);
                //     break;
                // case 9:
                //     entityProperties = new GatherableProperties(_propsDict, baseKey);
                //     break;
                case 10:
                    entityProperties = new UpgradeProperties(_propsDict, baseKey, level);
                    break;
                case 11:
                    entityProperties = new ProduceProperties(_propsDict, baseKey, level);
                    break;
                case 12:
                    entityProperties = new TrainProperties(_propsDict, baseKey, level);
                    break;
                case 13:
                    entityProperties = new AirplaneProperties(_propsDict, baseKey, level);
                    break;
                case 14:
                    entityProperties = new FruitTreeProperties(_propsDict, baseKey);
                    break;
                case 15:
                    entityProperties = new DecorationBuildingProperties(_propsDict, baseKey);
                    break;
                case 16:
                    entityProperties = new ItemBonusProperties(_propsDict, baseKey);
                    break;
                case 17:
                    entityProperties = new ItemBonusChangeStageProperties(_propsDict, baseKey);
                    break;
                case 18:
                    entityProperties = new ItemBonusRepeatProperties(_propsDict, baseKey);
                    break;
                case 19:
                    entityProperties = new BonusTreeProperties(_propsDict, baseKey);
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

    public GeneralProperties GeneralProperties { get; private set; }


    public IslandFarmProperties(GeneralProperties generalProperties, string nameFile) : base(nameFile)
    {
        GeneralProperties = generalProperties;
    }
}