using System;
using EasyButtons;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WareHouseBuildingView :  UpgradeHouseView, IPointerClickHandler, IEventSystemHandler
{

    private WareHouseBuilding _building;
    private UpgradeBuildingSprites _Sprites;

    [SerializeField] private GameObject CanvasnameHouse;
    [SerializeField] private Button btUpgrade;

    private void Start()
    {
        _building.LevelUpEvent -= OnWarehouseLevelUp;
        _building.LevelUpEvent += OnWarehouseLevelUp;
        _building.UpgradeSpriteHandler -= UpdateBuildingSpriteFirts;
        _building.UpgradeSpriteHandler += UpdateBuildingSpriteFirts;
    }

    public override void Init(BuildingData building)
    {
        _building =(WareHouseBuilding) building;
        _building.LevelUpEvent -= OnWarehouseLevelUp;
        _building.LevelUpEvent += OnWarehouseLevelUp;
        _building.UpgradeSpriteHandler -= UpdateBuildingSpriteFirts;
        _building.UpgradeSpriteHandler += UpdateBuildingSpriteFirts;
        //_building.updateProductCompleted += LoadProductsCompleted;
        
        _Sprites =
            SingletonMonobehaviour<UpgradeBuildingSpritesAssetCollection>.Instance.GetAsset(_building.WarehouseBuildingProperties
                .SpriteReference);
        UpdateBuildingSprite();
        //LoadProductsCompleted();
    }
    
    protected override void OnDestroy()
    {
        if (_building != null)
        {
            _building.LevelUpEvent -= OnWarehouseLevelUp;
            _building.UpgradeSpriteHandler -= UpdateBuildingSpriteFirts;
        }
    }

    private void OnWarehouseLevelUp(WareHouseBuilding warehouse)
    {
        //thay ảnh
        UpdateBuildingSprite();
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
       // if ((BuildingData as UpgradeHouse).Level < 1) return;
       
        if (IsCanUse())
        {
            PopupManagerView.Instance.PopupManager.RequestPopup(new WareHousePopupRequest(_building));
        }
        else
        {
            OnCanvasNameHouse();
        }
    }

    public void UpdateBuildingSprite()
    {
        SpriteRenderer.sprite = _Sprites.GetBuildingSpritesWithLevel(_building.Level - 1);
    }
    public void UpdateBuildingSpriteFirts()
    {
        SpriteRenderer.sprite = _Sprites.GetBuildingSpritesWithLevel(1);
    }
    private void OnCanvasNameHouse()
    {
        bool stt = CanvasnameHouse.gameObject.activeSelf;
        CanvasnameHouse.gameObject.SetActive(stt);
        btUpgrade.onClick.RemoveAllListeners();
        btUpgrade.onClick.AddListener(OnButtonUpgrade);
    }

    private void OnButtonUpgrade()
    {
        PopupManagerView.Instance.PopupManager.RequestPopup(new UpgradeWarehouseRequest(_building,GetSprites().sprite));
      //   _building.PopupManager.RequestPopup(new UpgradePopupRequest(_building,GetSprites().sprite));
        OnCanvasNameHouse();
    }

    public SpriteRenderer GetSprites()
    {
        return SpriteRenderer;
    }
}