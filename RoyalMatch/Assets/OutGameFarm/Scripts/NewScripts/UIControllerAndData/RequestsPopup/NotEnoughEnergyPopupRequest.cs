using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotEnoughEnergyPopupRequest : PopupRequest
{
    public NotEnoughEnergyPopupRequest()
        : base(typeof(NotEnoughEnergyPopup), true, false, true, false)
    {
    }
}
