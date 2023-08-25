using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GatherableAnimationCollection",
    menuName = "Scriptable Objects/GatherableAnimationCollection")]
[Serializable]
public class GatherableAnimationCollection : ScripableSingleton<GatherableAnimationCollection>,
    ISerializationCallbackReceiver
{
    public List<GatherableCategoryToAnimation> GatherableCategoryToAnimation;
    private Dictionary<GatherableCategory, GatherableCategoryToAnimation> _cache;

    public GatherableCategoryToAnimation GetAnimationInfo(GatherableCategory category)
    {
        if (_cache != null && _cache.ContainsKey(category))
        {
            return _cache[category];
        }

        return null;
    }

    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<GatherableCategory, GatherableCategoryToAnimation>();

        foreach (var item in GatherableCategoryToAnimation)
        {
            _cache[item.Category] = item;
        }
    }

    public void OnBeforeSerialize()
    {
        // No implementation needed
    }
}