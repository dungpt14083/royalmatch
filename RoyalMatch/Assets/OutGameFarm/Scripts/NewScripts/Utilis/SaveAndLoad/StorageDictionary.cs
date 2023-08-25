using System;
using System.Collections.Generic;

//CUNG CẤP TIỆN ÍCH LƯU TRỮ CHO GAME TẠO DICTINARY:::
//SET ADD REMOVE LƯU TRỮ KEY VÀ VALUE LÀ LIST::
public class StorageDictionary
{
    private Dictionary<string, object> _storage;

    public Dictionary<string, object> InternalDictionary
    {
        get { return _storage; }
    }

    public StorageDictionary()
    {
        _storage = new Dictionary<string, object>();
    }

    public StorageDictionary(Dictionary<string, object> storage)
    {
        _storage = storage;
    }

    public bool Contains(string key)
    {
        return _storage.ContainsKey(key);
    }

    public void Remove(string key)
    {
        _storage.Remove(key);
    }

    public void Set(string key, string value)
    {
        _storage[key] = value;
    }

    public void Set(string key, bool value)
    {
        _storage[key] = value;
    }

    public void Set(string key, char value)
    {
        _storage[key] = value;
    }

    public void Set(string key, float value)
    {
        _storage[key] = value;
    }

    public void Set(string key, double value)
    {
        _storage[key] = value;
    }

    public void Set(string key, sbyte value)
    {
        _storage[key] = value;
    }

    public void Set(string key, byte value)
    {
        _storage[key] = value;
    }

    public void Set(string key, short value)
    {
        _storage[key] = value;
    }

    public void Set(string key, ushort value)
    {
        _storage[key] = value;
    }

    public void Set(string key, int value)
    {
        _storage[key] = value;
    }

    public void Set(string key, uint value)
    {
        _storage[key] = value;
    }

    public void Set(string key, long value)
    {
        _storage[key] = value;
    }

    public void Set(string key, ulong value)
    {
        _storage[key] = value;
    }

    public void Set(string key, decimal value)
    {
        _storage[key] = value;
    }

    public void Set(string key, DateTime value)
    {
        _storage[key] = value.ToBinary();
    }

    public void Set<T>(string key, T value) where T : ICanSerialize
    {
        _storage[key] = value.Serialize()._storage;
    }

    public void SetRef(string key, IHaveAnIdentifier value)
    {
        if (value == null)
        {
            _storage.Remove(key);
        }
        else
        {
            _storage[key] = value.Identifier;
        }
    }

    public void SetOrRemove(string key, ICanSerialize value)
    {
        if (value == null)
        {
            _storage.Remove(key);
        }
        else
        {
            _storage[key] = value.Serialize()._storage;
        }
    }

    public void Set(string key, List<string> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<bool> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<char> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<float> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<double> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<sbyte> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<byte> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<short> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<ushort> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<int> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<uint> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<long> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<ulong> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<decimal> values)
    {
        SetList(key, values);
    }

    public void Set(string key, List<DateTime> values)
    {
        List<object> list = new List<object>();
        int count = values.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(values[i].ToBinary());
        }

