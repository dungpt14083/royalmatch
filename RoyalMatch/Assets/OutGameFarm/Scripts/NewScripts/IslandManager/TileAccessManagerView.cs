using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class TileAccessManagerView : MonoBehaviour
{
    #region EVENT TILEACESS

    public delegate void TileAccessStatusChangeHandler();

    public event TileAccessStatusChangeHandler TileAccessStatusChangeEvent;

    protected void FireTileAccessStatusChangeEvent()
    {
        if (this.TileAccessStatusChangeEvent != null)
        {
            this.TileAccessStatusChangeEvent();
        }
    }

    #endregion

    [SerializeField] private Vector3Int startPoint;

    [FormerlySerializedAs("gridIgridGridView")] [FormerlySerializedAs("gridView")] [SerializeField]
    private GridIgridObjectView gridIgridObjectView;

    //CHÚ Ý THẰNG NÀY NOTVISIT???VÀ CÓ THỂ ACESSS?
    private Dictionary<Vector2Int, AccessStatus> _tileAccessStatus;

    //Dành cho thuật toán tìm kiếm thằng tile truy cập được theo thuật toán tìm kiếm:::
    private HashSet<Vector2Int> _reachedTiles;
    public HashSet<Vector2Int> ReachedTiles => _reachedTiles;

    public Vector3Int StartPoint => startPoint;


    private IsLandInfo _isLandInfo;

    private TileManager TileManager { get; set; }


    //CHỜ TỚI KHI MÀ BỌN KIA TẠO XONG NHÀ CỬA CÁC VẬT THỂ THÌ MỚI INIT LIST NÀY
    //KhI VÀO ĐÂY THÌ CÓ AVAILABLE LIST RỒI:::
    //CUXNG CÓ DATA CỦA BỌN KIA LOCK VS K LOCK RỒI CHỈ VIỆC LẤY XÀI THÔI
    public void Init(IsLandInfo isLandInfo)
    {
        //Sau đó lấy bên tilemanager gọi lên
        _tileAccessStatus = new Dictionary<Vector2Int, AccessStatus>();
        _reachedTiles = new HashSet<Vector2Int>();
        _isLandInfo = isLandInfo;
        TileManager = isLandInfo.TileManager;
        Executors.Instance.StartCoroutine(DelayFrame());
    }

    private IEnumerator DelayFrame()
    {
        yield return new WaitForSeconds(0.7f);
        Refresh();
    }


    //Gọi phát refresh chạy luôn khi mà gm rác 
    //Tư tưởng tileacesss chỉ xét tới thằng nào mà nó sẽ truy cập được còn k quan tâm tới tất cả :::còn mây khả năng lấy từ tilemanager::đúng v:::
    [Button]
    public void Refresh()
    {
        UpdateAccessableTiles();
        FireTileAccessStatusChangeEvent();
    }


    private void UpdateAccessableTiles()
    {
        this._reachedTiles.Clear();

        if (_tileAccessStatus == null) return;
        _tileAccessStatus.Clear();


        // for (int i = 0; i < TileManager.AvailableTiles.Count; i++)
        // {
        //     if (TileManager.BlockedTiles.ContainsKey(TileManager.AvailableTiles[i]))
        //     {
        //         _tileAccessStatus[TileManager.AvailableTiles[i]] = AccessStatus.Blocked;
        //     }
        //     else
        //     {
        //         //CHỈ QUAN TÂM BLOCK VÀ K BLOCK BỎ QUA HẾT CÁI NHÀ Ở TRÊN ĐI VÌ NÓ K THAM GIA VÀO TILEACESS VÙNG
        //         //KHI DI CHUYỂN TRÁNH NÓ ĐI LÀ ĐƯỢC ĐỪNG Ở Ô ĐẤY LÀ ĐC
        //
        //
        //         // if (TileManager.IsTileReserved(tile))
        //         // {
        //         //     _tileAccessStatus[tile] = AccessStatus.NotVisited;
        //         // }
        //         // else
        //         // {
        //         _tileAccessStatus[TileManager.AvailableTiles[i]] = AccessStatus.Accessable;
        //         //}
        //     }
        // }


        foreach (var tile in TileManager.AvailableTiles)
        {
            if (TileManager.BlockedTiles.ContainsKey(tile))
            {
                _tileAccessStatus[tile] = AccessStatus.Blocked;
            }
            else
            {
                //CHỈ QUAN TÂM BLOCK VÀ K BLOCK BỎ QUA HẾT CÁI NHÀ Ở TRÊN ĐI VÌ NÓ K THAM GIA VÀO TILEACESS VÙNG
                //KHI DI CHUYỂN TRÁNH NÓ ĐI LÀ ĐƯỢC ĐỪNG Ở Ô ĐẤY LÀ ĐC


                // if (TileManager.IsTileReserved(tile))
                // {
                //     _tileAccessStatus[tile] = AccessStatus.NotVisited;
                // }
                // else
                // {
                _tileAccessStatus[tile] = AccessStatus.Accessable;
                //}
            }
        }


        var startPosition = new Vector2Int(startPoint.x, startPoint.z);
        CheckNeighbours(startPosition);
        //Debug.LogError("todo");
    }

    // private UnityEngine.Vector2Int[] directions =
    // {
    //     UnityEngine.Vector2Int.up, UnityEngine.Vector2Int.left, UnityEngine.Vector2Int.down,
    //     UnityEngine.Vector2Int.right
    // };


    //tìm ô lân cận và phải nằm trong available còn lại nằm ngoài k xét như núi
    public void CheckNeighbours(Vector2Int pos)
    {
        #region DÙNG QUUE HƠI NẶNG

        // Queue<Vector2Int> queue = new Queue<Vector2Int>();
        // queue.Enqueue(new Vector2Int(startPoint.x, startPoint.z));
        // while (queue.Count > 0)
        // {
        //     Vector2Int currentPos = queue.Dequeue();
        //     if (!TileManager.IsTileExist(currentPos)) continue;
        //     if (_tileAccessStatus.TryGetValue(currentPos, out AccessStatus status))
        //     {
        //         if (status == AccessStatus.Blocked)
        //         {
        //             _reachedTiles.Add(currentPos);
        //             continue;
        //         }
        //     }
        //
        //     //NẾU MÀ Ô TIẾP CÓ THỂ TRUY CAP THÌ SẼ 
        //     _tileAccessStatus[currentPos] = AccessStatus.Accessable;
        //     _reachedTiles.Add(currentPos);
        //
        //     Vector2Int[] neighbours = new Vector2Int[]
        //     {
        //         currentPos + Vector2Int.up,
        //         currentPos + Vector2Int.left,
        //         currentPos + Vector2Int.down,
        //         currentPos + Vector2Int.right
        //     };
        //
        //     for (int i = 0; i < neighbours.Length; i++)
        //     {
        //         if (!_reachedTiles.Contains(neighbours[i]))
        //         {
        //             if (!queue.Contains(neighbours[i]))
        //             {
        //                 queue.Enqueue(neighbours[i]);
        //             }
        //         }
        //     }
        // }
        //
        //
        // for (int i = 0; i < _reachedTiles.Count; i++)
        // {
        //     if (_tileAccessStatus.ContainsKey(_reachedTiles[i]))
        //     {
        //         _tileAccessStatus[_reachedTiles[i]] = AccessStatus.Accessable;
        //     }
        //     else
        //     {
        //         _tileAccessStatus.Add(_reachedTiles[i], AccessStatus.Accessable);
        //     }
        // }

        #endregion


        Queue<Vector2Int> queue = new Queue<Vector2Int>();
        HashSet<Vector2Int> visited = new HashSet<Vector2Int>();

        queue.Enqueue(new Vector2Int(startPoint.x, startPoint.z));
        visited.Add(new Vector2Int(startPoint.x, startPoint.z));

        while (queue.Count > 0)
        {
            Vector2Int currentPos = queue.Dequeue();
            if (!TileManager.IsTileExist(currentPos)) continue;
            if (_tileAccessStatus.TryGetValue(currentPos, out AccessStatus status))
            {
                if (status == AccessStatus.Blocked)
                {
                    continue;
                }
            }

            _tileAccessStatus[currentPos] = AccessStatus.Accessable;

            Vector2Int[] neighbours = new Vector2Int[]
            {
                currentPos + Vector2Int.up,
                currentPos + Vector2Int.left,
                currentPos + Vector2Int.down,
                currentPos + Vector2Int.right
            };

            for (int i = 0; i < neighbours.Length; i++)
            {
                if (!visited.Contains(neighbours[i]))
                {
                    //chưa key thì mới đưa vào chứ nhỉ lỗi đoạn này:::
                    if (_tileAccessStatus.ContainsKey(neighbours[i]))
                    {
                        queue.Enqueue(neighbours[i]);
                        visited.Add(neighbours[i]);
                    }
                }
            }
        }

        _reachedTiles = visited;
    }


    #region CÁC UTILITY TRONG NÀY:::

    public void SetTileAccessStatus(Vector2Int pos, AccessStatus status)
    {
        this._tileAccessStatus[pos] = status;
    }

    //Check có thể accessable
    //DÙNG CHO VIỆC ẤN VÀO TRONG PALNE
    public bool IsPositionAccessable(UnityEngine.Vector3 position)
    {
        //Chuyển sang he grid từ vị trí thế giới từ đó sẽ check
        var tmpGridPosition = gridIgridObjectView.WorldVectorToVector2Int(position);
        var tmp = _tileAccessStatus.TryGetValue(tmpGridPosition, out AccessStatus status);
        return tmp && status == AccessStatus.Accessable;
    }

    //Check vị trí này có thể đã đi tới
    public bool IsPositionVisited(UnityEngine.Vector3 position)
    {
        var tmpGridPosition = gridIgridObjectView.WorldVectorToVector2Int(position);
        return IsPositionVisited(tmpGridPosition);
    }

    public bool IsPositionVisited(Vector2Int tilePosition)
    {
        AccessStatus accessStatus;
        return _tileAccessStatus.TryGetValue(tilePosition, out accessStatus);
    }

    public bool IsTileAccessable(UnityEngine.Vector2Int tile)
    {
        AccessStatus accessStatus;
        bool hasAccessStatus = _tileAccessStatus.TryGetValue(tile, out accessStatus);
        bool isAccessable = hasAccessStatus && accessStatus == AccessStatus.Accessable;
        return isAccessable;
    }

    public bool IsTileReached(GridArea area)
    {
        return IsTileReached(area.Index, area.Size);
    }

    public bool IsTileReached(GridIndex index, GridSize size)
    {
        return IsTileReached(index.U, index.V, size);
    }

    //CHO THẰNG AREA DUYỆT QUA LIST VÀ CÁC VỊ TRÍ TRONG ĐÓ ĐỂ :::
    public bool IsTileReached(int u, int v, GridSize size)
    {
        for (int num = u + size.U - 1; num >= u; num--)
        {
            for (int num2 = v + size.V - 1; num2 >= v; num2--)
            {
                if (_reachedTiles == null ||
                    (_reachedTiles != null && !_reachedTiles.Contains(new Vector2Int(num, num2))))
                {
                    return false;
                }
            }
        }

        return true;
    }

    //DÙNG CHO THẰNG GRABLE CHECK:::
    public bool IsTileReached(Vector2Int tilePosition)
    {
        if (_reachedTiles != null)
        {
            return _reachedTiles.Contains(tilePosition);
        }

        return false;
    }


    //LẤY VỊ TRÍ NÀY PHẢI TRÁNH Ô DỰ TRỮ NCH LÀ Ô TRUY CẬP ĐƯỢC
    //LẤY VỊ TRÍ GẦN NHÂT QUANH ĐIỂM TILEPOS
    public bool TryGetClosestAccessibleTileAroundTileByMaxDistance(UnityEngine.Vector2Int tilePos, int distance,
        out Vector2Int result)
    {
        result = Vector2Int.zero;
        List<Vector2Int> accessibleTiles =
            GetAccessibleTilesAroundTile(tilePos, distance, 1);

        if (accessibleTiles.Count == 0)
        {
            return false;
        }

        var closest = FindNearestPoint(tilePos, accessibleTiles);
        result = new Vector2Int(closest.x, closest.y);
        return true;
    }

    public Vector2Int FindNearestPoint(Vector2Int tilePos, List<Vector2Int> pointList)
    {
        Vector2Int closestPoint = Vector2Int.zero;
        float closestDistance = Mathf.Infinity;

        foreach (Vector2Int point in pointList)
        {
            if (tilePos == point) continue;

            float distance = Vector2Int.Distance(tilePos, point);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestPoint = point;
            }
        }

        return closestPoint;
    }

    //TÌM VỊ TRÍ KHẢ DỤNG Ở BÁNH KÍNH XUNG QUANH NÓ::
    public List<Vector2Int> GetAccessibleTilesAroundTile(Vector2Int centerTile, int maxDistance, int minDistance = 1)
    {
        List<Vector2Int> accessibleTiles = new List<UnityEngine.Vector2Int>();

        if (minDistance > maxDistance)
        {
            return accessibleTiles;
        }

        for (int x = -maxDistance; x <= maxDistance; x++)
        {
            for (int y = -maxDistance; y <= maxDistance; y++)
            {
                Vector2Int tile = new Vector2Int(centerTile.x + x, centerTile.y + y);
                if (IsTileAccessable(tile) && !accessibleTiles.Contains(tile) && IsTileReached(tile) &&
                    !TileManager.BlockedTiles.ContainsKey(tile) && !TileManager.IsTileReserved(tile))
                {
                    accessibleTiles.Add(tile);
                }
            }
        }

        return accessibleTiles;
    }


    public bool TryGetRandomAccessibleTileAroundTileByMaxDistance(UnityEngine.Vector2Int tilePos, int distance,
        out Vector2Int result)
    {
        result = Vector2Int.zero;
        List<Vector2Int> accessibleTiles =
            GetAccessibleTilesAroundTile(centerTile: tilePos, maxDistance: distance, minDistance: 1);

        if (accessibleTiles.Count == 0)
        {
            return false;
        }

        int randomIndex = Random.Range(0, accessibleTiles.Count);


        Vector2Int randomTile = accessibleTiles[randomIndex];
        result = new Vector2Int(randomTile.x, randomTile.y);
        return true;
    }

    public bool HasNonVisitedNeighbour(UnityEngine.Vector2Int pos)
    {
        bool IsPositionValidAndNotVisited(UnityEngine.Vector2Int position)
        {
            return TileManager.IsTileExist(position) && !this.IsPositionVisited(position);
        }

        UnityEngine.Vector2Int upPosition = pos + UnityEngine.Vector2Int.up;
        if (IsPositionValidAndNotVisited(upPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int downPosition = pos + UnityEngine.Vector2Int.down;
        if (IsPositionValidAndNotVisited(downPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int leftPosition = pos + UnityEngine.Vector2Int.left;
        if (IsPositionValidAndNotVisited(leftPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int rightPosition = pos + UnityEngine.Vector2Int.right;
        if (IsPositionValidAndNotVisited(rightPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int rightUpPosition = pos + UnityEngine.Vector2Int.right + UnityEngine.Vector2Int.up;
        if (IsPositionValidAndNotVisited(rightUpPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int rightDownPosition = pos + UnityEngine.Vector2Int.right + UnityEngine.Vector2Int.down;
        if (IsPositionValidAndNotVisited(rightDownPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int leftUpPosition = pos + UnityEngine.Vector2Int.left + UnityEngine.Vector2Int.up;
        if (IsPositionValidAndNotVisited(leftUpPosition))
        {
            return true;
        }

        UnityEngine.Vector2Int leftDownPosition = pos + UnityEngine.Vector2Int.left + UnityEngine.Vector2Int.down;
        if (IsPositionValidAndNotVisited(leftDownPosition))
        {
            return true;
        }

        return false;
    }

    public IEnumerable<Vector2Int> GetAccessibleTiles()
    {
        if (_tileAccessStatus == null) return null;
        return _tileAccessStatus.Keys.ToList();
    }

    #endregion


    // #region SAVEANDLOAD:::DATA::
    //
    // private StorageDictionary _storage;
    //
    // public TileAccessManager(GridManager gridManager)
    // {
    //     GridManager = gridManager;
    // }
    //
    // public TileAccessManager(StorageDictionary storage)
    // {
    //     _storage = storage;
    // }
    //
    // public StorageDictionary Serialize()
    // {
    //     if (_storage == null)
    //     {
    //         _storage = new StorageDictionary();
    //     }
    //
    //     return _storage;
    // }
    //
    // public void ResolveDependencies(GridManager gridManager)
    // {
    //     GridManager = gridManager;
    // }
    //
    // #endregion
}