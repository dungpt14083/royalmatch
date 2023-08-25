using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WareHousePopup : Popup
{
    [SerializeField] private TMP_Text txtLevel;
    [SerializeField] private TMP_Text txtCapacity;
    [SerializeField] private WareHouseItem prefabItem;
    [SerializeField] private Transform holder;
    [SerializeField] private PanalTradePopup panalTradePopup;
    [SerializeField] private WareHousePanalDetail _wareHousePanalDetail;
    [SerializeField] private Button btnUpgrade;
    [SerializeField] private WareHousePanalUpgrade _panalUpgrade;

    public WareHouseBuilding _warehouse { get; private set; }
    [SerializeField] private WareHouseCategoryView[] _wareHouseCategoryViews;
    private WareHouseCategory _category;
    public override void Open(PopupRequest request)
    {
        base.Open(request);
        WareHousePopupRequest request2 = GetRequest<WareHousePopupRequest>();
        _warehouse = request2.Warehouse;
        OnLevelUp(request2.Warehouse);
        //nghe sự kiện level up hiển thị text luôn
        _warehouse.LevelUpEvent += OnLevelUp;
        SetDefault();
        btnUpgrade.onClick.AddListener(OnPanalUpgrade);
        btnUpgrade.interactable = _warehouse.CanLevelUp && FarmMapController.Instance.GeneralBalance.CanSpendCurrencies(_warehouse.WarehouseBuildingProperties.NextLevelProperties.GemCost) ;
       // ViewGrid();
       int num = _wareHouseCategoryViews.Length;
       for (int i = 0; i < num; i++)
       {
           _category = _wareHouseCategoryViews[i].Category;
           switch (_category)
           {
               case WareHouseCategory.All:
                   _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyAllProperties,panalTradePopup,_wareHousePanalDetail);
                   break;
               case WareHouseCategory.Product:
                   _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyProductProperties,panalTradePopup,_wareHousePanalDetail);
                   break;
               case WareHouseCategory.ItemMap:
                   _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyItemMapProperties,panalTradePopup,_wareHousePanalDetail);
                   break;
               case WareHouseCategory.ItemBonus:
                   _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyItemBonusProperties,panalTradePopup,_wareHousePanalDetail);
                   break;
               default:
                   _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyAllProperties,panalTradePopup,_wareHousePanalDetail);
                   break;
           }
           
       }
    }

    public void Refresh()
    {
        txtCapacity.text = string.Format("{0}/{1}", FarmMapController.Instance.GeneralBalance.SumCurrentCurrencies,
            FarmMapController.Instance.GeneralBalance.MaxWarehouseCurrencyCapacity);
        int num = _wareHouseCategoryViews.Length;
        for (int i = 0; i < num; i++)
        {
            _category = _wareHouseCategoryViews[i].Category;
            switch (_category)
            {
                case WareHouseCategory.All:
                    _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyAllProperties,panalTradePopup,_wareHousePanalDetail);
                    break;
                case WareHouseCategory.Product:
                    _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyProductProperties,panalTradePopup,_wareHousePanalDetail);
                    break;
                case WareHouseCategory.ItemMap:
                    _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyItemMapProperties,panalTradePopup,_wareHousePanalDetail);
                    break;
                case WareHouseCategory.ItemBonus:
                    _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyItemBonusProperties,panalTradePopup,_wareHousePanalDetail);
                    break;
                default:
                    _wareHouseCategoryViews[i].Init(_warehouse,prefabItem,_warehouse.CurrencyAllProperties,panalTradePopup,_wareHousePanalDetail);
                    break;
            }
           
        }
        
    }
    

    protected override void OnDestroy()
    {
        if (_warehouse != null)
        {
            _warehouse.LevelUpEvent -= OnLevelUp;
            _warehouse = null;
        }

        base.OnDestroy();
    }

    public override void Close()
    {
        if (_warehouse != null)
        {
            _warehouse.LevelUpEvent -= OnLevelUp;
            _warehouse = null;
        }

        base.Close();
    }

    private void OnLevelUp(WareHouseBuilding warehouse)
    {
        txtLevel.text = "level" + warehouse.Level.ToString();
        txtCapacity.text = string.Format("{0}/{1}", FarmMapController.Instance.GeneralBalance.SumCurrentCurrencies,
            FarmMapController.Instance.GeneralBalance.MaxWarehouseCurrencyCapacity);
    }

    //nút updare tạm thời để kiểu update đi không quan tâm là có bao nhiêu vật liệu cần bỏ vào để up:::
    public void TestUpgrade()
    {
        _warehouse.LevelUpWithGems();
        btnUpgrade.interactable = _warehouse.CanLevelUp && FarmMapController.Instance.GeneralBalance.CanSpendCurrencies(new Currencies(CurrencyType.golds,_warehouse.ValueUpgradeCapacity)) ;
    }

    private void OnPanalUpgrade()
    {
        _panalUpgrade.gameObject.SetActive(true);
    }

    private void SetDefault()
    {
        for (int i = holder.childCount - 1; i >= 0; i--)
        {
            if (holder.GetChild(i) != null)
            {
                Destroy(holder.GetChild(i).gameObject);
            }
        }
    }

    private void ViewGrid()
    {
        //Tạm tời view hạt giống thôi
        //LỌC RA LIST PROP ỔN CÓ VALUE LỚN HƠN 0 TRONG TÚI
        var tmpList = new Dictionary<EntityCurrencyProperties, long>();

        for (int i = 0; i < _warehouse.CurrencyAllProperties.Count; i++)
        {
            var tmpValue = FarmMapController.Instance.GeneralBalance.GetValue(_warehouse.CurrencyAllProperties[i].CurrencyName);
            if (tmpValue > 0)
            {
                tmpList.Add(_warehouse.CurrencyAllProperties[i], tmpValue);
            }
        }

        foreach (var tmp in tmpList)
        {
            var tmpItem = Instantiate(prefabItem, holder);
            tmpItem.Init(tmp,panalTradePopup,_wareHousePanalDetail);
        }
    }
}