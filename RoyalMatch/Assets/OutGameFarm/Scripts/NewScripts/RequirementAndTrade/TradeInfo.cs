using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PHẢI CONVER RA THẰNG TRADEINFO NÀY CHO NHẬN THƯỞNG:::CÁC THƯỞNG KHI XÂY NHÀ KHI NÀY KIA ĐỔI THÀNH
//TRADEINFO ĐỂ HỆ THỐNG SẼ LÀM VIỆC VỚI NÓ TRONG NÓ CÓ CẢ KÍCH HOẠT CUTSCENE NÀO:::
//TRADE NÀY THÊM CẢ CURRENCY VÀO NỮA::::currenty cho type là Currency thôi:::
[Serializable]
public class TradeInfo : IEquatable<TradeInfo>
{
    public TradeType TradeType;
    public int IdInType;
    public int Amount;
    //public Currencies Currencies;

    public TradeInfo()
    {

    }
    public TradeInfo(TradeInfo tradeInfo)
    {
        if (tradeInfo != null)
        {
            this.TradeType = tradeInfo.TradeType;
            this.IdInType = tradeInfo.IdInType;
        }
        else
        {
            this.TradeType = 0;
            this.IdInType = 0;
        }

        this.Amount = tradeInfo.Amount;

        //Currencies = tradeInfo.Currencies;
    }

    public TradeInfo(TradeType tradeInfoType, int typeId, int amount/*, Currencies currencies = null*/)
    {
        this.TradeType = tradeInfoType;
        this.IdInType = typeId;
        this.Amount = amount;
        //Currencies = currencies;
    }

    //SO SÁNH Ở ĐÂY LÀ IDINTYPE:::
    public bool Equals(TradeInfo other)
    {
        if (other == null)
        {
            return false;
        }

        if (ReferenceEquals(this, other))
        {
            return true;
        }

        if (TradeType != other.TradeType)
        {
            return false;
        }

        int difference = IdInType - other.IdInType;
        return difference != 0;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        if (ReferenceEquals(this, obj))
        {
            return true;
        }

        return false;
    }
}