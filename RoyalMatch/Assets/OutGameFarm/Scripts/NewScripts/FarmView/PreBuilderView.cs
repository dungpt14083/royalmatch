using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;
using UnityEngine.Serialization;

//CÁI NÀY ĐƯỢC MỞ KHI MÀ UI NÓ HIỆN LÊN 
//MỘT SỐ CÁI ĐƯA VÀO PHỤC VỤ CHO VIỆC TẠO TỪ VIỆC MUA TỪ CỦA HÀNG ISLANDFARMBUILDINGPROPERITES::
public class PreBuilderView : MonoBehaviour
{
    [SerializeField] private BuildingPreviewView buildingPreviewPrefab;

    [FormerlySerializedAs("gridIgridGridView")] [FormerlySerializedAs("gridView")] [SerializeField]
    private GridIgridObjectView gridIgridObjectView;

    [SerializeField] private CameraControllerView cameraController;


    public delegate void MoveFinishedEventHandler(PreBuilderView preBuilderView);

    public event MoveFinishedEventHandler MoveFinishedEvent;

    public void FlipPreviewBuilding()
    {
        if (_previewBuilding != null)
        {
            _previewBuilding.FlipBuilding();
        }
    }

    private void FireMoveFinishedEvent()
    {
        if (this.MoveFinishedEvent != null)
        {
            this.MoveFinishedEvent(this);
        }
    }


    private IslandFarmProperties _islandFarmProperties;
    private TimeKeeper _time;
    private IsLandInfo _isLandInfo;
    private PopupManager _popupManager;
    private GeneralBalance _generalBalance;
    private GeneralProperties _generalProperties;


    private Building _originalBuilding;
    private BuildingProperties _newBuildingProperties;
    private BuildingPreviewView _previewBuilding;
    private readonly List<BuildingPreviewView> _finishingPreviewBuildings = new List<BuildingPreviewView>();

    public PreBuilderState State { get; private set; }
    public Building CurrentBuilding { get; private set; }


    public void Init(GameData gameData, IsLandInfo isLandInfo)
    {
        _islandFarmProperties = isLandInfo.IslandFarmProperties;
        _time = gameData.Time;
        _isLandInfo = isLandInfo;
        _popupManager = gameData.PopupManager;
        State = PreBuilderState.Idle;
        _generalBalance = gameData.GeneralBalance;
        _generalProperties = gameData.GeneralProperties;
    }

    public void StartBuilding(BuildingProperties properties)
    {
        if (_isLandInfo != null && State == PreBuilderState.Idle)
        {
            _newBuildingProperties = properties;
            GridIndex index = FindOpenAreaCloseToCamera(_newBuildingProperties.BuildingSize);
            _previewBuilding = NewBuildingPreview(_newBuildingProperties, index);
            State = PreBuilderState.Building;
        }
    }

    private GridIndex FindOpenAreaCloseToCamera(GridSize size)
    {
        Vector3 tmpPosition;
        if (RayCastFromCameraExtensions.GetHitPlaneFromCamera(out tmpPosition))
        {
            
        }
        else
        {
            tmpPosition = Vector3.zero;
        }

        GridPoint gridPoint = gridIgridObjectView.WorldVectorToGridPoint(tmpPosition);
        IGridObject gridObject = gridIgridObjectView.FindGridObject(gridPoint);
        if (gridObject != null)
        {
            gridPoint = new GridPoint(gridObject.Area.Index);
        }

        // if (!_isLandInfo.GridManager.Area.IsWithinBounds(gridPoint))
        // {
        //     Debug.LogError("Started building at an out-of-bound nearIndex!");
        // }

        GridIndex gridIndex = _isLandInfo.FindFreeGridIndex(gridPoint, size);
        gridIndex = gridIndex ?? new GridIndex(gridPoint - size.Half);
        // if (!_isLandInfo.IsWithinBounds(gridIndex))
        // {
        //     Debug.LogWarningFormat("Started building at an out-of-bound index!");
        // }

        return gridIndex;
    }


    //KHI BẮT ĐẦU MOVE TỪ NGOÀI LÊN:::
    public void StartMoving(Building building, SpriteRenderer spriteRenderer)
    {
        if (_isLandInfo == null || State != 0)
        {
            return;
        }

        _originalBuilding = building;
        gridIgridObjectView.HideGridObject(_originalBuilding);
        List<BuildingPreviewView> list =
            _finishingPreviewBuildings.FindAll((BuildingPreviewView x) => x.Area.Index == building.Area.Index);
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            BuildingPreviewView buildingPreviewView = list[i];
            if (_finishingPreviewBuildings.Remove(buildingPreviewView))
            {
                UnityEngine.Object.Destroy(buildingPreviewView.gameObject);
            }
        }

