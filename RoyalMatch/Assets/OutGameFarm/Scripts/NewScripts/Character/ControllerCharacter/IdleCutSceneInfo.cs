using System;
using System.Collections.Generic;
using UnityEngine;

//IDLE CUTSCENE INFO CHỈ CÓ PRIORITY KHÔNG CHỨA GÌ CẢ:::DATABASE LOCAL
[Serializable]
public class IdleCutsceneInfo
{
    public string Name;

    public int UnityId;

    public int CutsceneUnityId;

    public List<IdleConditionInfo> Conditions;

    public List<RequirementInfo> Requirements;

    public int Weight;

    public int Priority;

    public IdleCutsceneInfo(int priority)
    {
        this.Priority = priority;
    }
}