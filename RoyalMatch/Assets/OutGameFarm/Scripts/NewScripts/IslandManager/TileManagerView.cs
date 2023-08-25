using System;
using EasyButtons;
using UnityEngine;
using UnityEngine.UI;

//ĐẠI DIỆN CHO VIEW LẤY DATA ONAWAKE CỦA TILEPLANE VÀ TRUY VẤN GRID HỆ TỌA ĐỘ
//2 MỤC ĐÍCH :
//-1 LÀ CHO TRUY XUẤT TỌA ĐỘ GRID
//-2 LÀ CHO VIỆC INIT AVAILABLE DATA BAN ĐẦU - VÌ DATA SỐNG SCENE AWAKE
public class TileManagerView : MonoSingleton<TileManagerView>
{
    //[SerializeField] private NavMeshSurface navMeshSurface;
    [SerializeField] private Grid mainGrid;
    [SerializeField] private TileAccessManagerView tileAccessManagerView;

    private IsLandInfo _isLandInfo;
    private TileManager _tileManager;

    private IsLandInfo IsLandInfo => _isLandInfo;


    public void Init(IsLandInfo isLandInfo)
    {
        _isLandInfo = isLandInfo;
        _tileManager = _isLandInfo.TileManager;
        _tileManager.UnBlockTileEvent += UpdateTileAccessManagerView;
        _tileManager.UpdateReservedTilesEvent += UpdateTileAccessManagerView;
    }

    private void OnDestroy()
    {
        if (_tileManager != null)
        {
            _tileManager.UnBlockTileEvent -= UpdateTileAccessManagerView;
            _tileManager.UpdateReservedTilesEvent -= UpdateTileAccessManagerView;
        }
    }

    //DƯỚI ĐÂY SẼ LÀ CÁC HÀM CHO VIỆC QUẢN LÍ TILE INIT DATA TU NGOÀI VIEW VÀO:::

    #region QUẢN LÍ HỆ THỐNG TILE TỪ GRIDVIEW SANG CUNG CẤP TIỆN ÍCH CONVERT

    public Vector3 GridIndexToLocalVector(Vector2Int index)
    {
        return mainGrid.GetCellCenterLocal(new Vector3Int(index.x, index.y, 0));
    }

    public Vector3 GridIndexToLocalVector(GridIndex index)
    {
        return mainGrid.GetCellCenterLocal(new Vector3Int(index.U, index.V, 0));
    }


    public GridPoint WorldVectorToGridPoint(Vector3 worldPosition)
    {
        var tmp = mainGrid.WorldToCell(worldPosition);
        return new GridPoint(tmp.x, tmp.y);
    }

    public Vector2Int WorldVectorToVector2Int(Vector3 worldPosition)
    {
        var tmp = mainGrid.WorldToCell(worldPosition);
        return new Vector2Int(tmp.x, tmp.y);
    }


    public Vector3 GridPointToWorldVector(Vector2Int vector2)
    {
        return mainGrid.CellToWorld(new Vector3Int(vector2.x, vector2.y, 0));
    }

    public Vector3 GridPointToWorldVector(GridPoint point)
    {
        return mainGrid.CellToWorld(new Vector3Int((int)point.U, (int)point.V, 0));
    }

    public Vector3 GridPointToWorldVector(GridIndex gridIndex)
    {
        return mainGrid.CellToWorld(new Vector3Int((int)gridIndex.U, (int)gridIndex.V, 0));
    }

    public Vector3 Vector2IntToWorldVector(Vector2Int point)
    {
        return mainGrid.CellToWorld(new Vector3Int((int)point.x, (int)point.y, 0));
    }

    #endregion


    public bool IsFreeAndValidPosition(Vector3 vector3)
    {
        var tmpPositionVector2Int = WorldVectorToVector2Int(vector3);
        return _tileManager.IsValidPosition(tmpPositionVector2Int);
    }


    #region UNTILITY CHO VIỆC ĐĂNG KÍ MAP KHI MỞ LÊN

    public void RegisterAvailableTile(Vector3 position)
    {
        var position2 = WorldVectorToVector2Int(position);
        _tileManager.RegisterAvailableTile(position2);
    }

    public void UnRegisterAvailableTile(Vector2Int position)
    {
        _tileManager.UnRegisterAvailableTile(position);
    }

