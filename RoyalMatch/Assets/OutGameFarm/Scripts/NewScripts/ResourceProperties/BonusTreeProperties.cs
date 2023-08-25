using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTreeProperties : BuildingProperties
{
    //string keys
    private const string rewardsKey = "rewards";
    //end
    public int MaxHarvests;
    public float HarvestCooldown;
    public float TimeToFirstHarvest;
    public GatherableCategory GatherableCategory { get; private set; }
    public Currency DestroyCost { get; private set; }
    public Currencies DestroyReward { get; private set; }
    public Currencies rewards { get; private set; }

    public BonusTreeProperties(PropertiesDictionary propsDict, string key) : base(propsDict, key)
    {
        Currencies resultCurrencies;
        MaxHarvests = GetProperty("maxHarvests", 1,true);
        HarvestCooldown = GetProperty("harvestCooldown", 1f, true);
        TimeToFirstHarvest = GetProperty("timeToFirstHarvest", 1f, true);
        
        Currencies resultRewards;
        if (Currencies.TryParse(GetProperty(rewardsKey, string.Empty), out resultRewards))
        {
            rewards = resultRewards;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.rewards'", key);
        }
        
        if (Currencies.TryParse(GetProperty("destroyRewards", string.Empty, true), out resultCurrencies))
        {
            DestroyReward = resultCurrencies;
        }

        Currency resultCurrency;
        if (Currency.TryParse(GetProperty("destroyCost", string.Empty, true), out resultCurrency))
        {
            DestroyCost = resultCurrency;
        }

        var tmp = GetProperty("gatherableCategory", 0, true);
        GatherableCategory = (GatherableCategory)tmp;
    }
}
