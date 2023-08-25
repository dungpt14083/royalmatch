using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProduceProperties : UpgradeProperties
{
    private const string productsKey = "products";
    private List<string> listProductsKey;


    public ProduceProperties(PropertiesDictionary propsDict, string key, int level)
        : base(propsDict, key, level)
    {
        listProductsKey = GetProperty(productsKey, new List<string>());
    }
    public List<string> GetProductsKey()
    {
        return listProductsKey == null ? new List<string>() : listProductsKey;
    }
    public List<int> GetUnlockWaitingProduce()
    {
        return CurrentLevelProperties == null ? new List<int>() : CurrentLevelProperties.unlockWaitingProduce;
    }
}
