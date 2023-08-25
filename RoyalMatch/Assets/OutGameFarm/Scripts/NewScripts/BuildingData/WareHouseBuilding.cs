using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WareHouseBuilding : UpgradeHouse
{
    public delegate void LevelUpEventHandler(WareHouseBuilding warehouse);

    public event LevelUpEventHandler LevelUpEvent;
    public delegate void UpgradeSpriteHandle();

    public event UpgradeSpriteHandle UpgradeSpriteHandler;
    private void FireUpgradeSpriteEvent()
    {
        if (this.UpgradeSpriteHandler != null)
        {
            this.UpgradeSpriteHandler();
        }
    }

    private void FireLevelUpEvent()
    {
        if (this.LevelUpEvent != null)
        {
            this.LevelUpEvent(this);
        }
    }
    private List<EntityCurrencyProperties> _currencyAllProperties;
    private List<EntityCurrencyProperties> _currencyProperties;
    private List<EntityCurrencyProperties> _baseMaterialProperties;
    private List<EntityCurrencyProperties> _productProperties;
    private List<EntityCurrencyProperties> _buildingMaterialProperties;
    private List<EntityCurrencyProperties> _itemMapPropertiesList;
    private List<EntityCurrencyProperties> _itemBonusPropertiesList;
    public List<EntityCurrencyProperties> CurrencyProperties
    {
        get
        {
            if (_currencyProperties == null)
            {
                List<ProductProperties> list = new List<ProductProperties>();
                list.AddRange(FarmMapController.Instance.GeneralProperties.SowingMaterialProperties.CastAll(
                    (Func<SowingMaterialProperties, ProductProperties>)((SowingMaterialProperties c) => c)));
                
                _currencyProperties =
                    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _currencyProperties;
        }
    }
    public List<EntityCurrencyProperties> CurrencyAllProperties
    {
        get
        {
            if (_currencyAllProperties == null)
            {
              // List<ProductProperties> list = new List<ProductProperties>();
             List<EntityCurrencyProperties> list = new List<EntityCurrencyProperties>();
             //   list.AddRange(GeneralProperties.SowingMaterialProperties.CastAll(
              //      (Func<SowingMaterialProperties, ProductProperties>)((SowingMaterialProperties c) => c)));
                list.AddRange(FarmMapController.Instance.GeneralProperties.AllProductProperties);
                list.AddRange(FarmMapController.Instance.GeneralProperties.ItemBounsProperties);
                list.AddRange(FarmMapController.Instance.GeneralProperties.ItemMapProperties);
                _currencyAllProperties = list;
            }

            return _currencyAllProperties;
        }
    }

    public List<EntityCurrencyProperties> CurrencyItemMapProperties
    {
        get
        {
            if (_itemMapPropertiesList == null)
            {
                List<ProductProperties> list = new List<ProductProperties>();
                
                // Thêm các EntityCurrencyProperties từ ProductProperties
                list.AddRange(FarmMapController.Instance.GeneralProperties.ItemMapProperties);
                
                _itemMapPropertiesList =
                    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _itemMapPropertiesList;
        }
    }

    public List<EntityCurrencyProperties> CurrencyItemBonusProperties
    {
        get
        {
            if (_itemBonusPropertiesList == null)
            {
                List<EntityCurrencyProperties> list = new List<EntityCurrencyProperties>();
                list.AddRange(FarmMapController.Instance.GeneralProperties.ItemBounsProperties);
                _itemBonusPropertiesList = list;
            }

            return _itemBonusPropertiesList;
        }
    }
    public List<EntityCurrencyProperties> CurrencyProductProperties
    {
        get
        {
            if (_productProperties == null)
            {
                List<EntityCurrencyProperties> list = new List<EntityCurrencyProperties>();
             list.AddRange(FarmMapController.Instance.GeneralProperties.ProductProperties);
             _productProperties = list;

             // _productProperties =
             //    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _productProperties;
        }
    }


    public  List<Currency> GetRewardsBuilding()
    {
        List<Currency> result = new();
        var rewards = WarehouseBuildingProperties.rewardBuildCompleted;
        for (int i = 0; i < rewards.KeyCount; i++)
        {
            var reward = rewards.GetCurrency(i);
            result.Add(reward);
        }
        return result;
    }
    public List<EntityCurrencyProperties> BaseMaterialProperties
    {
        get
        {
            if (_baseMaterialProperties == null)
            {
                List<ProductProperties> list = new List<ProductProperties>();
                list.AddRange(FarmMapController.Instance.GeneralProperties.SowingMaterialProperties.CastAll(
                    (Func<SowingMaterialProperties, ProductProperties>)((SowingMaterialProperties c) => c)));
                list.Sort((ProductProperties a, ProductProperties b) => a.UnlockLevel.CompareTo(b.UnlockLevel));
                _baseMaterialProperties =
                    list.CastAll((Func<ProductProperties, EntityCurrencyProperties>)((ProductProperties c) => c));
            }

            return _baseMaterialProperties;
        }
    }


    public WarehouseBuildingProperties WarehouseBuildingProperties { get; private set; }
    private BuildingLevelProperties currentlevelProperties;
    public IslandFarmProperties IslandFarmProperties { get; private set; }



    private int _valueUpgradeCapacity;
    public int ValueUpgradeCapacity
    {
        get
        {
            if (NextLevel < 49)
            {
                _valueUpgradeCapacity = 20;
            }else if (NextLevel >= 49 && NextLevel < 109)
            {
                _valueUpgradeCapacity = 25;
            }else if (NextLevel >= 109 && NextLevel < 1009)
            {
                _valueUpgradeCapacity = 50;
            }
            else if(NextLevel>=1009 && NextLevel<2009)
            {
                _valueUpgradeCapacity = 75;
            }
            else
            {
                _valueUpgradeCapacity = 100;
            }
            return _valueUpgradeCapacity;
        }
      
    }

    private int _nextLevel;

    public int NextLevel
    {
        get
        {
            _nextLevel = _level + 1;
            return _nextLevel;
        }
    }

    private int _valueGoldSpenUpgrade;
    public int ValueGoldSpenUpgrade
    {
        get
        {
            if (_level < 49)
            {
                _valueGoldSpenUpgrade = 150;
            }else if (_level >= 49 && _level < 109)
            {
                _valueGoldSpenUpgrade = 300;
            }else if (_level >= 109 && _level < 1009)
            {
                _valueGoldSpenUpgrade = 450;
            }
            else if(_level>=1009&&_level<2009)
            {
                _valueGoldSpenUpgrade = 600;
            }
            else
            {
                _valueGoldSpenUpgrade = 750;
            }
            return _valueGoldSpenUpgrade;
        }
    }
    //public List<ProductProperties> products { get; private set; }
    
    //public UpspeedableProcess produceProcess;
    //public UpspeedableProcess upgradeProcess;
    
    //public List<ProductProperties> waitingProducts;//các sản phẩm chờ sản xuất
    //public List<ProductProperties> completedProducts;//các sản phẩm hoàn thành chờ nhận
    //public List<int> indexWaitingUnlock;//các ô chờ sản xuất đã mở khóa
    private int _level;
    //public Action updateProductCompleted;
    //public Action<ConstructionState> changeStatusBuilding;

    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;

            if (_level == 0)
            {
                WarehouseBuildingProperties.Level = _level ;
            }
            WarehouseBuildingProperties.LevelWareHouse = _level;
            _valueUpgradeCapacity = ValueUpgradeCapacity;
            if (_level <= 1)
            {
                FarmMapController.Instance.GeneralBalance.MaxWarehouseCurrencyCapacity =
                    WarehouseBuildingProperties.MaxCapacity;
            }
            else
            {
                _valueUpgradeCapacity = ValueUpgradeCapacity;
                FarmMapController.Instance.GeneralBalance.MaxWarehouseCurrencyCapacity += _valueUpgradeCapacity;
            }
            
            
        }
    }

    public bool CanLevelUp
    {
       // get { return !IsMaxLevel; }
       get { return true; }
    }

    public bool IsMaxLevel
    {
        get { return WarehouseBuildingProperties.NextLevelProperties == null; }
    }
    
    public override Currencies GetMerterials()
    {
       
        return WarehouseBuildingProperties.CurrentLevelProperties.BuildingMaterials;
    }
    private void LevelUp()
    {
        //upgradeProcess = null;
        //UpdateStatusBuilding();
        Level++;
        FireLevelUpEvent();
    }

    public bool LevelUpWithGems()
    {
        if (!CanLevelUp)
        {
            Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
            return false;
        }

        /*  if (GeneralBalance.SpendCurrencies(WarehouseBuildingProperties.NextLevelProperties.GemCost, false,
                Drain.WarehouseUpgrade))
        {
            LevelUp();
            return true;
        } */
        Currency currency = new Currency(CurrencyType.golds, ValueGoldSpenUpgrade);
      //  if (FarmMapController.Instance.SpendCurrencies(currency, true, Drain.WarehouseUpgrade))
            if (FarmMapController.Instance.SpendCurrencies(currency))
        {
            LevelUp();
            return true;
        }

        return false;
    }

    public bool UpgradeSprite()
    {
        FireUpgradeSpriteEvent();
        return true;
    }

    //public bool LevelUpWithMaterials()
    //{
    //    if (!CanLevelUp)
    //    {
    //        Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
    //        return false;
    //    }

    //    if (GeneralBalance.SpendCurrencies(WarehouseBuildingProperties.NextLevelProperties.GemCost, false,
    //            Drain.WarehouseUpgrade))
    //    {
    //        LevelUp();
    //        return true;
    //    }

    //    return false;
    //}


    #region saveandload::

    private StorageDictionary _storage;

    public WareHouseBuilding(WarehouseBuildingProperties warehouseProps,Building building) : base(warehouseProps,building)
    {
        
        WarehouseBuildingProperties = warehouseProps;
        
        Level = 0;
        //levelLimit = 3;
        //var timeBuildingFake = DateTime.UtcNow.AddSeconds(-40).ToString();
        //DateTime lastTimeBuilding = DateTime.Parse(timeBuildingFake);
        //var timeDeltaBuilding = DateTime.UtcNow - lastTimeBuilding;
        //upgradeProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, timeDeltaBuilding.TotalSeconds,
        //            1.0,
        //            1f, LevelUp, GeneralProperties);

        //products = new List<ProductProperties>();
        //foreach(var productKey in WarehouseBuildingProperties.GetProductsKey())
        //{
        //    var productProperties = GeneralProperties.GetProperties<ProductProperties>(productKey);
        //    products.Add(productProperties);
        //}
        ////load indexWaitingUnlock
        //indexWaitingUnlock = new List<int>();
        ////load indexWaitingUnlock từ data runtime lưu trong file
        ////chưa có data fake tạm
        //indexWaitingUnlock.Add(0);
        //indexWaitingUnlock.Add(1);
        //indexWaitingUnlock.Add(2);
        //waitingProducts = new List<ProductProperties>();
        ////load waitingProducts từ data runtime lưu trong file 
        ////chưa có data fake tạm
        //if (products.Count > 0)
        //{
        //    var product = products[0];
        //    product.SetProductionTimeSeconds(80f);
        //    waitingProducts.Add(product);
        //    var product2 = products[1];
        //    product2.SetProductionTimeSeconds(40f);
        //    waitingProducts.Add(product2);
        //}
        
        //if (waitingProducts.Count > 0)
        //{
        //    completedProducts = new List<ProductProperties>();
        //    var currentProduct = waitingProducts[0];
        //    //Todo : ProductionTimeSeconds 
        //    var timeFake = DateTime.UtcNow.AddSeconds(-40).ToString();
        //    DateTime lastTimeCountDown = DateTime.Parse(timeFake);
        //    var timeDelta = DateTime.UtcNow - lastTimeCountDown;
            
        //    var productionTimeSeconds = currentProduct.GetProductionTimeSecondsByLevelBuilding(Level);
        //    while (timeDelta.TotalSeconds > 0 && waitingProducts.Count > 0)
        //    {
        //        if(timeDelta.TotalSeconds > productionTimeSeconds)
        //        {
        //            timeDelta -= TimeSpan.FromMilliseconds(productionTimeSeconds);
        //        }
        //        else
        //        {
        //            productionTimeSeconds -= (float)timeDelta.TotalSeconds;
        //            break;
        //        }
                
        //        var _currentProduct = waitingProducts[0];
        //        waitingProducts.RemoveAt(0);
        //        completedProducts.Add(_currentProduct);
        //        if (waitingProducts.Count > 0)
        //        {
        //            productionTimeSeconds = waitingProducts[0].GetProductionTimeSecondsByLevelBuilding(Level);
        //        }
        //    }
        //    if (waitingProducts.Count > 0)
        //    {
        //        produceProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, productionTimeSeconds,
        //            1.0,
        //            1f, ProduceComplete, GeneralProperties);
        //    }
                
        //}
        //updateProductCompleted?.Invoke();
    }
    
    //public void UpdateStatusBuilding()
    //{
    //    if (upgradeProcess != null) changeStatusBuilding?.Invoke(ConstructionState.Constructing);
    //    else changeStatusBuilding?.Invoke(ConstructionState.Constructed);
    //}
    //public void ProduceComplete()
    //{
    //    Debug.Log("ProduceComplete");
    //    if (waitingProducts == null || waitingProducts.Count == 0) return;
    //    var completeProduct = waitingProducts[0];
    //    if(completedProducts != null) completedProducts.Add(completeProduct);
    //    waitingProducts.RemoveAt(0);
    //    produceProcess = null;
    //    if (waitingProducts.Count > 0)
    //    {
    //        var currentProduct = waitingProducts[0];
    //        produceProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, currentProduct.ProductionTimeSeconds,
    //                1.0,
    //                1f, ProduceComplete, GeneralProperties);
    //    }
    //    Debug.Log("ProduceComplete 2222222222");
    //    actionUpdateWaiting?.Invoke();
    //    updateProductCompleted?.Invoke();
    //}
    
    public WareHouseBuilding(StorageDictionary storage) : base(storage)
    {
        _storage = storage;
        _level = storage.Get("Level", 1);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("Level", Level);
        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
       
        IslandFarmProperties = isLandInfo.IslandFarmProperties;
       

      
        WarehouseBuildingProperties = (WarehouseBuildingProperties)building.BuildingProperties;
        Level = _level;
    }

    #endregion
    //public override int GetLevel()
    //{
    //    return Level;
    //}
    //public override int GetLevelLimit()
    //{
    //    //Todo : get level limit from config
    //    return levelLimit;
    //}
    //public override Currencies GetMerterials()
    //{
    //    if (WarehouseBuildingProperties == null) return null;
    //    if (WarehouseBuildingProperties.CurrentLevelProperties == null) return null;
    //    if (WarehouseBuildingProperties.CurrentLevelProperties.BuildingMaterials == null) return null;
    //    return WarehouseBuildingProperties.CurrentLevelProperties.BuildingMaterials;
    //}
    //public override bool UpgradeWithMaterials()
    //{
    //    if (!CanLevelUp)
    //    {
    //        Debug.Log("Warehouse cannot be uplevelled (or is it levelled up?).");
    //        return false;
    //    }
    //    if (upgradeProcess != null) return false;
    //    var materials = GetMerterials();
    //    if (materials != null)
    //    {
    //        for (int i = 0; i < materials.KeyCount; i++)
    //        {
    //            var merterial = materials.GetCurrency(i);
    //            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(merterial.Name);
    //            if (currentCountMerterial < merterial.Amount) return false;
    //        }
    //        for (int i = 0; i < materials.KeyCount; i++)
    //        {
    //            var merterial = materials.GetCurrency(i);
    //            GeneralBalance.EarnCurrencies(new Currency(merterial.Name, -merterial.Amount));
    //        }
    //    }
    //    var timeBuilding = TimeSpan.FromSeconds(WarehouseBuildingProperties.CurrentLevelProperties.timeBuilding);
    //    upgradeProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, timeBuilding.TotalSeconds,
    //                1.0,
    //                1f, LevelUp, GeneralProperties);
    //    UpdateStatusBuilding();
    //    return true;
    //}
    //public override string GetName()
    //{
    //    return WarehouseBuildingProperties.BuildingName;
    //}
    //public override List<Reward> GetRewards()
    //{
    //    List<Reward> result = new();
    //    var rewards = WarehouseBuildingProperties.GetCurrentRewardBuildComplete();
    //    for(int i=0;i< rewards.KeyCount;i++)
    //    {
    //        var reward = rewards.GetCurrency(i);
    //        result.Add(new Reward(Reward.GetTypeByName(reward.Name), reward.Amount));
    //    }

    //    return result;
    //}
    //public override double GetTimeWaiting()
    //{
    //    if (produceProcess == null) return 0;
    //    return produceProcess.RemainingTimeSeconds;
    //}
    //public override List<ProductProperties> GetWaitingProduct()
    //{
    //    return waitingProducts;
    //}
    //public override List<ProductProperties> GetProducts()
    //{
    //    return products;
    //}
    //public override List<int> GetIndexWaitingUnlock()
    //{
    //    return indexWaitingUnlock;
    //}
    //public override List<int> GetUnlockWaitingProduce()
    //{
    //    return WarehouseBuildingProperties.GetUnlockWaitingProduce();
    //}
    //public override bool AddProduct(ProductProperties productProperties)
    //{
    //    //kiểm tra các điều kiện
    //    if (waitingProducts.Count >= indexWaitingUnlock.Count) return false;//limit
    //    var product = products.Find(x => x.CurrencyName == productProperties.CurrencyName);
    //    if (product == null) return false;//không có trong danh sách đc phép sản xuất
    //    waitingProducts.Add(product);
    //    if(waitingProducts.Count == 1)//cái đầu đc sản xuất luôn
    //    {
    //        produceProcess = new UpspeedableProcess(IslandFarmProperties, timeKeeper, product.ProductionTimeSeconds,
    //                1.0,
    //                1f, ProduceComplete, GeneralProperties);
    //    }
        
    //    return true;
    //}
    //public override bool UnlockWaitingProduct(int indexUnlock, Currency currency)
    //{
    //    if (indexWaitingUnlock.Contains(indexUnlock)) return false;
    //    var status = FarmMapController.Instance.BuyMaterial(currency, true, null);
    //    if (!status) return false;
    //    indexWaitingUnlock.Add(indexUnlock);
    //    return true;
    //}
    //public override bool SpeedUpProduct(Currency currency)
    //{
    //    if (waitingProducts.Count <= 0 || produceProcess == null) return false;
    //    var status = FarmMapController.Instance.BuyMaterial(currency, true, null);
    //    if (!status) return false;
    //    ProduceComplete();
    //    return true;
    //}
    //public override bool IsUpgrade(int levelPlayer)
    //{
    //    if (WarehouseBuildingProperties.CurrentLevelProperties.levelPlayerRequire > levelPlayer) return false;
    //    var materials = GetMerterials();
    //    if (materials != null)
    //    {
    //        for (int i = 0; i < materials.KeyCount; i++)
    //        {
    //            var merterial = materials.GetCurrency(i);
    //            var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(merterial.Name);
    //            if (currentCountMerterial < merterial.Amount) return false;
    //        }
    //    }
    //    return true;
    //}
}