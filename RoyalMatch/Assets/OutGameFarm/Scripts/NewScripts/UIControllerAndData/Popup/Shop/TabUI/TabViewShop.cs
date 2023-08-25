using System;
using System.Collections.Generic;
using UnityEngine;

public class TabViewShop : MonoBehaviour
{
    private ShopCategory _category;
    [SerializeField] private ItemShop itemShop;

    [SerializeField] private ShopCategoryButtonView _shopCategoryButtonView;
    private GameData _game;
    [SerializeField] private RectTransform content;
    private List<ItemShop> _itemShops= new List<ItemShop>();
    private List<BuildingProperties> _buildingProperties = new List<BuildingProperties>();
    private List<ProductProperties> _productProperties = new List<ProductProperties>();


    private void Start()
    {
        _category = _shopCategoryButtonView.Category;
        GetDataPropertiesList();
        if (_itemShops.Count <= 0)
        {
            Init();
        }

    }

    private void GetDataPropertiesList()
    {
        _buildingProperties = _shopCategoryButtonView.GetBuildingPropertiesList();
        _productProperties = _shopCategoryButtonView.GetProductPropertiesList();
        _game = _shopCategoryButtonView.GetGameData();
    }

    private void OnEnable()
    {
        Init();
    }
    

    private void Init()
    {
        SetDefault();
        GetDataPropertiesList();
        switch (_category)
        {
            case ShopCategory.ItemMap:
                GenProductProperties();
                break;
            case ShopCategory.Commercial:
                GenBuildingProperties();
                break;
            case ShopCategory.Community :
                GenBuildingProperties();
                break;
            case ShopCategory.Decoration:
                GenBuildingProperties();
                break;
            case ShopCategory.Residential:
                GenBuildingProperties();
                break;
            case ShopCategory.Special:
                GenBuildingProperties();
                break;
            case ShopCategory.PetHouse:
                GenBuildingProperties();
                break;
            case ShopCategory.ItemFruit:
                GenBuildingProperties();
                break;
            case ShopCategory.TntAndEnergy:
                GenProductProperties();
                break;
            case ShopCategory.RecallDecoration:
                GenDecorationBuildingProperties();
                break;
            default:
                break;
        }
    }

    private void GenBuildingProperties()
    {
        foreach (var item in _buildingProperties)
        {
            var gameObj = Instantiate(itemShop, content);
            gameObj.InitBuildingProperties(_game,item,_category);
            _itemShops.Add(gameObj);
        }
    }
    
    private void GenProductProperties()
    {
        foreach (var item in _productProperties)
        {
            var gameObj = Instantiate(itemShop, content);
            gameObj.InitProductProperties(_game,item,_category);
            _itemShops.Add(gameObj);
        }
    }

    private void GenDecorationBuildingProperties()
    {
        Dictionary<string, int> baseKeyCounts = new Dictionary<string, int>();

        foreach (var item in _buildingProperties)
        {
            if (!baseKeyCounts.ContainsKey(item.BaseKey))
            {
                baseKeyCounts[item.BaseKey] = 1;
                var gameObj = Instantiate(itemShop, content);
                gameObj.InitBuildingProperties(_game, item, _category);
                _itemShops.Add(gameObj);
            }
            else
            {
                baseKeyCounts[item.BaseKey]++;
            }
            
        }
        foreach (var itemShop in _itemShops)
        {
            var buildingProperties = itemShop.GetBuildingProperties();
            if (buildingProperties != null && baseKeyCounts.ContainsKey(buildingProperties.BaseKey))
            {
                itemShop.CountItem = baseKeyCounts[buildingProperties.BaseKey];
                itemShop.UpdateCountItem(); // Gọi hàm cập nhật số lượng
                itemShop.TextCountActive(true);
            }
        }
        
    }
    private void SetDefault()
    {
        for (int i = content.childCount - 1; i >= 0; i--)
        {
            if (content.GetChild(i) != null)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
        _itemShops.Clear();
    }

}
