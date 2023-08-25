using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UpgradeHouseView : BuildingView
{
    private UpgradeBuildingSprites _sprites;
    public TMP_Text txtNameBuilding;
    public Button btBuild;
    public Button btUpSpeed;
    public Image iconMoneySpeedUp;
    public TMP_Text txtValueSpeedUp;
    public TMP_Text txtTimeBuilding;
    public GameObject objBuildingStaus;


    private void Start()
    {
        QuestManagerSignals.QuestFinishEventSignal.AddListener(OnQuestFinish);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        if (BuildingData != null)
        {
            (BuildingData as UpgradeHouse).LevelUpEvent -= OnWarehouseLevelUp;
        }

        QuestManagerSignals.QuestFinishEventSignal.RemoveListener(OnQuestFinish);
    }


    #region EVENTFORSHOW UPDATE BUTTON::::

    protected void OnAccessStatusChange(bool status)
    {
        //this.CheckOverlay();
    }

    // private void OnInventoryUpdate( data)
    // {
    //     this.CheckOverlay();
    // }

    //KHI 1 QUEST FINISH THÌ SẼ:::
    private void OnQuestFinish(UserQuestData data)
    {
        this.CheckOverlay();
    }


    //ĐỂ HIỆN THỊ BÚA LÊN::::
    public void CheckOverlay()
    {
        //CÁC STAGE CỦA NHÀ CÓ CẢ RUIN VÀ RUINDATA + HOẶC ĐÃ BUILD 
        if ((BuildingData as UpgradeHouse) != null && !IsBuilt() && IsRequirementsProvided() &&
            !(BuildingData as UpgradeHouse).InBuildQueue)
        {
            btBuild.gameObject.SetActive(true);
            if (!CutSceneManager.Instance.IsCutscenePlaying())
            {
                btBuild.gameObject.SetActive(true);
                return;
            }
        }

        btBuild.gameObject.SetActive(false);
    }

    private bool IsRequirementsProvided()
    {
        var tmp = (BuildingData as UpgradeHouse);
        if ((tmp.BuildingProperties as UpgradeProperties) != null)
        {
            return RequirementManager.Instance.IsRequirementsProvided((tmp.BuildingProperties as UpgradeProperties)
                .CurrentLevelProperties.requirementsForUpdate);
        }

        return false;
    }


    //LỚN HƠN 0 TỨC LÀ ĐÃ UPDATE QUA RUIN RỒI:::
    public bool IsBuilt()
    {
        return (BuildingData as UpgradeHouse).Level > 0;
    }

    #endregion


    //TRUYỀN BUILDINGDATA VÀO ĐỂ CHẠY:::
    //BTNUPSEPPEED ẤN VÀO KIM CƯƠNG ĐỂ UPSPEED NÓ LÊN:::ẤN VÀO THÌ RÚT NHANH TIME VÀ NÓ NẰM TRONG objBuildingStaus ẤN HIỆN THEO TRẠNG THÁI ĐANG XÂY DỰNG:::
    public override void Init(BuildingData _BuildingData)
    {
        base.Init(_BuildingData);
        btUpSpeed.onClick.RemoveAllListeners();
        btUpSpeed.onClick.AddListener(BtUpSpeed);
        (BuildingData as UpgradeHouse).LevelUpEvent += OnWarehouseLevelUp;

        //lấy ảnh từ collect ra rồi ti level nào thì update lấy và thả ảnh vào :::
        _sprites =
            SingletonMonobehaviour<UpgradeBuildingSpritesAssetCollection>.Instance.GetAsset(BuildingData
                .BuildingProperties
                .SpriteReference);
        UpdateBuildingSprite();
        if (txtNameBuilding != null) txtNameBuilding.text = _BuildingData.GetName();


        var BuildingDataUpgradeHouse = BuildingData as UpgradeHouse;
        //NẾU UPGRADEPCORCESS ĐANG THỰC HIỆN THÌ SHOW BUILDING STATUS:::
        if (BuildingDataUpgradeHouse.upgradeProcess != null)
        {
            ShowBuildingStatus((BuildingDataUpgradeHouse.BuildingProperties as UpgradeProperties).CurrentLevelProperties
                .upSpeedBuilding);
        }
        else
        {
            //NẾU Ở TRONG KHI LEVEL BÉ HƠN 1 VÀ KHÔNG TRONG TRẠNG THÁI XÂY DỰNG THÌ MỚI HIỆN BÚA LÊN
            if ((BuildingData as UpgradeHouse).Level < 1)
            {
                btBuild.onClick.RemoveAllListeners();
                btBuild.onClick.AddListener(ButtonUpgradeClick);
                HideBuildingStatus();
            }
            //LEVEL KHÁC THÌ SẼ TẮT HIỂN THỊ BTN BÚA:::
            else
            {
                ShowBuildingStatus((BuildingDataUpgradeHouse.BuildingProperties as UpgradeProperties)
                    .CurrentLevelProperties.upSpeedBuilding);
            }
        }

        CheckOverlay();
    }

    public void ShowBuildingStatus(Currency moneySpeedUp)
    {
        btBuild.gameObject.SetActive(false);
        objBuildingStaus.gameObject.SetActive(true);
        txtValueSpeedUp.text = moneySpeedUp.Amount.ToString();
        iconMoneySpeedUp.sprite =
            SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(
                Currency.GetCurrencyTypeByName(moneySpeedUp.Name));
    }


    public void ButtonUpgradeClick()
    {
        PopupManagerView.Instance.PopupManager.RequestPopup(new UpgradePopupRequest(BuildingData,
            GetSpriteRenderer().sprite));
    }

    //POINTER CLICK UPGRADE????KHI MÀ 
    // OVERRIDE RỒI THÌ KHÔNG CODE GÌ TẠM Ở ĐÂY NỮA::::
    public override void OnPointerClick(PointerEventData eventData)
    {
        //if ((BuildingData as UpgradeHouse).Level < 1) return;
        //PopupManagerView.Instance.PopupManager.RequestPopup(new UpgradePopupRequest(BuildingData, GetSpriteRenderer().sprite));
    }

    private void OnWarehouseLevelUp(BuildingData warehouse)
    {
        HideBuildingStatus();
        UpdateBuildingSprite();
    }


    public void UpdateBuildingSprite()
    {
        GetSpriteRenderer().sprite = _sprites.GetBuildingSpritesWithLevel((BuildingData as UpgradeHouse).Level);
    }


    public void HideBuildingStatus()
    {
        objBuildingStaus.gameObject.SetActive(false);
    }

    public override void ChangeStatusBuilding(ConstructionState buildingStage)
    {
        base.ChangeStatusBuilding(buildingStage);
        var BuildingDataUpgradeHouse = BuildingData as UpgradeHouse;
        switch (buildingStage)
        {
            case ConstructionState.Constructing:
                ShowBuildingStatus((BuildingDataUpgradeHouse.BuildingProperties as UpgradeProperties)
                    .CurrentLevelProperties.upSpeedBuilding);
                break;
            default:
                HideBuildingStatus();
                break;
            // case ConstructionState.Constructed:
            //     HideBuildingStatus();
            //     break;
            // case ConstructionState.Completed:
            //     HideBuildingStatus();
            //     break;
        }
    }

    public void BtUpSpeed()
    {
        var BuildingDataUpgradeHouse = BuildingData as UpgradeHouse;
        var status = BuildingDataUpgradeHouse.SpeedUpUpgrade();
        if (status)
        {
        }
    }

    private void Update()
    {
        var BuildingDataUpgradeHouse = BuildingData as UpgradeHouse;
        if (BuildingDataUpgradeHouse == null)
        {
            return;
        }

        if (BuildingDataUpgradeHouse.upgradeProcess != null)
        {
            TimeSpan time = TimeSpan.FromSeconds(BuildingDataUpgradeHouse.upgradeProcess.RemainingTimeSeconds);
            txtTimeBuilding.text = time.ToString(@"hh\:mm\:ss");
        }
    }
    public virtual bool IsCanUse()
    {
        if ((BuildingData as UpgradeHouse).Level < 1) return false;
        return true;
    }
}