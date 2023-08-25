using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WareHousePanalUpgrade : MonoBehaviour
{
    [SerializeField] private TMP_Text txtNameHouse;
    [SerializeField] private TMP_Text txtreward;
    [SerializeField] private Image ImgiconReward;
    [SerializeField] private Image iconProviso;
    [SerializeField] private TMP_Text txtProviso;
    [SerializeField] private TMP_Text txtLevel;
    [SerializeField] private Button btnClose;
    [SerializeField] private Button btnUpgrade;
    [SerializeField] private WareHousePopup WareHousePopup;
    [SerializeField] private Button btnInfo;
    [SerializeField] private GameObject panalInfo;

    private void Start()
    {
        btnClose.onClick.RemoveAllListeners();
        btnClose.onClick.AddListener(Close);
        btnUpgrade.onClick.AddListener(Upgrade);
        btnInfo.onClick.AddListener(OnOffPanalInfo);
        Init();
    }

    public void Init()
    {
        txtNameHouse.text = WareHousePopup._warehouse.WarehouseBuildingProperties.NameItem;
        txtreward.text = WareHousePopup._warehouse.WarehouseBuildingProperties.CurrencyBuildComplete.Amount.ToString();

        
        try
        {
            txtProviso.text =
                $"{FarmMapController.Instance.GeneralBalance.GetValue(CurrencyType.golds)}/{WareHousePopup._warehouse.ValueGoldSpenUpgrade}";
        }
        catch (Exception e)
        {
        }
        txtLevel.text = WareHousePopup._warehouse.Level.ToString();

    }

    private void Close()
    {
        this.gameObject.SetActive(!gameObject.activeSelf);
    }

    private void OnOffPanalInfo()
    {
       bool isActive= panalInfo.activeSelf;
       panalInfo.SetActive(!isActive);
    }

    private void Upgrade()
    {
        if (WareHousePopup == null) return;
        WareHousePopup.TestUpgrade();
        Init();
        Close();

    }
}
