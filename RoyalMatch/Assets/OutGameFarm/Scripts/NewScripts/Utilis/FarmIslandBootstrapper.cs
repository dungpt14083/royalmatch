using System;
using System.Collections;
using System.Collections.Generic;
using GameCreator.Camera;
using TMPro.SpriteAssetUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class FarmIslandBootstrapper : MonoBehaviour
{
    [SerializeField] private IsLandView islandView;

    [SerializeField] private CharacterManagerView characterManagerView;

    //VIỆC XÂY TÒA NHÀ HỆ THỐNG GRID
    [FormerlySerializedAs("gridIgridGridView")] [FormerlySerializedAs("gridView")] [SerializeField]
    private GridIgridObjectView gridIgridObjectView;

    [SerializeField] private PreBuilderView preBuilderView;
    [SerializeField] private PopupManagerView popupManagerView;
    [SerializeField] private UIVIEW uiView;
    [SerializeField] private TileAccessManagerView tileAccessManagerView;
    [SerializeField] private CloudManagerView cloudManagerView;
    [SerializeField] private TileManagerView tileManagerView;
    [SerializeField] private MapActionQueueManager mapActionQueueManager;
    [SerializeField] private FarmQuestManagerView farmQuestManagerView;
    [SerializeField] private InventoryManagerView inventoryManagerView;
    [SerializeField] private GatherableRequirementManagerView _gatherableRequirementManagerView;





    //Cái này mỗi đảo chắc đóng 1 prefab rồi tạo ra thôi::::
    [SerializeField] private GameObject[] _singletonPrefabs;
    [SerializeField] private Transform holderSingleton;
    [SerializeField] private TimeTicker timeTicker;
    [SerializeField] private TutorialDirectorView tutorialDirectorView;
    [SerializeField] private SceneLoader sceneLoader;

    private FarmIsLandData _farmIsLandData;
    private IsLandInfo _currentIsLandInfo;
    private IslandId _currentIslandId;

    private void Awake()
    {
        FarmSceneRequest farmSceneRequest = Loader.LastSceneRequest as FarmSceneRequest;
        if (farmSceneRequest == null)
        {
            Debug.LogError("Scene was not loaded using Scene Loader!");
            return;
        }

        if (farmSceneRequest.CityIsland != null)
        {
            _farmIsLandData = farmSceneRequest.CityIsland;
        }
        else
        {
            Debug.LogError("CityIsland in GameSceneRequest is null.");
        }

        for (int i = 0; i < _singletonPrefabs.Length; i++)
        {
            GameObject gameObject = Instantiate(_singletonPrefabs[i], holderSingleton);
        }

        _currentIslandId = farmSceneRequest.CurrentIslandId;
        _currentIsLandInfo = _farmIsLandData.GameData.IslandsManager.CurrentIsland;
        //Khi mở scene lên thì init thằng tilemanager đi xóa cái data cũ đi:::
        _currentIsLandInfo.TileManager.ResetForNewSession(_currentIslandId);
    }

    private void Start()
    {
        //islandView.Init(_currentIsLandInfo);
        //TẠO RA NHÀ Ở ĐÂY??THÌ PHẢI XÉT TỚI VỤ TILEACESSMANAGVIEW THỜI ĐIỂM NÀY CÓ AVAILABE=>
        //Khi xây nhà th cập nhật list kia bên tilemanager thì acess cũng nên nghe và cập nhật
        gridIgridObjectView.Init(_currentIsLandInfo);
        preBuilderView.Init(_farmIsLandData.GameData, _currentIsLandInfo);

        popupManagerView.Init(_farmIsLandData.GameData, _currentIsLandInfo);
        characterManagerView.Init(_farmIsLandData.GameData.CharacterPositionManager, _currentIsLandInfo);

        uiView.Init(_farmIsLandData, gridIgridObjectView);
        timeTicker.Init(_farmIsLandData.GameData.Time);
        //CÁI ĐOẠN NÀY NÓ SẼ INIT VIEW BĂNG LÕI MODEL:::FEATRU FLAG ĐỂ LÀM GÌ?
        tutorialDirectorView.Init(_farmIsLandData.GameData.TutorialDirector, _farmIsLandData.GameData.PopupManager,
            gridIgridObjectView, popupManagerView,
            preBuilderView /*,_farmIsLandData.GameData.Props.FeatureFlagsProperties*/);


        tileManagerView.Init(_currentIsLandInfo);
        tileAccessManagerView.Init(_currentIsLandInfo);
        cloudManagerView.Init(_currentIsLandInfo);

        _farmIsLandData.GameData.TutorialDirector.TryStartingATutorial();
        mapActionQueueManager.Init(_farmIsLandData.GameData.PopupManager);
        farmQuestManagerView.Init(_farmIsLandData.GameData.UserQuestsData);
        inventoryManagerView.Init(_farmIsLandData.GameData.GeneralBalance);
        _gatherableRequirementManagerView.Init(_currentIsLandInfo.GatherableManager);
        Application.targetFrameRate = 60;
    }

    public void GoToWorldMap()
    {
        if (_farmIsLandData != null)
        {
            _farmIsLandData.GameData.IslandsManager.ResetCurrentIsland();
            GameSceneRequest request = new GameSceneRequest(_farmIsLandData);
            sceneLoader.LoadScene(request);
            return;
        }
    }
    public FarmIsLandData GetFarmIsLandData()
    {
        return _farmIsLandData;
    }
    public IslandFarmProperties GetIslandFarmProperties()
    {
        if (_currentIsLandInfo == null) return null;
        return _currentIsLandInfo.IslandFarmProperties;
    }
}