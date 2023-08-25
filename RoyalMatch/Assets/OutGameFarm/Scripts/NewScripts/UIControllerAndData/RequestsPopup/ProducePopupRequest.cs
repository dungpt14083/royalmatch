using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducePopupRequest : PopupRequest
{
    public ProduceHouse data { get; private set; }
    public Sprite sprIcon { get; private set; }

    public ProducePopupRequest(ProduceHouse _data, Sprite _sprIcon)
        : base(typeof(ProducePopup), true, true)
    {
        data = _data;
        sprIcon = _sprIcon;
    }
}
