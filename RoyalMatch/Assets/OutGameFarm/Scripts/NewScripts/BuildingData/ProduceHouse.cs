using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ProduceHouse : UpgradeHouse
{
    public UpspeedableProcess produceProcess;
    public List<ProductProperties> waitingProducts; //các sản phẩm chờ sản xuất
    public List<ProductProperties> completedProducts; //các sản phẩm hoàn thành chờ nhận
    public List<int> indexWaitingUnlock; //các ô chờ sản xuất đã mở khóa
    public Action actionUpdateWaiting;
    public Action updateProductCompleted;
    public List<ProductProperties> products { get; private set; }

    public ProduceHouse(ProduceProperties houseProps, Building building) : base(houseProps, building)
    {
        completedProducts = new List<ProductProperties>();
        products = new List<ProductProperties>();
        waitingProducts = new List<ProductProperties>();
        if (GetLevel() < 1) return;
        StartProduce();
    }

    public ProduceHouse(StorageDictionary storage) : base(storage)
    {
    }


    private void StartProduce()
    {
        var name = GetName();
        if (name == "GoldMining" || name == "EnergyLake")
        {
            var timeProduce = (BuildingProperties as ProduceProperties).CurrentLevelProperties.timeProduce;
            produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                FarmMapController.Instance.GetTimeKeeper(), timeProduce,
                1.0,
                1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
            return;
        }

        foreach (var productKey in ((ProduceProperties)BuildingProperties).GetProductsKey())
        {
            var productProperties = FarmMapController.Instance.GetGeneralProperties()
                .GetProperties<ProductProperties>(productKey);
            products.Add(productProperties);
        }

        //load indexWaitingUnlock
        indexWaitingUnlock = new List<int>();
        //load indexWaitingUnlock từ data runtime lưu trong file
        //chưa có data fake tạm
        if (name == "DinnerTable")
        {
            indexWaitingUnlock.Add(0);
            indexWaitingUnlock.Add(1);
        }
        else
        {
            indexWaitingUnlock.Add(0);
            indexWaitingUnlock.Add(1);
            indexWaitingUnlock.Add(2);
        }

        //load waitingProducts từ data runtime lưu trong file 
        //chưa có data fake tạm
        if (products.Count > 0)
        {
            //var product = products[0];
            //product.SetProductionTimeSeconds(80f);
            //waitingProducts.Add(product);
            //var product2 = products[1];
            //product2.SetProductionTimeSeconds(40f);
            //waitingProducts.Add(product2);
        }

        if (waitingProducts.Count > 0)
        {
            completedProducts = new List<ProductProperties>();
            var currentProduct = waitingProducts[0];
            //Todo : ProductionTimeSeconds 
            var timeFake = DateTime.UtcNow.AddSeconds(-40).ToString();
            DateTime lastTimeCountDown = DateTime.Parse(timeFake);
            var timeDelta = DateTime.UtcNow - lastTimeCountDown;

            var productionTimeSeconds = currentProduct.GetProductionTimeSecondsByLevelBuilding(Level);
            while (timeDelta.TotalSeconds > 0 && waitingProducts.Count > 0)
            {
                if (timeDelta.TotalSeconds > productionTimeSeconds)
                {
                    timeDelta -= TimeSpan.FromMilliseconds(productionTimeSeconds);
                }
                else
                {
                    productionTimeSeconds -= (float)timeDelta.TotalSeconds;
                    break;
                }

                var _currentProduct = waitingProducts[0];
                waitingProducts.RemoveAt(0);
                completedProducts.Add(_currentProduct);


                if (waitingProducts.Count > 0)
                {
                    productionTimeSeconds = waitingProducts[0].GetProductionTimeSecondsByLevelBuilding(Level);
                }
            }

            if (waitingProducts.Count > 0)
            {
                produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                    FarmMapController.Instance.GetTimeKeeper(), productionTimeSeconds,
                    1.0,
                    1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
            }
        }

        updateProductCompleted?.Invoke();
    }

    public void ProduceComplete()
    {
        Debug.Log("ProduceComplete");
        produceProcess.CancelAction();
        produceProcess = null;
        var name = GetName();
        if (name == "GoldMining")
        {
            Debug.Log("ProduceComplete GoldMining");
            var max = (BuildingProperties as ProduceProperties).CurrentLevelProperties.maxProduce;
            var numberProduce = (BuildingProperties as ProduceProperties).CurrentLevelProperties.numberProduce;
            if (completedProducts != null && completedProducts.Count < max)
            {
                for (int i = 0; i < numberProduce; i++)
                {
                    var gold = FarmMapController.Instance.GetProductPropertiesBykey("golds");
                    completedProducts.Add(gold);
                }

                updateProductCompleted?.Invoke();
                var timeProduce = (BuildingProperties as ProduceProperties).CurrentLevelProperties.timeProduce;
                produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                    FarmMapController.Instance.GetTimeKeeper(), timeProduce,
                    1.0,
                    1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
            }

            //else
            //{
            //    produceProcess.CancelAction();
            //    produceProcess = null;
            //}
            return;
        }

        if (name == "EnergyLake")
        {
            Debug.Log("ProduceComplete EnergyLake");
            var max = (BuildingProperties as ProduceProperties).CurrentLevelProperties.maxProduce;
            var numberProduce = (BuildingProperties as ProduceProperties).CurrentLevelProperties.numberProduce;
            if (completedProducts != null && completedProducts.Count < max)
            {
                for (int i = 0; i < numberProduce; i++)
                {
                    var Energy = FarmMapController.Instance.GetProductPropertiesBykey("energy");
                    completedProducts.Add(Energy);
                }

                updateProductCompleted?.Invoke();
                var timeProduce = (BuildingProperties as ProduceProperties).CurrentLevelProperties.timeProduce;
                produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                    FarmMapController.Instance.GetTimeKeeper(), timeProduce,
                    1.0,
                    1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
            }
            //else
            //{
            //    produceProcess.CancelAction();
            //    produceProcess = null;
            //}
            
            
            return;
        }

        if (waitingProducts == null || waitingProducts.Count == 0) return;
        if (name == "DinnerTable")
        {
            var completeProduct = waitingProducts[0];
            if (completedProducts != null)
            {
                for (int i = 0; i < completeProduct.energyForDinnerTable; i++)
                {
                    var Energy = FarmMapController.Instance.GetProductPropertiesBykey("energy");
                    completedProducts.Add(Energy);
                }
            }
        }
        else
        {
            var completeProduct = waitingProducts[0];
            if (completedProducts != null) completedProducts.Add(completeProduct);
        }

        waitingProducts.RemoveAt(0);

        if (waitingProducts.Count > 0)
        {
            var currentProduct = waitingProducts[0];
            produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                FarmMapController.Instance.GetTimeKeeper(), currentProduct.ProductionTimeSeconds,
                1.0,
                1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
        }

        Debug.Log("ProduceComplete 2222222222");
        actionUpdateWaiting?.Invoke();
        updateProductCompleted?.Invoke();
    }


    public override void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        base.ResolveDependencies(game, isLandInfo, building);
    }

    public override double GetTimeWaiting()
    {
        if (produceProcess == null) return 0;
        return produceProcess.RemainingTimeSeconds;
    }

    public override List<ProductProperties> GetWaitingProduct()
    {
        return waitingProducts;
    }

    public override List<ProductProperties> GetProducts()
    {
        return products;
    }

    public override List<int> GetIndexWaitingUnlock()
    {
        return indexWaitingUnlock;
    }

    public override List<int> GetUnlockWaitingProduce()
    {
        return (BuildingProperties as ProduceProperties).GetUnlockWaitingProduce();
    }


    public override bool AddProduct(ProductProperties productProperties)
    {
        var tmpList = new List<ProductProperties>();
        //kiểm tra các điều kiện
        if (waitingProducts.Count >= indexWaitingUnlock.Count) return false; //limit
        var product = products.Find(x => x.CurrencyName == productProperties.CurrencyName);
        if (product == null) return false; //không có trong danh sách đc phép sản xuất
        if (!IsAddProduct(productProperties)) return false;

        if (GetName() == "DinnerTable")
        {
            FarmMapController.Instance.SpendCurrencies(new Currency(productProperties.CurrencyName, 1));
        }
        else
        {
            //for (int i = 0; i < product.materials.KeyCount; i++)
            //{
            //    var material = product.materials.GetCurrency(i);
            //    FarmMapController.Instance.SpendCurrencies(new Currency(material.Name, material.Amount));
            //}
            FarmMapController.Instance.SpendCurrencies(product.materials);
        }

        waitingProducts.Add(product);
        if (waitingProducts.Count == 1) //cái đầu đc sản xuất luôn
        {
            produceProcess = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(),
                FarmMapController.Instance.GetTimeKeeper(), product.ProductionTimeSeconds,
                1.0,
                1f, ProduceComplete, FarmMapController.Instance.GetGeneralProperties());
        }

        tmpList.Add(product);
        ObjectiveTrackerSignals.FactoryProductionStartEvent.Dispatch(new FactoryEventData(tmpList));
        return true;
    }


    public override bool UnlockWaitingProduct(int indexUnlock, Currency currency)
    {
        if (indexWaitingUnlock.Contains(indexUnlock)) return false;
        var status = FarmMapController.Instance.SpendCurrencies(currency);
        if (!status) return false;
        indexWaitingUnlock.Add(indexUnlock);
        return true;
    }

    public override bool SpeedUpProduct(Currency currency)
    {
        if (waitingProducts.Count <= 0 || produceProcess == null) return false;
        var status = FarmMapController.Instance.SpendCurrencies(currency);
        if (!status) return false;
        ProduceComplete();
        return true;
    }

    public bool IsAddProduct(ProductProperties productProperties)
    {
        for (int i = 0; i < productProperties.materials.KeyCount; i++)
        {
            var material = productProperties.materials.GetCurrency(i);
            var currentMaterial = FarmMapController.Instance.GetGeneralBalanceByKey(material.Name);
            if (material.Amount > currentMaterial) return false;
        }

        return true;
    }

    public bool AddProductToInventory()
    {
        if (completedProducts == null || completedProducts.Count < 1) return false;
        var tmpList = new List<ProductProperties>();
        var product = completedProducts[0];

        if (FarmMapController.Instance.EarnCurrencies(new Currency(product.CurrencyName, 1)))
        {
            completedProducts.RemoveAt(0);
            updateProductCompleted?.Invoke();
            tmpList.Add(product);
            ObjectiveTrackerSignals.FactoryCollectItemEvent.Dispatch(new FactoryEventData(tmpList));
            return true;
        }
        else
        {
            //Thông báo cái gì đó
        }

        return false;
    }

    public int AddAllProductToInventory()
    {
        int count = 0;
        var tmpList = new List<ProductProperties>();
        while (completedProducts.Count > 0)
        {
            var product = completedProducts[0];
            if (FarmMapController.Instance.EarnCurrencies(new Currency(product.CurrencyName, 1)))
            {
                completedProducts.RemoveAt(0);
                tmpList.Add(product);
                count += 1;
            }
            else
            {
                //Thông báo cái gì đó
                break;
            }
        }

        if (count > 0)
        {
            updateProductCompleted?.Invoke();
            ObjectiveTrackerSignals.FactoryCollectItemEvent.Dispatch(new FactoryEventData(tmpList));
        }

        return count;
    }


    protected override void LevelUp()
    {
        base.LevelUp();
        if (GetLevel() == 1) StartProduce();
    }
}