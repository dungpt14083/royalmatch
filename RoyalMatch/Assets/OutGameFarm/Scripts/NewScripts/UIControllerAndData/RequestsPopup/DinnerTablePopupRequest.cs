using UnityEngine;

public class DinnerTablePopupRequest : PopupRequest
{
    public ProduceHouse data { get; private set; }
    public Sprite sprIcon { get; private set; }

    public DinnerTablePopupRequest(ProduceHouse _data, Sprite _sprIcon)
        : base(typeof(DinnerTablePopup), true, true)
    {
        data = _data;
        sprIcon = _sprIcon;
    }
}
