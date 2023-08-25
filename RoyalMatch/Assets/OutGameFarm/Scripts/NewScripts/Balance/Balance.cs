using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Liên quan toi tien te trong game:::
public class Balance : BaseBalance
{

    
    // private static List<string> _nonWarehouseCurrencyNames;
    //
    // //PROP VÀ THẰNG CURRENTCIES INSTANCE?
    // private Properties _props;
    // private Currencies _currencies;
    // private const string CurrenciesKey = "Currencies";
    //
    // private const string WarehouseCurrenciesKey = "WarehouseCurrencies";
    // //private const string XPLevelKey = "XPLevel";
    // //public XPLevel XPLevel { get; private set; }
    //
    //
    // #region WAREHOSE NHÀ KHO
    //
    // //NẦ KHO SẼ CHỨADDONG STRING NAY  LIST KEY::
    // //TẠM THỜI CHỈ CHUA HẠT GIỐNG:::::::CHỨA CẢ MẤY LOẠI NHƯNG CHỈ TẠM THỜI LÀM HẠT GIỐNG:
    // //SowingMaterial::::corn?::+BuildingMaterial::windowGlass?::::product::::foodCow?::basicMaterial:::iron?
    // public List<string> WarehouseCurrencyNames
    // {
    //     get { return _props.AllCurrencyNames; }
    // }
    //
    // //CURENCY CỦA WAREHOUSE LƯU TRỮ CÁC VẬT PHẨM TRONG NHÀ KHO
    // public Currencies WarehouseCurrencies { get; private set; }
    //
    // public long WarehouseCurrenciesSum
    // {
    //     get { return WarehouseCurrencies.SumValues; }
    // }
    //
    // #endregion
    //
    //
    // #region CURRENCY + ALL CENTYC
    //
    // //TẤT CẢ CURRENCY LÀ GỘP CURRENY VÀ THẰNG NHÀ KHO
    // private Currencies AllCurrencies
    // {
    //     get { return _currencies + WarehouseCurrencies; }
    // }
    //
    // #endregion
    //
    //
    // //INIT CÁC THÔNG SỐ VÀO  À ĐỐNG TIỀN GEM DY VÀ XP LÀ 3 LOẠI COI NHƯ TIỀN NGOÀI WAREHOUSE
    // static Balance()
    // {
    //     CurrencyType[] array = (CurrencyType[])Enum.GetValues(typeof(CurrencyType));
    //     _nonWarehouseCurrencyNames = new List<string>();
    //     for (int i = 0; i < array.Length; i++)
    //     {
    //         _nonWarehouseCurrencyNames.Add(array[i].ToCurrencyName());
    //     }
    // }
    //
    // //TẠO INSTANCE VỚI PROPPETIES KHI VÀO GAME:::
    // public Balance(Properties properties)
    // {
    //     _props = properties;
    //     _currencies = new Currencies();
    //     WarehouseCurrencies = new Currencies();
    //     //ĐÂY NÓ SẼ LIÊN QUAN ỚI THẰNG STARTCURRENCY BAN ĐẦU TIÊN BAN ĐẦU VÀO GAME::
    //     EarnCurrencies(properties.GameProperties.StartCurrencies);
    // }
    //
    // // private void FireBalanceChangedEvent(Currencies oldBalance, object earnSource)
    // // {
    // //     if (this.BalanceChangedEvent != null)
    // //     {
    // //         this.BalanceChangedEvent(oldBalance, AllCurrencies, earnSource);
    // //     }
    // // }
    // //
    // // private void FireInsufficientBalanceEvent(Currencies missing, bool usedGems)
    // // {
    // //     if (this.InsufficientBalanceEvent != null)
    // //     {
    // //         this.InsufficientBalanceEvent(missing, usedGems);
    // //     }
    // // }
    // //
    // // private void FireInsufficientCapacityEvent(long overcap)
    // // {
    // //     if (this.InsufficientCapacityEvent != null)
    // //     {
    // //         this.InsufficientCapacityEvent(overcap);
    // //     }
    // // }
    // //
    // // private void FireCurrenciesSpendEvent(Currencies spend, Drain drain)
    // // {
    // //     if (this.CurrenciesSpendEvent != null)
    // //     {
    // //         this.CurrenciesSpendEvent(spend, drain);
    // //     }
    // // }
    // //
    // // private void FireCurrenciesEarnedEvent(Currencies earned)
    // // {
    // //     if (this.CurrenciesEarnedEvent != null)
    // //     {
    // //         this.CurrenciesEarnedEvent(earned);
    // //     }
    // // }
    //
    //
    // #region NHẬN TIỀN VÀO
    //
    // //NHẬN TIỀN VÔ NGƯỜI  ::TẠM BỎ QUA GIỚI HẠN Ô CHUA TRONG KHO
    // public bool EarnCurrencies(Currencies currencies, object earnSource = null)
    // {
    //     return EarnCurrencies(currencies, false, earnSource);
    // }
    //
    // //NHẬN TIỀN VÔ==CHO PHÉP VƯỢT QUẢ KHẢ NĂNG LƯU KHÔNG 
    // private bool EarnCurrencies(Currencies currencies, bool allowOverCap, object earnSource = null)
    // {
    //     long num = OverCapCurrencies(currencies);
    //
    //     //KHÔNG ĐỦ Ô CHỨA THÌ PHÁT SỰ KIỆN CHO VIỆC K ĐỦ
    //     if (!allowOverCap && num > 0)
    //     {
    //         Debug.LogFormat("[Balance] Over Capacity: {0}", num);
    //         FireInsufficientCapacityEvent(num);
    //         return false;
    //     }
    //
    //     //BỎ QUA XP TÍNH SAU
    //     long num2;
    //     if (currencies.Contains(CurrencyType.XP))
    //     {
    //         //num2 = currencies.GetValue(CurrencyType.XP);
    //         //currencies = currencies.Filter((string c, long v) => c != CurrencyType.XP.ToCurrencyName());
    //     }
    //     else
    //     {
    //         num2 = 0L;
    //     }
    //
    //     Currencies allCurrencies = AllCurrencies;
    //     //LỌC RA TIỀN K PHẢI WAREHOUSE VÀ BỎ VÀO TRONG...VÀ WAREHOUSE THÌ COOJNG VÀO WAREHOUSE
    //     Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
    //     _currencies += currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c));
    //     WarehouseCurrencies += warehouseCurrencies;
    //
    //     // if (num2 > 0)
    //     // {
    //     //     //XPLevel.EarnXP(num2, earnSource);
    //     // }
    //
    //     if (currencies.SumValues > 0)
    //     {
    //         FireCurrenciesEarnedEvent(currencies);
    //     }
    //
    //     FireBalanceChangedEvent(allCurrencies, earnSource);
    //     return true;
    // }
    //
    // //NẾU LÀ LOẠI TIỀN NONWAHEHOSE THÌ REUTNR 0 VÀ CỘNG VÔ
    // public long OverCapCurrencies(Currencies currencies)
    // {
    //     if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
    //     {
    //         return 0L;
    //     }
    //
    //     //NẾU KHÔNG THÌ LẤY LỌC NONWAREHOUSE RA VÀ CỘNG WAHOUSE VÀO VÀ TRỪ ĐI SỐ MAX WAREHOUSE >0 TỨC LÀ THƯA
    //     Currencies currencies2 = WarehouseCurrencies + FilterNonWarehouseCurrencies(currencies);
    //     return 0L;
    // }
    //
    // public static Currencies FilterNonWarehouseCurrencies(Currencies currencies)
    // {
    //     return currencies.Filter((string c, long v) => !_nonWarehouseCurrencyNames.Contains(c));
    // }
    //
    // #endregion
    //
    //
    // #region CURRENCY ?????LÀ LƯU LẺ 1 FIED 1 LOẠI TIỀN DUY NHÂT PHẢI CONVER SANG CURRENCIES ĐỂ MÀ LÀM VS BALANCE
    //
    // public bool CanEarnCurrencies(Currency currency)
    // {
    //     return CanEarnCurrencies(currency.ToCurrencies());
    // }
    //
    // public bool CanEarnCurrencies(Currencies currencies)
    // {
    //     if (currencies.ContainsOnly(_nonWarehouseCurrencyNames))
    //     {
    //         return true;
    //     }
    //
    //     return OverCapCurrencies(currencies) <= 0;
    // }
    //
    // public bool EarnCurrencies(Currency currency, object earnSource = null)
    // {
    //     return EarnCurrencies(currency.ToCurrencies(), earnSource);
    // }
    //
    // #endregion
    //
    //
    // #region TIỆN ÍCH::MISSIONG VÀ GIÁ KIM CƯƠNG
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
    // //TÍNH TOÁN CÒN THIẾU BAO NHIÊU CURRENCIES MỚI ĐỦ ĐỂ SPEND
    // //NẾU SỬ DỤNG GEM THÌ THÌ SẼ TÍNH TOÁN LẠI VS SỐ GEM TẠM THỜI CHƯA CẦN QUAN TÂM CÁI NÀY BỎ QUA
    // public Currencies MissingCurrencies(Currencies currencies, bool useGems = false)
    // {
    //     currencies = FilterXP(currencies);
    //     //DÙNG CHECK TRUYỀN CURRENCUES VÀO VÀ SO SÁNH VS CURRENCY HIỆN TẠI V TRẢ VỀ LƯỢNG THIẾU :::KIỂU GIÁ TRỊ THIẾU
    //     Currencies currencies2 = AllCurrencies.MissingCurrencies(currencies);
    //     if (useGems)
    //     {
    //         currencies2 =
    //             AllCurrencies.MissingCurrencies(currencies - currencies2 + CalculatePurchaseCost(currencies2));
    //     }
    //
    //     return currencies2;
    // }
    //
    // //TẠM BỎ QUA CHƯA XÉT TỚI GIÁ BẰNG KIM CƯƠNG
    // public Currencies CalculatePurchaseCost(Currencies currencies)
    // {
    //     Currencies result = new Currencies();
    //     int keyCount = currencies.KeyCount;
    //     for (int i = 0; i < keyCount; i++)
    //     {
    //         string key = currencies.GetKey(i);
    //         if (_props.AllCurrencyNames.Contains(key))
    //         {
    //             EntityCurrencyProperties properties = _props.GetProperties<EntityCurrencyProperties>(key);
    //             //GIÁ TIÊN Ở TRONG
    //             result += properties.PurchaseCost * currencies.GetValue(key);
    //         }
    //         else
    //         {
    //             result += new Currencies(key, currencies.GetValue(key));
    //         }
    //     }
    //
    //     return result;
    // }
    //
    //
    //
    // public Currencies CalculateMissingPurchaseCost(Currencies currencies)
    // {
    //     Currencies currencies2 = MissingCurrencies(currencies);
    //     return currencies - currencies2 + CalculatePurchaseCost(currencies2);
    // }
    //
    // public long GetValue(CurrencyType type)
    // {
    //     return GetValue(type.ToCurrencyName());
    // }
    //
    // public long GetValue(string currency)
    // {
    //     if (_nonWarehouseCurrencyNames.Contains(currency))
    //     {
    //         // if (currency == _xpCurrencyKey)
    //         // {
    //         //     return XPLevel.XP;
    //         // }
    //         return _currencies.GetValue(currency);
    //     }
    //
    //     return WarehouseCurrencies.GetValue(currency);
    // }
    //
    // #endregion
    //
    //
    // #region FOR NHẢ TIỀN RA SPEND TIỀN RA NGOÀI:::
    //
    // public bool CanSpendCurrencies(Currency currency, bool useGems = false)
    // {
    //     return CanSpendCurrencies(currency.ToCurrencies(), useGems);
    // }
    //
    // public bool CanSpendCurrencies(Currencies currencies, bool useGems = false)
    // {
    //     currencies = FilterXP(currencies);
    //     return MissingCurrencies(currencies, useGems).IsEmpty();
    // }
    //
    // public bool SpendCurrencies(Currency currency, bool useGems = false, Drain drain = Drain.None)
    // {
    //     return SpendCurrencies(currency.ToCurrencies(), useGems, drain);
    // }
    //
    //
    // public bool SpendCurrencies(Currencies currencies, bool useGems = false,
    //     Drain drain = Drain.None)
    // {
    //     //LỌC BỎ XP RA KHỎI
    //     currencies = FilterXP(currencies);
    //     //RETURN RA NẾU SỬ DỤNG GEM THÌ SẼ DÙNG GEM THANH TOÁN XEM ĐƯỢC BN K THÌ NẾU THU THÌ TRẢ VỀ SỐ THIẾU CURRENCY
    //     Currencies currencies2 = MissingCurrencies(currencies, useGems);
    //     if (!currencies2.IsEmpty())
    //     {
    //         Debug.LogWarningFormat("[Balance] Failed to spend currencies. Missing: {0}", currencies2);
    //         FireInsufficientBalanceEvent(currencies2, useGems);
    //         return false;
    //     }
    //
    //     //NẾU MÀ TRÔNG KHÔNG CÓ GÌ THÌ TỨC LÀ SẠCH THANH TOÁN R TIH TOÁN MISSINOG COST 
    //     currencies = CalculateMissingPurchaseCost(currencies);
    //
    //     //FILLTER BỎ LOẠI KHÔNG WAREHOUSE RA TRỪ TIỀN 2 LOẠI CURRENYC
    //     Currencies allCurrencies = AllCurrencies;
    //     Currencies warehouseCurrencies = FilterNonWarehouseCurrencies(currencies);
    //     _currencies -= currencies.Filter((string c, long v) => !warehouseCurrencies.Contains(c));
    //     WarehouseCurrencies -= warehouseCurrencies;
    //     if (currencies.SumValues > 0)
    //     {
    //         FireCurrenciesSpendEvent(currencies, drain);
    //     }
    //
    //     FireBalanceChangedEvent(allCurrencies, null);
    //     return true;
    // }
    //
    // #endregion
    //
    // #region SAVE AND LOAD
    //
    // private StorageDictionary _storage;
    //
    // public Balance(StorageDictionary storage)
    // {
    //     _storage = storage;
    //     //XPLevel = new XPLevel(_storage.GetStorageDict("XPLevel"));
    //     _currencies = new Currencies(_storage.GetStorageDict("Currencies"));
    //     WarehouseCurrencies = new Currencies(_storage.GetStorageDict("WarehouseCurrencies"));
    // }
    //
    // public StorageDictionary Serialize()
    // {
    //     if (_storage == null)
    //     {
    //         _storage = new StorageDictionary();
    //     }
    //
    //     _storage.Set("Currencies", _currencies);
    //     _storage.Set("WarehouseCurrencies", WarehouseCurrencies);
    //     //_storage.Set("XPLevel", XPLevel);
    //     return _storage;
    // }
    //
    // public void ResolveDependencies(Properties properties)
    // {
    //     _props = properties;
    // }

    //#endregion
}