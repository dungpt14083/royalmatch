using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProductItem : MonoBehaviour
{
    [SerializeField] private Button btShowInfo;
    [SerializeField] private Image icon;
    [SerializeField] private TMP_Text txtLevel;
    private ProductProperties productProperties;
    public void Show(int levelPlayer, ProductProperties _productProperties, Action<ProductProperties,Sprite> actionShowInfo)
    {
        gameObject.SetActive(true);
        
        productProperties = _productProperties;
        icon.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(productProperties.CurrencyName));
        btShowInfo.onClick.AddListener(() => { actionShowInfo?.Invoke(_productProperties, icon.sprite); });
        btShowInfo.enabled = productProperties.levelPlayerRequire <= levelPlayer;
        txtLevel.gameObject.SetActive(productProperties.levelPlayerRequire > levelPlayer);
        if (productProperties.levelPlayerRequire > levelPlayer)//chưa đc unlock
        {
            txtLevel.text = productProperties.levelPlayerRequire.ToString();
            icon.color = new Color32(255, 255, 255, 100);
        }
        else
        {
            icon.color = new Color32(255, 255, 255, 255);
        }
    }
    public Sprite GetSpriteIcon()
    {
        return icon.sprite;
    }
    public ProductProperties GetProductProperties()
    {
        return productProperties;
    }
    public bool CheckDrag()
    {
        if (productProperties == null) return false;
        if (FarmMapController.Instance.GetLevelPlayer() < productProperties.levelPlayerRequire) return false;
        for(int i= 0; i < productProperties.materials.KeyCount; i++){
            var material = productProperties.materials.GetCurrency(i);
            var countMaterial = FarmMapController.Instance.GetGeneralBalanceByKey(material.Name);
            if (countMaterial < material.Amount) return false;
        }
        return true;
    }
}
