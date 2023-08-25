using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Propeties cho mặc định:::
public class GatherableProperties : BuildingProperties
{
    //CHO KIỂU ANIMATION THỰC HIỆN HÀNH ĐỘNG
    public GatherableCategory GatherableCategory { get; private set; }

    public int EnergyCost;

    //REWARD KHI MÀ PHÁ ĐÁ XONG::::
    public System.Collections.Generic.List<TradeInfo> DestroyRewards { get; private set; }

    public GatherableProperties(PropertiesFile propsDict, string key)
        : base(propsDict, key)
    {
        DestroyRewards = TradeExtensions.ParseTradeInfoList(GetProperty("destroyRewards", string.Empty, true));
        EnergyCost = GetProperty("destroyCost", 0);
        var tmp = GetProperty("gatherableCategory", 0, true);
        GatherableCategory = (GatherableCategory)tmp;
    }
}