public class ItemBonusChangeStageProperties : ItemBonusProperties
{
    private const string nextStageKey = "nextStage";
    public string nextStage { get; private set; }
    
    public ItemBonusChangeStageProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        nextStage = GetProperty(nextStageKey, string.Empty);
    }
}
