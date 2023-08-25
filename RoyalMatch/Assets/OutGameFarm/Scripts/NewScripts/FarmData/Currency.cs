using System;
using System.Collections.Generic;

public class Currency : ICanSerialize
{
    private const string NameKey = "Name";

    private const string AmountKey = "Amount";

    public string Name { get; private set; }

    public long Amount { get; private set; }

    public Currency(string name, long amount)
    {
        Name = name;
        Amount = amount;
    }

    public Currency(CurrencyType type, long amount)
        : this(type.ToCurrencyName(), amount)
    {
    }

    public Currency(Currency currency, long amount)
        : this(currency.Name, amount)
    {
    }


    public static Currency Empty(Currency c)
    {
        if (c == null)
        {
            return null;
        }

        return Empty(c.Name);
    }

    public static Currency Empty(CurrencyType type)
    {
        return Empty(type.ToCurrencyName());
    }

    public static Currency Empty(string name)
    {
        return new Currency(name, 0L);
    }

    public static bool TryParse(string currenciesFormat, out Currency result)
    {
        if (string.IsNullOrEmpty(currenciesFormat))
        {
            result = Empty(string.Empty);
            return true;
        }

        result = null;
        if (!currenciesFormat.Contains(","))
        {
            return false;
        }

        string[] array = currenciesFormat.Split(',');
        if (array.Length != 2)
        {
            return false;
        }

        long result2;
        if (!long.TryParse(array[1], out result2))
        {
            return false;
        }

        result = new Currency(array[0], result2);
        return true;
    }

    public Currency Cap(long cap)
    {
        return new Currency(Name, Math.Min(cap, Amount));
    }

    public bool IsMissingCurrency(Currency c)
    {
        if (!IsMatchingName(c))
        {
            return true;
        }

        return c.Amount > Amount;
    }

    public Currency MissingCurrency(Currency c)
    {
        long num = Amount - c.Amount;
        if (num < 0)
        {
            return new Currency(c.Name, -num);
        }

        return Empty(c);
    }

    public bool IsEmpty()
    {
        return Amount == 0;
    }

    public bool IsMatchingName(CurrencyType type)
    {
        return IsMatchingName(type.ToCurrencyName());
    }

    public bool IsMatchingName(Currency c)
    {
        return IsMatchingName(c.Name);
    }

    public bool IsMatchingName(string name)
    {
        return !string.IsNullOrEmpty(Name) && Name == name;
    }

    public Currencies ToCurrencies()
    {
        return new Currencies(this);
    }

