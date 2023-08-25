using UnityEngine;

public class RewardProperties: EntityProperties
{
    private const string rewardsKey = "rewards";
    public Currencies rewards;
    public RewardProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        Currencies resultRewards;
        if (Currencies.TryParse(GetProperty(rewardsKey, string.Empty, true), out resultRewards))
        {
            rewards = resultRewards;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, rewardsKey);
        }
    }
}
