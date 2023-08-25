using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuestInfo
{
    //CÁC THÔNG SỐ CHO CONFIG QUEST NHƯ ID,ICON ID, NAME
    public int id;
    public int IconId;

    public string Name;

    //YÊU CẦU KÍCH HOẠT YEEU CẦU ĐỂ HOÀN THÀNH:::VÀ TASKINFFO
    public List<RequirementInfo> Requirements;
    public List<RequirementInfo> FinishRequirements;

    public List<TradeInfo> Rewards;
    public List<TaskInfo> Tasks;


    //LẤY SỐ LƯỢNG THƯỞNG LÀ XP
    public int GetXpRewardAmount()
    {
        for (int i = 0; i < Rewards.Count; i++)
        {
            //Lấy tradetype là id là đc?
        }

        return 0;
    }



    //CHECK XEM THỬ CÓ REWARD L CUTSCENE HAY K ĐỂ KÍCH HOẠT NÓ:::
    public bool HasCutsceneReward()
    {
        for (int i = 0; i < Rewards.Count; i++)
        {
            if (Rewards[i].TradeType == TradeType.Cutscene)
            {
                return true;
            }
        }

        return false;
    }
}