using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//lưu trữ key value list ket và list value với key đó::
[Serializable]
public class Currencies : ICanSerialize,ISerializationCallbackReceiver
{
    private List<string> _currencyKeys;
    private Dictionary<string, long> _currencies;
    private const string CurrenciesKey = "Currencies";


    
    
    #region SERIALIZED::::::::
    
    //CÁI NÀY BỔ SUNG SERILIZE CHO VIỆC INSPECTOR:::
    [SerializeField] private SerializableCurrencyData _serializedCurrencies;
    
    //TRƯỚC VÀ SAU KHI LÊN THÌ SẼ LẤY BỎ VÀO ĐÂY LẤY THÌ LẤY KHI TRƯỚC KHI SERILIZE THÌ ĐU LẠI VÀO KE VALUE
    //LƯU XÚN???
    public void OnBeforeSerialize()
    {
        _serializedCurrencies.currencyKeys = new List<string>(_currencies.Keys);
        _serializedCurrencies.currencyValues = new List<long>(_currencies.Values);
    }
    
    public void OnAfterDeserialize()
    {
        _currencies = new Dictionary<string, long>();
        int count = Mathf.Min(_serializedCurrencies.currencyKeys.Count, _serializedCurrencies.currencyValues.Count);
        for (int i = 0; i < count; i++)
        {
            _currencies[_serializedCurrencies.currencyKeys[i]] = _serializedCurrencies.currencyValues[i];
        }
    }
    #endregion
    
    
    

    public int KeyCount
    {
        get { return _currencyKeys.Count; }
    }

    //troong gióa trị tất cả các loại:
    public long SumValues
    {
        get
        {
            long num = 0L;
            foreach (long value in _currencies.Values)
            {
                num += value;
            }

            return num;
        }
    }

    public Currencies()
    {
        //THÊM MỘT CÁI NÀY ĐỂ DÀNH CHO LƯU XUỐNG VÀ K LƯU XUỐNG CỦA UNITY RIÊNG K LIÊN QUAN HỆ THỐNG LƯU KIA NHA:::
        _serializedCurrencies = new SerializableCurrencyData();
        
        _currencyKeys = new List<string>();
        _currencies = new Dictionary<string, long>();
    }

    //TRYỀN VÀO INIT LẠI
    public Currencies(Currencies c)
    {
        //THÊM MỘT CÁI NÀY ĐỂ DÀNH CHO LƯU XUỐNG VÀ K LƯU XUỐNG CỦA UNITY RIÊNG K LIÊN QUAN HỆ THỐNG LƯU KIA NHA:::
        _serializedCurrencies = new SerializableCurrencyData();
        
        _currencyKeys = new List<string>(c._currencyKeys);
        _currencies = new Dictionary<string, long>(c._currencies);
    }


    public Currencies(params Currency[] currencies)
        : this()
    {
        int num = currencies.Length;
        for (int i = 0; i < num; i++)
        {
            Currency currency = currencies[i];
            if (currency != null)
            {
                SetValue(currency.Name, GetValue(currency.Name) + currency.Amount);
            }
        }
    }

    public Currencies(CurrencyType type, long value)
        : this()
    {
        SetValue(type, value);
    }

    public Currencies(string currency, long value)
        : this()
    {
        SetValue(currency, value);
    }


    //TIỆN ÍCH CUNG CẤP RA CHO BÊN NGOÀI ĐỂ MÀ LẤY RESULT LÀ CURRENCIES::
    public static bool TryParse(string currenciesFormat, out Currencies result)
    {
        result = new Currencies();
        if (string.IsNullOrEmpty(currenciesFormat))
        {
            return true;
        }

        if (!currenciesFormat.Contains(","))
        {
            return false;
        }

        string[] array = currenciesFormat.Split(',');
        if (array.Length % 2 != 0)
        {
            return false;
        }

        int num = array.Length / 2;
        for (int i = 0; i < num; i++)
        {
            string key = array[i * 2].Trim();
            long result2;
            if (!long.TryParse(array[i * 2 + 1], out result2))
            {
                return false;
            }

            result.SetValue(key, result2);
        }

        return true;
    }

    public long GetValue(CurrencyType type)
    {
        return GetValue(type.ToCurrencyName());
    }

    //THỬ LẤY VALUE VỚI KET LÀ CURRENTCY::
    public long GetValue(string currency)
    {
        long value;
        if (_currencies.TryGetValue(currency, out value))
        {
            return value;
        }

        return 0L;
    }

    public bool Contains(CurrencyType type)
    {
        return Contains(type.ToCurrencyName());
    }

    public bool Contains(string currency)
    {
        return _currencyKeys.Contains(currency);
    }

    //CH CHỨA LIST NÀY CÒN NGOÀI RA THÌ SẼ FALSE NGAY
    public bool ContainsOnly(List<string> currencies)
    {
        int count = _currencyKeys.Count;
        for (int i = 0; i < count; i++)
        {
            if (!currencies.Contains(_currencyKeys[i]))
            {
                return false;
            }
        }

        return true;
    }

    public bool ContainsOnly(CurrencyType currency)
    {
        return ContainsOnly(currency.ToCurrencyName());
    }

    public bool ContainsOnly(string currency)
    {
        return _currencyKeys.Count == 1 && _currencyKeys.Contains(currency);
    }

    public bool IsEmpty()
    {
        int count = _currencyKeys.Count;
        for (int i = 0; i < count; i++)
        {
            if (_currencies[_currencyKeys[i]] != 0)
            {
                return false;
            }
        }

        return true;
    }

    //XEM FLAG CÓ THAY ĐỔI SO VỚI CURRENCY HIỆN TẠI HAY K
    public bool HasChanged(Currencies otherCurrencies, string currencyName)
    {
        return GetValue(currencyName) != otherCurrencies.GetValue(currencyName);
    }

