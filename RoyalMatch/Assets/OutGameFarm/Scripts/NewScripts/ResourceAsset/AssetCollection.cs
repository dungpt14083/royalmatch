using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AssetCollection<TSerializable, TKey, TValue, TSelf> : SingletonMonobehaviour<TSelf>
    where TSerializable : class where TSelf : AssetCollection<TSerializable, TKey, TValue, TSelf>
{
    [SerializeField] protected List<TSerializable> _assets;

    protected Dictionary<TKey, TValue> _cache = new Dictionary<TKey, TValue>();

    protected override void Awake()
    {
        base.Awake();
        BuildAssetCache();
    }

    public bool ContainsAsset(TKey key)
    {
        return _cache.ContainsKey(key);
    }

    public TValue GetAsset(TKey key)
    {
        TValue value;
        if (_cache.TryGetValue(key, out value))
        {
            return value;
        }

        return default(TValue);
    }

    protected abstract void GetAssetKeyValue(TSerializable asset, out TKey key, out TValue value);

    private void RemoveNullElements()
    {
        if (_assets.RemoveAll((TSerializable a) => a == null) > 0)
        {
            Debug.LogErrorFormat("There were missing elements or null elements in AssetCollection '{0}'", base.name);
        }
    }

    private void BuildAssetCache()
    {
        RemoveNullElements();
        int count = _assets.Count;
        for (int i = 0; i < count; i++)
        {
            TSerializable asset = _assets[i];
            TKey key;
            TValue value;
            GetAssetKeyValue(asset, out key, out value);
            if (_cache.ContainsKey(key))
            {
                Debug.LogErrorFormat("Duplicate asset '{0}' in '{1}'", key, base.name);
            }
            else
            {
                _cache[key] = value;
            }
        }
    }
}