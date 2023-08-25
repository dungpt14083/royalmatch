using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewBuilding : IGridObject
{
    public event TileManager.MovedEventHandler MovedEvent;
    public event TileManager.FlippedEventHandler FlippedEvent;


    private bool _isFlipped;

    public GridArea Area { get; private set; }

    public bool IsFlipped
    {
        get { return _isFlipped; }
        set
        {
            if (_isFlipped != value)
            {
                _isFlipped = value;
                FireFlippedEvent();
            }
        }
    }

    public PreviewBuilding(GridArea area, bool isFlipped)
    {
        Area = area;
        _isFlipped = isFlipped;
    }

    private void FireMovedEvent()
    {
        if (this.MovedEvent != null)
        {
            this.MovedEvent(this);
        }
    }

    private void FireFlippedEvent()
    {
        if (this.FlippedEvent != null)
        {
            this.FlippedEvent(this);
        }
    }

    public void MoveTo(GridIndex index)
    {
        if (!index.Equals(Area.Index))
        {
            Area = new GridArea(index, Area.Size);
            FireMovedEvent();
        }
    }
}