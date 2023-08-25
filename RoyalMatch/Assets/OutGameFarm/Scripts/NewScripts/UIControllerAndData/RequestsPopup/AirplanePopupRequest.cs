using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplanePopupRequest : PopupRequest
{
    public AirplaneBuilding data { get; private set; }
    public AirplanePopupRequest(AirplaneBuilding _data)
        : base(typeof(AirplanePopup), true, true)
    {
        data = _data;
    }
}
