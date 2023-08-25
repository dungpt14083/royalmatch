using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

//Thay gridmanager làm hệ quản lí hệ vị trí các thứ
public class TileManager
{
    public delegate void MovedEventHandler(IGridObject gridObject);

    public delegate void FlippedEventHandler(IGridObject gridObject);

    public delegate void UnBlockTileEventHandler();


    public delegate void UpdateReservedTilesEventHandler();


    public event UpdateReservedTilesEventHandler UpdateReservedTilesEvent;

    private void FireUpdateReservedTilesEvent()
    {
        this.UpdateReservedTilesEvent?.Invoke();
    }


    public event UnBlockTileEventHandler UnBlockTileEvent;

    private void FireUnBlockTileEvent(Vector2Int pos)
    {
        if (this.UnBlockTileEvent != null)
        {
            this.UnBlockTileEvent();
        }
    }


    public IslandId AdventureId;

    //Lưu tất cả vị trí khả dụng trong map từ thằng tileplane gọi lên::LÀ CÁC VỊ TRÍ TRONG MAP KHẢ DỤNG
    private HashSet<Vector2Int> _availableTiles;

    //LIST TẤT CẢ NHÀ TRONG GAME CHẢ ĐỂ LÀM GÌ???
    private List<IGridObject> _activeTileElements;


    //2 CÁI NÀY CÒN CÓ BIẾN THỂ PHẢI XỬ LÍ BLOCK BỞI RÁC HOẶC BLOCK BOI BLOCK NỮA::::

    //CÁC VỊ TRÍ ĐÃ ĐẶT NHÀ VÀ ID NHÀ À?
    private Dictionary<Vector2Int, IGridObject> _reservedTiles;

    //1 là block bởi reachable:::0 là block bởi rác
    private Dictionary<Vector2Int, int> _blockedTiles;

    //Chiều cao của đất sẽ được setting sau này sẽ tính sau::
    public Dictionary<Vector2Int, float> TileHeights;

    //Block bởi unrachable và block bởi asset
    public Dictionary<Vector2Int, int> BlockedTiles => _blockedTiles;
    public HashSet<Vector2Int> AvailableTiles => _availableTiles;
    public Dictionary<Vector2Int, IGridObject> ReservedTiles => _reservedTiles;


    public bool IsValidPosition(Vector2Int vector2Int)
    {
        return _availableTiles.Contains(vector2Int) && !_reservedTiles.ContainsKey(vector2Int) &&
               !_blockedTiles.ContainsKey(vector2Int);
    }


    #region CLOUDREVESER::::::

    //THÊM 1 CAI QUẢN LÍ MÂY TỪ ĐÓ XÉT CẢ XEM MÂY ĐÃ MỞ RA CHƯA THÌ MỚI CHO BỎ VÀO::::
    private Dictionary<Vector2Int, IGridObject> _activeClouds;

    public void RegisterAvailableTileCloud(IGridObject gridObject)
    {
        var area = gridObject.Area;
        int u = area.Index.U;
        GridSize size = area.Size;
        for (int num = u + size.U - 1; num >= area.Index.U; num--)
        {
            int v = area.Index.V;
            GridSize size2 = area.Size;
            for (int num2 = v + size2.V - 1; num2 >= area.Index.V; num2--)
            {
                _activeClouds.Add(new Vector2Int(num, num2), gridObject);
            }
        }
    }

    public void UnRegisterAvailableTileCloud(IGridObject gridObject)
    {
        var area = gridObject.Area;
        int u = area.Index.U;
        GridSize size = area.Size;
        for (int num = u + size.U - 1; num >= area.Index.U; num--)
        {
            int v = area.Index.V;
            GridSize size2 = area.Size;
            for (int num2 = v + size2.V - 1; num2 >= area.Index.V; num2--)
            {
                _activeClouds.Remove(new Vector2Int(num, num2));
            }
        }
    }

    #endregion


    #region FORINIT AWKAE SCENE OPEN

    //Tile Awake sẽ gọi để mà đăng kí:::==> phải clear sạch data trước khi..
    public void RegisterAvailableTile(Vector2Int position)
    {
        if (_availableTiles != null && !_availableTiles.Contains(position))
        {
            _availableTiles.Add(new Vector2Int(position.x, position.y));
        }
    }

    public void UnRegisterAvailableTile(Vector2Int position)
    {
        if (_availableTiles.Contains(position))
        {
            _availableTiles.Remove(new Vector2Int(position.x, position.y));
        }
    }

    #endregion


    #region ADDANDREMOVE IGRIDOBJECT VÀO RA TÒA NHÀ:::

