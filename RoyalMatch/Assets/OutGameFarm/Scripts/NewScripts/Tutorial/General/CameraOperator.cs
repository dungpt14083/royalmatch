using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperator
{
    public delegate void ScrollToEventHandler(GridPoint gridPoint, bool animated);

    public event ScrollToEventHandler ScrollToEvent;

    private void FireScrollToEvent(GridPoint gridPoint, bool animated)
    {
        if (this.ScrollToEvent != null)
        {
            this.ScrollToEvent(gridPoint, animated);
        }
    }

    public void ScrollTo(GridPoint gridPoint)
    {
        FireScrollToEvent(gridPoint, true);
    }

    public void JumpTo(GridPoint gridPoint)
    {
        FireScrollToEvent(gridPoint, false);
    }
}