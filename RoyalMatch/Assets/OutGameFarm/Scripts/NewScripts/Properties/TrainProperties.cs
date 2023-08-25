using System;
using System.Collections.Generic;
using UnityEngine;

public class TrainProperties : UpgradeProperties
{
    private const string rewardsKey = "rewards";
    private const string receivedRewardsKey = "receivedRewards";
    private const string questsKey = "quests";
    private const string questsCompletedKey = "questsCompleted";
    private const string questsDeletedKey = "questsDeleted";
    public Currencies rewards;
    public List<string> receivedRewards;
    public Currencies quests;
    public List<string> questsCompleted;
    public List<string> questsDeleted;
    public TrainProperties(PropertiesDictionary propsDict, string key,int level)
        : base(propsDict, key, level)
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

        receivedRewards = GetProperty(receivedRewardsKey, new List<string>());
        Currencies resultQuests;
        if (Currencies.TryParse(GetProperty(questsKey, string.Empty, true), out resultQuests))
        {
            quests = resultQuests;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, questsKey);
        }

        questsCompleted = GetProperty(questsCompletedKey, new List<string>());
        questsDeleted = GetProperty(questsDeletedKey, new List<string>());
    }
}
