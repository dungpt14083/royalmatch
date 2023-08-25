using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class EventCollect
{
   public int id;
   //vip
   public Sprite IconRewardVip;
   public int countVip;
   public bool UnlockVip;
   //free
   public Sprite IconRewardFree;
   public int countFree;
   public StatusEventCollect statusReward;
}

public enum StatusEventCollect
{
   Rewarded,
   CanRewardWatched,
   CanReward,
   NotCanReward
}