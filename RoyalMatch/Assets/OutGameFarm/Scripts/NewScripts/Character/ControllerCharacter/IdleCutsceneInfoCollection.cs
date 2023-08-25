using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "IdleCutsceneInfoCollection", menuName = "Scriptable Objects/IdleCutsceneInfoCollection")]
public class IdleCutsceneInfoCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public List<IdleCutsceneInfo> IdleCutscenes;
    private Dictionary<int, IdleCutsceneInfo> _cache;
    
    public IdleCutsceneInfo Get(int id)
    {
        if (_cache != null && _cache.ContainsKey(id))
        {
            return _cache[id];
        }

        return null;
    }
    
    public void OnBeforeSerialize()
    {

    }

    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<int, IdleCutsceneInfo>();

        foreach (var cutsceneInfo in IdleCutscenes)
        {
            _cache[cutsceneInfo.CutsceneUnityId] = cutsceneInfo;
        }
    }
    
    public IdleCutsceneInfoCollection()
    {
        _cache = new Dictionary<int, IdleCutsceneInfo>();
    }
}
