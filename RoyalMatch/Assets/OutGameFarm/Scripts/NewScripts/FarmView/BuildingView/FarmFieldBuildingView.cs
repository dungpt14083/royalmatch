using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class FarmFieldBuildingView : MonoBehaviour, IPointerClickHandler,IPointerExitHandler
{
    private FarmFieldBuilding _farmfield;
    private ContructionSiteStating _construction;
    [SerializeField] private BuildingView _buildingView;
    [SerializeField] private FarmFieldView[] _fieldLayoutTemplates;
    [SerializeField] private PanelTimeScript PenalTime;

    private FarmFieldView _activeFarmField;

    private bool HasBeenConstructed
    {
        get
        {
            return _construction != null && _construction.State == ConstructionState.Completed && _farmfield != null;
        }
    }

    private void OnEnable()
    {
        if (_activeFarmField != null)
        {
            _activeFarmField.Activate();
        }

        if (_buildingView != null)
        {
            SetFieldTemplatesVisible(true);
        }
    }

    public void Init(Building building)
    {
        _farmfield = building.Farmfield;
        //_construction = building.Construction;
        _farmfield.FieldClearedEvent += OnFieldCleared;
        _farmfield.CropsStartedGrowingEvent += OnCropsStartedGrowing;
        _farmfield.CropsBecameWitheredEvent += OnCropsBecameWithered;
        _farmfield.CropsAreHarvestReadyEvent += OnCropsAreHarvestReady;

        int num = _fieldLayoutTemplates.Length;
        for (int i = 0; i < num; i++)
        {
            FarmFieldView farmfieldView = _fieldLayoutTemplates[i];
            farmfieldView.Init(_farmfield);
            if (_farmfield.SowedMaterial != null &&
                _farmfield.SowedMaterial.FarmfieldTemplate == farmfieldView.TemplateType)
            {
                _activeFarmField = farmfieldView;
                _activeFarmField.Activate();
            }
            else
            {
                farmfieldView.Deactivate();
            }
        }

        SetFieldTemplatesVisible(true);
    }

    private void OnDestroy()
    {
        _farmfield.FieldClearedEvent -= OnFieldCleared;
        _farmfield.CropsStartedGrowingEvent -= OnCropsStartedGrowing;
        _farmfield.CropsBecameWitheredEvent -= OnCropsBecameWithered;
        _farmfield.CropsAreHarvestReadyEvent -= OnCropsAreHarvestReady;
        _farmfield = null;
        _construction = null;
    }

    private void OnFieldCleared(bool cropsCollected)
    {
        _activeFarmField.Deactivate();
        _activeFarmField = null;
    }

    private void OnCropsStartedGrowing()
    {
        int num = _fieldLayoutTemplates.Length;
        for (int i = 0; i < num; i++)
        {
            if (_fieldLayoutTemplates[i].TemplateType == _farmfield.SowedMaterial.FarmfieldTemplate)
            {
                _activeFarmField = _fieldLayoutTemplates[i];
                break;
            }
        }

        if (_activeFarmField != null)
        {
            _activeFarmField.ActivateAndStartGrowing();
        }
    }

    private void OnCropsAreHarvestReady(FarmFieldBuilding farmFieldBuilding)
    {
        _activeFarmField.HarvestReady();
    }

    private void OnCropsBecameWithered()
    {
        _activeFarmField.Wither();
    }

    private void InitTimePanel()
    {
        PenalTime.Init((int)_farmfield.SowedMaterial.Cost.SumValues, 30, _farmfield.SowedMaterial.CurrencyName,_farmfield);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        switch (_farmfield.State)
        {
            case FarmfieldState.Empty:
                OpenFarmFieldsPopup();
                break;
            case FarmfieldState.Growing:
                InitTimePanel();
                break;
            case FarmfieldState.HarvestReady:
                Collect();
                break;
            case FarmfieldState.Withered:
                
                break;
            default:
                break;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        //PenalTime.gameObject.SetActive(false);
    }
    private void OpenFarmFieldsPopup()
    {
        _farmfield.PopupManager.RequestPopup(new FarmFieldPopupRequest(_farmfield));
    }

    private void Collect()
    {
        _farmfield.PopupManager.RequestPopup(new CollecPopupRequest(_farmfield));
        // if (_farmfield.Collect())
        // {
        //     Debug.LogError("thu hoach thanh cong");
        // }
        // else
        // {
        //     Debug.LogError("thu hoach that bai");
        // }
    }

    private void SetFieldTemplatesVisible(bool visible)
    {
        int i = 0;
        for (int num = _fieldLayoutTemplates.Length; i < num; i++)
        {
            _fieldLayoutTemplates[i].SetVisible(visible);
        }
    }
}