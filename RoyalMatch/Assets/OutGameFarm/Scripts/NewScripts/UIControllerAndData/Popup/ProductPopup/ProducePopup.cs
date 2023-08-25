using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ProducePopup : Popup
{
    [SerializeField] protected List<ProduceWaitingItem> produceWaitingItems;
    [SerializeField] protected Image iconHouse;
    [SerializeField] protected Image iconProductMoveToInventory;
    [SerializeField] protected ProductItem productItemPrefab;
    [SerializeField] protected Transform productItemParent;
    [SerializeField] protected ProductInfoUI productInfoUI;
    [SerializeField] protected BuyItemsPopup buyItemsPopup;
    [SerializeField] protected SpeedupPopup speedupPopup;
    [SerializeField] protected Button btClose;
    [SerializeField] protected Button btUpgrade;
    [SerializeField] protected TMP_Text txtBtUpgrade;
    protected ProduceHouse buildingData;
    protected double timeCountDown = 0;
    public override void Open(PopupRequest request)
    {
        productInfoUI.gameObject.SetActive(false);
        base.Open(request);
        iconProductMoveToInventory.transform.parent.gameObject.SetActive(false);
        btClose.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(OnCloseClicked);
        btUpgrade.onClick.RemoveAllListeners();
        btUpgrade.onClick.AddListener(OpenUpgradePopup);
        ClearProducts();
        ProducePopupRequest request1 = GetRequest<ProducePopupRequest>();
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
    public virtual void UpdateWaitingProducs()
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

            produceWaitingItems[i].Load(i,moneyUpSpend, moneyUnlock, product, buildingData, DropProductItem, OpenBuyItemPopup,OpenSpeedUpPopup);
        }
        timeCountDown = buildingData.GetTimeWaiting();
        Debug.Log("timeCountDown " + timeCountDown);
    }
    protected void ClearProducts()
    {
        foreach(Transform chil in productItemParent)
        {
            Destroy(chil.gameObject);
        }
    }
    public void ShowProductInfoUI(ProductProperties product,Sprite icon)
    {
        productInfoUI.Show(product, icon);
    }
    
    
    
    
    
    
    
    
    
    
    
    public bool DropProductItem(ProductProperties product)
    {
        //NẾU THÀNH CÔNG THÌ MỚI REFRESH TIME CHẠY CỦA ITEM:::
        bool status = buildingData.AddProduct(product);
        if (status)
        {
            UpdateWaitingProducs();
            if (productInfoUI.gameObject.activeInHierarchy)
            {
                productInfoUI.Refresh(product);
            }
        }
        return status;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    protected override void OnDestroy()
    {
        buildingData.actionUpdateWaiting -= UpdateWaitingProducs;
        buildingData.updateProductCompleted -= ProductCompleted;
        base.OnDestroy();
    }

    public override void Close()
    {
        buildingData.actionUpdateWaiting -= UpdateWaitingProducs;
        buildingData.updateProductCompleted -= ProductCompleted;
        base.Close();
        
    }
    public override void OnCloseClicked()
    {
        buildingData.actionUpdateWaiting -= UpdateWaitingProducs;
        buildingData.updateProductCompleted -= ProductCompleted;
        base.OnCloseClicked();
    }
    private void Update()
    {
        if (timeCountDown <= 0) return;
        timeCountDown -= Time.deltaTime;
        if (timeCountDown < 0) timeCountDown = 0;
        string time = "--:--";
        if (timeCountDown < 0) {
            timeCountDown = 0;
        }
        else
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeCountDown * 1000);
            time = timeSpan.ToString(@"m\:ss");
            UpdateTime(time);
        }
        
    }
    public void UpdateTime(string time)
    {
        produceWaitingItems[0].UpdateTime(time);
    }
    public void OpenBuyItemPopup(int index,Currency moneyUnlock)
    {
        //check điều kiện đc mở slot ở đây
        int lastIndex = index - 1;
        if(lastIndex > -1)
        {
            var indexWaitingProducts = buildingData.GetIndexWaitingUnlock();
            if(!indexWaitingProducts.Contains(lastIndex))
            {
                //show thông báo ở đây
                return;
            }
        }
        else
        {
            //show thông báo ở đây
            return;
        }
        var request = new BuyItemsPopupRequest(moneyUnlock, ()=> BuyItem(index, moneyUnlock));
        buyItemsPopup.Open(request);
    }
    public void OpenSpeedUpPopup(Currency moneyUnlock)
    {
        var request = new SpeedupPopupRequest(buildingData, moneyUnlock, null);
        speedupPopup.Open(request);
    }
    public void Unlocked(int index)
    {
        produceWaitingItems[index].Unlocked();
    }
    protected void OpenUpgradePopup()
    {
        OnCloseClicked();
        PopupManagerView.Instance.PopupManager.RequestPopup(new UpgradePopupRequest(buildingData, iconHouse.sprite));
    }
    public void BuyItem(int index,Currency currency)
    {
        var status = buildingData.UnlockWaitingProduct(index, currency);
        if (status)
        {
            Unlocked(index);
        }
    }
    public virtual void ProductCompleted()
    {
        if (buildingData.completedProducts.Count > 0)
        {
            if (buildingData.AddAllProductToInventory() > 0) 
            {
                if(iconProductMoveToInventory != null)
                {
                    iconProductMoveToInventory.transform.parent.gameObject.SetActive(true);
                    var iconProduct = produceWaitingItems[0].GetIconProduct();
                    var oldPos = iconProductMoveToInventory.transform.position;
                    iconProductMoveToInventory.transform.position = iconProduct.transform.position;
                    iconProductMoveToInventory.sprite = iconProduct.sprite;
                    iconProductMoveToInventory.transform.DOMove(oldPos, 0.5f).SetEase(Ease.Linear).OnComplete(() => {
                        iconProductMoveToInventory.transform.parent.gameObject.SetActive(false);
                    });
                }
                
            }
            productInfoUI.Refresh();
        }
    }
}
