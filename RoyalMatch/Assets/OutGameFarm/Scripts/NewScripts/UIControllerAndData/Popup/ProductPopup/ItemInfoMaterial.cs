using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoMaterial : MonoBehaviour
{
    [SerializeField] private Image iconMaterial;
    [SerializeField] private TMP_Text txtStatus;
    public void Show(Currency currency)
    {
        var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(currency.Name);
        Show(currentCountMerterial, currency);
    }
    public void Show(long currentCountMerterial, Currency currency)
    {
        gameObject.SetActive(true);
        iconMaterial.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(currency.Name));
        string color = currentCountMerterial < currency.Amount ? "red" : "green";
        txtStatus.text = $"<color={color}>{currentCountMerterial}</color>/{currency.Amount}";
    }
}
