using System;
using UnityEngine;


public abstract class DictionaryAssetCollection<TSerializable, TKey, TValue, TSelf> : AssetCollection<TSerializable, TKey, TValue, TSelf> where TSerializable : DictionaryAssetCollection<TSerializable, TKey, TValue, TSelf>.SerializableDictionary where TSelf : DictionaryAssetCollection<TSerializable, TKey, TValue, TSelf>
{
    [Serializable]
    public class SerializableDictionary
    {
        [SerializeField]
        protected TKey _key;

        [SerializeField]
        protected TValue _value;

        public TKey Key
        {
            get
            {
                return _key;
            }
        }

        public TValue Value
        {
            get
            {
                return _value;
            }
        }
    }

    protected override void GetAssetKeyValue(TSerializable asset, out TKey key, out TValue value)
    {
        key = asset.Key;
        value = asset.Value;
    }
}
