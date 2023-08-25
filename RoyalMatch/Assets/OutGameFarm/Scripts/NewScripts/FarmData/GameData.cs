using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : ICanSerialize
{
    private const string UserKey = "User";
    private const string TimeKeeperKey = "Timekeeper";
    private const string GeneralPropertiesKey = "GeneralProps";


    //public IsLandInfo IsLandInfo { get; private set; }
    public TimeKeeper Time { get; private set; }
    public PopupManager PopupManager { get; private set; }
    public TutorialDirector TutorialDirector { get; private set; }

    //public QuestDistributor QuestDistributor { get; private set; }

    public IslandsManager IslandsManager { get; private set; }

    public WorldMap WorldMap { get; private set; }


    //public Properties Props { get; private set; }
    // public Balance Balance { get; private set; }


    //CÁI NÀY ĐỦ KHẢ NĂNG CUNG CẤP HẾT CÁC PROPETIES CHUNG TRONG GAME NHƯ LÀ BỌN PRODUCT MATERIAL...
    public GeneralProperties GeneralProperties { get; private set; }
    public GeneralBalance GeneralBalance { get; private set; }
    public CharacterPositionManager CharacterPositionManager { get; private set; }


    public UserQuestsData UserQuestsData { get; private set; }


    public GameData()
    {
        //Prop ny k còn là prop của game nữa
        //Props = new Properties();
        //Balance = new Balance(Props);
        
        //Cái này sẽ chứa hết properties chung trong game ::: mà qua các đảo sẽ có :::
        GeneralProperties = new GeneralProperties(GeneralPropertiesKey);
        GeneralBalance = new GeneralBalance(GeneralProperties);
        
        CharacterPositionManager = new CharacterPositionManager();
        UserQuestsData = new UserQuestsData();
        Time = new TimeKeeper();
        PopupManager = new PopupManager();
        TutorialDirector = new TutorialDirector(this);
        //QuestDistributor = new QuestDistributor(this);

        IslandsManager = new IslandsManager(Time, PopupManager, GeneralBalance, GeneralProperties);
        WorldMap = new WorldMap(IslandsManager);
        Setup();
        FarmMapController.Instance.GeneralProperties = this.GeneralProperties;
        FarmMapController.Instance.GeneralBalance = this.GeneralBalance;
        FarmMapController.Instance.TimeKeeper = this.Time;
        
    }


    #region SAVE AND LOAD

    private StorageDictionary _storage;

    public GameData(StorageDictionary storage)
    {
        _storage = storage;
        PopupManager = new PopupManager();
        Time = new TimeKeeper(_storage.GetStorageDict("Timekeeper"));
        UserQuestsData = new UserQuestsData(_storage.GetStorageDict("UserQuestsData"));

        //Balance = new Balance(_storage.GetStorageDict("Balance"));
        //IsLandInfo = new IsLandInfo(_storage.GetStorageDict("Island"));
        GeneralBalance = new GeneralBalance(_storage.GetStorageDict("GeneralBalance"));
        CharacterPositionManager = new CharacterPositionManager(_storage.GetStorageDict("CharacterPositionManager"));
        TutorialDirector = new TutorialDirector(_storage.GetStorageDict("TutorialDirector"));
        IslandsManager = new IslandsManager(_storage.GetStorageDict("IslandsManager"));
        WorldMap = new WorldMap(IslandsManager);
    }


    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("UserQuestsData", UserQuestsData);
        //_storage.Set("Balance", Balance);
        _storage.Set("GeneralBalance", GeneralBalance);
        _storage.Set("CharacterPositionManager", CharacterPositionManager);
        _storage.Set("Timekeeper", Time);
        //_storage.Set("TutorialDirector", TutorialDirector);
        TutorialDirector = new TutorialDirector(this);
        _storage.Set("IslandsManager", IslandsManager);
        return _storage;
    }

    public void ResolveDependencies()
    {
        //Props = new Properties();
        //Balance.ResolveDependencies(Props);
        GeneralProperties = new GeneralProperties(GeneralPropertiesKey);
        GeneralBalance.ResolveDependencies(GeneralProperties);


        //IsLandInfo.ResolveDependencies(this);
        IslandsManager.ResolveDependencies(this);
        WorldMap = new WorldMap(IslandsManager);
        TutorialDirector.ResolveDependencies(this /*, device*/);
        Setup();
    }

    private void Setup()
    {
        //
    }

    #endregion
}