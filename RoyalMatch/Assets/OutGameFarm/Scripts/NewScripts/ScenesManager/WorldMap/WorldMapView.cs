using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WorldMapView : MonoBehaviour
{
    [SerializeField] private WorldMapIslandView[] islands;
    [SerializeField] private GameObject root;
    [SerializeField] private EventSystem eventSystem;

    //CAMERA CHO VIỆC VIEW VÀO CHỖ GẦN VIEW
    [SerializeField] private WorldMapCameraOperatorView cameraOperatorView;
    [SerializeField] private WorldMapCloudController worldMapCloudController;

    //Data map:::
    private WorldMap _worldMap;
    public IslandsManager IslandsManager { get; private set; }

    public void Init(IslandsManager islandsManager, WorldMap worldMap)
    {
        _worldMap = worldMap;
        IslandsManager = islandsManager;

        IslandsManager.IslandUnlockedEvent += OnIslandUnlocked;
        IslandsManager.IslandUnlockedEvent += OnIslandUnlocked;

        for (int i = 0; i < islands.Length; i++)
        {
            islands[i].Init(islandsManager, worldMap, OnIslandClicked);
        }
    }

    private void OnDestroy()
    {
        IslandsManager.IslandUnlockedEvent -= OnIslandUnlocked;
        IslandsManager.IslandUnlockedEvent -= OnIslandUnlocked;
    }

    private void OnIslandClicked(IslandId islandId)
    {
        IslandsManager.OpenIsland(islandId);
    }

    private void OnIslandChanged(IsLandInfo island)
    {
        //Chạy select đảo::
    }

    private void OnIslandUnlocked(IslandId islandId)
    {
        //Chạy hiệu ứng:::
    }
}