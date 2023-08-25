using System;
using System.Collections.Generic;
using System.Linq;

public class AirplaneBuilding : UpgradeHouse
{
    public DateTime timeReset;
    public UpspeedableProcess resetProcess;
    public Action updateData;
    public Dictionary<int, UpspeedableProcess> listSkipProcess = new Dictionary<int, UpspeedableProcess>();

    public AirplaneBuilding(AirplaneProperties _BuildingProperties, Building building) : base(_BuildingProperties,
        building)
    {
        if (Level < 1) return;
        StartProcess();
    }

    public AirplaneBuilding(StorageDictionary storage) : base(storage)
    {
    }

    public bool Remove(int index)
    {
        var airplaneProperties = BuildingProperties as AirplaneProperties;
        if (!airplaneProperties.airplaneQuestsActived.ContainsKey(index)) return false;
        var airplaneQuestProperties = airplaneProperties.airplaneQuestsActived[index];
        if (airplaneQuestProperties == null) return false;
        if (airplaneQuestProperties.Remove())
        {
            listSkipProcess[index] = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                FarmMapController.Instance.GetTimeKeeper(), airplaneQuestProperties.timeRemove,
                1.0,
                1f, () => { GenNewQuest(index); }, FarmMapController.Instance.GetGeneralProperties());
            UnityEngine.Debug.Log("-----------------AirplaneBuilding Remove----------------");

            updateData?.Invoke();
            return true;
        }

        return false;
    }

    public void GenNewQuest(int index)
    {
        var airplaneProperties = BuildingProperties as AirplaneProperties;
        var airplaneQuestProperties = airplaneProperties.airplaneQuestsActived[index];
        listSkipProcess[index].CancelAction();
        listSkipProcess.Remove(index);

        airplaneProperties.airplaneQuestsActived.Remove(index);
        airplaneProperties.quests.Remove(airplaneQuestProperties.BaseKey);
        airplaneProperties.airplaneQuests.Remove(airplaneQuestProperties.BaseKey);
        var questActived = airplaneProperties.airplaneQuestsActived.Select(x => x.Value.BaseKey).ToList();
        airplaneProperties.airplaneQuestsActived[index] = airplaneProperties.airplaneQuests
            .FirstOrDefault(x => !questActived.Contains(x.Key)).Value;
        updateData?.Invoke();
    }

    public bool Delivery(AirplaneQuestProperties airplaneQuestProperties)
    {
        if (airplaneQuestProperties.Delivery())
        {
            var airplaneProperties = BuildingProperties as AirplaneProperties;
            airplaneProperties.countQuestCompleted += 1;
            airplaneProperties.quests.Remove(airplaneQuestProperties.BaseKey);
            airplaneProperties.airplaneQuests.Remove(airplaneQuestProperties.BaseKey);
            UnityEngine.Debug.Log("-----------------AirplaneBuilding Delivery Success----------------");
            updateData?.Invoke();
        }
        else
        {
            UnityEngine.Debug.Log("-----------------AirplaneBuilding Delivery Fail----------------");
        }

        return true;
    }

    public bool Skip(int index)
    {
        var airplaneProperties = BuildingProperties as AirplaneProperties;
        var airplaneQuestProperties = airplaneProperties.airplaneQuestsActived[index];
        if (airplaneQuestProperties == null) return false;
        if (FarmMapController.Instance.SpendCurrencies(airplaneQuestProperties.skipTime))
        {
            GenNewQuest(index);
            return true;
        }

        return false;
    }

    public bool RevecieReward()
    {
        var airplaneProperties = BuildingProperties as AirplaneProperties;
        if (airplaneProperties == null) return false;
        if (airplaneProperties.rewards == null) return false;
        if (airplaneProperties.countQuestCompleted < airplaneProperties.countQuestCompletedToReward) return false;
        if (airplaneProperties.isRevecedReward) return false;
        FarmMapController.Instance.EarnCurrencies(airplaneProperties.rewards);
        airplaneProperties.isRevecedReward = true;
        return true;
    }

    public void ResetData()
    {
        foreach(var process in listSkipProcess)
        {
            process.Value.CancelAction();
        }
        listSkipProcess.Clear();

        var airplaneProperties = (AirplaneProperties)BuildingProperties;
        airplaneProperties.isRevecedReward = false;
        airplaneProperties.quests.Clear();
        airplaneProperties.quests.AddRange(airplaneProperties.allQuests);
        airplaneProperties.countQuestCompleted = 0;
        airplaneProperties.ResetAirplaneQuests();
        timeReset = DateTime.Now.AddSeconds(1000);
        resetProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
            FarmMapController.Instance.GetTimeKeeper(), (timeReset - DateTime.Now).TotalSeconds,
            1.0,
            1f, ResetData, FarmMapController.Instance.GetGeneralProperties());
        UnityEngine.Debug.Log("-----------------AirplaneBuilding ResetData----------------");
        updateData?.Invoke();
    }

    public void StartProcess()
    {
        foreach (var quest in (BuildingProperties as AirplaneProperties).airplaneQuestsActived)
        {
            if (quest.Value.statusRemoved)
            {
                listSkipProcess[quest.Key] = new UpspeedableProcess(
                    FarmMapController.Instance.GetIslandFarmProperties(), FarmMapController.Instance.GetTimeKeeper(),
                    quest.Value.timeRemove,
                    1.0,
                    1f, () => { GenNewQuest(quest.Key); }, FarmMapController.Instance.GetGeneralProperties());
            }
        }

        timeReset = DateTime.Now.AddSeconds(1000);
        resetProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
            FarmMapController.Instance.GetTimeKeeper(), (timeReset - DateTime.Now).TotalSeconds,
            1.0,
            1f, ResetData, FarmMapController.Instance.GetGeneralProperties());
    }

    protected override void LevelUp()
    {
        base.LevelUp();
        if (GetLevel() == 1) StartProcess();
    }
}