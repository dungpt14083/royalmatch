using System;
using System.Collections.Generic;
using UnityEngine;

public class BuildingData : ICanSerialize
{
    private StorageDictionary _storage;
    public BuildingProperties BuildingProperties { get; private set; }
    private List<EntityCurrencyProperties> _currencyProperties;
    private List<EntityCurrencyProperties> _baseMaterialProperties;
    private List<EntityCurrencyProperties> _productProperties;
    private List<EntityCurrencyProperties> _buildingMaterialProperties;

    public List<EntityCurrencyProperties> CurrencyProperties
    {
        get
        {
            if (_currencyProperties == null)
            {
                List<ProductProperties> list = new List<ProductProperties>();
                list.AddRange(FarmMapController.Instance.GetGeneralProperties().SowingMaterialProperties.CastAll(
                    (Func<SowingMaterialProperties, ProductProperties>)((SowingMaterialProperties c) => c)));
                _currencyProperties =
                    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _currencyProperties;
        }
    }

    public List<EntityCurrencyProperties> BaseMaterialProperties
    {
        get
        {
            if (_baseMaterialProperties == null)
            {
                List<ProductProperties> list = new List<ProductProperties>();
                list.AddRange(FarmMapController.Instance.GetGeneralProperties().SowingMaterialProperties.CastAll(
                    (Func<SowingMaterialProperties, ProductProperties>)((SowingMaterialProperties c) => c)));
                list.Sort((ProductProperties a, ProductProperties b) => a.UnlockLevel.CompareTo(b.UnlockLevel));
                _baseMaterialProperties =
                    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _baseMaterialProperties;
        }
    }
    
    //THÔNG TIN ELELEMENT ID VÀ SAU NÀY LÀ CẢ TYPE NHÀ NỮA::
    public Building Building { get; private set; }

    public BuildingData(BuildingProperties _BuildingProperties,Building building)
    {
        Building = building;
        BuildingProperties = _BuildingProperties;
    }
    public BuildingData(StorageDictionary storage)
    {
        _storage = storage;
    }
    public virtual int GetLevel()
    {
        return 0;
    }
    public virtual int GetLevelLimit()
    {
        return 0;
    }
    public virtual Currencies GetMerterials()
    {
        return default;
    }
    public virtual bool UpgradeWithMaterials()
    {
        return false;
    }
    public virtual string GetName()
    {
        return BuildingProperties.BuildingName;
    }
    public virtual List<Currency> GetRewards()
    {
        return new List<Currency>();
    }
    public virtual List<ProductProperties> GetWaitingProduct()
    {
        return new List<ProductProperties>();
    }
    public virtual List<int> GetIndexWaitingUnlock()
    {
        return new List<int>();
    }
    public virtual List<int> GetUnlockWaitingProduce()
    {
        return null;
    }
    public virtual List<ProductProperties> GetProducts()
    {
        return new List<ProductProperties>();
    }
    public virtual bool AddProduct(ProductProperties productProperties)
    {
        return false;
    }
    public virtual UpspeedableProcess GetUpspeedableProcess()
    {
        return null;
    }
    public virtual double GetTimeWaiting()
    {
        return 0;
    }
    public virtual bool UnlockWaitingProduct(int index, Currency currency)
    {
        return false;
    }
    public virtual bool SpeedUpProduct(Currency currency)
    {
        return false;
    }
    public virtual bool IsUpgrade(int levelPlayer)
    {
        return false;
    }

    public virtual StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        //_storage.Set("Level", Level);
        return _storage;
    }
    public virtual void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        BuildingProperties = building.BuildingProperties;
    }
}
