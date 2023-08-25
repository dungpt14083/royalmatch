using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTicker : MonoBehaviour
{
    private TimeKeeper _timeKeeper;

    //HÀM UPDATE SẼ UPDATE THẰNG TIMETICKER:::
    private void Update()
    {
        if (_timeKeeper != null)
        {
            _timeKeeper.AutoTick();
        }
    }

    public void Init(TimeKeeper timeKeeper)
    {
        _timeKeeper = timeKeeper;
    }
}