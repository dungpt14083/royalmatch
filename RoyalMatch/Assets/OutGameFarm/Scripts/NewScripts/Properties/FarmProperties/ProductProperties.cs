using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductProperties : EntityCurrencyProperties
{
    //time trửng thành của cây coois cũng như product cần để tạo ra::
    private const string ProductionTimeSecondsKey = "productionTimeSeconds";
    private const string ChainProductionTimeSecondsKey = "chainProductionTimeSeconds";
    private const string CostKey = "cost";
    private const string materialsKey = "materials";
    private const string rewardsKey = "rewards";
    private const string levelPlayerRequireKey = "levelPlayerRequire";
    private const string energyForDinnerTableKey = "EnergyForDinnerTable";
    private const string timeToConsumeInDinnerTableKey = "TimeToConsumeInDinnerTable";
   

    public Currencies Cost { get; private set; }
    public Currencies materials { get; private set; }
    public Currencies rewards { get; private set; }
    public int levelPlayerRequire { get; private set; }
    public int energyForDinnerTable { get; private set; }
    public int timeToConsumeInDinnerTable { get; private set; }
    

    public float ProductionTimeSeconds { get; private set; }

    public ProductProperties(PropertiesDictionary propsDict, string baseKey)
        : base(propsDict, baseKey)
    {
        ProductionTimeSeconds = GetProperty("productionTimeSeconds", float.MaxValue);
        Currencies result;
        if (Currencies.TryParse(GetProperty("cost", string.Empty), out result))
        {
            Cost = result;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.cost'", baseKey);
        }

        Currencies resultMaterials;
        if (Currencies.TryParse(GetProperty(materialsKey, string.Empty), out resultMaterials))
        {
            materials = resultMaterials;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.Materials'", baseKey);
        }
        Currencies resultRewards;
        if (Currencies.TryParse(GetProperty(rewardsKey, string.Empty), out resultRewards))
        {
            rewards = resultRewards;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.rewards'", baseKey);
        }
        levelPlayerRequire = GetProperty(levelPlayerRequireKey, 0);
        energyForDinnerTable = GetProperty(energyForDinnerTableKey, 0);
        timeToConsumeInDinnerTable = GetProperty(timeToConsumeInDinnerTableKey, 0);
    }
    public void SetProductionTimeSeconds(float time)
    {
        ProductionTimeSeconds = time;
    }
    public float GetProductionTimeSecondsByLevelBuilding(int levelBuilding)
    {
        return ProductionTimeSeconds * (1 - 0.1f * (levelBuilding-1));

    }
  
}