using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaillyRewardPopup : Popup
{
    public GameData GameData;
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        base.Init(game, isLandInfo);
        GameData = game;
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        DailyRewardPopupRequest dailyRewardPopupRequest = GetRequest<DailyRewardPopupRequest>();
    }
    
}
