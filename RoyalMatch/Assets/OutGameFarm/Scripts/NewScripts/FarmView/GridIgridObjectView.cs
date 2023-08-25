using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Tilemaps;

//QUẢN LÍ VIEW GRIDOBJECT TRONG GAME::::VIEW
public class GridIgridObjectView : MonoBehaviour
{
    private IsLandInfo _isLandInfo;
    [SerializeField] private IsLandInput islandInput;
    [SerializeField] private CameraControllerView cameraView;
    [SerializeField] private TileManagerView tileManagerView;

    private bool _isDrawed = false;
    //private bool _initialized = false;


    public delegate void BuildingAddedEventHandler(BuildingView buildingView);

    public delegate void GridObjectViewAddedEventHandler(GameObject view);

    public delegate void GridObjectViewRemovedEventHandler(GameObject view);


    public event BuildingAddedEventHandler BuildingAddedEvent;
    public event GridObjectViewAddedEventHandler GridObjectViewAddedEvent;
    public event GridObjectViewRemovedEventHandler GridObjectViewRemovedEvent;


    private void FireGridObjectViewAddedEvent(GameObject view)
    {
        if (this.GridObjectViewAddedEvent != null)
        {
            this.GridObjectViewAddedEvent(view);
        }
    }

    private void FireBuildingAddedEvent(BuildingView buildingView)
    {
        if (this.BuildingAddedEvent != null)
        {
            this.BuildingAddedEvent(buildingView);
        }
    }

    private void FireGridObjectViewRemovedEvent(GameObject view)
    {
        if (this.GridObjectViewRemovedEvent != null)
        {
            this.GridObjectViewRemovedEvent(view);
        }
    }


    private Dictionary<IGridObject, GameObject> _gridObjectViews = new Dictionary<IGridObject, GameObject>();

    //TẠO ĐỐNG VIEW RA NGOÀI MÀN HÌNH NHÀ CỬA:::
    public void Init(IsLandInfo island)
    {
        _isLandInfo = island;

        //NGHE CÁC SỰ KIỆN BÊN THẰNG ISLAND ĐỂ XÀI VIEW Ở ĐÂY
        _isLandInfo.BuildingAddedEvent += OnBuildingAdded;
        _isLandInfo.BuildingRemovedEvent += OnBuildingRemoved;
        _isLandInfo.BuildingMovedEvent += OnBuildingMoved;
        _isLandInfo.CameraOperator.ScrollToEvent += OnScrollTo;

        StartCoroutine(WaitTileManagerViewInstance());
    }

    //CHỜ BỌN KIA RỒI SẼ TẠO RA:::
    private IEnumerator WaitTileManagerViewInstance()
    {
        yield return new WaitUntil(() => TileManagerView.Instance != null);
        int buildingCount = _isLandInfo.BuildingCount;
        for (int i = 0; i < buildingCount; i++)
        {
            BuildingAdded(_isLandInfo.GetBuilding(i));
        }
        ItemBonusManager.Instance.Init();
        //_initialized = true;
    }

    private void OnDestroy()
    {
        if (_isLandInfo != null)
        {
            _isLandInfo.BuildingAddedEvent -= OnBuildingAdded;
            _isLandInfo.BuildingRemovedEvent -= OnBuildingRemoved;
            _isLandInfo.BuildingMovedEvent -= OnBuildingMoved;
            _isLandInfo.CameraOperator.ScrollToEvent -= OnScrollTo;
        }

        StopAllCoroutines();
    }

    private void OnScrollTo(GridPoint gridPoint, bool animated)
    {
        cameraView.ScrollTo(GridPointToWorldVector(gridPoint), animated);
    }

    #region LƯU Ý ĐOẠN NÀY LÀ BUILDING HOÀN THIỆN CMNRR

    private void OnBuildingAdded(Building building)
    {
        BuildingAdded(building);
    }

    private void OnBuildingRemoved(Building building)
    {
        RemoveGridObject(building);
    }

