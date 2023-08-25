using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrencyView : MonoBehaviour
{
    [SerializeField] private CurrencyType currencyType;
    [SerializeField] private TMP_Text txtValue;

    private GeneralBalance _generalBalance;

    //Mở mua gói bỏ qua sau
    private PopupManager _popupManager;

    private decimal _currentValue;

    private decimal _endValue;

    private float _tweenTime = 1f;

    private void OnDestroy()
    {
        if (_generalBalance != null)
        {
            _generalBalance.BalanceChangedEvent -= OnBalanceChanged;
        }
    }

    public void Init(GeneralBalance generalBalance, PopupManager popupManager)
    {
        _generalBalance = generalBalance;
        _popupManager = popupManager;
        _generalBalance.BalanceChangedEvent += OnBalanceChanged;
        _endValue = _generalBalance.GetValue(currencyType);
        UpdateValue(_endValue);
    }

    protected void UpdateValue(decimal value)
    {
        _currentValue = value;
        txtValue.text = _currentValue.ToString();
    }

    private void OnBalanceChanged(Currencies oldBalance, Currencies newBalance, object earnSource)
    {
        long num = newBalance.GetValue(currencyType) - oldBalance.GetValue(currencyType);
        if (num != 0)
        {
            _endValue += (decimal)num;
            UpdateValue(_endValue);
        }
    }
}