    //cái này phải lấy size để đưa vào list dự tr nữa::: add nhà vào ấy//Mây cũng s đưa vào?
    public bool RegisterTileElement(IGridObject element, bool startBuilding)
    {
        //PHẢI DỰA VÀO LOẠI NÀO ĐỂ ĐƯA VÀO LIST BLOCK NỮA::


        if (startBuilding)
        {
            _activeTileElements.Add(element);
            Add(element);
        }
        else
        {
            //Check xem thử các thứ???chắc k ần phức tạp ở đây??? tạm bỏ qua k check
            //THÊM ĐIỀU KIỆN CHO VIỆC VỊ TRÍ CHƯA MỞ 
            if (!IsOpenArea(element.Area))
            {
                Debug.LogErrorFormat(
                    "GridObject's '{0}' Area overlaps with existing object or is placed in a non-buildable area.",
                    element.Area.ToString());
                return false;
            }
            else
            {
                _activeTileElements.Add(element);
                Add(element);
            }
        }

        return true;
    }


    public void UnRegisterTileElement(IGridObject element)
    {
        if (_activeTileElements.Contains(element))
        {
            _activeTileElements.Remove(element);
            Remove(element);
        }
    }

    private void Add(IGridObject gridObject)
    {
        gridObject.MovedEvent += GridObjectMovedEvent;
        UpdateArea(gridObject);
    }

    //Đưa vào trong reservedtiles::
    private void UpdateArea(IGridObject gridObject)
    {
        var area = gridObject.Area;
        int u = area.Index.U;
        GridSize size = area.Size;
        bool needUpdateTileAccess = false;
        for (int num = u + size.U - 1; num >= area.Index.U; num--)
        {
            int v = area.Index.V;
            GridSize size2 = area.Size;
            for (int num2 = v + size2.V - 1; num2 >= area.Index.V; num2--)
            {
                Vector2Int position = new Vector2Int(num, num2);
                if (!_reservedTiles.ContainsKey(position))
                {
                    _reservedTiles.Add(position, gridObject);
                    needUpdateTileAccess = true;
                    if (gridObject is Building)
                    {
                        //BlockTile(position);
                        var tmp = (Building)gridObject;
                        if (tmp.Gatherable != null || tmp.Ruin != null)
                        {
                            BlockTile(position);
                        }
                    }
                }
                else
                {
                    if (_reservedTiles[position] == null)
                    {
                        _reservedTiles[position] = gridObject;
                        needUpdateTileAccess = true;
                        if (gridObject is Building)
                        {
                            //BlockTile(position);
                            var tmp = (Building)gridObject;
                            if (tmp.Gatherable != null || tmp.Ruin != null)
                            {
                                BlockTile(position);
                            }
                        }
                    }
                }
            }
        }

        if (needUpdateTileAccess)
        {
            FireUpdateReservedTilesEvent();
        }
    }


    private void GridObjectMovedEvent(IGridObject gridObject)
    {
        //check nếu hợp lệ lần nữa thì remove và add ở chỗ mới
        Remove(gridObject);
        Add(gridObject);
    }

    private void Remove(IGridObject gridObject)
    {
        var area = gridObject.Area;
        int u = area.Index.U;
        GridSize size = area.Size;

        bool needUpdateTileAccess = false;


        for (int num = u + size.U - 1; num >= area.Index.U; num--)
        {
            int v = area.Index.V;
            GridSize size2 = area.Size;
            for (int num2 = v + size2.V - 1; num2 >= area.Index.V; num2--)
            {
                if (_reservedTiles.ContainsKey(new Vector2Int(num, num2)) &&
                    _reservedTiles[new Vector2Int(num, num2)] == gridObject)
                {
                    _reservedTiles.Remove(new Vector2Int(num, num2));
                    needUpdateTileAccess = true;
                }

                //NẾU MÀ LOẠI KIA THÌ REMOVE ĐI NHƯ RÁC:::
                if (gridObject is Building)
                {
                    if (((Building)gridObject).Gatherable != null || ((Building)gridObject).Ruin != null)
                    {
                        needUpdateTileAccess = false;
                        UnBlockTile(new Vector2Int(num, num2));
                    }
                }
            }
        }

        if (needUpdateTileAccess)
        {
            FireUpdateReservedTilesEvent();
        }

        gridObject.MovedEvent -= GridObjectMovedEvent;
    }

    //tí tính
    public void BlockTile(Vector2Int pos, int isGatherable = 0)
    {
        if (_blockedTiles.ContainsKey(pos)) return;
        _blockedTiles.Add(pos, isGatherable);
    }

    public void UnBlockTile(Vector2Int pos)
    {
        if (!_blockedTiles.ContainsKey(pos)) return;
        _blockedTiles.Remove(pos);
        FireUnBlockTileEvent(pos);
    }

