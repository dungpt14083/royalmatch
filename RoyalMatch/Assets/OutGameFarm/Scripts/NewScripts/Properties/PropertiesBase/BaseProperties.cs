using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProperties
{
    protected PropertiesFile _propsDict;
    protected Dictionary<string, List<string>> _keysByType;
    protected Dictionary<string, EntityProperties> _propertiesCache;

    public BaseProperties(string nameFile)
    {
        _propsDict = new PropertiesFile(nameFile);
        _keysByType = new Dictionary<string, List<string>>();
        _propertiesCache = new Dictionary<string, EntityProperties>();
    }

    protected List<string> GetBaseKeysWithType(string type)
    {
        if (!_keysByType.ContainsKey(type))
        {
            _keysByType[type] = _propsDict.GetBaseKeysByKeyValue("type", type);
        }

        return _keysByType[type];
    }

    protected List<string> GetBaseKeysWithTypeShop(string typeShop)
    {
        if (!_keysByType.ContainsKey(typeShop))
        {
            _keysByType[typeShop] = _propsDict.GetBaseKeysByKeyValue("typeShop", typeShop);
        }

        return _keysByType[typeShop];
    }
    protected List<string> GetBaseKeysWithTypeWareHouse(string type)
    {
        if (!_keysByType.ContainsKey(type))
        {
            _keysByType[type] = _propsDict.GetBaseKeysByKeyValue("typeWareHouse", type);
        }

        return _keysByType[type];
    }
    protected List<T> GetProperties<T>(List<string> baseKeys) where T : EntityProperties
    {
        List<T> list = new List<T>();
        int count = baseKeys.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(GetProperties<T>(baseKeys[i]));
        }

        return list;
    }

    //Viết lại hàm này cho các loại get chắc chỉ dành cho nhà của buildingpropeties
    public virtual T GetProperties<T>(string baseKey, int level = 1) where T : EntityProperties
    {
        return null;
    }
}