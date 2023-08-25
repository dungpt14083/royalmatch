using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties
{
    //SAU KHI LẤY HẾT RA THÌ CACH LẠI PROPRTIES LIST CÁI ĐƯỢC ÉP KIỂU TỪ JSON RA CÁI NÀY PROPETIES CHI TIẾT CỦA BỌN BUILDING
    private Dictionary<string, EntityProperties> _propertiesCache;
    private List<BuildingProperties> _buildingProperties;


    private List<BuildingProperties> _decorationBuildingProperties;
    private List<BuildingProperties> _specialBuildingProperties;
    private List<SowingMaterialProperties> _sowingMaterialProperties;
    private List<BasicMaterialProperties> _basicMaterialProperties;
    private List<ProductProperties> _productProperties;


    //2CASI NÀY ĐƯỢC INIT KHI TẠO INSTANCE CHƯA CÓ DATA COMBINE THÌ DÙNG TẠM CÁI NÀY ĐI
    private Dictionary<string, List<string>> _keysByType;

    private PropertiesFile _propsDict;

    //lưu giữ string va int stt sẽ dùng cho switchcase việc string ấy mà ::::::string loại h gì utowng ứng index bn để switchcase
    private static Dictionary<string, int> _string_switch_int;

    #region DDDD

    public List<string> SowingMaterialNames
    {
        get { return GetBaseKeysWithType("sowingMaterial"); }
    }

    public List<string> BasicMaterialNames
    {
        get { return GetBaseKeysWithType("basicMaterial"); }
    }

    public List<string> ProductNames
    {
        get { return GetBaseKeysWithType("product"); }
    }

    #endregion


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
                _productProperties = GetProperties<ProductProperties>(ProductNames);
            }

            return _productProperties;
        }
    }


    #region STARTBUILDINGGGGGGGGGG:::

    public List<StartBuildingProperties> StartBuildings
    {
        get { return GetProperties<StartBuildingProperties>(GetBaseKeysWithType("startBuilding")); }
    }

    #endregion


    //STARTGAME TIỀN TỆ VÀ????
    public GameStartCurrrencysProperties GameStartCurrrencysProperties { get; private set; }


    public List<string> AllCurrencyNames
    {
        get
        {
            if (!_keysByType.ContainsKey("allCurrencies"))
            {
                _keysByType["allCurrencies"] = new List<string>();
                _keysByType["allCurrencies"].AddRange(GetBaseKeysWithType("sowingMaterial"));
            }

            return _keysByType["allCurrencies"];
        }
    }

    public Properties()
    {
        //propsIsland
        _propsDict = new PropertiesFile("DataProps");
        _keysByType = new Dictionary<string, List<string>>();
        _propertiesCache = new Dictionary<string, EntityProperties>();
        GameStartCurrrencysProperties = new GameStartCurrrencysProperties(_propsDict, "game");
    }

    public List<T> SortBuildingByUnlockLevel<T>(List<T> buildings) where T : BuildingProperties
    {
        List<T> list = new List<T>(buildings);
        //list.Sort((T a, T b) => (a.UnlockLevel == b.UnlockLevel) ? a.BuildingName.CompareTo(b.BuildingName) : a.UnlockLevel.CompareTo(b.UnlockLevel));
        return list;
    }


    private List<string> GetBaseKeysWithType(string type)
    {
        if (!_keysByType.ContainsKey(type))
        {
            _keysByType[type] = _propsDict.GetBaseKeysByKeyValue("type", type);
        }

        return _keysByType[type];
    }

    private List<T> GetProperties<T>(List<string> baseKeys) where T : EntityProperties
    {
        List<T> list = new List<T>();
        int count = baseKeys.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(GetProperties<T>(baseKeys[i]));
        }

        return list;
    }

    //T PHẢI LÀ CLASS DẠNG BASEPROPETIES LÀ LỚP BASE CHO PROFILE CÒN LOẠI NÀO NTN THÌ SẼ KẾ THỪA TỪ THẰNG NÀY TRIỂN KHAI CHO TỪNG CLASS TỪNG FIELD
    public T GetProperties<T>(string baseKey, int level = 1) where T : EntityProperties
    {
        //nếu trong cache có thì lấy ra:::
        if (_propertiesCache.ContainsKey(baseKey) && _propertiesCache[baseKey] is T)
        {
            return (T)_propertiesCache[baseKey];
        }

        //nếu propsdict k có thì return
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
                dictionary.Add("sowingMaterial", 6);
                dictionary.Add("startBuilding", 7);
                dictionary.Add("upspeed", 8);

                _string_switch_int = dictionary;
            }
        }

        //từ đây sẽ lấy ra loại nào tạo instance vói popdict và ket và cc kiểu 
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
                //case 5:
                //entityProperties = new FarmfieldBuildingProperties(this, _propsDict, baseKey);
                //break;
                case 6:
                    entityProperties = new SowingMaterialProperties(_propsDict, baseKey);
                    break;
                case 7:
                    entityProperties = new StartBuildingProperties(_propsDict, baseKey);
                    break;
                case 8:
                    entityProperties = new SpeedupProperties(_propsDict, baseKey);
                    break;
                default:
                    entityProperties = null;
                    break;
            }

            //bijesp kiểu về building tạm cho việc xây dựng khi xây ra thì nó bung prop ra dựa vào buidling popr.type ép kiểu lại lấy prrop
            return (T)entityProperties;
        }

        return (T)null;
    }


    #region lấy farm properties:::

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

        //list.Sort((SowingMaterialProperties a, SowingMaterialProperties b) => a.UnlockLevel.CompareTo(b.UnlockLevel));
        return list;
    }

    #endregion


    #region CẤP CÁC PROP THEO NHÀ DÀNH CHO SHOP HIỂN THỊ

    private List<string> _commercialBuildingNames;
    private List<string> _specialBuildingNames;


    public List<string> ResidentialBuildingNames
    {
        get { return GetBaseKeysWithType("residential"); }
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
            }

            return _specialBuildingNames;
        }
    }

    #endregion


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
}