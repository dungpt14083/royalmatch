using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarehouseBuildingProperties : UpgradeProperties
{
    private const string LevelsKey = "levels";
    private List<string> _levelKeys;
    private const string productsKey = "products";
    private const string rewardBuildCompletedKey = "rewardBuildCompleted";
    private List<string> listProductsKey;

    //KHI SET THÌ SẼ SET CHO CURRENT LEVEL VÀ NEXT LEVEL PROPETIES::
    //CÁC THÔNG SỐ NHƯ KHẢ NĂNG LƯU GIŨ GIÁ NÂNG CẤP YÊU CẦU VẬT LIỆU NÂNG CẤP:::
    public int Level
    {
        set
        {
            if (value < 0 || value > _levelKeys.Count)
            {
                throw new ArgumentOutOfRangeException("level",
                    string.Format("WarehouseProperties of '{0}' at Level '{1}' is out of bounds.", base.BuildingName,
                        value));
            }

            //LẤY PROPPETIES CHO CURRENT LEVEL HIỆN TẠI
            CurrentLevelProperties =
                new BuildingLevelProperties((PropertiesDictionary)_propsDict, _levelKeys[value]);

            //NEXT LEVEL NẾU CÓ THÌ SET K THÌ THÔI 
            if (value + 1 < _levelKeys.Count)
            {
                NextLevelProperties = new BuildingLevelProperties((PropertiesDictionary)_propsDict, _levelKeys[value + 1]);
            }
            else
            {
                NextLevelProperties = null;
            }
        }
        
    }

    public int LevelWareHouse;
    public long MaxCapacity;
    public BuildingLevelProperties CurrentLevelProperties { get; private set; }
    public BuildingLevelProperties NextLevelProperties { get; private set; }

    public Currencies rewardBuildCompleted { get; private set; }

    
    public WarehouseBuildingProperties(PropertiesDictionary propsDict, string key, int level)
        : base(propsDict, key,level)
    {
        //GET LIST KEY CHO LEVEL TRONG PROPETIES LÀ LEVELS NÓ LÀ 1 MẢNG STRING
        _levelKeys = GetProperty("levels", new List<string>());
        Level = level;
        listProductsKey = GetProperty(productsKey, new List<string>());
        LevelWareHouse = GetProperty("level", 0);
        MaxCapacity = GetProperty("storage", 75L);
        Currencies resultRewardBuildCompleted;
        if (Currencies.TryParse(GetProperty(rewardBuildCompletedKey, string.Empty), out resultRewardBuildCompleted))
        {
            rewardBuildCompleted = resultRewardBuildCompleted;
        }
        else
        {
            
        }

    }
    public List<string> GetProductsKey()
    {
        return listProductsKey == null ? new List<string>() : listProductsKey;
    }
    //public Currencies GetCurrentRewardBuildComplete()
    //{
    //    return CurrentLevelProperties == null ? null : CurrentLevelProperties.rewardBuildCompleted;
    //}
    //public List<int> GetUnlockWaitingProduce()
    //{
    //    return CurrentLevelProperties == null ? new List<int>() : CurrentLevelProperties.unlockWaitingProduce;
    //}
}