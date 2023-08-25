
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class RaceScript
{
    public Sprite borderAvatar;
    public Sprite iconAvatar;
    public Sprite borderName;
    public string namePlayer;
    public int currentProgress;
    private int _maxProgress = 30;
    public Sprite sprReward;
    public Sprite sprRewardDetail;
    public string descDetail;
    public int reward;

    public int GetMaxProgress()
    {
        return _maxProgress;
    }
}
