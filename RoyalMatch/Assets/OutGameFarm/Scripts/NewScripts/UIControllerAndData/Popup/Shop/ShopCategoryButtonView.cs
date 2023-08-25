using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ShopCategoryButtonView : MonoBehaviour
{
    [SerializeField] private ShopCategory _category;
    private GameData _game;
    public ShopCategory Category
    {
        get { return _category; }
    }

    //LIST BUILDING PROPERTIES LẤY TỪ PROPERTIES RA ĐÙNG LÀM DATA LÕI
    //SẼ DÀNH CHO GÌ GÌ ĐÓ Ở DƯỚI....
    private List<BuildingProperties> _buildingProperties = new List<BuildingProperties>();
    private List<ProductProperties> _productProperties = new List<ProductProperties>();
    //KHI MỞ LÊN THÌ LIST NÓ SẼ CHỨA GÌ Ở TRONG THÌ SẼ CÓ
    public void Init(GameData game, IsLandInfo isLandInfo)
    {
        _game = game;
        List<string> list = new List<string>();
        List<BuildingProperties> listDecoration = new List<BuildingProperties>();
        _buildingProperties.Clear();
        _productProperties.Clear();
        switch (_category)
        {
            case ShopCategory.Residential:
                list = isLandInfo.IslandFarmProperties.ResidentialBuildingNames;
                break;
            case ShopCategory.Commercial:
                list = isLandInfo.IslandFarmProperties.CommercialBuildingNames;
                break;
            case ShopCategory.Community:
                list = isLandInfo.IslandFarmProperties.CommunityBuildingNames;
                break;
            case ShopCategory.Decoration:
                list = isLandInfo.IslandFarmProperties.DecorationBuildingNames;
                break;
            case ShopCategory.Special:
                list = isLandInfo.IslandFarmProperties.ShopTabFruitAndFarmField;
                break;
            case ShopCategory.ItemFruit:
                list = isLandInfo.IslandFarmProperties.ItemFruitBuildingNames;
                break;
            case ShopCategory.PetHouse:
                list = isLandInfo.IslandFarmProperties.ShopTabPetHouseAndEgg;
                break;
            case ShopCategory.ItemMap:
                list = game.GeneralProperties.ShopItemsNames;
                break;
            case ShopCategory.TntAndEnergy:
                list = game.GeneralProperties.ShopItemsTntAndEnergy;
                break;
            case ShopCategory.RecallDecoration:
                listDecoration = isLandInfo.IslandFarmProperties.WareHouseBuildingDecoration;
                list = new List<string>();
                break;
            default:
                Debug.LogErrorFormat("Missing category building names lookup: {0}", _category);
                list = new List<string>();
                break;
        }

        int count = list.Count;
        int countDecoration= listDecoration.Count;

        if (_category == ShopCategory.ItemMap)
        {
            for (int i = 0; i < count; i++)
            {
                _productProperties.Add(_game.GeneralProperties.GetProperties<ProductProperties>(list[i]));
            } 
        }else if (_category == ShopCategory.TntAndEnergy)
        {
            for (int i = 0; i < count; i++)
            {
                _productProperties.Add(_game.GeneralProperties.GetProperties<ProductProperties>(list[i]));
            } 
        }
        else if(_category==ShopCategory.RecallDecoration)
        {
            for (int i = 0; i < countDecoration; i++)
            {
                _buildingProperties.Add(listDecoration[i]);
            }
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                _buildingProperties.Add(isLandInfo.IslandFarmProperties.GetProperties<BuildingProperties>(list[i]));
            }
        }
    }

    public List<BuildingProperties> GetBuildingPropertiesList()
    {
        return _buildingProperties;
    }

    public List<ProductProperties> GetProductPropertiesList()
    {
        return _productProperties;
    }

    public GameData GetGameData()
    {
        return _game;
    }
}