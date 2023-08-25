using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//LƯU GIỮ DATA CHO VIỆC MỞ RỘNG LƯU KHẢ NWANG MỞ RỘNG SAU NÀY
//SẼ CÓ RẨ NHIỀU KẾ THỪA TỪ NÀY HOẶC KHÁC ĐI HCO KHÁC CHỨC NĂNG
public class BuildingLevelProperties : EntityProperties
{
    private const string StorageKey = "storage";
    private const string BuildingMaterialsKey = "buildingMaterials";
    private const string CoinCostKey = "coinCost";
    private const string GemCostKey = "gemCost";
    private const string unlockWaitingProduceKey = "unlockWaitingProduce";
    private const string timeBuildingKey = "timeBuilding";
    private const string rewardBuildCompletedKey = "rewardBuildCompleted";
    private const string levelPlayerRequireKey = "levelPlayerRequire";
    private const string upSpeedProduceKey = "upSpeedProduce";
    private const string upSpeedBuildingKey = "upSpeedBuilding";
    private const string timeProduceKey = "timeProduce";
    private const string numberProduceKey = "numberProduce";
    private const string maxProduceKey = "maxProduce";
    private const string requirements = "requirements";

    
    //REQUIREMENT CHO THẰNG LEVEL NÀY::::là REQUIREMENT HIỆN TẠI
    //CHỈ XÉT CHO RUIN TỪ LEVEL 0 LÊN 1 LÀ CÁI 1 CÒN CÁC CÁI SAU K CẦN XÀI REQUIREMENT:::
    public List<RequirementInfo> requirementsForUpdate { get; private set; }


    //KHẢ NĂNG CAPACITY::
    public long MaxCapacity { get; private set; }

    //GIẢ CHO VIỆC UPDATE BẰNG MATERIAL
    public Currencies BuildingMaterials { get; private set; }
    public Currency CoinCost { get; private set; }
    public Currency GemCost { get; private set; }
    public List<int> unlockWaitingProduce { get; private set; }
    public int timeBuilding { get; private set; }
    public Currencies rewardBuildCompleted { get; private set; }
    public int levelPlayerRequire { get; private set; }
    public int upSpeedProduce { get; private set; }
    public Currency upSpeedBuilding { get; private set; }

    public int timeProduce { get; private set; }
    public int numberProduce { get; private set; }
    public int maxProduce { get; private set; }

    public BuildingLevelProperties(PropertiesDictionary propDict, string key)
        : base(propDict, key)
    {
        MaxCapacity = GetProperty("storage", 0L);
        Currencies result;
        if (Currencies.TryParse(GetProperty("buildingMaterials", string.Empty), out result))
        {
            BuildingMaterials = result;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, "buildingMaterials");
        }
        
        CoinCost = new Currency(CurrencyType.golds, GetProperty("coinCost", 0L, true));
        long amount = (long)((float)GetProperty("gemCost", 0L));
        GemCost = new Currency(CurrencyType.gems, amount);

        unlockWaitingProduce = GetProperty(unlockWaitingProduceKey, new List<int>());
        timeBuilding = GetProperty(timeBuildingKey, 0);
        Currencies resultRewardBuildCompleted;
        if (Currencies.TryParse(GetProperty(rewardBuildCompletedKey, string.Empty), out resultRewardBuildCompleted))
        {
            rewardBuildCompleted = resultRewardBuildCompleted;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, unlockWaitingProduceKey);
        }
        levelPlayerRequire = GetProperty(levelPlayerRequireKey, 0);
        timeProduce = GetProperty(timeProduceKey, 0);
        numberProduce = GetProperty(numberProduceKey, 0);
        maxProduce = GetProperty(maxProduceKey, 0);
        //upSpeedProduce = GetProperty(upSpeedProduceKey, 0);
        if(Currency.TryParse(GetProperty(upSpeedBuildingKey, string.Empty),out var resultUpSpeedBuilding))
        {
            upSpeedBuilding = resultUpSpeedBuilding;
        }
        
        requirementsForUpdate =
            TradeExtensions.ParseRequirementInfoList(GetProperty("requirements", ""));
    }
}