using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WelcomeBootstrapper : MonoBehaviour
{
    [SerializeField] private WelcomeSceneLoader sceneLoader;
    [SerializeField] private WelcomeView welcomeView;

    //MODEL NÀY CHÍNH LÀ NƠI CHỨA HẾT TÂT Ả ỌI THỨ
    //TRONG GAME mà khônG CÓ NHIỀU ĐO THÌ NÓ SẼ LẤY CITIISLAND Ở ĐÂY TỪ REQUEST LOADER KIA TRONG REQUEST LẤY RA//ĐÂY LÀ NƠI CHỨ DATA CỦA GAME TRONG NÀY TẤT//ĐƯỢC TẠO NEW Ở REQUEST VÀ MỖI LẦN TẠO NEW TỰ NÓ LOAD DATA LÊN 
    //CHÚT XEM CHÚT CÁI NÀY HƠI LẠ NỚ TỰ INSTANCE LẤY TỪ LƯU TRỮ CÒN CÁI KIA LÀ LOAD SVER LUỒNG HƠI KHÁC TÍ
    //private Model _model;

    private FarmIsLandData _cityIsland;

    private void Awake()
    {
        WelcomeSceneRequest welcomeSceneRequest = Loader.LastSceneRequest as WelcomeSceneRequest;
        if (welcomeSceneRequest == null)
        {
            Debug.LogError("Scene was not loaded using Scene Loader!");
            return;
        }

        _cityIsland = welcomeSceneRequest.FarmIsLandData;
        if (_cityIsland == null)
        {
            Debug.LogError("CityIsland in WelcomeSceneRequest is null without a firebase warning.");
        }
        
        //tạo singleton prefab nhưn bỏ qua đi
        if (_cityIsland != null)
        {
            welcomeView.Initialize(_cityIsland, sceneLoader);
        }
    }
    
}