using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyItemAirplanePopup : MonoBehaviour
{
    [SerializeField] private Image iconMoneySkip;
    [SerializeField] private TMP_Text txtValueSkip;
    [SerializeField] private Button btBuy;
    [SerializeField] private Button btCancel;
    [SerializeField] private Button btClose;
    [SerializeField] private ItemInfoDetailAirplane itemInfoDetailAirplanePrefab;
    [SerializeField] private Transform itemInfoDetailAirplaneParent;
    Action actionBuy;
    public void Show(long countBuy, AirplaneQuestProperties airplaneQuestProperties, Action _actionBuy)
    {
        gameObject.SetActive(true);
        actionBuy = _actionBuy;
        iconMoneySkip.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(CurrencyType.gems);
        txtValueSkip.text = countBuy.ToString();
        btBuy.onClick.RemoveAllListeners();
        btCancel.onClick.RemoveAllListeners();
        btClose.onClick.RemoveAllListeners();
        btBuy.onClick.AddListener(Buy);
        btCancel.onClick.AddListener(Close);
        btClose.onClick.AddListener(Close);
        itemInfoDetailAirplaneParent.ClearAllChild();
        for (int i = 0; i < airplaneQuestProperties.quests.KeyCount; i++)
        {

            var info = airplaneQuestProperties.quests.GetCurrency(i);
            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(info.Name);
            if (currentCountMerterial >= info.Amount) continue;
            var item = itemInfoDetailAirplaneParent.CreateChild(itemInfoDetailAirplanePrefab);
            item.Show(currentCountMerterial,info);
        }
    }
    private void Buy()
    {
        actionBuy?.Invoke();
        gameObject.SetActive(false);
    }
    private void Close()
    {
        gameObject.SetActive(false);
    }
}
