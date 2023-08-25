using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneProperties : UpgradeProperties
{
    private const string rewardsKey = "rewards";
    private const string questsKey = "quests";
    private const string questsActivedKey = "questsActived";
    private const string allQuestsKey = "allQuests";
    private const string countQuestCompletedToRewardKey = "countQuestCompletedToReward";
    private const string countQuestCompletedKey = "countQuestCompleted";
    private const string isRevecedRewardKey = "isRevecedReward";
    public Currencies rewards;
    public List<string> quests;
    public Currencies questsActived;
    public List<string> allQuests;
    public int countQuestCompletedToReward;
    public int countQuestCompleted;
    public bool isRevecedReward;

    public Dictionary<string,AirplaneQuestProperties> airplaneQuests;
    public Dictionary<int,AirplaneQuestProperties> airplaneQuestsActived;

    public AirplaneProperties(PropertiesDictionary propsDict, string key, int level)
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

        quests = GetProperty(questsKey, new List<string>());

        Currencies resultQuestsActived;
        if (Currencies.TryParse(GetProperty(questsActivedKey, string.Empty, true), out resultQuestsActived))
        {
            questsActived = resultQuestsActived;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, questsActivedKey);
        }
        allQuests = GetProperty(allQuestsKey, new List<string>());
        
        countQuestCompletedToReward = GetProperty(countQuestCompletedToRewardKey, 10);
        countQuestCompleted = GetProperty(countQuestCompletedKey, 0);
        isRevecedReward = GetProperty(isRevecedRewardKey, false);
        ResetAirplaneQuests();
    }

    public void ResetAirplaneQuests()
    {
        airplaneQuests = new Dictionary<string, AirplaneQuestProperties>();
        foreach (var quest in quests)
        {
            var questProperties = new AirplaneQuestProperties((PropertiesDictionary)_propsDict, quest);
            airplaneQuests.Add(quest, questProperties);
        }
        airplaneQuestsActived = new Dictionary<int, AirplaneQuestProperties>();
        for (int i = 0; i < questsActived.KeyCount; i++)
        {
            var questActived = questsActived.GetCurrency(i);
            if (airplaneQuests.ContainsKey(questActived.Name))
            {
                airplaneQuestsActived.Add((int)questActived.Amount, airplaneQuests[questActived.Name]);
            }
            else
            {
                airplaneQuestsActived.Add((int)questActived.Amount, null);
            }
        }
    }
}
