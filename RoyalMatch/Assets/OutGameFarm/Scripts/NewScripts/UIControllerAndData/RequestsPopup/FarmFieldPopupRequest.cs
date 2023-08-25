using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmFieldPopupRequest : PopupRequest
{
    public FarmFieldBuilding FarmField { get; private set; }

    public FarmFieldPopupRequest(FarmFieldBuilding farmfield)
        : base(typeof(FarmFieldPopup), true, false, true, false)
    {
        FarmField = farmfield;
    }
}