using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemQuestTrain : MonoBehaviour
{
    [SerializeField] private Button btRemove;
    [SerializeField] private Button btBuy;
    [SerializeField] private Image iconMoney;
    [SerializeField] private TMP_Text txtCostBuy;
    [SerializeField] private Button btGive;
    [SerializeField] private TMP_Text txtNameQuest;
    [SerializeField] private Image iconQuest;
    [SerializeField] private TMP_Text txtStatus;
    private int index;
    Action<string> actionRemove;
    Func<string, bool> actionGive;
    Currency material;
    long currentMaterial;

    public void Show(int _index, Currency _material, Action<string> _actionRemove, Func<string, bool> _actionGive)
    {
        index = _index;
        material = _material;
        actionRemove = _actionRemove;
        actionGive = _actionGive;
        gameObject.SetActive(true);
        txtNameQuest.text = material.Name;
        iconQuest.sprite =
            SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(
                Currency.GetCurrencyTypeByName(material.Name));
        currentMaterial = FarmMapController.Instance.GetGeneralBalanceByKey(material.Name);
        string color = currentMaterial < material.Amount ? "red" : "green";
        txtStatus.text = $"<color={color}>{currentMaterial}</color>/{material.Amount}";
        if (currentMaterial < material.Amount)
        {
            btGive.gameObject.SetActive(false);
            btBuy.gameObject.SetActive(true);
            btBuy.onClick.AddListener(() => Buy());
            Currency currencyBuy = new Currency(CurrencyType.gems, material.Amount - currentMaterial);
            iconMoney.sprite =
                SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(CurrencyType.gems);
        }
        else
        {
            btGive.gameObject.SetActive(true);
            btBuy.gameObject.SetActive(false);
            btGive.onClick.AddListener(() => Give());
        }

        btRemove.onClick.AddListener(Remove);
    }

    public void Remove()
    {
        actionRemove?.Invoke(material.Name);
    }

    public bool Give()
    {
        bool? status = actionGive?.Invoke(material.Name);
        if (status == true)
        {
        }

        return true;
    }

    public bool Buy()
    {
        Currency buy = new Currency(CurrencyType.gems, material.Amount - currentMaterial);

        var status = FarmMapController.Instance.BuyMaterial(buy, true, material);
        if (status)
        {
            currentMaterial = FarmMapController.Instance.GetGeneralBalanceByKey(material.Name);
            string color = currentMaterial < material.Amount ? "red" : "green";
            txtStatus.text = $"<color={color}>{currentMaterial}</color>/{material.Amount}";
            if (currentMaterial < material.Amount)
            {
                btGive.gameObject.SetActive(false);
                btBuy.gameObject.SetActive(true);
                btBuy.onClick.AddListener(() => Buy());
                Currency currencyBuy = new Currency(CurrencyType.gems, material.Amount - currentMaterial);

                iconMoney.sprite =
                    SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(
                        Currency.GetCurrencyTypeByName(currencyBuy.Name));
            }
            else
            {
                btGive.gameObject.SetActive(true);
                btBuy.gameObject.SetActive(false);
                btGive.onClick.AddListener(() => Give());
            }
        }

        return status;
    }
}