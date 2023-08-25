using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ProduceWaitingItem : MonoBehaviour, IDropHandler
{
    [SerializeField] private Image iconProduct;
    [SerializeField] private Image iconClock;
    [SerializeField] private TMP_Text txtTime;
    [SerializeField] private Image iconMoneyBuyTime;
    [SerializeField] private TMP_Text txtMoneyBuyTime;
    [SerializeField] private Image iconMoneyUnlock;
    [SerializeField] private TMP_Text txtMoneyUnlock;
    [SerializeField] private Button btUpSpend;
    [SerializeField] private Button btUnlock;
    private Func<ProductProperties,bool> actionDrop;
    private int index;
    private BuildingData buildingData;
    Action<int,Currency> openBuyItem;
    Action<Currency> openSpeedUp;

    public void Load(int _index,Currency moneyUpSpend, Currency moneyUnlock,ProductProperties productProperties,BuildingData _buildingData,
        Func<ProductProperties,bool> _actionDrop, Action<int,Currency> _openBuyItem, Action<Currency> _openSpeedUp)
    {
        index = _index;
        buildingData = _buildingData;
        openBuyItem = _openBuyItem;
        openSpeedUp = _openSpeedUp;
        ClearProduct();
        actionDrop = _actionDrop;
        if (moneyUpSpend != null && productProperties !=null)
        {
            btUpSpend?.gameObject.SetActive(true);
            btUpSpend?.onClick.AddListener(()=>UpSpend(moneyUpSpend));
            //Todo : set icon iconMoneyBuyTime
            //iconMoneyBuyTime.sprite = 
            if (txtMoneyBuyTime != null) txtMoneyBuyTime.text = moneyUpSpend.Amount.ToString();
        }
        if (moneyUnlock != null)
        {
            btUnlock?.gameObject.SetActive(true);
            btUnlock?.onClick.AddListener(()=>Unlock(moneyUnlock));
            //Todo : set icon iconMoneyUnlock
            //iconMoneyUnlock.sprite = 
            if(txtMoneyUnlock != null) txtMoneyUnlock.text = moneyUnlock.Amount.ToString();
        }
        else
        {
            if (productProperties != null)
            {
                iconProduct.gameObject.SetActive(true);
                iconProduct.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(productProperties.CurrencyName));
            }
        }
        
    }
    public void ClearProduct()
    {
        btUpSpend?.onClick.RemoveAllListeners();
        btUpSpend?.gameObject.SetActive(false);
        btUnlock?.onClick.RemoveAllListeners();
        btUnlock?.gameObject.SetActive(false);

        iconProduct.gameObject.SetActive(false);
        if(txtTime) txtTime.text = "-- --";
    }
    public void UpdateTime(string timeCountDown)
    {
        if (txtTime) txtTime.text = timeCountDown;
    }
    public void UpSpend(Currency moneyUpSpend)
    {
        openSpeedUp?.Invoke(moneyUpSpend);
    }
    public void Unlock(Currency moneyUnlock)
    {
        openBuyItem?.Invoke(index,moneyUnlock);
        //FarmMapController.Instance.GetPopupManager().RequestPopup(new BuyItemsPopupRequest(index, buildingData, moneyUnlock, Unlocked));
    }
    public void Unlocked()
    {
        btUnlock?.gameObject.SetActive(false);
    }
    public void OnDrop(PointerEventData eventData)
    {
        var objDrop = eventData.pointerDrag;
        DragProductItem dragProductItem = objDrop.GetComponent<DragProductItem>();
        if (dragProductItem == null) return;
        ProductProperties productProperties = dragProductItem.GetProductProperties();
        if (productProperties == null) return;
        var status = actionDrop?.Invoke(dragProductItem.GetProductProperties());
        if(status == true)
        {

        }
    }
    public Image GetIconProduct()
    {
        return iconProduct;
    }
}
