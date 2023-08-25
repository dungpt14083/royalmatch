using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemRewardTrainInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text txtCount;
    [SerializeField] private Image iconReward;
    public void Show(Currency valueReward)
    {
        gameObject.SetActive(true);
        txtCount.text = valueReward.Amount.ToString();
        iconReward.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(valueReward.Name));
    }
}
