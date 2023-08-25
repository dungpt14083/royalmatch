public class ItemBonusProperties : BuildingProperties
{
    private const string costCollectKey = "cost";
    private const string rewardsKey = "rewards";
    private const string gatherableCategoryKey = "gatherableCategory";
    

    public Currencies costCollect { get; private set; }
    public Currencies rewards { get; private set; }
    public GatherableCategory GatherableCategory { get; private set; }

    public ItemBonusProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        Currencies resultCostCollect;
        if (Currencies.TryParse(GetProperty(costCollectKey, string.Empty, true), out resultCostCollect))
        {
            costCollect = resultCostCollect;
        }
        Currencies resultRewards;
        if (Currencies.TryParse(GetProperty(rewardsKey, string.Empty, true), out resultRewards))
        {
            rewards = resultRewards;
        }
        var tmp = GetProperty(gatherableCategoryKey, 0, true);
        GatherableCategory = (GatherableCategory)tmp;
    }
}
