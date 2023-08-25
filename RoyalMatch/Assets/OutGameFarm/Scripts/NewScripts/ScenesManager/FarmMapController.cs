using System;
using System.Collections.Generic;
using UnityEngine;

public class FarmMapController /*: SingletonMonobehaviour<FarmMapController>*/
{
    private static FarmMapController instance = null;
    public static FarmMapController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new FarmMapController();

                if (instance == null)
                {
                    Debug.LogError("Could not find an instance of " + typeof(FarmMapController).Name + " in resources.");
                }
            }

            return instance;
        }
    }
    private int levelPlayer;
    public GeneralProperties GeneralProperties { get; set; }
    public GeneralBalance GeneralBalance { get; set; }
    public IslandFarmProperties IslandFarmProperties { get; set; }
    public TimeKeeper TimeKeeper { get; set; }
    public IsLandInfo IsLandInfo { get; set; }
    public Action actionLevelChange;

    public FarmMapController()
    {
        levelPlayer = 12;
    }
    public GeneralBalance GetGeneralBalance()
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralBalance == null) return null;
        //var value = farmIsLandData.GameData.GeneralBalance;
        return GeneralBalance;
    }
    public long GetGeneralBalanceByKey(string key)
    {
        //if (farmIslandBootstrapper == null) return 0;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralBalance == null) return 0;
        //var value = farmIsLandData.GameData.GeneralBalance.GetValue(key);
        return GeneralBalance.GetValue(key);
    }
    public GeneralProperties GetGeneralProperties()
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralProperties == null) return null;
        //var value = farmIsLandData.GameData.GeneralProperties;
        return GeneralProperties;
    }
    
    public EntityCurrencyProperties GetGeneralPropertiesBykey(string key)
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralProperties == null) return null;
        //var value = farmIsLandData.GameData.GeneralProperties.GetProperties<EntityCurrencyProperties>(key);
        return GeneralProperties.GetProperties<EntityCurrencyProperties>(key); ;
    }
    public RewardProperties GetRewardPropertiesBykey(string key)
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralProperties == null) return null;
        //var value = farmIsLandData.GameData.GeneralProperties.GetProperties<EntityCurrencyProperties>(key);
        return GeneralProperties.GetProperties<RewardProperties>(key); ;
    }
    public ProductProperties GetProductPropertiesBykey(string key)
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralProperties == null) return null;
        //var value = farmIsLandData.GameData.GeneralProperties.GetProperties<EntityCurrencyProperties>(key);
        return GeneralProperties.GetProperties<ProductProperties>(key); ;
    }
    public bool BuyMaterial(Currency cost, bool useGem, Currency material)
    {
        //if (farmIslandBootstrapper == null) return false;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.GeneralBalance == null) return false;
        //return farmIsLandData.GameData.GeneralBalance.BuyMaterial(cost, useGem, material);
        if (SpendCurrencies(cost))
        {
            return EarnCurrencies(material);
        }
        return false;
        //return GeneralBalance.BuyMaterial(cost, useGem, material);
    }

    public bool BuyMaterials(Currency cost, bool useGem, Currencies materials)
    {
        if (SpendCurrencies(cost))
        {
            return EarnCurrencies(materials);
        }
        return false;
    }
    public bool EarnCurrencies(Currency currency)
    {
        TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name)};
        return TradeManager.Instance.Add(tradeInfoCost, null);
    }
    public bool EarnCurrencies(Currencies currencies)
    {
        List<TradeInfo> tradeInfos = new List<TradeInfo>();
        for(int i=0; i<currencies.KeyCount;i++)
        {
            var currency = currencies.GetCurrency(i);
            
            TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name) };
            tradeInfos.Add(tradeInfoCost);
        }
        return TradeManager.Instance.Add(tradeInfos, null);
    }
    public bool SpendCurrencies(Currency currency)
    {
        TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name) };
        return TradeManager.Instance.Remove(tradeInfoCost, null);
    }
    public bool SpendCurrencies(Currencies currencies)
    {
        List<TradeInfo> tradeInfos = new List<TradeInfo>();
        for (int i = 0; i < currencies.KeyCount; i++)
        {
            var currency = currencies.GetCurrency(i);
            TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name) };
            tradeInfos.Add(tradeInfoCost);
        }
        return TradeManager.Instance.Remove(tradeInfos, null);
    }
    
    
    public IslandFarmProperties GetIslandFarmProperties()
    {
        //return farmIslandBootstrapper.GetIslandFarmProperties();
        if (IsLandInfo == null) return null;
        return IsLandInfo.IslandFarmProperties;
    }
    public TimeKeeper GetTimeKeeper()
    {
        //if (farmIslandBootstrapper == null) return null;
        //var farmIsLandData = farmIslandBootstrapper.GetFarmIsLandData();
        //if (farmIsLandData == null || farmIsLandData.GameData == null || farmIsLandData.GameData.Time == null) return null;
        //var value = farmIsLandData.GameData.Time;
        return TimeKeeper;
    }
    public int GetLevelPlayer()
    {
        return levelPlayer;
    }
    public void UpLevelPlayer()
    {
        levelPlayer += 1;
        actionLevelChange?.Invoke();
        Debug.Log("============> LevelChange " + levelPlayer);
    }
    public void DownLevelPlayer()
    {
        if (levelPlayer < 1) return;
        levelPlayer -= 1;
        actionLevelChange?.Invoke();
        Debug.Log("============> LevelChange " + levelPlayer);
    }

}
