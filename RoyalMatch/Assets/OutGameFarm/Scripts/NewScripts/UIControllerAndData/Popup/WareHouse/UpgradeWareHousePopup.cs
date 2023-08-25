using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeWareHousePopup : Popup
{
    [SerializeField] private RewardItem rewardItemPrefab;
    [SerializeField] private Transform rewardsParent;
    [SerializeField] private MaterialUpgradeItem materialUpgradeItemPrefab;
    [SerializeField] private Transform materialParent;
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text txtLevelHouse;
    [SerializeField] private Button btUpgrade;
    [SerializeField] private Button btNoti;
    [SerializeField] private Button btClose;
    [SerializeField] private TMP_Text txtNameHouse;
    [SerializeField] private TMP_Text txtNoti;
    [SerializeField] private BuyItemsPopup buyItemsPopup;
    private WareHouseBuilding buildingData;

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        LoadUpgrade(request);
    }

    private void ClearReward()
    {
        foreach (Transform child in rewardsParent)
        {
            DestroyImmediate(child.gameObject,true);
        }
    }

    private void ClearMaterial()
    {
        foreach (Transform child in materialParent)
        {
            DestroyImmediate(child.gameObject,true);
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

    private void Upgrade(WareHouseBuilding building,Sprite sprIcon)
    {
        if (building.LevelUpWithGems())
        {
            building.UpgradeSprite();
        }
        LoadUpgrade(new UpgradeWarehouseRequest(building,sprIcon));
        OnCloseClicked();
    }

    private void LoadUpgrade(PopupRequest upgradePopupRequest)
    {
        btClose.onClick.RemoveAllListeners();
        btNoti.onClick.RemoveAllListeners();
        btUpgrade.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(OnCloseClicked);
        btNoti.onClick.AddListener(Noti);
        ClearReward();
        ClearMaterial();
        UpgradeWarehouseRequest request = (UpgradeWarehouseRequest) upgradePopupRequest; 
        buildingData = request.Warehouse;
        btUpgrade.onClick.AddListener(()=> Upgrade(buildingData,request.GetSprite()));
        icon.sprite = request.GetSprite();
        int level = buildingData.Level;
        txtLevelHouse.text = $"Level: {level}";
        txtNameHouse.text = buildingData.BuildingProperties.NameItem;
        var rewards = buildingData.GetRewardsBuilding();
        if (rewards != null)
        {
            foreach (var reward in rewards)
            {
                var rewardItem = GameObject.Instantiate(rewardItemPrefab, rewardsParent);
                rewardItem.Show(reward);
            }
        }

        
        var materials = buildingData.GetMerterials();
        if (materials != null)
        {
            for (int i = 0; i < materials.KeyCount; i++)
            {
                var matertial = materials.GetCurrency(i);
                var materialUpgradeItem = GameObject.Instantiate(materialUpgradeItemPrefab, materialParent);
                materialUpgradeItem.Show(matertial,OpenBuyItemPopup);
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
