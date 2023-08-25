using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TRONG NÀY CHỈ QUAN TÂM TỚI CUTSCENE REQUIREMENT ĐỂ KHI NÀO KÍCH HOẠT:::
[Serializable]
[CreateAssetMenu(fileName = "CutsceneInfoCollection", menuName = "Scriptable Objects/CutsceneInfoCollection")]
public class CutsceneInfoCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public List<CutSceneInfo> Cutscenes;
    private Dictionary<int, CutSceneInfo> _cache;


    public CutSceneInfo Get(int id)
    {
        if(_cache != null)
        {
            return _cache[id];
        }
        
        return null;
    }


    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<int, CutSceneInfo>();
        for (int i = 0; i < Cutscenes.Count; i++)
        {
            if (!_cache.ContainsKey(Cutscenes[i].Id))
            {
                _cache.Add(Cutscenes[i].Id, Cutscenes[i]);
            }
        }
    }

    public void OnBeforeSerialize()
    {
    }
}