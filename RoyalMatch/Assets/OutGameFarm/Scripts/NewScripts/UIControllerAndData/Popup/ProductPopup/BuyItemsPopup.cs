using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuyItemsPopup : MonoBehaviour
{
    [SerializeField] private Button btClose;
    [SerializeField] private Button btBuy;
    [SerializeField] private Image iconMoney;
    [SerializeField] private TMP_Text txtValue;
    [SerializeField] private Button btCancel;
    [SerializeField] private ItemInfoMaterial itemInfoMaterialPrefab;
    [SerializeField] private Transform itemInfoMaterialParent;
    public void Open(PopupRequest request)
    {
        gameObject.SetActive(true);
        BuyItemsPopupRequest request1 = request as BuyItemsPopupRequest;
        Currencies currencyBuy = request1.currencies;
        btClose.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(Close);
        btBuy.onClick.RemoveAllListeners();
        btBuy.onClick.AddListener(()=>Buy(request1.actionBuy));
        btCancel.onClick.RemoveAllListeners();
        btCancel.onClick.AddListener(Cancel);
        txtValue.text = request1.valueBuy.ToString();
        if(itemInfoMaterialParent != null)
        {
            itemInfoMaterialParent.ClearAllChild();
            for (int i = 0; i < request1.currencies.KeyCount; i++)
            {
                var info = request1.currencies.GetCurrency(i);
                var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(info.Name);
                if (currentCountMerterial >= info.Amount) continue;
                var item = itemInfoMaterialParent.CreateChild(itemInfoMaterialPrefab);
                item.Show(currentCountMerterial, info);
            }
        }
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void Cancel()
    {
        Close();
    }
    //public void Buy(int index,Currency currency, BuildingData buildingData, Action<int> actionUnlocked)
    //{
    //    var status = buildingData.UnlockWaitingProduct(index, currency);
    //    if(status)
    //    {
    //        actionUnlocked?.Invoke(index);
    //    }
    //    gameObject.SetActive(false);
    //}
    public void Buy(Action actionBuy)
    {
        actionBuy?.Invoke();
        gameObject.SetActive(false);
    }
}
