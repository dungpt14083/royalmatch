using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePopup : Popup
{
    [SerializeField] private RewardItem rewardItemPrefab;
    [SerializeField] private Transform rewardsParent;
    [SerializeField] private MaterialUpgradeItem materialUpgradeItemPrefab;
    [SerializeField] private Transform merterialsParent;
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text txtLevelHouse;
    [SerializeField] private Button btUpgrade;
    [SerializeField] private Button btNoti;
    [SerializeField] private Button btClose;
    [SerializeField] private TMP_Text txtNameHouse;
    [SerializeField] private TMP_Text txtNoti;
    [SerializeField] private BuyItemsPopup buyItemsPopup;
    BuildingData buildingData;

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        LoadUpgrade(request);
    }
    private void ClearReward()
    {
        foreach(Transform chil in rewardsParent)
        {
            Destroy(chil.gameObject);
        }
    }
    private void ClearMerterial()
    {
        foreach (Transform chil in merterialsParent)
        {
            Destroy(chil.gameObject);
        }
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
    }

    public override void Close()
    {
        base.Close();
    }
    public override void OnCloseClicked()
    {
        base.OnCloseClicked();
    }
    
    
    
    private void Upgrade(BuildingData building,Sprite sprIcon)
    {
        var materials = building.GetMerterials();
        if ((building as UpgradeHouse).CheckMaterials(materials))
        {
            var statusUpgrade = building.UpgradeWithMaterials();
            if (statusUpgrade)
            {
                LoadUpgrade(new UpgradePopupRequest(building, sprIcon));
            }
            OnCloseClicked();
        }
        else
        {
            long valueBuy = 0;
            var missingMaterials = new Currencies();
            for (int i = 0; i < materials.KeyCount; i++)
            {
                var itemQuest = materials.GetCurrency(i);
                var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(itemQuest.Name);
                var itemQuestProperties = FarmMapController.Instance.GetGeneralPropertiesBykey(itemQuest.Name);
                if (currentCountMerterial < itemQuest.Amount)
                {
                    long countMissing = itemQuest.Amount - currentCountMerterial;
                    valueBuy += countMissing * itemQuestProperties.PurchaseCost.Amount;
                    missingMaterials.SetValue(itemQuest.Name, countMissing);
                }
            }
            var request = new BuyItemsPopupRequest(materials, valueBuy,() => {
                var status = FarmMapController.Instance.BuyMaterials(new Currency(CurrencyType.gems.ToString(), valueBuy), true, missingMaterials);
                if (status) LoadUpgrade(_request);
            });
            buyItemsPopup.Open(request);
        }
    }
    private void LoadUpgrade(PopupRequest upgradePopupRequest)
    {
        btClose.onClick.RemoveAllListeners();
        btNoti.onClick.RemoveAllListeners();
        btUpgrade.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(OnCloseClicked);
        btNoti.onClick.AddListener(Noti);
        ClearReward();
        ClearMerterial();
        
        UpgradePopupRequest request1 = (UpgradePopupRequest)upgradePopupRequest;
        buildingData = request1.data;
        btUpgrade.onClick.AddListener(() => Upgrade(request1.data, request1.GetSprite()));
        icon.sprite = request1.GetSprite();
        int level = request1.data.GetLevel();
        int levelLimit = request1.data.GetLevelLimit();
        txtLevelHouse.text = $"Level :{level}/{levelLimit}";
        string nameBuilding = request1.data.GetName();
        txtNameHouse.text = nameBuilding;
        var rewards = request1.data.GetRewards();
        //load reward show lên hiển thị 
        if (rewards != null)
        {
            foreach (var reward in rewards)
            {
                var rewardItem = GameObject.Instantiate(rewardItemPrefab, rewardsParent);
                rewardItem.Show(reward);
            }
        }
        //load Merterials
        var merterials = request1.data.GetMerterials();
        if (merterials != null)
        {
            for (int i = 0; i < merterials.KeyCount; i++)
            {
                var merterial = merterials.GetCurrency(i);
                var materialUpgradeItem = GameObject.Instantiate(materialUpgradeItemPrefab, merterialsParent);
                materialUpgradeItem.Show(merterial, OpenBuyItemPopup);
            }
        }
    }
    
    
    
    
    
    
    private void Noti()
    {
        txtNoti.transform.parent.gameObject.SetActive(!txtNoti.transform.parent.gameObject.activeInHierarchy);
    }
    public void OpenBuyItemPopup(Currency moneyBuyItems, Currency currencyMaterial, Action callbackUpdateMaterialItem)
    {
        var request = new BuyItemsPopupRequest(moneyBuyItems, () => {
           var status = BuyItem(moneyBuyItems, currencyMaterial);
            if (status) callbackUpdateMaterialItem?.Invoke();
        });
        buyItemsPopup.Open(request);
    }
    public bool BuyItem(Currency currency,Currency currencyMaterial)
    {
        bool buyStatus = FarmMapController.Instance.BuyMaterial(currency, true, currencyMaterial);
        return buyStatus;
    }
}
