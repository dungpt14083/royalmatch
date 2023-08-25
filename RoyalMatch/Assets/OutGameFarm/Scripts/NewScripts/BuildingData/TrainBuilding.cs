using System;
using System.Collections.Generic;
using System.Linq;

public class TrainBuilding : UpgradeHouse
{
    public DateTime timeReset;
    public UpspeedableProcess resetProcess;
    public Action actionReset;
    public TrainBuilding(TrainProperties _BuildingProperties,Building building) : base(_BuildingProperties,building)
    {
        if (Level < 1) return;
        StartProcess();
    }
    public TrainBuilding(StorageDictionary storage) : base(storage)
    {
    }

    public bool RemoveQuest(string questName)
    {
        var trainProperties = (TrainProperties)BuildingProperties;
        Currency quest = trainProperties.quests.GetCurrency(questName);
        if (trainProperties == null) return false;
        if (trainProperties.quests == null) return false;
        if (trainProperties.questsCompleted.Contains(quest.Name)) return false;
        trainProperties.questsDeleted.Add(quest.Name);
        return true;
    }
    public bool Give(string questName)
    {
        var trainProperties = (TrainProperties)BuildingProperties;
        Currency quest = trainProperties.quests.GetCurrency(questName);
        if (trainProperties == null) return false;
        if (trainProperties.quests == null) return false;
        if (trainProperties.questsDeleted.Contains(quest.Name)) return false;
        trainProperties.questsCompleted.Add(quest.Name);
        var rewards = trainProperties.rewards;
        for(int i=0; i< rewards.KeyCount; i++)
        {
            var reward = rewards.GetCurrency(i);
            if (reward.Amount > trainProperties.questsCompleted.Count) continue;
            if (trainProperties.receivedRewards.Contains(reward.Name)) continue;
            var rewardToEarn = FarmMapController.Instance.GetRewardPropertiesBykey(reward.Name);
            if (FarmMapController.Instance.EarnCurrencies(rewardToEarn.rewards))
            {
                trainProperties.receivedRewards.Add(reward.Name);
            }
        }
        return true;
    }
    public void ResetData()
    {
        var trainProperties = (TrainProperties)BuildingProperties;
        trainProperties.receivedRewards.Clear();
        trainProperties.questsDeleted.Clear();
        trainProperties.questsCompleted.Clear();
        timeReset = DateTime.Now.AddSeconds(30);
        resetProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(), FarmMapController.Instance.GetTimeKeeper(), (timeReset - DateTime.Now).TotalSeconds,
                    1.0,
                    1f, ResetData, FarmMapController.Instance.GetGeneralProperties());
        actionReset?.Invoke();
    }
    public void StartProcess()
    {
        timeReset = DateTime.Now.AddSeconds(30);
        resetProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(), FarmMapController.Instance.GetTimeKeeper(), (timeReset - DateTime.Now).TotalSeconds,
                    1.0,
                    1f, ResetData, FarmMapController.Instance.GetGeneralProperties());
    }
    protected override void LevelUp()
    {
        base.LevelUp();
        if (GetLevel() == 1) StartProcess();
    }
}