    private void SetValue(CurrencyType key, long value)
    {
        SetValue(key.ToCurrencyName(), value);
    }

    public void SetValue(string key, long value)
    {
        _currencies[key] = value;
        if (!_currencyKeys.Contains(key))
        {
            _currencyKeys.Add(key);
        }
    }

    public Currency GetCurrency(int index)
    {
        return GetCurrency(GetKey(index));
    }

    public string GetKey(int index)
    {
        return _currencyKeys[index];
    }

    public Currency GetCurrency(CurrencyType type)
    {
        return GetCurrency(type.ToCurrencyName());
    }


    public Currency GetCurrency(string currencyName)
    {
        return new Currency(currencyName, GetValue(currencyName));
    }


    //LỌC CURRRENTY THEO HÀM TRUYỀN VÀO NÀY
    public Currencies Filter(Func<string, long, bool> predicate)
    {
        Currencies currencies = new Currencies();
        int count = _currencyKeys.Count;
        for (int i = 0; i < count; i++)
        {
            string text = _currencyKeys[i];
            long value = GetValue(text);
            if (predicate(text, value))
            {
                currencies.SetValue(text, value);
            }
        }

        return currencies;
    }

    public Currency MissingCurrency(Currency c)
    {
        long num = GetValue(c.Name) - c.Amount;
        if (num < 0)
        {
            return new Currency(c.Name, -num);
        }

        return Currency.Empty(c);
    }


    public Currencies MissingCurrencies(Currencies c)
    {
        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            long num = GetValue(currency.Key) - c.GetValue(currency.Key);
            if (num < 0)
            {
                currencies.SetValue(currency.Key, -num);
            }
        }

        return currencies;
    }


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region BALANCE:::OPERATOR

    public static Currencies operator -(Currencies c)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, -currency.Value);
        }

        return currencies;
    }

    public static Currencies operator +(Currencies c1, Currencies c2)
    {
        if (object.ReferenceEquals(c1, null))
        {
            if (object.ReferenceEquals(c2, null))
            {
                return null;
            }

            return c2;
        }

        if (object.ReferenceEquals(c2, null))
        {
            return c1;
        }

        Currencies currencies = new Currencies(c1);
        foreach (KeyValuePair<string, long> currency in c2._currencies)
        {
            currencies.SetValue(currency.Key, currencies.GetValue(currency.Key) + currency.Value);
        }

        return currencies;
    }

    public static Currencies operator +(Currencies c1, Currency c2)
    {
        if (object.ReferenceEquals(c1, null))
        {
            if (object.ReferenceEquals(c2, null))
            {
                return null;
            }

            return new Currencies(c2);
        }

        if (object.ReferenceEquals(c2, null))
        {
            return c1;
        }

        Currencies currencies = new Currencies(c1);
        currencies.SetValue(c2.Name, currencies.GetValue(c2.Name) + c2.Amount);
        return currencies;
    }

    public static Currencies operator -(Currencies c1, Currencies c2)
    {
        if (object.ReferenceEquals(c1, null))
        {
            if (object.ReferenceEquals(c2, null))
            {
                return null;
            }

            return c2;
        }

        if (object.ReferenceEquals(c2, null))
        {
            return c1;
        }

        Currencies currencies = new Currencies(c1);
        foreach (KeyValuePair<string, long> currency in c2._currencies)
        {
            currencies.SetValue(currency.Key, currencies.GetValue(currency.Key) - currency.Value);
        }

        return currencies;
    }

    public static Currencies operator -(Currencies c1, Currency c2)
    {
        if (object.ReferenceEquals(c1, null))
        {
            if (object.ReferenceEquals(c2, null))
            {
                return null;
            }

            return new Currencies(c2);
        }

        if (object.ReferenceEquals(c2, null))
        {
            return c1;
        }

        Currencies currencies = new Currencies(c1);
        currencies.SetValue(c2.Name, currencies.GetValue(c2.Name) - c2.Amount);
        return currencies;
    }

    public static Currencies operator *(Currencies c, decimal m)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, (long)((decimal)currency.Value * m));
        }

        return currencies;
    }

    public static Currencies operator *(decimal m, Currencies c)
    {
        return c * m;
    }

    public static Currencies operator *(Currencies c, float m)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, (long)((float)currency.Value * m));
        }

        return currencies;
    }

    public static Currencies operator *(float m, Currencies c)
    {
        return c * m;
    }

    public static Currencies operator *(Currencies c, long m)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, currency.Value * m);
        }

        return currencies;
    }

    public static Currencies operator *(long m, Currencies c)
    {
        return c * m;
    }

    public static Currencies operator /(Currencies c, decimal m)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, (long)((decimal)currency.Value / m));
        }

        return currencies;
    }

    public static Currencies Multiply(Currencies c, decimal m, Func<decimal, long> roundingFunc)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        Currencies currencies = new Currencies();
        foreach (KeyValuePair<string, long> currency in c._currencies)
        {
            currencies.SetValue(currency.Key, roundingFunc((decimal)currency.Value * m));
        }

        return currencies;
    }

    #endregion
    
    #region SAVE AND LOAD

    private StorageDictionary _storage;

    public Currencies(StorageDictionary storage)
    {
        _storage = storage;
        _currencies = _storage.GetDictionary<long>("Currencies");
        _currencyKeys = new List<string>();
        foreach (string key in _currencies.Keys)
        {
            _currencyKeys.Add(key);
        }
    }
    
    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Currencies", _currencies);
        return _storage;
    }

    #endregion
}


//KEY VÀ VALUE:::
[Serializable]
public class SerializableCurrencyData
{
    public List<string> currencyKeys;
    public List<long> currencyValues;
}