using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeProperties : BuildingProperties
{
    private const string LevelsKey = "levels";
    private List<string> _levelKeys;

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
            if (value < _levelKeys.Count)
            {
                //LẤY PROPPETIES CHO CURRENT LEVEL HIỆN TẠI
                CurrentLevelProperties =
                    new BuildingLevelProperties((PropertiesDictionary)_propsDict, _levelKeys[value]);
            }
            else
            {
                CurrentLevelProperties = null;
            }
            

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

    public BuildingLevelProperties CurrentLevelProperties { get; private set; }
    public BuildingLevelProperties NextLevelProperties { get; private set; }

    public UpgradeProperties(PropertiesDictionary propsDict, string key, int level)
        : base(propsDict, key)
    {
        //GET LIST KEY CHO LEVEL TRONG PROPETIES LÀ LEVELS NÓ LÀ 1 MẢNG STRING
        _levelKeys = GetProperty("levels", new List<string>());
        Level = level;
    }
    public Currencies GetCurrentRewardBuildComplete()
    {
        return CurrentLevelProperties == null ? null : CurrentLevelProperties.rewardBuildCompleted;
    }
    public int GetMaxLevel()
    {
        return _levelKeys == null ? 0 : _levelKeys.Count - 1;
    }
}
