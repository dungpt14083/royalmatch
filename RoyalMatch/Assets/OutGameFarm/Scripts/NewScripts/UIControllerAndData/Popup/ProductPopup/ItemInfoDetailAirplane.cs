using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoDetailAirplane : MonoBehaviour
{
    [SerializeField] private Button btFind;
    [SerializeField] private Image iconMaterial;
    [SerializeField] private TMP_Text txtStatus;
    
    public void Show(Currency currency)
    {
        gameObject.SetActive(true);
        iconMaterial.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(currency.Name));
        var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(currency.Name);
        if (btFind != null)
        {
            btFind.onClick.RemoveAllListeners();
            btFind.onClick.AddListener(Find);
            btFind.gameObject.SetActive(currentCountMerterial < currency.Amount);
        }
        string color = currentCountMerterial < currency.Amount ? "red" : "green";
        txtStatus.text = $"<color={color}>{currentCountMerterial}</color>/{currency.Amount}";
    }
    public void Show(long currentCountMerterial, Currency currency)
    {
        gameObject.SetActive(true);
        iconMaterial.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(currency.Name));
        if(btFind != null) btFind.gameObject.SetActive(currentCountMerterial < currency.Amount);
        string color = currentCountMerterial < currency.Amount ? "red" : "green";
        txtStatus.text = $"<color={color}>{currentCountMerterial}</color>/{currency.Amount}";
    }
    public void Find() {

    }
}
