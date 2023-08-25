using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WareHouseItem : MonoBehaviour
{
    [SerializeField] private Image imageRender;
    [SerializeField] private TMP_Text txtLevel;
    [SerializeField] private Button ButtonTrade;
    [SerializeField] private Image PanalImage;
    private PanalTradePopup _panalTradePopup;
    private WareHousePanalDetail _panalWareHouseDetail;
    private KeyValuePair<EntityCurrencyProperties, long> _Data;


   

    public void SetColorImage(bool stt)
    {
        PanalImage.color = stt ? Color.white : Color.yellow;
        if (!stt)
        {
            _panalTradePopup.PopupActiveChanged -= SetColorImage;
            _panalWareHouseDetail.PopupActiveChanged -= SetColorImage;

        }
    }
    public void Init(KeyValuePair<EntityCurrencyProperties, long> data,PanalTradePopup panalTradePopup,WareHousePanalDetail wareHousePanalDetail)
    {
        _Data = data;
        imageRender.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(data.Key.CurrencyName));
        _panalTradePopup = panalTradePopup;
        _panalWareHouseDetail = wareHousePanalDetail;
       
        if ((_Data.Key.Category == CurrencyCategory.Product ||(_Data.Key.Category == CurrencyCategory.SowingMaterial) ) && _Data.Key.TypeWareHouse != "ItemMap"&&_Data.Key.TypeWareHouse!="ItemBonus")
        {
            ButtonTrade.onClick.AddListener(OnOpenTradePopup);
        }
        else
        {
          
            ButtonTrade.onClick.AddListener(OnOpenDetailPopup);
        }
        txtLevel.text = data.Value.ToString();
   
    }

    private void OnOpenTradePopup()
    {
        SetColorImage(false);
        _panalTradePopup.PopupActiveChanged += SetColorImage;
        _panalTradePopup.gameObject.SetActive(true);
        _panalTradePopup.gameObject.transform.position = this.transform.position;
        _panalTradePopup.transform.position = new Vector3(_panalTradePopup.transform.position.x - 150,_panalTradePopup.transform.position.y,_panalTradePopup.transform.position.z) ;
        _panalTradePopup.Init(_Data);
    }
    
    private void OnOpenDetailPopup()
    {
        SetColorImage(false);
        _panalWareHouseDetail.PopupActiveChanged += SetColorImage;
        _panalWareHouseDetail.gameObject.SetActive(true);
        _panalWareHouseDetail.gameObject.transform.position = this.transform.position;
        _panalWareHouseDetail.gameObject.transform.position = new Vector3(
            _panalWareHouseDetail.transform.position.x - 150,
            _panalWareHouseDetail.transform.position.y,
            _panalWareHouseDetail.transform.position.z);
        _panalWareHouseDetail.Init(_Data);
    }
} 