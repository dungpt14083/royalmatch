using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemShop : MonoBehaviour
{
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private Image imageItem;
    [SerializeField] private TMP_Text txtCostItem;
    [SerializeField] private Button btnBuy;
    [SerializeField] private Image iconBuy;
    [SerializeField] private TMP_Text txtCountItem;
    [SerializeField] private Sprite spriteCoin, spriteGem;
    [SerializeField] private Button btnSelected;
    public int CountItem;

    private GameData _gameData;
    private BuildingProperties _buildingProperties;
    private ProductProperties _productProperties;
    private CurrencyType currencyType;
    private ShopCategory _shopCategory;
    public void InitBuildingProperties(GameData gameData,BuildingProperties buildingProperties,ShopCategory shopCategory)
    {
        _shopCategory = shopCategory;
        _gameData = gameData;
        _buildingProperties = buildingProperties;
        if (buildingProperties != null)
        {
            
            btnBuy.onClick.AddListener(OnButtonClicked);
            UpdateCountItem();
            TextCountActive(false);
            txtName.text = buildingProperties.NameItem;
            int playerLevel = FarmMapController.Instance.GetLevelPlayer();
            long unlockLevel = buildingProperties.UnlockLevel;
            bool canAfford = _gameData.GeneralBalance.GetValue(buildingProperties.ConstructionCost.Name) >= buildingProperties.ConstructionCost.Amount;
            txtCostItem.text = playerLevel >= unlockLevel ? buildingProperties.ConstructionCost.Amount.ToString() : $"Unlock Level {unlockLevel}";
            btnBuy.interactable = playerLevel >= unlockLevel && canAfford;

            imageItem.sprite = SingletonMonobehaviour<ShopSpritesAssetCollection>.Instance.GetAsset(buildingProperties.BuildingName);
            if (buildingProperties.ConstructionCost.Name == CurrencyType.golds.ToString().ToLower())
            {
                iconBuy.sprite = spriteCoin;
            }else if (buildingProperties.ConstructionCost.Name == CurrencyType.gems.ToString().ToLower())
            {
                iconBuy.sprite = spriteGem;
            }
        }
    }
    public void InitProductProperties(GameData gameData,ProductProperties productProperties,ShopCategory shopCategory)
    {
        _shopCategory = shopCategory;
        _gameData = gameData;
        _productProperties = productProperties;
        if (productProperties != null)
        {
            btnBuy.onClick.AddListener(OnButtonClicked);
            TextCountActive(false);
            txtName.text = productProperties.NameItem;
            txtCostItem.text = productProperties.Cost.SumValues.ToString();
            imageItem.sprite = SingletonMonobehaviour<ShopSpritesAssetCollection>.Instance.GetAsset(productProperties.CurrencyName);
            btnBuy.interactable = _gameData.GeneralBalance.GetValue(productProperties.PurchaseCost.Name) >
                                  productProperties.Cost.SumValues;
            if (productProperties.PurchaseCost.Name.ToString() == CurrencyType.golds.ToString().ToLower())
            {
                iconBuy.sprite = spriteCoin;
            }else if (productProperties.PurchaseCost.Name.ToString() == CurrencyType.gems.ToString().ToLower())

            {
                iconBuy.sprite = spriteGem;
            }
        }
    }
    private void OnButtonClicked()
    {
        if (_shopCategory == ShopCategory.ItemMap)
        {
            EarnCurrencies();
        }
        else if(_shopCategory==ShopCategory.TntAndEnergy)
        {
            EarnCurrencies();
        }
        else if(_shopCategory==ShopCategory.RecallDecoration)
        {
            _gameData.PopupManager.RequestPopup(new BuildConfirmPopupRequest(_buildingProperties,this));
            _gameData.PopupManager.CloseAllOpenPopups();
        }
        else
        {
            _gameData.PopupManager.RequestPopup(new BuildConfirmPopupRequest(_buildingProperties));
            _gameData.PopupManager.CloseAllOpenPopups();
        }
       
    }

    private void EarnCurrencies()
    {
        if (_gameData.GeneralBalance.CanSpendCurrencies(_productProperties.Cost))
        {
            if (FarmMapController.Instance.GeneralBalance.CanEarnCurrencies(_productProperties.rewards))
            {
                if (FarmMapController.Instance.SpendCurrencies(_productProperties.Cost))
                {
                    if (FarmMapController.Instance.EarnCurrencies(_productProperties.rewards))
                    {
                        _gameData.PopupManager.CloseAllOpenPopups();
                    }
                }
            }
        }
    }

    public void UpdateCountItem()
    {
        txtCountItem.text = CountItem.ToString();
    }

    public void TextCountActive(bool isActive)
    {
        txtCountItem.gameObject.SetActive(isActive);
        btnSelected.gameObject.SetActive(isActive);
        btnSelected.onClick.AddListener(OnButtonClicked);
    }
    public void RemovePurchasedDecoration()
    {
        if (_gameData.IslandsManager.CurrentIsland != null && _buildingProperties != null)
        {
            _gameData.IslandsManager.CurrentIsland.IslandFarmProperties.WareHouseBuildingDecoration.Remove(_buildingProperties);
        }
    }
    public BuildingProperties GetBuildingProperties()
    {
        return _buildingProperties;
    }
}