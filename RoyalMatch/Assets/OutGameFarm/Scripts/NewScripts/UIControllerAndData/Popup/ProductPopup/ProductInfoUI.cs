using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductInfoUI : MonoBehaviour
{
    [SerializeField] private MaterialProductInfoUI materialProductInfoUIPrefab;
    [SerializeField] private Transform materialProductInfoUIParent;
    [SerializeField] private Image iconProduct;
    [SerializeField] private TMP_Text txtNameProduct;
    [SerializeField] private TMP_Text txtTimeProduce;
    [SerializeField] private TMP_Text txtValueUnlock;
    [SerializeField] private TMP_Text txtDinnerTableReward;

    ProductProperties product;

    public void Show(ProductProperties _product, Sprite sprIcon)
    {
        gameObject.SetActive(true);
        product = _product;
        if (materialProductInfoUIParent != null) materialProductInfoUIParent.ClearAllChild();
        try
        {
            txtNameProduct.text = product.CurrencyName;
        }
        catch(Exception e)
        {
            Debug.Log(e.StackTrace);
        }
        if(iconProduct != null) iconProduct.sprite = sprIcon;
        float timeCount = product.ProductionTimeSeconds;
        if (timeCount < 0) timeCount = 0f;
        var time = TimeSpan.FromSeconds(timeCount);
        txtTimeProduce.text = time.ToString(@"m\:ss");
        var currentProduct = FarmMapController.Instance.GetGeneralBalanceByKey(product.CurrencyName);
        txtValueUnlock.text = currentProduct.ToString();
        //load materails
        if(materialProductInfoUIPrefab != null && materialProductInfoUIParent != null)
        {
            var materials = product.materials;
            for (int i = 0; i < materials.KeyCount; i++)
            {
                var material = materials.GetCurrency(i);
                var materialProductInfoUI = materialProductInfoUIParent.CreateChild(materialProductInfoUIPrefab);
                materialProductInfoUI.Show(material);
            }
        }
        if(txtDinnerTableReward != null) txtDinnerTableReward.text = product.energyForDinnerTable.ToString();
    }
    public void Refresh(ProductProperties product)
    {
        if (!gameObject.activeInHierarchy) return;
        if (iconProduct != null) Show(product, iconProduct.sprite);
        else Show(product, null);
    }
    public void Refresh()
    {
        if (!gameObject.activeInHierarchy) return;
        if (iconProduct != null) Show(product, iconProduct.sprite);
        else Show(product, null);
    }
}
