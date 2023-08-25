using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "TranslationCollection", menuName = "Scriptable Objects/TranslationCollection")]
public class TranslationCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public string LanguageCode;
    public List<TranslationInfo> Translations;
    private Dictionary<string, TranslationInfo> _cache = new Dictionary<string, TranslationInfo>();

    public bool Contains(string key)
    {
        if (_cache != null)
        {
            return _cache.ContainsKey(key: key);
        }

        return false;
    }

    public TranslationInfo Get(string key)
    {
        if (this._cache != null)
        {
            return this._cache[key];
        }

        return null;
    }

    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<string, TranslationInfo>();
        for (int i = 0; i < Translations.Count; i++)
        {
            if (!_cache.ContainsKey(Translations[i].Key))
            {
                _cache.Add(Translations[i].Key, Translations[i]);
            }
        }
    }

    public void OnBeforeSerialize()
    {
    }
}