using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

public class WelcomeView : MonoBehaviour
{
    [SerializeField] private GameObject _playButton;

    private FarmIsLandData _cityIsland;


    //ĐÂY LÀ NƠI CHỨ DATA CỦA GAME TRONG NÀY TẤT//ĐƯỢC TẠO NEW Ở REQUEST VÀ MỖI LẦN TẠO NEW TỰ NÓ LOAD DATA LÊN 
    //CHÚT XEM CHÚT CÁI NÀY HƠI LẠ NỚ TỰ INSTANCE LẤY TỪ LƯU TRỮ CÒN CÁI KIA LÀ LOAD SVER LUỒNG HƠI KHÁC TÍ
    //private Model _model;

    private SceneLoader _sceneLoader;
    private bool _hasClickedPlay;

    private void Awake()
    {
    }

    public void Initialize(FarmIsLandData cityIsland, SceneLoader sceneLoader)
    {
        _cityIsland = cityIsland;
        _sceneLoader = sceneLoader;
    }

    private void OnDestroy()
    {
        _hasClickedPlay = false;
    }

    public void OnPlayClick()
    {
        if (_hasClickedPlay)
        {
            return;
        }

        _hasClickedPlay = true;
        if (_cityIsland != null)
        {
            GameSceneRequest request = new GameSceneRequest(_cityIsland);
            _sceneLoader.LoadScene(request);
            return;
        }

        _hasClickedPlay = false;
    }
}