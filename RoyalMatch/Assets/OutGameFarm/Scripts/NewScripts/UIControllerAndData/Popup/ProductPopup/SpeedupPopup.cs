using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedupPopup : MonoBehaviour
{
    [SerializeField] private Button btClose;
    [SerializeField] private Button btBuy;
    [SerializeField] private Image iconMoney;
    [SerializeField] private TMP_Text txtValue;
    [SerializeField] private Button btCancel;
    public void Open(PopupRequest request)
    {
        gameObject.SetActive(true);
        SpeedupPopupRequest request1 = request as SpeedupPopupRequest;
        Currency currencyBuy = request1.currencyBuy;
        btClose.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(Close);
        btBuy.onClick.RemoveAllListeners();
        btBuy.onClick.AddListener(() => Buy(currencyBuy, request1.buildingData, request1.actionSpeedUpComplete));
        btCancel.onClick.RemoveAllListeners();
        btCancel.onClick.AddListener(Cancel);
        //iconMoney.sprite = SingletonMonobehaviour<CurrencyAssetCollection>.Instance.GetAsset(currencyBuy);
        txtValue.text = currencyBuy.Amount.ToString();
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void Cancel()
    {
        Close();
    }
    public void Buy(Currency currency, BuildingData buildingData, Action actionSpeedUped)
    {
        var status = buildingData.SpeedUpProduct(currency);
        if (status)
        {
            actionSpeedUped?.Invoke();
        }
        gameObject.SetActive(false);
    }
}
