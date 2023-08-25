using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollecPopupRequest : PopupRequest
{ 
    public FarmFieldBuilding FarmField { get; private set; }
    public CollecPopupRequest(FarmFieldBuilding farmfield)
        : base(typeof(CollecPopup), true, false, true, false)
    {
        FarmField = farmfield;
    }
}