    public override bool Equals(object obj)
    {
        if (base.Equals(obj))
        {
            return true;
        }

        if (obj is Currency)
        {
            Currency currency = (Currency)obj;
            return this == currency;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Amount.GetHashCode();
    }

    public override string ToString()
    {
        return "{" + Name + ":" + Amount + "}";
    }


    
    
    
    
    
    
    
    

    #region OPERATOR::::::

    public static bool operator ==(Currency c1, Currency c2)
    {
        if (object.ReferenceEquals(c1, null))
        {
            if (object.ReferenceEquals(c2, null))
            {
                return true;
            }

            return false;
        }

        if (object.ReferenceEquals(c2, null))
        {
            return false;
        }

        return c1.Name == c2.Name && c1.Amount == c2.Amount;
    }

    public static bool operator !=(Currency c1, Currency c2)
    {
        return !(c1 == c2);
    }

    public static Currency operator -(Currency c)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, -c.Amount);
    }

    public static Currency operator +(Currency c1, Currency c2)
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

        if (!c1.IsMatchingName(c2))
        {
            throw new ArgumentException("Left Currency's name doesn't match right currency's name.");
        }

        return new Currency(c1.Name, c1.Amount + c2.Amount);
    }

    public static Currency operator +(Currency c, long amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, c.Amount + amount);
    }

    public static Currency operator +(long amount, Currency c)
    {
        return c + amount;
    }

    public static Currency operator -(Currency c1, Currency c2)
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

        if (!c1.IsMatchingName(c2))
        {
            throw new ArgumentException("Left Currency's name doesn't match right currency's name.");
        }

        return new Currency(c1.Name, c1.Amount - c2.Amount);
    }

    public static Currency operator -(Currency c, long amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, c.Amount - amount);
    }

    public static Currency operator -(long amount, Currency c)
    {
        return c - amount;
    }

    public static Currency operator *(Currency c, long amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, c.Amount * amount);
    }

    public static Currency operator *(long amount, Currency c)
    {
        return c * amount;
    }

    public static Currency operator *(Currency c, decimal amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, (long)((decimal)c.Amount * amount));
    }

    public static Currency operator *(decimal amount, Currency c)
    {
        return c * amount;
    }

    public static Currency operator *(Currency c, float amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, (long)((float)c.Amount * amount));
    }

    public static Currency operator *(float amount, Currency c)
    {
        return c * amount;
    }

    public static Currency operator /(Currency c, long amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, c.Amount / amount);
    }

    public static Currency operator /(long amount, Currency c)
    {
        return c * amount;
    }

    public static Currency operator /(Currency c, decimal amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, (long)((decimal)c.Amount / amount));
    }

    public static Currency operator /(decimal amount, Currency c)
    {
        return c / amount;
    }

    public static Currency operator /(Currency c, float amount)
    {
        if (object.ReferenceEquals(c, null))
        {
            return null;
        }

        return new Currency(c.Name, (long)((float)c.Amount / amount));
    }

    public static Currency operator /(float amount, Currency c)
    {
        return c / amount;
    }

    #endregion
    
    #region SAVE AND LOAD::

    private StorageDictionary _storage;

    public Currency(StorageDictionary storage)
    {
        _storage = storage;
        Name = _storage.Get("Name", "unknown");
        Amount = _storage.Get("Amount", 0L);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Name", Name);
        _storage.Set("Amount", Amount);
        return _storage;
    }

    #endregion

    public static CurrencyType GetCurrencyTypeByName(string _name)
    {
        CurrencyType type = CurrencyType.none;
        switch (_name.ToLowerInvariant())
        {
            case "grass":
                type = CurrencyType.grass;
                break;
            case "wood":
                type = CurrencyType.wood;
                break;
            case "stone":
                type = CurrencyType.stone;
                break;
            case "mission":
                type = CurrencyType.mission;
                break;
            case "string_":
                type = CurrencyType.string_;
                break;
            case "rope":
                type = CurrencyType.rope;
                break;
            case "cloth":
                type = CurrencyType.cloth;
                break;
            case "woodenplan":
                type = CurrencyType.woodenplan;
                break;
            case "pallet":
                type = CurrencyType.pallet;
                break;
            case "woodveneer":
                type = CurrencyType.woodveneer;
                break;
            case "quartzsand":
                type = CurrencyType.quartzsand;
                break;
            case "cement":
                type = CurrencyType.cement;
                break;
            case "bricks":
                type = CurrencyType.bricks;
                break;
            case "cowfeed":
                type = CurrencyType.cowfeed;
                break;
            case "chickenfeed":
                type = CurrencyType.chickenfeed;
                break;
            case "pigfeed":
                type = CurrencyType.pigfeed;
                break;
            case "milk":
                type = CurrencyType.milk;
                break;
            case "cream":
                type = CurrencyType.cream;
                break;
            case "cheese":
                type = CurrencyType.cheese;
                break;
            case "butter":
                type = CurrencyType.butter;
                break;
            case "tofu":
                type = CurrencyType.tofu;
                break;
            case "soymilk":
                type = CurrencyType.soymilk;
                break;
            case "egg":
                type = CurrencyType.egg;
                break;
            case "bread":
                type = CurrencyType.bread;
                break;
            case "cookies":
                type = CurrencyType.cookies;
                break;
            case "popcorn":
                type = CurrencyType.popcorn;
                break;
            case "cheeseburger":
                type = CurrencyType.cheeseburger;
                break;
            case "cornbread":
                type = CurrencyType.cornbread;
                break;
            case "pumpkinbread":
                type = CurrencyType.pumpkinbread;
                break;
            case "carrotbread":
                type = CurrencyType.carrotbread;
                break;
            case "strawbearrybread":
                type = CurrencyType.strawbearrybread;
                break;
            case "sandwich":
                type = CurrencyType.sandwich;
                break;
            case "cheesecake":
                type = CurrencyType.cheesecake;
                break;
            case "wheat":
                type = CurrencyType.wheat;
                break;
            case "corn":
                type = CurrencyType.corn;
                break;
            case "pumpkin":
                type = CurrencyType.pumpkin;
                break;
            case "carrot":
                type = CurrencyType.carrot;
                break;
            case "soybean":
                type = CurrencyType.soybean;
                break;
            case "strawberry":
                type = CurrencyType.strawberry;
                break;
            case "bacon":
                type = CurrencyType.bacon;
                break;
            case "baconwithegg":
                type = CurrencyType.baconwithegg;
                break;
            case "corndog":
                type = CurrencyType.corndog;
                break;
            case "coneydog":
                type = CurrencyType.coneydog;
                break;
            case "ricecasserole":
                type = CurrencyType.ricecasserole;
                break;
            case "sandwichcheesewithbacon":
                type = CurrencyType.sandwichcheesewithbacon;
                break;
            case "cornmilk":
                type = CurrencyType.cornmilk;
                break;
            case "blueberrymilk":
                type = CurrencyType.blueberrymilk;
                break;
            case "orangejuice":
                type = CurrencyType.orangejuice;
                break;
            case "applejuice":
                type = CurrencyType.applejuice;
                break;
            case "grapejuice":
                type = CurrencyType.grapejuice;
                break;
            case "tropicaljuice":
                type = CurrencyType.tropicaljuice;
                break;
            case "orange":
                type = CurrencyType.orange;
                break;
            case "apple":
                type = CurrencyType.apple;
                break;
            case "grape":
                type = CurrencyType.grape;
                break;
            case "key":
                type = CurrencyType.key;
                break;
            case "shovel":
                type = CurrencyType.shovel;
                break;
            case "pickaxe":
                type = CurrencyType.pickaxe;
                break;
            case "saw":
                type = CurrencyType.saw;
                break;
            case "stumpslim":
                type = CurrencyType.stumpslim;
                break;
            case "stumpnormal":
                type = CurrencyType.stumpnormal;
                break;
            case "stumpbig":
                type = CurrencyType.stumpbig;
                break;
            case "woodchest":
                type = CurrencyType.woodchest;
                break;
            case "bigchest":
                type = CurrencyType.bigchest;
                break;
            case "goldchest":
                type = CurrencyType.goldchest;
                break;
            case "diamondchest":
                type = CurrencyType.diamondchest;
                break;
            case "golds":
                type = CurrencyType.golds;
                break;
            case "gems":
                type = CurrencyType.gems;
                break;
            case "energy":
                type = CurrencyType.energy;
                break;
            case "live":
                type = CurrencyType.live;
                break;
            case "blueberry":
                type = CurrencyType.blueberry;
                break;
            case "redberry":
                type = CurrencyType.redberry;
                break;
            case "pineapple":
                type = CurrencyType.pineapple;
                break;
            case "seastar":
                type = CurrencyType.seastar;
                break;
            case "scallops":
                type = CurrencyType.scallops;
                break;
            case "openclam":
                type = CurrencyType.openclam;
                break;
            case "cactusflower":
                type = CurrencyType.cactusflower;
                break;
            case "mushrooms":
                type = CurrencyType.mushrooms;
                break;
            case "xp":
                type = CurrencyType.xp;
                break;
            case "bloomingcherrytree":
                type = CurrencyType.bloomingcherrytree;
                break;
        }
        return type;
    }
    //public static TradeInfo ToTradeInfo(this Currency _currency)
    //{
    //    TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)_currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(_currency.Name) };
    //    return tradeInfoCost;
    //}
    //public static List<TradeInfo> ToTradeInfos(this Currency _currency)
    //{
    //    TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)_currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(_currency.Name) };
    //    return new List<TradeInfo> { tradeInfoCost } ;
    //}
    //public static List<TradeInfo> ToTradeInfos(this Currencies currencies)
    //{
    //    List<TradeInfo> results = new List<TradeInfo>();
    //    if (currencies == null) return results;
    //    for (int i=0; i < currencies.KeyCount; i++)
    //    {
    //        var currency = currencies.GetCurrency(i);
    //        TradeInfo tradeInfoCost = new TradeInfo { TradeType = TradeType.Currency, Amount = (int)currency.Amount, IdInType = (int)Currency.GetCurrencyTypeByName(currency.Name) };
    //        results.Add(tradeInfoCost);
    //    }
        
    //    return results;
    //}
}