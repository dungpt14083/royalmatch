using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AirplaneQuestDetailInfo : MonoBehaviour
{
    [SerializeField] private ItemInfoDetailAirplane itemInfoDetailAirplanePrefab;
    [SerializeField] private Transform itemInfoDetailAirplaneParent;
    [SerializeField] private Button btRemove;
    [SerializeField] private Button btDelivery;
    [SerializeField] private Button btSkip;
    [SerializeField] private Image iconMoneySkip;
    [SerializeField] private TMP_Text txtValueSkip;
    [SerializeField] private TMP_Text txtTimeSkip;

    [SerializeField] private GameObject objSkipInfo;
    [SerializeField] private GameObject objInfo;
    [SerializeField] private BuyItemAirplanePopup buyItemAirplanePopup;
    Func<AirplaneQuestItem, bool> actionRemove;
    Func<AirplaneQuestItem, bool> actionDelivery;
    Func<AirplaneQuestItem, bool> actionSkip;
    float timeRemove;
    long valueBuy;
    Currencies missingMaterials;
    AirplaneQuestItem airplaneQuestItem;
    public Action updateData;
    public void Show(AirplaneQuestItem _airplaneQuestItem, Func<AirplaneQuestItem, bool> _actionRemove, Func<AirplaneQuestItem, bool> _actionDelivery, Func<AirplaneQuestItem, bool> _actionSkip)
    {
        gameObject.SetActive(true);
        if (_airplaneQuestItem.airplaneQuest == null)
        {
            objInfo.gameObject.SetActive(false);
            objSkipInfo.gameObject.SetActive(false);
            return;
        }
        airplaneQuestItem = _airplaneQuestItem;
        actionRemove = _actionRemove;
        actionDelivery = _actionDelivery;
        actionSkip = _actionSkip;
        valueBuy = 0;
        missingMaterials = new Currencies();
        for (int i = 0; i < airplaneQuestItem.airplaneQuest.quests.KeyCount; i++)
        {
            var itemQuest = airplaneQuestItem.airplaneQuest.quests.GetCurrency(i);
            UnityEngine.Debug.Log("airplaneQuestItem.airplaneQuest " + i);
            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(itemQuest.Name);
            
            var itemQuestProperties = FarmMapController.Instance.GetGeneralPropertiesBykey(itemQuest.Name);
            if (currentCountMerterial < itemQuest.Amount)
            {
                long countMissing = itemQuest.Amount - currentCountMerterial;
                valueBuy += countMissing * itemQuestProperties.PurchaseCost.Amount;
                missingMaterials.SetValue(itemQuest.Name, countMissing);
            }
        }
        ShowInfo(_airplaneQuestItem);

    }
    private void ShowInfo(AirplaneQuestItem _airplaneQuestItem)
    {
        airplaneQuestItem = _airplaneQuestItem;
        objInfo.gameObject.SetActive(true);
        objSkipInfo.gameObject.SetActive(false);
        itemInfoDetailAirplaneParent.ClearAllChild();
        timeRemove = 0;
        btRemove.onClick.RemoveAllListeners();
        btRemove.onClick.AddListener(() => Remove(_airplaneQuestItem));
        btDelivery.onClick.RemoveAllListeners();
        btDelivery.onClick.AddListener(() => Delivery(_airplaneQuestItem));
        for (int i = 0; i < _airplaneQuestItem.airplaneQuest.quests.KeyCount; i++)
        {
            var info = _airplaneQuestItem.airplaneQuest.quests.GetCurrency(i);
            var item = itemInfoDetailAirplaneParent.CreateChild(itemInfoDetailAirplanePrefab);
            item.Show(info);
        }
    }
    private void ShowSkip(AirplaneQuestItem _airplaneQuestItem)
    {
        timeRemove = _airplaneQuestItem.airplaneQuest.timeRemove;
        objInfo.gameObject.SetActive(false);
        objSkipInfo.gameObject.SetActive(true);
        iconMoneySkip.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(CurrencyType.gems);
        txtValueSkip.text = _airplaneQuestItem.airplaneQuest.skipTime.Amount.ToString();
        btSkip.onClick.AddListener(()=> Skip(_airplaneQuestItem));
    }
    public void Remove(AirplaneQuestItem _airplaneQuestItem)
    {
        if(actionRemove?.Invoke(_airplaneQuestItem) == true)
        {
            ShowSkip(_airplaneQuestItem);
        }
    }
    public void Delivery(AirplaneQuestItem _airplaneQuestItem)
    {
        if (!_airplaneQuestItem.airplaneQuest.IsDelivery())
        {
            ShowBuyItemPopup(valueBuy, _airplaneQuestItem.airplaneQuest);
        }
        else
        {
            if (actionDelivery?.Invoke(_airplaneQuestItem) == true)
            {
            }
        }
    }
    public void ShowBuyItemPopup(long countBuy, AirplaneQuestProperties airplaneQuestProperties)
    {
        buyItemAirplanePopup.Show(countBuy, airplaneQuestProperties,BuyMaterials);
    }
    public void BuyMaterials()
    {
        if (missingMaterials == null) return;
        var status = FarmMapController.Instance.SpendCurrencies(missingMaterials);
        
        if (status)
        {
            updateData?.Invoke();
        }
        airplaneQuestItem.Click();
    }
    public void Skip(AirplaneQuestItem _airplaneQuestItem)
    {
        if (actionSkip?.Invoke(_airplaneQuestItem) ==true)
        {
            _airplaneQuestItem.Click();
        }
        else
        {
            UnityEngine.Debug.Log("Skip fail");
        }
    }
    private void Update()
    {
        if(timeRemove > 0)
        {
            timeRemove -= Time.deltaTime;
            if (timeRemove < 0) timeRemove = 0;
            txtTimeSkip.text = TimeSpan.FromSeconds(timeRemove).ToString(@"m\:ss");
        }
    }
}