    //BlockByPlane
    public void BlockTileByTilePlane(Vector3 position)
    {
        var position2 = WorldVectorToVector2Int(position);
        _tileManager.BlockTile(position2, 1);
    }


    //Unblock:::thao tác khi phá hủy nhà bla bla đât là cho test
    [Button]
    public void TestUnBlockTile(Vector2 pos)
    {
        _tileManager.UnBlockTile(new Vector2Int((int)pos.x, (int)pos.y));
    }


    private void UpdateTileAccessManagerView()
    {
        tileAccessManagerView.Refresh();
        //navMeshSurface.BuildNavMesh();
    }

    public bool IsTileReached(GridArea area)
    {
        return tileAccessManagerView.IsTileReached(area);
    }

    public bool IsTileReached(Vector3 vector3)
    {
        var tmp = WorldVectorToVector2Int(vector3);
        return tileAccessManagerView.IsTileReached(tmp);
    }


    public bool GetClosePositionToElement(GridArea area, out Vector3 positionToWalk)
    {
        if (tileAccessManagerView.TryGetClosestAccessibleTileAroundTileByMaxDistance(
                new Vector2Int(area.Index.U, area.Index.V), 1, out Vector2Int result))
        {
            //Debug.LogError("Position tile" + result.ToString());
            positionToWalk = GridIndexToLocalVector(result);
            return true;
        }

        positionToWalk = Vector3.zero;
        return false;
    }

    #endregion


    public IGridObject FindGridObject(GridPoint gridPoint)
    {
        return _tileManager.FindGridObject(gridPoint);
    }


    #region TODOCLICKPLANE::::::::

    public event TilePlane.TilePlanePressHandler TilePlanePressEvent;

    public void FireTilePlanePressEvent(Vector3 worldClickPosition)
    {
        if (this.TilePlanePressEvent != null)
        {
            this.TilePlanePressEvent(worldClickPosition);
        }
    }

    #endregion


    #region Commandgatherable:::

    public delegate void TileCollectGatherablePressHandler(GatherableBuilding building);

    public event TileCollectGatherablePressHandler TileCollectGatherablePressEvent;

    public void FireTileCollectGatherableEvent(GatherableBuilding building)
    {
        if (this.TileCollectGatherablePressEvent != null)
        {
            this.TileCollectGatherablePressEvent(building);
        }
    }

    #endregion


    #region CommandFruitTree

    public delegate void TileCollectTreeFruitPressHandler(FruitTreeBuilding building);

    public event TileCollectTreeFruitPressHandler TileCollectTreeFruitPressEvent;

    public void FireTileCollectTreeFruitEvent(FruitTreeBuilding building)
    {
        if (this.TileCollectTreeFruitPressEvent != null)
        {
            this.TileCollectTreeFruitPressEvent(building);
        }
    }

    #endregion

    #region CommandItemBonus

    public Action<ItemBonus> TileCollectItemBonusPressEvent;

    public void FireTileCollectItemBonusEvent(ItemBonus building)
    {
        if (this.TileCollectItemBonusPressEvent != null)
        {
            this.TileCollectItemBonusPressEvent(building);
        }
    }

    #endregion

    #region CommandBonusTree

    public delegate void TileCollectBonusTreePressHandler(BonusTreeBuilding building);

    public event TileCollectBonusTreePressHandler TileCollectBonusTreePressEvent;

    public void FireTileCollectBonusTreeEvent(BonusTreeBuilding building)
    {
        if (this.TileCollectBonusTreePressEvent != null)
        {
            this.TileCollectBonusTreePressEvent(building);
        }
    }

    #endregion

    #region GETSPRITEBUILDING

    public Sprite GetSpriteByElementId(int elementId)
    {
        Building building = FindBuildingByElementId(elementId);
        if (building != null)
        {
            UpgradeBuildingSprites upgradeBuildingSprites =
                SingletonMonobehaviour<UpgradeBuildingSpritesAssetCollection>.Instance.GetAsset(
                    building.BuildingProperties.SpriteReference);
            if (upgradeBuildingSprites != new UpgradeBuildingSprites())
            {
                //lấy ảnh level 1 là level sau tàn tích
                return upgradeBuildingSprites.GetBuildingSpritesWithLevel(1);
            }
        }

        return null;
    }

    public Building FindBuildingByElementId(int elementId)
    {
        return _isLandInfo.FindBuildingByElementId(elementId);
    }

    #endregion
}