using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBalance : ICanSerialize
{
    public delegate void BalanceChangedEventHandler(Currencies oldBalance, Currencies newBalance, object earnSource);

    //invoke khi s dư k đủ
    public delegate void InsufficientBalanceEventHandler(Currencies missing, bool usedGems);

    //k đủ năng lực? KHẢ NWANG CHỨA CỦA KHO
    public delegate void InsufficientCapacityEventHandler(long overcap);

    //sự kiện khi trừ tiền
    public delegate void CurrenciesSpendEventHandler(Currencies spend, Drain drain);

    //s kiện khi nhận tiền
    public delegate void CurrenciesEarnedEventHandler(Currencies earned);
    
    

    public event BalanceChangedEventHandler BalanceChangedEvent;
    public event InsufficientBalanceEventHandler InsufficientBalanceEvent;
    public event InsufficientCapacityEventHandler InsufficientCapacityEvent;
    public event CurrenciesSpendEventHandler CurrenciesSpendEvent;
    public event CurrenciesEarnedEventHandler CurrenciesEarnedEvent;

    protected void FireBalanceChangedEvent(Currencies oldBalance, object earnSource)
    {
        if (this.BalanceChangedEvent != null)
        {
            this.BalanceChangedEvent(oldBalance, AllCurrencies, earnSource);
        }
    }

    protected void FireInsufficientBalanceEvent(Currencies missing, bool usedGems)
    {
        if (this.InsufficientBalanceEvent != null)
        {
            this.InsufficientBalanceEvent(missing, usedGems);
        }
    }

    protected void FireInsufficientCapacityEvent(long overcap)
    {
        if (this.InsufficientCapacityEvent != null)
        {
            this.InsufficientCapacityEvent(overcap);
        }
    }

    protected void FireCurrenciesSpendEvent(Currencies spend, Drain drain)
    {
        if (this.CurrenciesSpendEvent != null)
        {
            this.CurrenciesSpendEvent(spend, drain);
        }
    }

    protected void FireCurrenciesEarnedEvent(Currencies earned)
    {
        if (this.CurrenciesEarnedEvent != null)
        {
            this.CurrenciesEarnedEvent(earned);
        }
    }

    public virtual Currencies AllCurrencies { get; set; }


    #region SAVE AND LOAD:::

    public BaseBalance()
    {
    }

    protected StorageDictionary _storage;

    public BaseBalance(StorageDictionary storage)
    {
        _storage = storage;
    }

    public virtual StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        return _storage;
    }

    public virtual void ResolveDependencies(BaseProperties properties)
    {
        
    }

    #endregion
}