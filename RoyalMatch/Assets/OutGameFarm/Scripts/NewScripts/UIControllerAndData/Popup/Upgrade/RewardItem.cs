using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RewardItem : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text txtValue;
    public void Show(Currency reward)
    {
        var spr = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(reward.Name));
        icon.sprite = spr;
        txtValue.text = reward.Amount.ToString();
        gameObject.SetActive(true);
    }
}