    private void RemoveGridObject(IGridObject gridObject)
    {
        if (!_gridObjectViews.ContainsKey(gridObject))
        {
            Debug.LogErrorFormat("GridObject {0} has no View!", gridObject);
            return;
        }

        GameObject gameObject = _gridObjectViews[gridObject];
        _gridObjectViews.Remove(gridObject);
        FireGridObjectViewRemovedEvent(gameObject);
        UnityEngine.Object.Destroy(gameObject);
    }


    //MOVE XONG THÌ HỆN LÊN THÔI
    private void OnBuildingMoved(Building building, GridIndex oldIndex)
    {
        ShowGridObject(building);
    }

    private void BuildingAdded(Building building)
    {
        BuildingView buildingView = CreatePreBuildingView(building);
        AddGridObject(building, buildingView.gameObject);
        FireBuildingAddedEvent(buildingView);
    }

    private BuildingView CreatePreBuildingView(Building building)
    {
        //Debug.LogError("nAMEbuilding"+building.BuildingProperties.BuildingName);

        BuildingView buildingView = SingletonMonobehaviour<BuildingPrefabAssetCollection>.Instance
            .GetAsset(building.BuildingProperties.BuildingName).InstantiatePrefab(this);
        // if (buildingView==null)
        // {
        //     //Debug.LogError("Null"+building.BuildingProperties.BuildingName);
        // }
        GameObject gameObject = buildingView.gameObject;
        gameObject.name = gameObject.name.Replace("(Clone)", string.Empty);
        buildingView.Init(this, islandInput, building);
        Debug.Log("CreatePreBuildingView " + gameObject.name);
        return buildingView;
    }

    private void AddGridObject(IGridObject gridObject, GameObject view)
    {
        if (_gridObjectViews.ContainsKey(gridObject))
        {
            Debug.LogErrorFormat("GridObject {0} was already added!", gridObject);
        }
        else
        {
            _gridObjectViews.Add(gridObject, view);
            FireGridObjectViewAddedEvent(view);
        }
    }

    public void HideGridObject(IGridObject gridObject)
    {
        if (!_gridObjectViews.ContainsKey(gridObject))
        {
            Debug.LogErrorFormat("GridObject {0} has no View!", gridObject);
        }
        else
        {
            _gridObjectViews[gridObject].SetActive(false);
        }
    }

    public void ShowGridObject(IGridObject gridObject)
    {
        if (!_gridObjectViews.ContainsKey(gridObject))
        {
            Debug.LogErrorFormat("GridObject {0} has no View!", gridObject);
        }
        else
        {
            _gridObjectViews[gridObject].SetActive(true);
        }
    }

    #endregion

    #region TIỆN ÍCH SẼ DÙNG TILEMANAGER THAY THẾ CHO GRIDMANAGER

    public IGridObject FindGridObject(GridPoint gridPoint)
    {
        return tileManagerView.FindGridObject(gridPoint);
    }

    #endregion


    //TÌM CÁCH XÓA CỤC NÀY ĐI HƠI THỪA THÃI LOGIC LỘN XỘN:::
    //CONVERT TỌA ĐỘ HỆ GRID VÀ WORLD

    //TÁCH RA 1 CÁI NÀY VÌ CHO THẰNG PREBUILDER VFA BUILDVIEW NÓ TRA CỨU QUA THẰNG NÀY CHỨ K THAM CHIẾU BỌN KIA THẢ VÀO

    #region CHỌC TỚI TILEMANAGERVIEW TRA CỨU ::

    // public Vector3 GridIndexToLocalVector(GridIndex index)
    // {
    //     return tileManagerView.GridIndexToLocalVector(index);
    // }

    public GridPoint WorldVectorToGridPoint(Vector3 worldPosition)
    {
        return tileManagerView.WorldVectorToGridPoint(worldPosition);
    }

    public Vector2Int WorldVectorToVector2Int(Vector3 worldPosition)
    {
        return tileManagerView.WorldVectorToVector2Int(worldPosition);
    }

    public Vector3 GridPointToWorldVector(GridPoint point)
    {
        return tileManagerView.GridPointToWorldVector(point);
    }
    
    public Vector3 GridPointToWorldVector(GridIndex index)
    {
        return tileManagerView.GridPointToWorldVector(index);
    }

    #endregion
}