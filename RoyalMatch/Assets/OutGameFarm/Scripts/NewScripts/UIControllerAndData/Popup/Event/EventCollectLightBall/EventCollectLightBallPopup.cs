using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCollectLightBallPopup : Popup
{
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        base.Init(game, isLandInfo);
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        EventCollectLightBallRequestPopup eventCollectLightBallRequestPopup =
            GetRequest<EventCollectLightBallRequestPopup>();
    }
}
