using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour, IGridObject
{
    [SerializeField] private Vector2Int gridSize;

    public Vector2Int GridSize => gridSize;


    #region TODOGRIDCLOUND

    //khi tạo mây ra thì init nó bn kích thước.....đ mà giống như ô đất chiếm chỗ k cho build hay thao tác
    public event TileManager.MovedEventHandler MovedEvent;
    public event TileManager.FlippedEventHandler FlippedEvent;


    private GridArea _area;

    public GridArea Area
    {
        get { return _area; }
        private set
        {
            if (value.Index != _area.Index)
            {
                _area = value;
            }
        }
    }

    public bool IsFlipped { get; private set; }

    #endregion


    public void Init(GridIndex index, GridSize gridSize)
    {
        _area = new GridArea(index, gridSize);
    }


    public object Position { get; }
    public Vector2Int PivotPosition { get; set; }
    public Vector2Int Size { get; set; }
    public int Height { get; set; }

    public void FadeOut()
    {
        this.gameObject.SetActive(false);
    }

    public void SetVisible(bool b)
    {
        this.gameObject.SetActive(b);
    }
}