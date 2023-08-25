using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaterialUpgradeItem : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Image status;
    [SerializeField] private TMP_Text txtInfoRequire;
    [SerializeField] private Image iconMoney;
    [SerializeField] private TMP_Text txtBuyValue;
    [SerializeField] private Button btBuy;
    [SerializeField] private Button btFind;
    //private long buyAmount;
    private EntityCurrencyProperties itemInfo;
    Action<Currency, Currency, Action> openBuyItem;
    Currency currencyLimit;

    public void Show(Currency _currencyLimit, Action<Currency, Currency, Action> _openBuyItem)
    {
        gameObject.SetActive(true);
        btBuy.onClick.RemoveAllListeners();
        btFind.onClick.RemoveAllListeners();
        currencyLimit = _currencyLimit;
        openBuyItem = _openBuyItem;
       
        var spr = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(currencyLimit.Name));
        icon.sprite = spr;
        UpdateItemInfo();
    }
    private void Buy(Currency currencyBuy, Currency currencyMaterial)
    {
        openBuyItem?.Invoke(currencyBuy, currencyMaterial, UpdateItemInfo);
    }
    private void Find()
    {

    }
    public void UpdateItemInfo()
    {
        var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(currencyLimit.Name);
        string color = currentCountMerterial < currencyLimit.Amount ? "red" : "green";
        txtInfoRequire.text = $"<color={color}>{currentCountMerterial}</color>/{currencyLimit.Amount}";
        itemInfo = FarmMapController.Instance.GetGeneralPropertiesBykey(currencyLimit.Name);
        if (currentCountMerterial < currencyLimit.Amount)
        {
            status.gameObject.SetActive(false);
            btFind.onClick.AddListener(Find);
            Currency currencyBuy = null;
            if(itemInfo != null) currencyBuy = new Currency(CurrencyType.gems, (currencyLimit.Amount - currentCountMerterial) * itemInfo.PurchaseCost.Amount);

            Currency currencyMaterial = new Currency(currencyLimit.Name, currencyLimit.Amount - currentCountMerterial);
            btBuy.onClick.AddListener(() => Buy(currencyBuy, currencyMaterial));
            //if (itemInfo != null) buyAmount = itemInfo.PurchaseCost.Amount;
            //iconMoney.sprite = SingletonMonobehaviour<CurrencyAssetCollection>.Instance.GetAsset(currencyBuy);
            txtBuyValue.text = currencyBuy?.Amount.ToString();
        }
        else
        {
            status.gameObject.SetActive(true);
            btFind.gameObject.SetActive(false);
            btBuy.gameObject.SetActive(false);
        }
    }
}
