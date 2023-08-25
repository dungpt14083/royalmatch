using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class RewardDailyReward
{
  public List<RewardType> type;
  public int reward;
  public Sprite Sprite;
}
public enum RewardType
{
  Gems,
  Coins,
  Energy
}