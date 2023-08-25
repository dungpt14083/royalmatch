public class ItemBonusRepeatProperties : ItemBonusProperties
{
    private const string timeResetKey = "timeReset";
    public long timeReset { get; private set; }
    public ItemBonusRepeatProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        timeReset = GetProperty(timeResetKey, 0);
    }
}
