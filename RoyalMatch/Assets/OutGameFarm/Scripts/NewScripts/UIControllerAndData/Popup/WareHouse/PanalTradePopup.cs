using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PanalTradePopup : MonoBehaviour
{
    [SerializeField] private WareHousePopup _wareHousePopup;
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private TMP_Text txtContent;
    [SerializeField] private TMP_Text txtCost;
    [SerializeField] private Button btnTrade;
    [SerializeField] private TMP_InputField _edtSell;
    [SerializeField] private Button btnAdd;
    [SerializeField] private Button btnRemove;
    private KeyValuePair<EntityCurrencyProperties, long> _Data;
    
    public delegate void OnPopupActiveChanged(bool active);
    public event OnPopupActiveChanged PopupActiveChanged;
    private void Awake()
    {
        btnAdd.onClick.AddListener(AddValue);
        btnRemove.onClick.AddListener(RemoveValue);
        _edtSell.onValueChanged.AddListener(OnSellValueChanged);
        _edtSell.contentType = TMP_InputField.ContentType.IntegerNumber;
        btnTrade.onClick.AddListener(SpenCurrencies);
    }

    public void Init(KeyValuePair<EntityCurrencyProperties, long> data)
    {
        _Data = data;
        txtName.text = data.Key.NameItem;
        txtCost.text = data.Key.CostSell.Amount.ToString();
        long values = data.Value / 2;
        int roundedValue = Mathf.CeilToInt(values);
        if (roundedValue <= 0)
        {
            roundedValue = 1;
        }
        _edtSell.text = roundedValue.ToString();
        CheckValueState();
    }

    private void CaculatorCost()
    {
        int num = int.Parse(_edtSell.text);
        long AmountCost = 0;
        for (int i = 0; i < num; i++)
        {
            AmountCost += _Data.Key.CostSell.Amount;
        }

        txtCost.text = AmountCost.ToString();
    }

    private void SpenCurrencies()
    {
        
        int cost = int.Parse(_edtSell.text);
        int earnCost = int.Parse(txtCost.text);
        Currencies currency = new Currencies(_Data.Key.CurrencyName, cost);

        if (FarmMapController.Instance.GeneralBalance.SpendCurrencies(currency))
        {
            Currencies currencies = new Currencies(_Data.Key.CostSell.Name, earnCost);
            if (FarmMapController.Instance.GeneralBalance.EarnCurrencies(currencies))
            {
                _wareHousePopup.Refresh();
                ClosePopup();
            }
            //  FarmMapController.Instance.EarnCurrencies(currencies);
           
        }
    }
    private void OnSellValueChanged(string value)
    {

        try
        {
            int currentValue = int.Parse(value);
            currentValue = Mathf.Clamp(currentValue, 0, (int)_Data.Value);
            _edtSell.text = currentValue.ToString();
            CheckValueState();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
    private void CheckValueState()
    {
        int currentValue = int.Parse(_edtSell.text);
        btnAdd.interactable = currentValue < _Data.Value;
        btnRemove.interactable = currentValue > 0;
        CaculatorCost();
    }
    public void RemoveValue()
    {
        int currentValue = int.Parse(_edtSell.text);
        currentValue--;
        if (currentValue <= 0)
        {
            currentValue = 0;
        }
        _edtSell.text = currentValue.ToString();
        CheckValueState();
    }
    
    public void AddValue()
    {
        int currentValue = int.Parse(_edtSell.text);
        currentValue++;
        if (currentValue >= _Data.Value)
        {
            currentValue = (int)_Data.Value;
        }
        _edtSell.text = currentValue.ToString();
        CheckValueState();
    }
    public void ClosePopup()
    {
        bool isActive = this.gameObject.activeSelf;
        this.gameObject.SetActive(!isActive);
        PopupActiveChanged?.Invoke(isActive);
    }
 
}
