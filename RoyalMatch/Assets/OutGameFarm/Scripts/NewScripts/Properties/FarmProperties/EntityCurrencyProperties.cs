using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityCurrencyProperties : EntityProperties
{
    private const string TypeKey = "type";

    private const string BuildingNamesKey = "buildingNames";

    //các flag giá kim cương giá sell tiền mwajt max rồi ..unlck level?
    private const string CostGemsKey = "costDiamonds";
    private const string MinSellCoinsKey = "minSellCash";
    private const string MaxSellCoinsKey = "maxSellCash";
    private const string StringReferenceKey = "stringReference";
    private const string UnlockLevelKey = "unlockLevel";
    private const string NameItemKey = "name";

    private float _purchaseCostMultiplier = 1f;
    private Currency _basePurchaseCost;


    //dictinay lưu tiền tệ theo key value::
    public static readonly Dictionary<string, CurrencyCategory> CurrencyCategoryLookup =
        new Dictionary<string, CurrencyCategory>
        {
            {
                string.Empty,
                CurrencyCategory.None
            },
            {
                "basicMaterial",
                CurrencyCategory.BasicMaterial
            },
            {
                "product",
                CurrencyCategory.Product
            },
            {
                "buildingMaterial",
                CurrencyCategory.BuildingMaterial
            },
            {
                "sowingMaterial",
                CurrencyCategory.SowingMaterial
            },
            {
                "shopitems",
                CurrencyCategory.Product
            },
            {
                "ItemBonus",
                CurrencyCategory.ItemBonus
            },
            {
                "itemFruit",
                CurrencyCategory.itemFruit
            }
        };

    public string CurrencyName
    {
        get { return base.BaseKey; }
    }


    public CurrencyCategory Category { get; private set; }
    public string StringReference { get; private set; }
    public List<string> BuildingNames { get; private set; }
    public long UnlockLevel { get; private set; }
    public long MinSellCoins { get; private set; }
    public long MaxSellCoins { get; private set; }
    public Currency PurchaseCost { get; private set; }
    public Currency CostSell { get; private set; }

    public string NameItem { get; private set; }
    public string TypeWareHouse { get; private set; }

    //lấy thằng trong dictionnay enum kia lấy theo farmfield lấy từ string sang enum thôi::
    public EntityCurrencyProperties(PropertiesDictionary propsDict, string baseKey)
        : base(propsDict, baseKey)
    {
        string property = GetProperty("type", string.Empty);
        Category = CurrencyCategoryLookup[property];
        StringReference = GetProperty("stringReference", "TOVI_" + baseKey);
        //các tòa nhà sẽ dùng cái này là tòa nhà nào như hạt giống thì sẽ và vật liệu 
        BuildingNames = GetProperty("buildingNames", new List<string>());
        MinSellCoins = GetProperty("minSellCash", 0L);
        MaxSellCoins = GetProperty("maxSellCash", 0L);
        UnlockLevel = GetProperty("unlockLevel", 0L);
        TypeWareHouse = GetProperty("typeWareHouse", "none");
        Currency currency = null;
        if (Currency.TryParse(GetProperty("cost", string.Empty), out currency))
        {
            CostSell = currency;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.cost'", baseKey);
        }
       
        NameItem = GetProperty("name", base.BaseKey);
        _basePurchaseCost = new Currency(CurrencyType.gems, GetProperty("costDiamonds", 1L));

        PurchaseCost = _basePurchaseCost;
    }

    public Currency CreateCurrency(long amount)
    {
        return new Currency(CurrencyName, amount);
    }
}