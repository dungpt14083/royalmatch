using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class IslandsManager : ICanSerialize
{
    #region EVENT

    public delegate void IslandUnlockedEventHandler(IslandId islandId);

    public delegate void IslandChangedEventHandler(IslandId islandId);

    public event IslandUnlockedEventHandler IslandUnlockedEvent;
    public event IslandChangedEventHandler IslandChangedEvent;

    private void FireIslandUnlockedEvent(IslandId islandId)
    {
        if (this.IslandUnlockedEvent != null)
        {
            this.IslandUnlockedEvent(islandId);
        }
    }

    private void FireIslandChangedEvent(IslandId islandId)
    {
        if (this.IslandChangedEvent != null)
        {
            this.IslandChangedEvent(islandId);
        }
    }

    #endregion

    //INIT UNLOCKEDISLAND LÀ ĐẢO 1 LUÔN MỞ RA::::
    private static readonly IslandId[] InitiallyUnlockedIslands = new[] { IslandId.Island01 };

    //List island id đã unlocks::
    private readonly List<IslandId> _unlockedIslands = new List<IslandId>();

    private readonly List<IslandId> _islandListSetting = new List<IslandId>()
    {
        IslandId.Island01,
        IslandId.Island02,
        IslandId.Island03,
        IslandId.Island04,
    };

    private readonly Dictionary<IslandId, string> _islandSceneName = new Dictionary<IslandId, string>()
    {
        { IslandId.Island01, "FarmMap1" },
        { IslandId.Island02, "FarmMap2" },
        { IslandId.Island03, "FarmMap1" },
        { IslandId.Island04, "FarmMap1" },
    };


    //List propeties mà các đảo kia có or list string để nó load file 
    private readonly Dictionary<IslandId, string> _islandTileFilesName = new Dictionary<IslandId, string>()
    {
        { IslandId.Island01, "IslandTile01" },
        { IslandId.Island02, "IslandTile02" },
        { IslandId.Island03, "IslandTile03" },
        { IslandId.Island04, "IslandTile04" },
    };

    //List propeties mà các đảo kia có or list string để nó load file 
    private readonly Dictionary<IslandId, string> _islandPropertiesFilesName = new Dictionary<IslandId, string>()
    {
        { IslandId.Island01, "IslandProp01" },
        { IslandId.Island02, "IslandProp02" },
        { IslandId.Island03, "IslandProp03" },
        { IslandId.Island04, "IslandProp04" },
    };

    //List island trong game sẽ được tạo ra 
    private readonly List<IsLandInfo> _islands = new List<IsLandInfo>();
    public IsLandInfo CurrentIsland { get; private set; }

    //Lưu trữ đảo cuối cùng thăm quan cho lần load sau tự động loadScene::
    public IslandId LastOpenedIsland { get; private set; }
    public GeneralBalance GeneralBalance { get; private set; }
    public GeneralProperties GeneralProperties { get; private set; }


    #region HÀM TIỆN ÍCH CUNG CẤP RA BÊN NGOÀI:::

    //Open này là quản lí setactive nhưng ở đây sẽ gọi load scene luôn hoặc để view gọi tùy ::
    //Hhãy để bên ngoài nghe sự kiên và chạy vì bên ngoài ms thả tham chiếu scene vào
    public void OpenIsland(IslandId islandId)
    {
        if (!IsUnlocked(islandId)) return;
        if (this.CurrentIsland != null)
        {
            if (this.CurrentIsland.IslandId == islandId)
            {
                return;
            }
        }

        IsLandInfo isLandInfo = GetIslandInfo(islandId);
        if (isLandInfo != null)
        {
            CurrentIsland = isLandInfo;
            FarmMapController.Instance.IsLandInfo = CurrentIsland;
            LastOpenedIsland = CurrentIsland.IslandId;
            FireIslandChangedEvent(islandId);
        }
    }

    public void ResetCurrentIsland()
    {
        CurrentIsland = null;
    }

    private IsLandInfo GetIslandInfo(IslandId islandId)
    {
        IsLandInfo isLandInfo = GetIsland(islandId);
        return isLandInfo;
    }

    public IsLandInfo GetIsland(IslandId islandId)
    {
        return _islands.Find(info => info.IslandId == islandId);
    }

    //MỞ RA THẰNG ISLAND:::
    public void UnlockIsLand(IslandId islandId)
    {
        if (_unlockedIslands.Contains(islandId)) return;
        _unlockedIslands.Add(islandId);
        var isLandInfo = GetIsland(islandId);
        //Có unlock gì gì đó
        if (isLandInfo != null)
        {
            //Gọi tới unlock
            //isLandInfo.Unlock();
        }

        FireIslandUnlockedEvent(islandId);
    }

    //Check với ID đã unlock hay chưa
    public bool IsUnlocked(IslandId islandId)
    {
        return this._unlockedIslands.Contains(item: islandId);
    }

    public List<IslandId> GetAllUnlock()
    {
        return this._unlockedIslands;
    }

    public string GetSceneFarmName(IslandId islandId)
    {
        return _islandSceneName[islandId];
    }

    public string GetTileFilesName(IslandId islandId)
    {
        return _islandTileFilesName[islandId];
    }

    public string GetPropertiesFilesName(IslandId islandId)
    {
        return _islandPropertiesFilesName[islandId];
    }

    #endregion


    #region SAVE AND LOAD DATA AND GAME:::

    private StorageDictionary _storage;


    //ĐÂY LÀ GAME MỚI HOÀN TOÀN THÌ SẼ ::://TIỀN NÀY SẼ CHỈ ĐỂ TIỀN CỦA THẰNG CẢ GAME K CÓ TIỀN CHO TRONG KHO
    public IslandsManager(TimeKeeper time, PopupManager popupManager, GeneralBalance generalBalance,
        GeneralProperties generalProperties)
    {
        GeneralBalance = generalBalance;
        GeneralProperties = generalProperties;
        _unlockedIslands.Clear();
        _islands.Clear();
        for (int i = 0; i < InitiallyUnlockedIslands.Length; i++)
        {
            if (!_unlockedIslands.Contains(InitiallyUnlockedIslands[i]))
            {
                _unlockedIslands.Add(InitiallyUnlockedIslands[i]);
            }
        }

        foreach (var islandId in _islandListSetting)
        {
            if (_islands.All(info => info.IslandId != islandId))
            {
                _islands.Add(new IsLandInfo(islandId, this, time,
                    popupManager, GeneralBalance, GeneralProperties));
            }
        }
    }


    public IslandsManager(StorageDictionary storage)
    {
        _islands.Clear();
        _unlockedIslands.Clear();
        _storage = storage;
        _islands = storage.GetModels("islandInfos", (StorageDictionary sd) => new IsLandInfo(sd));
        List<int> list = _storage.GetList<int>("unlockedIslands");
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            _unlockedIslands.Add((IslandId)list[i]);
        }

        if (_unlockedIslands.Count == 0)
        {
            for (int i = 0; i < InitiallyUnlockedIslands.Length; i++)
            {
                if (!_unlockedIslands.Contains(InitiallyUnlockedIslands[i]))
                {
                    _unlockedIslands.Add(InitiallyUnlockedIslands[i]);
                }
            }
        }
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        List<int> list = new List<int>();
        int count = _unlockedIslands.Count;
        for (int i = 0; i < count; i++)
        {
            list.Add((int)_unlockedIslands[i]);
        }

        _storage.Set("islandInfos", _islands);

        _storage.Set("unlockedIslands", list);

        return _storage;
    }

    public void ResolveDependencies(GameData game)
    {
        GeneralBalance = game.GeneralBalance;
        GeneralProperties = game.GeneralProperties;
        for (int i = 0; i < _islands.Count; i++)
        {
            IsLandInfo islandInfo = _islands[i];
            islandInfo.ResolveDependencies(game);
        }
    }

    #endregion
}