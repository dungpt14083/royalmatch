using System.Collections.Generic;
using System.Diagnostics;
using Malee;
using UnityEngine;
using UnityEngine.Serialization;

namespace JellyGarden.Scripts.Targets
{
    [CreateAssetMenu(fileName = "TargetLevel", menuName = "TargetLevel", order = 1)]
    public class TargetLevel : ScriptableObject
    {
        //[Reorderable]
        //public TargetList targets;
        public List<TargetInfo> targets;
    }
    
    //[System.Serializable]
    //public class TargetList : ReorderableArray<TargetInfo> {
    //}

    //[System.Serializable]
    //public class TargetObject
    //{
    //    public Target type;
    //    public Sprite icon;
    //    public int color;
    //    [FormerlySerializedAs("count")]public int targetCount;
    //    [HideInInspector] public int countCollected;
    //    [HideInInspector] public TargetIcon guiObj;

    //    public TargetObject DeepCopy()
    //    {
    //        TargetObject other = (TargetObject) MemberwiseClone();
    //        return other;
    //    }

    //    public bool Done() => GetCount() <= 0;
    //    public int GetCount() => targetCount - countCollected;

    //    public bool SetOff(GameObject item, int c = 1)
    //    {
    //        if (type == Target.COLLECT)
    //        {
    //            //Todo : lam sau
    //            //if(item.GetComponent<Item>()?.color == color)
    //            //{
    //            //    countCollected+=c;
    //            //    return true;
    //            //}
    //        }
    //        return false;
    //    }
    //}
}