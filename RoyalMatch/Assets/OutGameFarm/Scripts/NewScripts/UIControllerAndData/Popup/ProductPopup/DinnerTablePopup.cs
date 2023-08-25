using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinnerTablePopup : ProducePopup
{
    public override void Open(PopupRequest request)
    {
        productInfoUI.gameObject.SetActive(false);
        _request = request;
        base.gameObject.SetActive(true);
        IsOpen = true;
        btClose.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(OnCloseClicked);
        btUpgrade.onClick.RemoveAllListeners();
        btUpgrade.onClick.AddListener(OpenUpgradePopup);
        ClearProducts();
        DinnerTablePopupRequest request1 = GetRequest<DinnerTablePopupRequest>();
        iconHouse.sprite = request1.sprIcon;
        buildingData = request1.data;
        buildingData.actionUpdateWaiting += UpdateWaitingProducs;
        buildingData.updateProductCompleted += ProductCompleted;
        //load waiting product
        UpdateWaitingProducs();

        //load product
        //Todo: lấy level player runtime

        int levelPlayer = FarmMapController.Instance.GetLevelPlayer();

        foreach (var product in request1.data.GetProducts())
        {
            var productItem = GameObject.Instantiate(productItemPrefab, productItemParent);
            productItem.Show(levelPlayer, product, ShowProductInfoUI);
        }
        if (buildingData.IsUpgrade(levelPlayer))
        {
            btUpgrade.image.color = Color.white;
            btUpgrade.enabled = true;
            txtBtUpgrade.text = "UPGRADE";
        }
        else
        {
            btUpgrade.image.color = Color.black;
            btUpgrade.enabled = false;
            txtBtUpgrade.text = $"UPGRADE\nLevel Required: {(buildingData.BuildingProperties as UpgradeProperties).CurrentLevelProperties.levelPlayerRequire}";
        }
    }
    public override void UpdateWaitingProducs()
    {
        Debug.Log("UpdateWaitingProducs ------------");
        //load waiting product
        var listWaitingProduct = buildingData.GetWaitingProduct();
        var indexWaitingProducts = buildingData.GetIndexWaitingUnlock();
        var unlockWaitingProduce = buildingData.GetUnlockWaitingProduce();
        for (int i = 0; i < produceWaitingItems.Count; i++)
        {
            Currency moneyUpSpend = null;
            Currency moneyUnlock = null;
            ProductProperties product = null;
            if (i == 0) moneyUpSpend = new Currency(CurrencyType.gems, 15);
            if (i < listWaitingProduct.Count) product = listWaitingProduct[i];
            if (!indexWaitingProducts.Contains(i))//chưa đc unlock
            {
                if (i < unlockWaitingProduce.Count) moneyUnlock = new Currency(CurrencyType.gems, unlockWaitingProduce[i]);

            }

            produceWaitingItems[i].Load(i, moneyUpSpend, moneyUnlock, product, buildingData, DropProductItem, OpenBuyItemPopup, OpenSpeedUpPopup);
        }
        timeCountDown = buildingData.GetTimeWaiting();
        Debug.Log("timeCountDown " + timeCountDown);
    }
    public override void ProductCompleted()
    {
        if (buildingData.completedProducts.Count > 0)
        {
            //int count = 
            if (buildingData.AddAllProductToInventory() > 0)
            {
                if (iconProductMoveToInventory != null)
                {
                    iconProductMoveToInventory.transform.parent.gameObject.SetActive(true);
                    var iconProduct = produceWaitingItems[0].GetIconProduct();
                    var oldPos = iconProductMoveToInventory.transform.position;
                    iconProductMoveToInventory.transform.position = iconProduct.transform.position;
                    iconProductMoveToInventory.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName("energy"));
                    iconProductMoveToInventory.transform.DOMove(oldPos, 0.5f).SetEase(Ease.Linear).OnComplete(() => {
                        iconProductMoveToInventory.transform.parent.gameObject.SetActive(false);
                    });
                }

            }
        }
    }
}
