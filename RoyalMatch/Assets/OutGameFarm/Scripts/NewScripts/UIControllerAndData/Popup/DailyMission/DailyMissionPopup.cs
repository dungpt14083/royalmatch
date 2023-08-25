using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyMissionPopup : Popup
{
    public GameData gameData;

    public override void Init(GameData _gameData, IsLandInfo isLandInfo)
    {
        base.Init(_gameData,isLandInfo);
        gameData = _gameData;
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        DailyMissionRequestPopup dailyMissionRequestPopup = GetRequest<DailyMissionRequestPopup>();
    }
}
