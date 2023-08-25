using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//SẼ LÀ CHỨA TIỀN CHUNG HẾT TẤT CẢ CÁC ĐẢO::::
public class GeneralBalance : BaseBalance
{
    //Tiền tệ chung của cả game:::: vật phẩm product hay kia kia qua đây nch là nhà kho::
    public override Currencies AllCurrencies
    {
        get { return _currencies + WarehouseCurrencies; }
    }

    private GeneralProperties _generalProperties;
    private Currencies _currencies;

    public event Action<Currencies> WarehouseCurrenciesChangedEvent;

    public bool WarehouseIsFull { get { return WarehouseCurrenciesSum >= MaxWarehouseCurrencyCapacity; } }

    //THÊM CHO THẰNG WAREHOUSE:::
    public Currencies WarehouseCurrencies { get; private set; }

    public long MaxWarehouseCurrencyCapacity { get; set; }

    //Tất cả tiền loại tiền ở trong kho dạng propetis lấy tên cho việc ở trong nhà kho vật lên để xài
    public List<string> WarehouseCurrencyNames
    {
        get { return _generalProperties.AllCurrencyNames; }
    }

    //Dành cho việc chỗ trống trong nhà kho số lượng
    public long WarehouseCurrenciesSum
    {
        get { return WarehouseCurrencies.SumValues; }
    }


    #region LỌC TIỀN TỆ:::

    //NONWAREHOUSE NAMES::
    private static List<string> _nonWarehouseCurrencyNames;
    private static  List<string> _NoCoinWarehouseCurrencyNames;
    static GeneralBalance()
    {
        CurrencyType[] array = (CurrencyType[])Enum.GetValues(typeof(CurrencyType));
        _nonWarehouseCurrencyNames = new List<string>();
     /*   List<CurrencyType> allowedCurrencies = new List<CurrencyType>
        {
            CurrencyType.gems,
            CurrencyType.xp,
            CurrencyType.golds,
            CurrencyType.energy
        };*/
        for (int i = 0; i < array.Length; i++)
        { 
            _nonWarehouseCurrencyNames.Add(array[i].ToCurrencyName());
        }
    }

    #endregion


    #region NHẬN TIỀN VÀ TRỪ TIỀN TRONG GAME::::

    public bool EarnCurrencies(Currency currency, object earnSource = null)
    {
        return EarnCurrencies(currency.ToCurrencies(), earnSource);
    }

    public bool EarnCurrencies(Currencies currencies, object earnSource = null)
    {
        return EarnCurrencies(currencies, true, earnSource);
    }

