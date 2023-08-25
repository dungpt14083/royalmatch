using UnityEngine;

public class AirplaneQuestProperties : EntityProperties
{
    private const string questsKey = "quests";
    private const string goldRewardKey = "goldReward";
    private const string xpRewardKey = "xpReward";
    private const string timeRemoveKey = "timeRemove";
    private const string skipTimeKey = "skipTime";
    private const string statusRemovedKey = "statusRemoved";
    public Currencies quests;
    public long goldReward;
    public long xpReward;
    public long timeRemove;//tính bằng giây
    public Currency skipTime;
    public bool statusRemoved;
    public AirplaneQuestProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        Currencies resultquest;
        if (Currencies.TryParse(GetProperty(questsKey, string.Empty, true), out resultquest))
        {
            quests = resultquest;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, questsKey);
        }
        goldReward = GetProperty(goldRewardKey, 0, true);
        xpReward = GetProperty(xpRewardKey, 0, true);
        timeRemove = GetProperty(timeRemoveKey, 0, true);

        Currency resultSkipTime;
        if (Currency.TryParse(GetProperty(skipTimeKey, string.Empty, true), out resultSkipTime))
        {
            skipTime = resultSkipTime;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, skipTimeKey);
        }
        statusRemoved = GetProperty(statusRemovedKey, false, true);
    }
    public bool Remove()
    {
        statusRemoved = true;
        return true;
    }
    public bool Skip()
    {
        statusRemoved = true;
        return true;
    }
    public bool Delivery()
    {
        if (statusRemoved) return false;
        if (!IsDelivery()) return false;
        //trừ trong đống đồ
        for (int i = 0; i < quests.KeyCount; i++)
        {
            var quest = quests.GetCurrency(i);
            FarmMapController.Instance.EarnCurrencies(new Currency(quest.Name, -quest.Amount));
        }

        //nhận thưởng
        FarmMapController.Instance.EarnCurrencies(new Currency(CurrencyType.golds, goldReward));
        FarmMapController.Instance.EarnCurrencies(new Currency(CurrencyType.xp, xpReward));
        return true;
    }
    public bool IsDelivery()
    {
        for (int i = 0; i < quests.KeyCount; i++)
        {
            var quest = quests.GetCurrency(i);
            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(quest.Name);
            if (currentCountMerterial < quest.Amount) return false;
        }
        return true;
    }
}
