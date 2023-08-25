using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class QuestBase : MonoBehaviour
{
    public List<string> caseWin;
    public List<string> caseLose;
    public List<KeyColor> keyColors;
    public StatusQuest statusQuest = StatusQuest.Playing;
    public string steps = "";
    public Action actionWinLose;

    public void CheckTarget(List<Item> items)
    {
        if (statusQuest != StatusQuest.Playing) return;
        if (items == null) return;
        //Todo : lam sau
        //foreach(var item in items)
        //{
        //    var key = keyColors.Find(x => x.color == item.color);
        //    if (key == null) continue;
        //    if (!key.isOpened)
        //    {
        //        key.AddColor();
        //        if (key.isOpened)
        //        {
        //            steps += key.color.ToString();
        //            if (caseWin.Contains(steps))
        //            {
        //                statusQuest = StatusQuest.Win;
        //            }
        //            else if(caseLose.Contains(steps))
        //            {
        //                statusQuest = StatusQuest.Lose;
        //            }

        //            if(statusQuest == StatusQuest.Win || statusQuest == StatusQuest.Lose)
        //            {
        //                Debug.Log("QuestWinlose");
        //            }
        //        }
        //    }
        //}
        
    }
}

public enum StatusQuest
{
    None, Playing,Win,Lose
}