using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyQuestEventManager
{
  private static DailyQuestEventManager instance;
  public DailyMissionPopup _dailyMissionPopup;
  private GeneralBalance _generalBalance;

  public static DailyQuestEventManager Instance
  {
    get
    {
      if(instance == null)
      {
        instance = new DailyQuestEventManager();
      }

      return instance;
    }
  }
  public event Action<int> OnDailyQuestUpdate;
  public void RaiseDailyQuestUpdate(int amount)
  {
    OnDailyQuestUpdate?.Invoke(amount);
  }
}
