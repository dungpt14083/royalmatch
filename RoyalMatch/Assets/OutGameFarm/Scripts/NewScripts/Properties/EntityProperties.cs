using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityProperties
{
    private static readonly char[] SPLIT_CHAR = new char[1] { ',' };

    protected PropertiesDictionary _propsDict;

    private Dictionary<string, object> _cache;

    private string _baseKey;

    public string BaseKey
    {
        get { return _baseKey; }
    }

    public string Type { get; private set; }

    public EntityProperties(PropertiesDictionary propsDict, string baseKey)
    {
        _cache = new Dictionary<string, object>();
        _propsDict = propsDict;
        _baseKey = baseKey;
        if (!propsDict.HasBaseKey(baseKey))
        {
            Debug.LogErrorFormat("Properties does not have a base key '{0}'", baseKey);
        }

        Type = GetProperty("type", string.Empty, true);
    }

    public static object Parse<T>(string valuestr)
    {
        return Parse(typeof(T), valuestr);
    }

    public static object Parse(Type parseType, string valuestr)
    {
        if (parseType == typeof(bool))
        {
            return bool.Parse(valuestr.ToLowerInvariant());
        }

        if (parseType == typeof(int))
        {
            return int.Parse(valuestr);
        }

        if (parseType == typeof(long))
        {
            return long.Parse(valuestr);
        }

        if (parseType == typeof(double))
        {
            return double.Parse(valuestr);
        }

        if (parseType == typeof(float))
        {
            return float.Parse(valuestr);
        }

        if (parseType == typeof(decimal))
        {
            return decimal.Parse(valuestr);
        }

        if (parseType == typeof(string))
        {
            return valuestr;
        }

        if (parseType == typeof(List<string>))
        {
            return new List<string>(ParseStringList(valuestr));
        }

        if (parseType == typeof(List<int>))
        {
            return ParseList(valuestr, int.Parse);
        }

        if (parseType == typeof(List<long>))
        {
            return ParseList(valuestr, long.Parse);
        }

        if (parseType == typeof(List<double>))
        {
            return ParseList(valuestr, double.Parse);
        }

        if (parseType == typeof(List<float>))
        {
            return ParseList(valuestr, float.Parse);
        }

        if (parseType == typeof(List<decimal>))
        {
            return ParseList(valuestr, decimal.Parse);
        }

        throw new FormatException(string.Format("Type {0} is not a supported property type", parseType.ToString()));
    }

    public bool HasProperty(string key)
    {
        return _propsDict.HasKey(_baseKey, key);
    }

    public T GetProperty<T>(string key, T defaultValue, bool optional = false)
    {
        string text = PropertiesDictionary.CombineKeys(_baseKey, key);
        object value;
        if (_cache.TryGetValue(text, out value) && value is T)
        {
            return (T)value;
        }

        string value2;
        if (_propsDict.TryGetValue(text, out value2))
        {
            try
            {
                object obj = Parse<T>(value2);
                _cache.Add(text, obj);
                return (T)obj;
            }
            catch (FormatException ex)
            {
                Debug.LogError(string.Format("Failed to parse property '{0} = {1}' as {2} : {3}", text, value2,
                    typeof(T), ex.Message));
            }
        }

        if (!optional)
        {
            Debug.LogFormat("Property of type {0} with key {1} does not exist.", typeof(T), text);
        }

        return defaultValue;
    }

    private static List<T> ParseList<T>(string strValues, Func<string, T> parse)
    {
        string[] array = ParseStringList(strValues);
        List<T> list = new List<T>();
        int num = array.Length;
        for (int i = 0; i < num; i++)
        {
            list.Add(parse(array[i]));
        }

        return list;
    }

    private static string[] ParseStringList(string valuestr)
    {
        string[] array = null;
        int num = valuestr.IndexOf('[');
        int num2 = valuestr.IndexOf(']');
        if (num >= 0 && num2 > 0 && num2 > num)
        {
            return valuestr.Substring(num + 1, num2 - num - 1).Split(SPLIT_CHAR, StringSplitOptions.RemoveEmptyEntries);
        }

        throw new FormatException("Unable to parse array");
    }
}