    #endregion


    #region CÁC TIỆN ÍCH CHECK VỊ TRÍ KHẢ DỤNG:: //LƯU Ý XÉT VN DỰA DỰA TILEMAP???VÀ THỰC RA TILEMAP VỚI KIA GIỐNG NHAU NHƯNG MÀ VẪN XÀI?

    #region TÌM VỊ TRÍ HỢP LỆ TRONG HỆ GRID

    //Nó sẽ bỏ qua chính nó
    public bool IsOpenArea(GridArea area, IGridObject ignoreObject = null)
    {
        return IsOpenArea(area.Index, area.Size, ignoreObject);
    }

    public bool IsOpenArea(GridIndex index, GridSize size, IGridObject ignoreObject = null)
    {
        return IsOpenArea(index.U, index.V, size, ignoreObject);
    }

    //Bỏ qua cái thằng vụ Ignore:::
    public bool IsOpenArea(int u, int v, GridSize size, IGridObject ignoreObject = null)
    {
        for (int num = u + size.U - 1; num >= u; num--)
        {
            for (int num2 = v + size.V - 1; num2 >= v; num2--)
            {
                if (!IsBuildable(num, num2, ignoreObject))
                {
                    return false;
                }
            }
        }

        return true;
    }


    //XÉT VỊ TRÍ CÓ THỂ BUILD HAY K DỰA VÀO các vị trí khả dụng sau
    public bool IsBuildable(int u, int v, IGridObject ignoreObject = null)
    {
        var tmpVector2Int = new Vector2Int(u, v);
        if ((_reservedTiles.ContainsKey(tmpVector2Int) && _reservedTiles[tmpVector2Int] != ignoreObject) ||
            (!_availableTiles.Contains(tmpVector2Int) ||
             _blockedTiles.ContainsKey(tmpVector2Int))) return false;
        if (_activeClouds != null && _activeClouds.ContainsKey(tmpVector2Int)) return false;

        return true;
    }

    #endregion

    public IGridObject FindGridObject(GridPoint gridPoint)
    {
        var tmpVector2Int = new Vector2Int((int)gridPoint.U, (int)gridPoint.V);
        if (_reservedTiles.ContainsKey(tmpVector2Int)) return _reservedTiles[tmpVector2Int];
        return null;
    }

    public bool IsTileExist(Vector2Int position)
    {
        if (_availableTiles.Contains(position)) return true;
        return false;
    }

    public bool IsTileReserved(Vector2Int position)
    {
        if (_reservedTiles.ContainsKey(position) && _reservedTiles[position] != null) return true;
        return false;
    }

    #endregion


    #region INIT CONTRUCTOR::

    //DO CƠ CHẾ LÀ MỖI LẦN VÀO GAME INIT HẾT TILEMANAGER BUILDINGỞ TẤT CẢ ĐẢO NÊN LÀ SẼ K ĐƯỢC XÓA ACTIVETILELEMENT RESERVEDTILE VÀ BLOCKTILE CHỈ XÓA AVAILABLE TILES
    //cách 2 cho vấn đê này khi bọn kia awake thì sẽ đăng kí vào đây nhưng cách đó khá bất tiện cho việc bắt sự kiện khi nào cái này được init thành công
    //Để mà cho tileacess và clound nó chạy....cái available thì bắt được còn? chạy ở hàm start ...Bọn kia đăng kí ở awake tileplane thì tới start mới chạy tileacess mà clound
    //Còn building thì
    public TileManager(IslandId id)
    {
        AdventureId = id;
        _availableTiles = new HashSet<Vector2Int>();
        _activeTileElements = new List<IGridObject>();
        _reservedTiles = new Dictionary<Vector2Int, IGridObject>();
        _blockedTiles = new Dictionary<Vector2Int, int>();
        _activeClouds = new Dictionary<Vector2Int, IGridObject>();
    }

    public void ResetForNewSession(IslandId id)
    {
        AdventureId = id;
        if (_availableTiles != null)
        {
            _availableTiles.Clear();
        }
        else
        {
            _availableTiles = new HashSet<Vector2Int>();
        }

        if (_activeClouds != null)
        {
            _activeClouds.Clear();
        }
        else
        {
            _activeClouds = new Dictionary<Vector2Int, IGridObject>();
        }


        if (_activeTileElements == null)
        {
            _activeTileElements = new List<IGridObject>();
        }

        if (_reservedTiles == null)
        {
            _reservedTiles = new Dictionary<Vector2Int, IGridObject>();
        }

        if (_blockedTiles == null)
        {
            _blockedTiles = new Dictionary<Vector2Int, int>();
        }
    }

    #endregion
}