    private bool EarnCurrencies(Currencies currencies, bool allowOverCap = false, object earnSource = null)
    {
        //Số lượng bị thừa ra khi nhà kho đầy:::
        long num = OverCapCurrencies(currencies);
        if (!allowOverCap && num > 0)
        {
            Debug.LogFormat("[Balance] Over Capacity: {0}", num);
            FireInsufficientCapacityEvent(num);
            return false;
        }

        //Lọc ra tiền của warehouse và tiền của kia để mà cộng vô
        Currencies allCurrencies = AllCurrencies;
        Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
        _currencies += currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c));
        WarehouseCurrencies += warehouseCurrencies;
        if (currencies.SumValues > 0)
        {
            FireCurrenciesEarnedEvent(currencies);
        }

        WarehouseCurrenciesChangedEvent?.Invoke(warehouseCurrencies);
        FireBalanceChangedEvent(allCurrencies, earnSource);
        return true;
    }

    #endregion


    #region CHECK ĐỦ KHẢ NNG ERNCURRRENTY HAY K ĐỂ NHẬN

    public bool CanEarnCurrencies(Currency currency)
    {
        return CanEarnCurrencies(currency.ToCurrencies());
    }

    //NẾU LÀ MỖI TIỀN TỆ K THÌ LUÔN NHẬN ĐƯỢC
    public bool CanEarnCurrencies(Currencies currencies)
    {
        if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
        {
            return true;
        }

        return OverCapCurrencies(currencies) <= 0;
    }

    //CSAI NÀY CHECK SỨC CHỨA CỦA NHÀ KHO THÔI:CÒN TIỀN KIA VÔ HẠN K CẦN CHECK:::CHECK XEM BỊ THIẾU BAO NHIÊU VỊ TRÍ TRONG NHÀ KHO:::THỪA RA BN::
    public long OverCapCurrencies(Currencies currencies)
    {
        if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
        {
            return 0L;
        }

        Currencies currencies2 = WarehouseCurrencies + FilterNonWarehouseCurrencies(currencies);
        return currencies2.SumValues - MaxWarehouseCurrencyCapacity;
    }

    public static Currencies FilterNonWarehouseCurrencies(Currencies currencies)
    {
        return currencies.Filter((string c, long v) => !_nonWarehouseCurrencyNames.Contains(c));
    }

    public  Currencies FilterNonCoinCurrencies(Currencies currencies)
    {
        return currencies.Filter((c, v) => WarehouseCurrencyNames.Contains(c));
    }

    #endregion


    #region CHECK ĐỦ KHẢ NĂNG SPEND HAY K:::

    public bool CanSpendCurrencies(Currency currency, bool useGems = false)
    {
        return CanSpendCurrencies(currency.ToCurrencies(), useGems);
    }

    public bool CanSpendCurrencies(Currencies currencies, bool useGems = false)
    {
        currencies = FilterXP(currencies);
        return MissingCurrencies(currencies, useGems).IsEmpty();
    }

    //Tính giá cả bị thiếu ở trong này khi thanh toán TẤT CẢ LOẠI TIỀN TỆ XEM ĐỦ K::kể cả thanh toán bằng gem thử
    public Currencies MissingCurrencies(Currencies currencies, bool useGems = false)
    {
        currencies = FilterXP(currencies);
        Currencies currencies2 = AllCurrencies.MissingCurrencies(currencies);
        //Nếu sử dụng gem thanh toán thì lấy tiền gem thanh toán trừ thửu xem tính toán ntn
        if (useGems)
        {
            currencies2 =
                AllCurrencies.MissingCurrencies(currencies - currencies2 +
                                                CalculatePurchaseCost(currencies2));
        }

        return currencies2;
    }


    public static Currencies FilterXP(Currencies currencies)
    {
        if (currencies.Contains(CurrencyType.xp))
        {
            currencies = currencies.Filter((string c, long v) => c != CurrencyType.xp.ToCurrencyName());
        }

        return currencies;
    }

    //CÁI NÀY SẼ XEM XÉT THẬT KĨ::::::
    public Currencies CalculatePurchaseCost(Currencies currencies)
    {
        Currencies result = new Currencies();
        int keyCount = currencies.KeyCount;
        for (int i = 0; i < keyCount; i++)
        {
            string key = currencies.GetKey(i);
            if (_generalProperties.AllCurrencyNames.Contains(key))
            {
                EntityCurrencyProperties properties =
                    _generalProperties.GetProperties<EntityCurrencyProperties>(key);
                result += properties.PurchaseCost * currencies.GetValue(key);
            }
            else
            {
                result += new Currencies(key, currencies.GetValue(key));
            }
        }

        return result;
    }

    #endregion

    public bool BuyMaterial(Currency cost, bool useGem, Currency material)
    {
        if (SpendCurrencies(cost, useGem))
        {
            if (material == null) return true;
            return EarnCurrencies(material);
        }

        return false;
    }

    public bool BuyMaterial(Currency cost, bool useGem, Currencies materials)
    {
        if (SpendCurrencies(cost, useGem))
        {
            if (materials == null) return true;
            return EarnCurrencies(materials, true);
        }

        return false;
    }

    #region ĐÂY À CHỐ SẼ LẤY TIỀN TRONG NGƯỜI CHOI RA ĐỂ THANH TOÁN::::

    public bool SpendCurrencies(Currency currency, bool useGems = false, Drain drain = Drain.None)
    {
        return SpendCurrencies(currency.ToCurrencies(), useGems, drain);
    }

    public bool SpendCurrencies(Currencies currencies, bool useGems = false,
        Drain drain = Drain.None)
    {
        currencies = FilterXP(currencies);
        Currencies currencies2 = MissingCurrencies(currencies, useGems);
        if (!currencies2.IsEmpty())
        {
            Debug.LogWarningFormat("[Balance] Failed to spend currencies. Missing: {0}", currencies2);
            FireInsufficientBalanceEvent(currencies2, useGems);
            return false;
        }

        currencies = CalculateMissingPurchaseCost(currencies);
        Currencies allCurrencies = AllCurrencies;
        Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
        _currencies -= currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c));
        WarehouseCurrencies -= warehouseCurrencies;
        if (currencies.SumValues > 0)
        {
            FireCurrenciesSpendEvent(currencies, drain);
        }

        FireBalanceChangedEvent(allCurrencies, null);
        return true;
    }

    //TÍNH TOÁN TIỀN CÒN THIẾU:::
    public Currencies CalculateMissingPurchaseCost(Currencies currencies)
    {
        Currencies currencies2 = MissingCurrencies(currencies);
        return currencies - currencies2 + CalculatePurchaseCost(currencies2);
    }

    #endregion


    public long GetValue(CurrencyType type)
    {
        return GetValue(type.ToCurrencyName());
    }

    public long GetValue(string currency)
    {
        if (_nonWarehouseCurrencyNames.Contains(currency))
        {
            // if (currency == _xpCurrencyKey)
            // {
            //     return XPLevel.XP;
            // }
            return _currencies.GetValue(currency);
        }

        return WarehouseCurrencies.GetValue(currency);
    }


    #region NHẬN TIỀN VÔ VÀ PHÁT SỰ KIỆN

    // public bool EarnCurrencies(Currencies currencies, object earnSource = null)
    // {
    //     return EarnCurrencies(currencies, false, earnSource);
    // }
    //
    // private bool EarnCurrencies(Currencies currencies, bool allowOverCap, object earnSource = null)
    // {
    //     //Lưu tiên ệ trước khi phát
    //     Currencies allCurrencies = AllCurrencies;
    //
    //     _currencies += currencies;
    //
    //     if (currencies.SumValues > 0)
    //     {
    //         FireCurrenciesEarnedEvent(currencies);
    //     }
    //
    //     FireBalanceChangedEvent(allCurrencies, earnSource);
    //     return true;
    // }

    #endregion


    #region TRẢ GIÁ CHO VIỆC TRẢ TIỀN THANH TOÁN VÀ LOẠI THÀNH TOÁN

    // //CÁI NÀY BỌN BUILDING PHI TÍNH TOÁN XEM ĐỦ TIỀN HAY K BÙ BN GEM TỪ PROP CỦA CHÚNG NÓ RỒI MỚI BỎ VÀO ĐÂY TRỪ TỀN
    // public bool SpendCurrencies(Currency currency, bool useGems = false, Drain drain = Drain.None)
    // {
    //     return SpendCurrencies(currency.ToCurrencies(), useGems, drain);
    // }
    //
    // public bool SpendCurrencies(Currencies currencies, bool useGems = false, Drain drain = Drain.None)
    // {
    //     currencies = FilterXP(currencies);
    //     //NEESU TỚI THANH TOÀN K ĐỦ TIỀN CHO OUT LUÔN K TIH TOÁN TỚI...
    //     Currencies currencies2 = MissingCurrencies(currencies, useGems);
    //     if (!currencies2.IsEmpty())
    //     {
    //         Debug.LogWarningFormat("[Balance] Failed to spend currencies. Missing: {0}", currencies2);
    //         FireInsufficientBalanceEvent(currencies2, useGems);
    //         return false;
    //     }
    //
    //     Currencies allCurrencies = AllCurrencies;
    //
    //     _currencies -= currencies;
    //
    //     if (currencies.SumValues > 0)
    //     {
    //         FireCurrenciesSpendEvent(currencies, drain);
    //     }
    //
    //     FireBalanceChangedEvent(allCurrencies, null);
    //     return true;
    // }
    //
    // public static Currencies FilterXP(Currencies currencies)
    // {
    //     if (currencies.Contains(CurrencyType.XP))
    //     {
    //         currencies = currencies.Filter((string c, long v) => c != CurrencyType.XP.ToCurrencyName());
    //     }
    //
    //     return currencies;
    // }
    //
    // public Currencies MissingCurrencies(Currencies currencies, bool useGems = false)
    // {
    //     currencies = FilterXP(currencies);
    //     Currencies currencies2 = AllCurrencies.MissingCurrencies(currencies);
    //     return currencies2;
    // }
    //
    // public long GetValue(CurrencyType type)
    // {
    //     return GetValue(type.ToCurrencyName());
    // }
    //
    // public long GetValue(string currency)
    // {
    //     return _currencies.GetValue(currency);
    // }

    #endregion

    public long SumCurrentCurrencies
    {
        get
        {
            Currencies currencies = FilterNonCoinCurrencies(_currencies);

            
            return currencies.SumValues;
        }
    }

    #region SAVE AND LOAD

    public GeneralBalance(GeneralProperties generalProperties) : base()
    {
        _generalProperties = generalProperties;
        _currencies = new Currencies();
        WarehouseCurrencies = new Currencies();
        //Khi mà vào game ban đầu thì phải init tiền ban đầu cho balance:::
        EarnCurrencies(_generalProperties.GameStartCurrrencysProperties.StartCurrencies, true);
    }
    

    public GeneralBalance(StorageDictionary storage)
    {
        _storage = storage;
        _currencies = new Currencies(_storage.GetStorageDict("Currencies"));
        WarehouseCurrencies = new Currencies(_storage.GetStorageDict("WarehouseCurrencies"));
    }


    public override StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Currencies", _currencies);
        _storage.Set("WarehouseCurrencies", WarehouseCurrencies);
        return _storage;
    }

    public void ResolveDependencies(BaseProperties properties)
    {
        _generalProperties = (GeneralProperties)properties;
    }

    #endregion


    #region CONVERTTRADEINFOTOCURENCIES:::::

    public bool EarnCurrencies(TradeInfo tradeInfo, string earnSource = "")
    {
        if (tradeInfo.TradeType != TradeType.Currency)
        {
            return false;
        }

        Currency currency = new Currency(((CurrencyType)tradeInfo.IdInType), tradeInfo.Amount);
        return EarnCurrencies(currency.ToCurrencies(), earnSource);
    }

    public bool SpendCurrencies(TradeInfo tradeInfo, string earnSource = "")
    {
        if (tradeInfo.TradeType != TradeType.Currency)
        {
            return false;
        }

        Currency currency = new Currency(((CurrencyType)tradeInfo.IdInType), tradeInfo.Amount);
        return SpendCurrencies(currency.ToCurrencies());
    }


    public bool CanSpendCurrencies(RequirementInfo requirementInfo, bool useGems = false)
    {
        if (requirementInfo.RequirementType != RequirementType.Currency)
        {
            return false;
        }

        Currency currency = new Currency(CurrencyType.gems, requirementInfo.Value);
        return CanSpendCurrencies(currency.ToCurrencies(), useGems);
    }

    #endregion
}