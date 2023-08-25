using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePopupRequest : PopupRequest
{
    private Sprite sprIcon;
    public BuildingData data { get; private set; }
    public UpgradePopupRequest(BuildingData _data, Sprite _sprIcon)
        : base(typeof(UpgradePopup), true, true)
    {
        data = _data;
        sprIcon = _sprIcon;
    }
    public Sprite GetSprite()
    {
        return sprIcon;
    }
    public void GetMerterials()
    {

    }
}
