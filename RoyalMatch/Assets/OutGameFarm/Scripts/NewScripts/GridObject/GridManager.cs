using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

public class GridManager
{
    //NGHE Ự KIỆN MOVE VÀ FLOP CỦA GAMEOBJCTGRID ĐỂ Ừ ĐÓ INVOKE LẠI ĐỂ THẰNG NÀY BẮT MÀ XỬ LÍ CẬP HẬT THẰNG HỆ THỐNG GRID TRONG NÀY CHO CÁC Ô NÀO CHỨA NÓ
    //SẼ RẤT NHIỀU NƠI NGHE CHỨ K PHẢI MỖI Ở ĐÂY
    //public delegate void MovedEventHandler(IGridObject gridObject);

    //public delegate void FlippedEventHandler(IGridObject gridObject);

    /*
    //LƯU GRIDOBJECT VỚI AREA VỊ TRÍ
    private Dictionary<IGridObject, GridArea> _gridAreas;

    //Lưu lại vị trí đó tile có Gridobject không
    private IGridObject[,] _gridObjects;

    //TYPE CHO VIỆC TÒA NHÀ NÀY SẼ LÀ LOẠI NƯỚC HAY ĐẤT XÂY NHÀ THUYỀN
    private ElementType[,] _elements;

    //MARBG BUILDABLE LẤY TỪ THẰNG FILETILES
    private bool[,] _buildable;


    //DIỆN TÍCH TOÀN BỘ MAP::
    private GridArea _area;

    public GridArea Area
    {
        get { return _area; }
    }

    //TẠO THẰNG GRID DỰA VÀO MẢNG ISBUILDABLE::
    //ĐÂY LÀ BAN ĐẦU MỚI CÒN NẾU CŨ THÌ PHẢI ADD GRIDOBJECT VÀO
    public GridManager(bool[,] isBuildable)
    {
        _gridAreas = new Dictionary<IGridObject, GridArea>();
        //AREA SẼ INDEX NHƯ SAU VÀ BLA BLA
        _area = new GridArea(new GridIndex(0, 0), new GridSize(isBuildable.GetLength(0), isBuildable.GetLength(1)));
        _buildable = isBuildable;
        //XỬ LÍ THẰNG NƯỚC HAY ĐẤT
        _gridObjects = new IGridObject[_area.Size.U, _area.Size.V];
    }

    //truyền cả đống object vào để add vào nữa ngoài việc tạo grid thì còn nữa
    public GridManager(bool[,] isBuildable, List<IGridObject> gridObjects)
        : this(isBuildable)
    {
        int count = gridObjects.Count;
        for (int i = 0; i < count; i++)
        {
            AddGridObject(gridObjects[i]);
        }
    }

    public IGridObject FindGridObject(GridPoint gridPoint)
    {
        if (!IsWithinBounds(gridPoint))
        {
            return null;
        }

        return _gridObjects[(int)gridPoint.U, (int)gridPoint.V];
    }

    public IGridObject FindGridObject(GridIndex index)
    {
        if (!IsWithinBounds(index))
        {
            return null;
        }

        return _gridObjects[index.U, index.V];
    }

    
    
    
    
    
    
    //ADD GRIDBJECT VÀO TRONG HỆ THỐNG NÀY NHƯ SAU:::
    public void AddGridObject(IGridObject gridObject)
    {
        if (!IsWithinBounds(gridObject.Area))
        {
            Debug.LogErrorFormat("GridObject's '{0}' Area is out of bounds.", gridObject);
        }
        else if (!IsOpenArea(gridObject.Area))
        {
            Debug.LogErrorFormat(
                "GridObject's '{0}' Area overlaps with existing object or is placed in a non-buildable area.",
                gridObject);
        }
        else
        {
            Add(gridObject);
        }
    }

    public void RemoveGridObject(IGridObject gridObject)
    {
        if (!_gridAreas.ContainsKey(gridObject))
        {
            Debug.LogErrorFormat("Grid does not contain {0}.", gridObject);
        }
        else
        {
            Remove(gridObject);
        }
    }

    public bool IsWithinBounds(GridArea area)
    {
        return IsWithinBounds(area.Index, area.Size);
    }

    public bool IsWithinBounds(GridIndex index, GridSize size)
    {
        return IsWithinBounds(index.U, index.V, size);
    }

    public bool IsWithinBounds(GridPoint gridPoint)
    {
        return _area.IsWithinBounds(gridPoint);
    }

    public bool IsWithinBounds(GridIndex index)
    {
        return _area.IsWithinBounds(index);
    }

    public bool IsOpenArea(GridArea area, IGridObject ignoreObject = null)
    {
        return IsOpenArea(area.Index, area.Size, ignoreObject);
    }

    public bool IsOpenArea(GridIndex index, GridSize size, IGridObject ignoreObject = null)
    {
        return IsOpenArea(index.U, index.V, size, ignoreObject);
    }

    public bool IsOpenArea(int u, int v, GridSize size, IGridObject ignoreObject = null)
    {
        if (!IsWithinBounds(u, v, size))
        {
            return false;
        }

        for (int num = u + size.U - 1; num >= u; num--)
        {
            for (int num2 = v + size.V - 1; num2 >= v; num2--)
            {
                if (!IsBuildable(num, num2))
                {
                    return false;
                }

                if (_gridObjects != null)
                {
                    if (_gridObjects[num, num2] != null &&
                        (ignoreObject == null || _gridObjects[num, num2] != ignoreObject))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }

    private bool IsWithinBounds(int u, int v, GridSize size)
    {
        return _area.IsWithinBounds(u, v, size);
    }

    
    
    
    
    
    
    public bool IsBuildable(int u, int v)
    {
        return u >= 0 && v >= 0 && u < _buildable.GetLength(0) && v < _buildable.GetLength(1) && _buildable[u, v];
    }

    private void Add(IGridObject gridObject)
    {
        _gridAreas.Add(gridObject, gridObject.Area);
        Debug.LogError(gridObject.Area);
        UpdateArea(gridObject.Area, gridObject);
        //gridObject.MovedEvent += GridObjectMovedEvent;
    }

    private void Remove(IGridObject gridObject)
    {
        //gridObject.MovedEvent -= GridObjectMovedEvent;
        UpdateArea(_gridAreas[gridObject], null);
        _gridAreas.Remove(gridObject);
    }

    private void GridObjectMovedEvent(IGridObject gridObject)
    {
        if (!IsOpenArea(gridObject.Area, gridObject))
        {
            throw new ArgumentException("GridObject moved to illegal position, Overlaps with other object!");
        }

        Remove(gridObject);
        Add(gridObject);
    }

    private void UpdateArea(GridArea area, IGridObject gridObject)
    {
        int u = area.Index.U;
        GridSize size = area.Size;
        for (int num = u + size.U - 1; num >= area.Index.U; num--)
        {
            int v = area.Index.V;
            GridSize size2 = area.Size;
            for (int num2 = v + size2.V - 1; num2 >= area.Index.V; num2--)
            {
                _gridObjects[num, num2] = gridObject;
            }
        }
    }*/
}