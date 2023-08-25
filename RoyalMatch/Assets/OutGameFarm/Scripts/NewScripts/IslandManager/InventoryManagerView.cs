using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TẤT CẢ THÔNG QUA TRADEINFO VÀ SẼ ĐẨY QUA ĐÂY NỜ VIỆC ::::TYPE CỦA NÓ ĐĂNG KÍ::::
public class InventoryManagerView : MonoSingleton<InventoryManagerView>, ITradeController, IRequirementController
{
    [SerializeField] private TradeManager tradeManager;
    [SerializeField] private RequirementManager requirementManager;


    //ĐÂY LÕI TIỀN ĐẨY ĐƯỢC ĐẨY VÀO:::
    public GeneralBalance GeneralBalance { get; set; }

    public void Init(GeneralBalance generalBalance)
    {
        GeneralBalance = generalBalance;
    }

    private void Start()
    {
        tradeManager.RegisterTradeController(TradeType.Currency, this);

        //ĐĂNG KÍ CHO REQUIRMENTCHECK LÀ CURRENCY:::
        requirementManager.RegisterRequirementController(RequirementType.Currency, this);
    }


    //DỰA VÀO ĐÂY ĐẨY VÀO INVENTORY NÀY ĐẨY VÀO VẬY CÒN THẰNG 
    public bool Add(TradeInfo tradeInfo, string source)
    {
        if (tradeInfo.TradeType != TradeType.Currency) return false;
        return GeneralBalance.EarnCurrencies(tradeInfo);
    }


    public bool Remove(TradeInfo tradeInfo, string source)
    {
        if (tradeInfo.TradeType != TradeType.Currency) return false;

        return GeneralBalance.SpendCurrencies(tradeInfo);
    }

    public int Diff(TradeInfo tradeInfo)
    {
        return 0;
    }

    public int ToGem(TradeInfo tradeInfo)
    {
        return 0;
    }

    //CẤP ẢNH CHO THẰNG ITEM LẤY SẼ Ở ĐÂY::::
    public UnityEngine.Sprite GetSprite(TradeInfo tradeInfo)
    {
        return CurrencySpritesAssetCollection.Instance.GetAsset((CurrencyType)tradeInfo.IdInType);
    }

    public string GetTranslationKey(TradeInfo tradeInfo)
    {
        return "";
    }

    public long GetCurrentAmount(TradeInfo tradeInfo)
    {
        if (tradeInfo.TradeType != TradeType.Currency) return 0;
        return GeneralBalance.GetValue((CurrencyType)tradeInfo.IdInType);
    }

    public long GetCurrency(CurrencyType currencyType)
    {
        return GeneralBalance.GetValue(currencyType);
    }


    //CHECK TIỀN TỆ::::chỉ dành CHO GEM MÀ THÔI GAME NÀY Ở ĐÂY CHỈ DÀNH CHO GEM TYPE TỰ LẤY

    #region REQUIREMENT:::::::::

    public bool IsProvided(RequirementInfo requirement)
    {
        if (requirement.RequirementType != RequirementType.Currency) return false;
        if (GeneralBalance != null)
        {
            return GeneralBalance.CanSpendCurrencies(requirement);
        }

        return false;
    }

    #endregion


    public void DecCurrency(Currency currency)
    {
        GeneralBalance.SpendCurrencies(currency);
    }
}