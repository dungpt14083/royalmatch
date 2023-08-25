using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsLandsManagerView : MonoBehaviour
{
    private PopupManager _popupManager;
    private TimeKeeper _timeKeeper;
    public TutorialDirector TutorialDirector { get; private set; }
    public IslandsManager IslandsManager { get; private set; }
    private FarmIsLandData _cityIsland;
    private SceneLoader _sceneLoader;


    public void Init(FarmIsLandData cityIsland, SceneLoader sceneLoader)
    {
        _cityIsland = cityIsland;
        _sceneLoader = sceneLoader;

        _popupManager = cityIsland.GameData.PopupManager;
        _timeKeeper = cityIsland.GameData.Time;
        IslandsManager = cityIsland.GameData.IslandsManager;

        IslandsManager.IslandChangedEvent += OnIslandChanged;
        IslandsManager.IslandUnlockedEvent += OnIslandUnlocked;

        //Load đảo mặc định khi có current lưu lại::
        if (IslandsManager.CurrentIsland != null)
        {
            //LoadIsland( islandsManager.CurrentIsland);
        }
    }

    private void OnDestroy()
    {
        IslandsManager.IslandChangedEvent -= OnIslandChanged;
        IslandsManager.IslandUnlockedEvent -= OnIslandUnlocked;
    }

    //Đã duyệt xong các điều kiện m đảo ra để mở đảo thì nhận sự kiện chỉ có mở mà thôi
    private void OnIslandChanged(IslandId islandId)
    {
        //load scene được chọn lên đảo lên :::
        _sceneLoader.LoadScene(new FarmSceneRequest(_cityIsland, islandId, IslandsManager.GetSceneFarmName(islandId)));
    }

    //Sự kiện unlock
    private void OnIslandUnlocked(IslandId islandId)
    {
        //load scene được chọn lên đảo lên :::
        //Dùng cho view hệ đảo à?
    }
}