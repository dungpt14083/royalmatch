using UnityEngine;

public class TrainPopupRequest : PopupRequest
{
    public TrainBuilding data { get; private set; }
    public TrainPopupRequest(TrainBuilding _data)
        : base(typeof(TrainPopup), true, true)
    {
        data = _data;
    }
}