        _storage[key] = list;
    }

    public void Set(string key, Dictionary<string, string> values)
    {
        SetDictionary(key, values);
    }

    public void Set(string key, Dictionary<string, long> values)
    {
        SetDictionary(key, values);
    }

    public void Set(string key, Dictionary<string, int> values)
    {
        SetDictionary(key, values);
    }

    public void Set<T>(string key, List<T> values, Func<T, StorageDictionary> serialize)
    {
        List<object> list = new List<object>();
        int count = values.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(serialize(values[i])._storage);
        }

        _storage[key] = list;
    }

    public void Set<T>(string key, List<T> values) where T : ICanSerialize
    {
        List<object> list = new List<object>();
        int count = values.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(values[i].Serialize()._storage);
        }

        _storage[key] = list;
    }

    public void Set<T>(string key, Dictionary<string, T> values) where T : ICanSerialize
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        foreach (KeyValuePair<string, T> value in values)
        {
            dictionary.Add(value.Key, value.Value.Serialize()._storage);
        }

        _storage[key] = dictionary;
    }

    public void SetWithNulls<T>(string key, Dictionary<string, T> values) where T : ICanSerialize
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        foreach (KeyValuePair<string, T> value in values)
        {
            if (value.Value != null)
            {
                dictionary.Add(value.Key, value.Value.Serialize()._storage);
            }
            else
            {
                dictionary.Add(value.Key, null);
            }
        }

        _storage[key] = dictionary;
    }

    public void SetWithNulls<T>(string key, List<T> values) where T : ICanSerialize
    {
        List<object> list = new List<object>();
        int count = values.Count;
        for (int i = 0; i < count; i++)
        {
            if (values[i] != null)
            {
                list.Add(values[i].Serialize()._storage);
            }
            else
            {
                list.Add(null);
            }
        }

        _storage[key] = list;
    }

    private void SetList<T>(string key, List<T> values)
    {
        List<object> list = new List<object>();
        int count = values.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add(values[i]);
        }

        _storage[key] = list;
    }

    private void SetDictionary<T>(string key, Dictionary<string, T> values)
    {
        Dictionary<string, object> dictionary = new Dictionary<string, object>();
        foreach (KeyValuePair<string, T> value in values)
        {
            dictionary.Add(value.Key, value.Value);
        }

        _storage[key] = dictionary;
    }

    public TField Get<TField>(string key, TField defaultValue)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is TField))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    (_storage[key] != null) ? _storage[key].GetType().Name : "null", key, typeof(TField).Name));
            }

            return (TField)_storage[key];
        }

        return defaultValue;
    }

    public DateTime GetDateTime(string key, DateTime defaultValue)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is long))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(long).Name));
            }

            return DateTime.FromBinary((long)_storage[key]);
        }

        return defaultValue;
    }

    public List<DateTime> GetDateTimeList(string key)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is List<object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(List<object>).Name));
            }

            List<DateTime> list = new List<DateTime>();
            List<object> list2 = (List<object>)_storage[key];
            int count = list2.Count;
            for (int i = 0; i < count; i++)
            {
                if (!(list2[i] is long))
                {
                    throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}][{2}]. Expecting {3}",
                        (list2[i] != null) ? list2[i].GetType().Name : "null", key, i, typeof(long).Name));
                }

                list.Add(DateTime.FromBinary((long)list2[i]));
            }

            return list;
        }

        return new List<DateTime>();
    }

    public StorageDictionary GetStorageDict(string key)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is Dictionary<string, object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(List<object>).Name));
            }

            return new StorageDictionary((Dictionary<string, object>)_storage[key]);
        }

        return new StorageDictionary();
    }

    public List<TField> GetList<TField>(string key)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is List<object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(List<object>).Name));
            }

            List<TField> list = new List<TField>();
            List<object> list2 = (List<object>)_storage[key];
            int count = list2.Count;
            for (int i = 0; i < count; i++)
            {
                if (!(list2[i] is TField))
                {
                    throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}][{2}]. Expecting {3}",
                        (list2[i] != null) ? list2[i].GetType().Name : "null", key, i, typeof(TField).Name));
                }

                list.Add((TField)list2[i]);
            }

            return list;
        }

        return new List<TField>();
    }

    public Dictionary<string, TField> GetDictionary<TField>(string key)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is Dictionary<string, object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(Dictionary<string, object>).Name));
            }

            Dictionary<string, TField> dictionary = new Dictionary<string, TField>();
            Dictionary<string, object> dictionary2 = (Dictionary<string, object>)_storage[key];
            {
                foreach (KeyValuePair<string, object> item in dictionary2)
                {
                    if (!(dictionary2[item.Key] is TField))
                    {
                        throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                            _storage[key].GetType().Name, key, typeof(TField).Name));
                    }

                    dictionary.Add(item.Key, (TField)dictionary2[item.Key]);
                }

                return dictionary;
            }
        }

        return new Dictionary<string, TField>();
    }

    public Dictionary<string, TModel> GetDictionaryModels<TModel>(string key,
        Func<StorageDictionary, TModel> factoryMethod)
    {
        Dictionary<string, Dictionary<string, object>> dictionary = GetDictionary<Dictionary<string, object>>(key);
        Dictionary<string, TModel> dictionary2 = new Dictionary<string, TModel>();
        foreach (KeyValuePair<string, Dictionary<string, object>> item in dictionary)
        {
            dictionary2.Add(item.Key, factoryMethod(new StorageDictionary(item.Value)));
        }

        return dictionary2;
    }

    public Dictionary<string, TModel> GetDictionaryModelsWithNulls<TModel>(string key,
        Func<StorageDictionary, TModel> factoryMethod)
    {
        if (_storage.ContainsKey(key))
        {
            if (!(_storage[key] is Dictionary<string, object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                    _storage[key].GetType().Name, key, typeof(List<object>).Name));
            }

            Dictionary<string, object> dictionary = (Dictionary<string, object>)_storage[key];
            Dictionary<string, TModel> dictionary2 = new Dictionary<string, TModel>();
            {
                foreach (KeyValuePair<string, object> item in dictionary)
                {
                    if (item.Value == null)
                    {
                        dictionary2.Add(item.Key, default(TModel));
                        continue;
                    }

                    if (!(dictionary[item.Key] is Dictionary<string, object>))
                    {
                        throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                            _storage[key].GetType().Name, key, typeof(Dictionary<string, object>).Name));
                    }

                    dictionary2.Add(item.Key,
                        factoryMethod(new StorageDictionary((Dictionary<string, object>)item.Value)));
                }

                return dictionary2;
            }
        }

        return new Dictionary<string, TModel>();
    }

    public List<TModel> GetModels<TModel>(string key, Func<StorageDictionary, TModel> factoryMethod)
    {
        List<Dictionary<string, object>> list = GetList<Dictionary<string, object>>(key);
        List<TModel> list2 = new List<TModel>();
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            list2.Add(factoryMethod(new StorageDictionary(list[i])));
        }

        return list2;
    }

    public List<TModel> GetModelsWithNulls<TModel>(string key, Func<StorageDictionary, TModel> factoryMethod)
    {
        if (!(_storage[key] is List<object>))
        {
            throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}]. Expecting {2}",
                _storage[key].GetType().Name, key, typeof(List<object>).Name));
        }

        List<TModel> list = new List<TModel>();
        List<object> list2 = (List<object>)_storage[key];
        int count = list2.Count;
        for (int i = 0; i < count; i++)
        {
            if (list2[i] == null)
            {
                list.Add(default(TModel));
                continue;
            }

            if (!(list2[i] is Dictionary<string, object>))
            {
                throw new InvalidOperationException(string.Format("Found {0} at _storage[{1}][{2}]. Expecting {3}",
                    list2[i].GetType().Name, key, i, typeof(Dictionary<string, object>).Name));
            }

            list.Add(factoryMethod(new StorageDictionary((Dictionary<string, object>)list2[i])));
        }

        return list;
    }
}