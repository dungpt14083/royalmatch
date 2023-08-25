using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Tạm bỏ qua cái này vì game dùng chung tiền tệ các đảo mang kho qua đảo khác được:::
// public class IslandFarmBalance : BaseBalance
// {
//     //public Currencies WarehouseCurrencies { get; private set; }
//     // public GeneralBalance GeneralBalance { get; private set; }
//     //
//     // private IslandFarmProperties _islandFarmProperties;
//
//     //SẼ ĐƯỢC WAREHOUSE LEVEL INIT GIÁ TRỊ VÀO:::
//     // public long MaxWarehouseCurrencyCapacity { get; set; }
//     //
//     //
//     // private const string WarehouseCurrenciesKey = "WarehouseCurrencies";
//     //
//     // public List<string> WarehouseCurrencyNames
//     // {
//     //     get { return _islandFarmProperties.AllCurrencyNames; }
//     // }
//
//     
//     
//     // public long WarehouseCurrenciesSum
//     // {
//     //     get { return WarehouseCurrencies.SumValues; }
//     // }
//
//     // private Currencies AllCurrencies
//     // {
//     //     get { return WarehouseCurrencies; }
//     // }
//
//
//     // #region FILLTER
//     //
//     // private static List<string> _nonWarehouseCurrencyNames;
//     //
//     // static IslandFarmBalance()
//     // {
//     //     CurrencyType[] array = (CurrencyType[])Enum.GetValues(typeof(CurrencyType));
//     //     _nonWarehouseCurrencyNames = new List<string>();
//     //     for (int i = 0; i < array.Length; i++)
//     //     {
//     //         _nonWarehouseCurrencyNames.Add(array[i].ToCurrencyName());
//     //     }
//     // }
//     //
//     // #endregion
//
//
//     // #region NHẬN TIỀN VÀ TRỪ TIỀN REMOVE TIỀN::GỘP LUÔN TÍNH TIỀN CHÍNH VÀO ĐÂY LUÔN
//     //
//     // public bool EarnCurrencies(Currency currency, object earnSource = null)
//     // {
//     //     return EarnCurrencies(currency.ToCurrencies(), earnSource);
//     // }
//     //
//     // public bool CanEarnCurrencies(Currency currency)
//     // {
//     //     return CanEarnCurrencies(currency.ToCurrencies());
//     // }
//     //
//     // public bool CanEarnCurrencies(Currencies currencies)
//     // {
//     //     if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
//     //     {
//     //         return true;
//     //     }
//     //
//     //     return OverCapCurrencies(currencies) <= 0;
//     // }
//
//     //NHẬN TIỀN VÀO KHO THÌ CÓ NHẬN THÔI:::
//     // public bool EarnCurrencies(Currencies currencies, object earnSource = null)
//     // {
//     //     return EarnCurrencies(currencies, false, earnSource);
//     // }
//     //
//     // private bool EarnCurrencies(Currencies currencies, bool allowOverCap, object earnSource = null)
//     // {
//     //     //
//     //     long num = OverCapCurrencies(currencies);
//     //     //KHÔNG ĐỦ Ô CHỨA THÌ PHÁT SỰ KIỆN CHO VIỆC K ĐỦ
//     //     if (!allowOverCap && num > 0)
//     //     {
//     //         Debug.LogFormat("[Balance] Over Capacity: {0}", num);
//     //         FireInsufficientCapacityEvent(num);
//     //         return false;
//     //     }
//     //
//     //     Currencies allCurrencies = AllCurrencies;
//     //     Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
//     //     //NHẬN TIỀN VÀO TRONG NÀY TRONG BALAANCE CHÍNH
//     //     GeneralBalance.EarnCurrencies(currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c)));
//     //     WarehouseCurrencies += warehouseCurrencies;
//     //     if (currencies.SumValues > 0)
//     //     {
//     //         FireCurrenciesEarnedEvent(currencies);
//     //     }
//     //
//     //     FireBalanceChangedEvent(allCurrencies, earnSource);
//     //     return true;
//     // }
//     //
//     // //CSAI NÀY CHECK SỨC CHỨA CỦA NHÀ KHO THÔI:CÒN TIỀN KIA VÔ HẠN K CẦN CHECK
//     // public long OverCapCurrencies(Currencies currencies)
//     // {
//     //     if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
//     //     {
//     //         return 0L;
//     //     }
//     //
//     //     Currencies currencies2 = WarehouseCurrencies + FilterNonWarehouseCurrencies(currencies);
//     //     return currencies2.SumValues - MaxWarehouseCurrencyCapacity;
//     // }
//     //
//     // public static Currencies FilterNonWarehouseCurrencies(Currencies currencies)
//     // {
//     //     return currencies.Filter((string c, long v) => !_nonWarehouseCurrencyNames.Contains(c));
//     // }
//
//
//     
//     
//     
//     
//     
//     //CHECK CÓ THỂ THANH TOÁN TIỀN HAY K
//     // public bool CanSpendCurrencies(Currency currency, bool useGems = false)
//     // {
//     //     return CanSpendCurrencies(currency.ToCurrencies(), useGems);
//     // }
//     //
//     // public bool CanSpendCurrencies(Currencies currencies, bool useGems = false)
//     // {
//     //     //LỌC BỎ XP RA
//     //     currencies = FilterXP(currencies);
//     //     //NẾU THIẾU CURRENTY M TRỐNG THÌ L CÓ THỂ THANH TOÁN
//     //     return MissingCurrencies(currencies, useGems).IsEmpty();
//     // }
//     //
//     // public static Currencies FilterXP(Currencies currencies)
//     // {
//     //     if (currencies.Contains(CurrencyType.XP))
//     //     {
//     //         currencies = currencies.Filter((string c, long v) => c != CurrencyType.XP.ToCurrencyName());
//     //     }
//     //
//     //     return currencies;
//     // }
//     //
//     // public Currencies MissingCurrencies(Currencies currencies, bool useGems = false)
//     // {
//     //     currencies = FilterXP(currencies);
//     //     //DÙNG CHECK TRUYỀN CURRENCUES VÀO VÀ SO SÁNH VS CURRENCY HIỆN TẠI V TRẢ VỀ LƯỢNG THIẾU :::KIỂU GIÁ TRỊ THIẾU
//     //     Currencies currencies2 = (AllCurrencies + GeneralBalance.AllCurrencies).MissingCurrencies(currencies);
//     //     if (useGems)
//     //     {
//     //         currencies2 =
//     //             (AllCurrencies + GeneralBalance.AllCurrencies).MissingCurrencies(currencies - currencies2 +
//     //                 CalculatePurchaseCost(currencies2));
//     //     }
//     //
//     //     return currencies2;
//     // }
//     //
//     // //PROPETIES CỦA FARM MANG GIÁ TIỀN
//     // public Currencies CalculatePurchaseCost(Currencies currencies)
//     // {
//     //     Currencies result = new Currencies();
//     //     int keyCount = currencies.KeyCount;
//     //     for (int i = 0; i < keyCount; i++)
//     //     {
//     //         string key = currencies.GetKey(i);
//     //         if (_islandFarmProperties.AllCurrencyNames.Contains(key))
//     //         {
//     //             EntityCurrencyProperties properties =
//     //                 _islandFarmProperties.GetProperties<EntityCurrencyProperties>(key);
//     //             result += properties.PurchaseCost * currencies.GetValue(key);
//     //         }
//     //         else
//     //         {
//     //             result += new Currencies(key, currencies.GetValue(key));
//     //         }
//     //     }
//     //
//     //     return result;
//     // }
//
//     //BẮT ĐẦU THANH TÓ TIỀN NONG:::
//     // public bool SpendCurrencies(Currency currency, bool useGems = false, Drain drain = Drain.None)
//     // {
//     //     return SpendCurrencies(currency.ToCurrencies(), useGems, drain);
//     // }
//     //
//     // public bool SpendCurrencies(Currencies currencies, bool useGems = false,
//     //     Drain drain = Drain.None)
//     // {
//     //     currencies = FilterXP(currencies);
//     //     Currencies currencies2 = MissingCurrencies(currencies, useGems);
//     //     if (!currencies2.IsEmpty())
//     //     {
//     //         Debug.LogWarningFormat("[Balance] Failed to spend currencies. Missing: {0}", currencies2);
//     //         FireInsufficientBalanceEvent(currencies2, useGems);
//     //         return false;
//     //     }
//     //
//     //     currencies = CalculateMissingPurchaseCost(currencies);
//     //     Currencies allCurrencies = AllCurrencies;
//     //     Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
//     //     GeneralBalance.SpendCurrencies(currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c)));
//     //     WarehouseCurrencies -= warehouseCurrencies;
//     //     if (currencies.SumValues > 0)
//     //     {
//     //         FireCurrenciesSpendEvent(currencies, drain);
//     //     }
//     //
//     //     FireBalanceChangedEvent(allCurrencies, null);
//     //     return true;
//     // }
//
//
//     #region VIẾT 1 HÀM CHO VIỆC THANH TOÁN TIỀN K HẾT NGHĨA LÀ K CẦN TỚI ĐỦ MS XÉT MÀ VAFUAW LÀ XÉT ĐƯỢC
//
//     #endregion
//
//
//     // public Currencies CalculateMissingPurchaseCost(Currencies currencies)
//     // {
//     //     Currencies currencies2 = MissingCurrencies(currencies);
//     //     return currencies - currencies2 + CalculatePurchaseCost(currencies2);
//     // }
//
//     
//     
//     
//     // public long GetValue(CurrencyType type)
//     // {
//     //     return GetValue(type.ToCurrencyName());
//     // }
//     //
//     // public long GetValue(string currency)
//     // {
//     //     if (_nonWarehouseCurrencyNames.Contains(currency))
//     //     {
//     //         // if (currency == _xpCurrencyKey)
//     //         // {
//     //         //     return XPLevel.XP;
//     //         // }
//     //         return GeneralBalance.GetValue(currency);
//     //     }
//     //
//     //     return WarehouseCurrencies.GetValue(currency);
//     // }
//     //
//     // #endregion
//
//
//     // #region SaveAndLoad:::
//     //
//     // private StorageDictionary _storage;
//     //
//     // public IslandFarmBalance(IslandFarmProperties properties, GeneralBalance generalBalance)
//     // {
//     //     _islandFarmProperties = properties;
//     //     WarehouseCurrencies = new Currencies();
//     //     GeneralBalance = generalBalance;
//     // }
//     //
//     // public IslandFarmBalance(StorageDictionary storage)
//     // {
//     //     _storage = storage;
//     //     WarehouseCurrencies = new Currencies(_storage.GetStorageDict("WarehouseCurrencies"));
//     // }
//     //
//     // public StorageDictionary Serialize()
//     // {
//     //     if (_storage == null)
//     //     {
//     //         _storage = new StorageDictionary();
//     //     }
//     //
//     //     _storage.Set("WarehouseCurrencies", WarehouseCurrencies);
//     //     return _storage;
//     // }
//     //
//     // public void ResolveDependencies(IslandFarmProperties properties, GeneralBalance generalBalance)
//     // {
//     //     GeneralBalance = generalBalance;
//     //     _islandFarmProperties = properties;
//     // }
//     //
//     // #endregion
// }