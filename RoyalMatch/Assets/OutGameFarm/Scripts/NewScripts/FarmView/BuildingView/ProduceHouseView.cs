using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProduceHouseView : UpgradeHouseView
{
    [SerializeField] private ProductItemView productItemViewPrefab;
    [SerializeField] private Transform productItemViewParent;

    public override void Init(BuildingData _BuildingData)
    {
        base.Init(_BuildingData);
        //INIT VÀ THÊM SỰ KIỆN UPDATEPRODUCT HOÀN THÀNH:::
        (BuildingData as ProduceHouse).updateProductCompleted += LoadProductsCompleted;
        LoadProductsCompleted();
    }
    public override void OnPointerClick(PointerEventData eventData)
    {
        if (!IsCanUse()) return;
        if (AddAllProductToInventory() > 0) return;
        var name = BuildingData.GetName();
        if (name == "GoldMining" || name == "EnergyLake")
        {
            ButtonUpgradeClick();
        }
        else if(BuildingData.GetName() == "DinnerTable")
        {
            PopupManagerView.Instance.PopupManager.RequestPopup(new DinnerTablePopupRequest(BuildingData as ProduceHouse, GetSpriteRenderer().sprite));
        }
        else
        {
            PopupManagerView.Instance.PopupManager.RequestPopup(new ProducePopupRequest(BuildingData as ProduceHouse, GetSpriteRenderer().sprite));
        }
        
    }
    public void LoadProductsCompleted()
    {
        productItemViewParent.gameObject.SetActive(true);
        productItemViewParent?.ClearAllChild();
        if ((BuildingData as ProduceHouse) == null) return;
        if ((BuildingData as ProduceHouse).completedProducts == null || (BuildingData as ProduceHouse).completedProducts.Count < 1) return;
        //LẤY PRODUCT RA VÀ GÁN VÀO THẰNG PARENT VỚI SỐ LƯỢNG COPLETEDPRODUCTS:::VÀ CALLBACK CHO NÚT KHI ẤN VÀO ITEM LẺ ĐỂ NÓ VÀO INVENTORY::::
        for (int i = 0; i < (BuildingData as ProduceHouse).completedProducts.Count; i++)
        {
            var data = (BuildingData as ProduceHouse).completedProducts[i];
            var item = productItemViewParent.CreateChild(productItemViewPrefab);
            item.Show(data, AddProductToInventory);
            item.transform.localPosition = new Vector3(0.5f * i, 0, 0);
            item.EnableCollider(i == 0);
        }
    }

    public void AddProductToInventory()
    {
        (BuildingData as ProduceHouse).AddProductToInventory();
    }
    public int AddAllProductToInventory()
    {
        return (BuildingData as ProduceHouse).AddAllProductToInventory();
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
        if (BuildingData == null) return;
        var produceHouse = BuildingData as ProduceHouse;
        if (produceHouse == null) return;
        produceHouse.updateProductCompleted -= LoadProductsCompleted;
    }
    public override bool IsCanUse()
    {
        if (!base.IsCanUse()) return false;
        //kiem tra dk nha kho full hay khong
        if (InventoryManagerView.Instance.GeneralBalance.WarehouseIsFull) return false;
        return true;
    }
}
