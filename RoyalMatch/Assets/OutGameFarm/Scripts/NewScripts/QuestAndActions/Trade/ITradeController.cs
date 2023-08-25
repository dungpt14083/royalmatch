using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CUNG CẤP CÁC HÀNH VI MẪU NHƯ ADD TRADEINFO VÀO REMOVE ĐI 
public interface ITradeController 
{
    bool Add(TradeInfo tradeInfo, string source);

    bool Remove(TradeInfo tradeInfo, string source);

    //KHÁC BIỆT???CHUYỂN TRADEINFO TO GEAM. GET SPRITE CHO TRADEINFO, GET TRANLATIONKEY, CRENTAMOUNT
    int Diff(TradeInfo tradeInfo);
    int ToGem(TradeInfo tradeInfo);
    Sprite GetSprite(TradeInfo tradeInfo);
    string GetTranslationKey(TradeInfo tradeInfo);
    long GetCurrentAmount(TradeInfo tradeInfo);
}
