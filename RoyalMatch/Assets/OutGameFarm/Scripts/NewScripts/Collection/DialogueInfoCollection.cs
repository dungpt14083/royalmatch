using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "DialogueInfoCollection", menuName = "Scriptable Objects/DialogueInfoCollection")]
public class DialogueInfoCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public List<DialogueInfo> Dialogues;
    private Dictionary<int, DialogueInfo> _cache;
    
    public DialogueInfo Get(int dialogId)
    {
        if(_cache != null)
        {
            return this._cache[dialogId];
        }

        return null;
    }
    
    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<int, DialogueInfo>();
        for (int i = 0; i < Dialogues.Count; i++)
        {
            if (!_cache.ContainsKey(Dialogues[i].id))
            {
                _cache.Add(Dialogues[i].id, Dialogues[i]);
            }
        }
    }
    
    public void OnBeforeSerialize()
    {
    }
}