        _previewBuilding = MoveBuildingPreview(_originalBuilding, spriteRenderer);
        State = PreBuilderState.Moving;
    }

    public void CancelProcess()
    {
        if (_isLandInfo != null && State != 0 && _finishingPreviewBuildings.Count == 0)
        {
            _previewBuilding.CancelPreview();
            if (State == PreBuilderState.Moving)
            {
                gridIgridObjectView.ShowGridObject(_originalBuilding);
            }

            _previewBuilding = null;
            _newBuildingProperties = null;
            _originalBuilding = null;
            State = PreBuilderState.Idle;
            FireMoveFinishedEvent();
        }
    }

    public bool FinishProcess()
    {
        if (_isLandInfo != null && State != 0 && CanPlacePreviewBuilding() && _finishingPreviewBuildings.Count == 0 &&
            _previewBuilding.PlaceBuilding())
        {
            _previewBuilding.PreviewBuildingPlacedEvent += OnPreviewBuildingPlaced;
            _finishingPreviewBuildings.Add(_previewBuilding);
            
            return true;
        }

        return false;
    }
    
    public bool FinishProcessDecoration()
    {
        if (_isLandInfo != null && State != 0 && CanPlacePreviewBuilding() && _finishingPreviewBuildings.Count == 0 &&
            _previewBuilding.PlaceBuilding())
        {
            _previewBuilding.PreviewBuildingPlacedEvent += OnPreviewBuildingDecorationPlaced;
            _finishingPreviewBuildings.Add(_previewBuilding);
            
            return true;
        }

        return false;
    }

    public bool CanPlacePreviewBuilding()
    {
        if (State != 0)
        {
            return _previewBuilding.CanPlacePreviewBuilding();
        }

        return false;
    }

    public void ReCallDecoration()
    {
        gridIgridObjectView.ShowGridObject(_originalBuilding);
        _islandFarmProperties.WareHouseBuildingDecoration.Add(_originalBuilding.BuildingProperties);
        _isLandInfo.RemoveBuilding(_originalBuilding);
    }

    
    
    
    
    
    
    private void OnPreviewBuildingPlaced(BuildingPreviewView buildingPreviewView)
    {
        _previewBuilding.PreviewBuildingPlacedEvent -= OnPreviewBuildingPlaced;
        if (State == PreBuilderState.Building)
        {
            //NCH PHẢI TẠO ID CHO NÓ DỰA VÀO MỚI MUA MỚI THÌ SẼ...
            Building building = new Building(_newBuildingProperties, ConstructionState.Constructing,
                _previewBuilding.Area.Index, _previewBuilding.IsFlipped, _islandFarmProperties,
                _generalBalance, _time, _isLandInfo,
                _popupManager, _generalProperties);


            _isLandInfo.BuyAndPlaceBuilding(building);
        }
        else if (State == PreBuilderState.Moving)
        {
            _originalBuilding.SetFlippedState(_previewBuilding.IsFlipped);
            _isLandInfo.MoveBuilding(_originalBuilding, _previewBuilding.Area.Index);
        }

        _previewBuilding = null;
        _newBuildingProperties = null;
        _originalBuilding = null;
        State = PreBuilderState.Idle;
        _finishingPreviewBuildings.Remove(buildingPreviewView);
        FireMoveFinishedEvent();
    }
    
    private void OnPreviewBuildingDecorationPlaced(BuildingPreviewView buildingPreviewView)
    {
        _previewBuilding.PreviewBuildingPlacedEvent -= OnPreviewBuildingPlaced;
        if (State == PreBuilderState.Building)
        {
            //NCH PHẢI TẠO ID CHO NÓ DỰA VÀO MỚI MUA MỚI THÌ SẼ...
            Building building = new Building(_newBuildingProperties, ConstructionState.Constructing,
                _previewBuilding.Area.Index, _previewBuilding.IsFlipped, _islandFarmProperties,
                _generalBalance, _time, _isLandInfo,
                _popupManager, _generalProperties);


            _isLandInfo.PlaceBuilding(building);
        }
        else if (State == PreBuilderState.Moving)
        {
            _originalBuilding.SetFlippedState(_previewBuilding.IsFlipped);
            _isLandInfo.MoveBuilding(_originalBuilding, _previewBuilding.Area.Index);
        }

        _previewBuilding = null;
        _newBuildingProperties = null;
        _originalBuilding = null;
        State = PreBuilderState.Idle;
        _finishingPreviewBuildings.Remove(buildingPreviewView);
        FireMoveFinishedEvent();
    }


    
    
    
    
    
    private BuildingPreviewView NewBuildingPreview(BuildingProperties buildingProperties, GridIndex index)
    {
        BuildingPreviewView buildingPreviewView =
            buildingPreviewPrefab.InstantiatePrefab(gridIgridObjectView.transform);
        GameObject gameObject = buildingPreviewView.gameObject;
        gameObject.name = gameObject.name.Replace("(Clone)", "(Preview)");

        BuildingView asset =
            SingletonMonobehaviour<BuildingPrefabAssetCollection>.Instance.GetAsset(buildingProperties.BuildingName);
        if (asset != null)
        {
            buildingPreviewView.Init(gridIgridObjectView, _isLandInfo,
                new GridArea(index, buildingProperties.BuildingSize),
                asset.SpriteRenderer, asset.BuildingCollider);
            cameraController.ScrollTo(gameObject, true);
            return buildingPreviewView;
        }

        return null;
    }

    private BuildingPreviewView MoveBuildingPreview(Building original, SpriteRenderer spriteRenderer)
    {
        BuildingPreviewView buildingPreviewView =
            buildingPreviewPrefab.InstantiatePrefab(gridIgridObjectView.transform);
        GameObject gameObject = buildingPreviewView.gameObject;
        gameObject.name = gameObject.name.Replace("(Clone)", "(Preview)");
        BuildingView asset =
            SingletonMonobehaviour<BuildingPrefabAssetCollection>.Instance.GetAsset(original.BuildingProperties
                .BuildingName);
        if (spriteRenderer == null)
        {
            
            if (asset != null)
            {
                buildingPreviewView.Init(gridIgridObjectView, _isLandInfo, original, asset.SpriteRenderer,
                    asset.BuildingCollider);
                return buildingPreviewView;
            }
        }
        else
        {
            buildingPreviewView.Init(gridIgridObjectView, _isLandInfo, original, spriteRenderer,
                asset.BuildingCollider);
            return buildingPreviewView;
        }

        return null;
    }
}