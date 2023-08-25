using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBootstrapper : MonoBehaviour
{
    //GAME SCENE LOADER CHO VIỆC LOAD VÔ CÁC THẰNG CHI TIẾT ĐẢO
    //SẼ CÓ NGĂN INPUT V 
    [SerializeField] private GameSceneLoader gameSceneLoader;
    [SerializeField] private IsLandsManagerView isLandsManagerView;
    [SerializeField] private WorldMapView worldMapView;


    private FarmIsLandData _cityIsland;

    private void Awake()
    {
        GameSceneRequest gameSceneRequest = Loader.LastSceneRequest as GameSceneRequest;
        if (gameSceneRequest == null)
        {
            Debug.LogError("Scene was not loaded using Scene Loader!");
            return;
        }

        if (gameSceneRequest.CityIsland != null)
        {
            _cityIsland = gameSceneRequest.CityIsland;
        }
        else
        {
            Debug.LogError("CityIsland in GameSceneRequest is null.");
        }
    }

    private void Start()
    {
        if (_cityIsland != null)
        {
            //QUẢN LÍ HÀNH VI CỦA THẰNG CẢ QUẦN THỂ ĐẢO TO CÁC VIEW...:::
            isLandsManagerView.Init(_cityIsland, gameSceneLoader);

            //QUẢN LÍ CHI TIẾT HÀNH VI CÁC ĐẢO VIEW
            worldMapView.Init(_cityIsland.GameData.IslandsManager, _cityIsland.GameData.WorldMap);
        }
    }
}