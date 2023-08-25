using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DailyQuest
{
    public TypeDailyMission TypeDailyMission;
    public string NameQuest;
    public Sprite SpriteQuest;
    public QuestGoal QuestGoal;
    public RewardDailyQuest RewardDailyQuest;
    public bool isCompleted;
    public bool isclaim;
}

[Serializable]
public class QuestGoal
{
    public string unit;
    public int CurrentAmount;
    public int RequiredAmount;

    public bool IsReached()
    {
       return CurrentAmount >= RequiredAmount;
    }
}

[Serializable]
public class RewardDailyQuest
{
    public RewardDailyQuestType Unit;
    public Sprite SpriteReward;
    public int Reward;
}

public enum TypeDailyMission
{
    GatherItemsAtFarm,
    MakeItemsInTheA,
    CollectXFruits,
    GatherSpecialItems,
    CookItemsInTheKitchen,
    FeedTheAnimals,
    Puzzle
}

public enum RewardDailyQuestType
{
    Gems,
    Coins,
    Energy
}