using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//CÁI NÀY QUẢN LÍ HIỂN THỊ NÊN ỚI CÓ SƠ ĐỒ KIA 
public class WorldMap
{
    #region EVENTWORLMAP

    //delegate cho việc hiển thị map unlock và select
    //public delegate void NewIslandUnlockedEventHandler(IslandId islandId);

    public delegate void WorldMapVisibilityChanged(bool visible);

    public delegate void IslandSelectedEventHandler(IslandId islandId);

    public event WorldMapVisibilityChanged VisibilityChangedEvent;

    //public event NewIslandUnlockedEventHandler NewIslandUnlockedEvent;
    public event IslandSelectedEventHandler IslandSelectedEvent;

    private void FireVisibilityEvent(bool visible)
    {
        if (this.VisibilityChangedEvent != null)
        {
            this.VisibilityChangedEvent(visible);
        }
    }

    // private void FireNewIslandUnlockedEvent(IslandId islandId)
    // {
    //     if (this.NewIslandUnlockedEvent != null)
    //     {
    //         this.NewIslandUnlockedEvent(islandId);
    //     }
    // }

    private void FireIslandSelectedEvent(IslandId islandId)
    {
        if (this.IslandSelectedEvent != null)
        {
            this.IslandSelectedEvent(islandId);
        }
    }

    #endregion


    //LIST CÁC ĐẢO HIỆN LÊN HIỆN LÊN MÀ UNLOCK KHÁC NHAU CÁI NÀY QUẢN LÍ HIỂN THỊ 
    private readonly List<IslandId> _visibleIslands = new List<IslandId>();

    public IslandsManager IslandsManager { get; private set; }


    #region SAVE AND LOAD DATA::::

    private readonly StorageDictionary _storage;

    public WorldMap(IslandsManager islandsManager)
    {
        _visibleIslands.Clear();
        IslandsManager = islandsManager;
        var unlocks = IslandsManager.GetAllUnlock();
        for (int i = 0; i < unlocks.Count; i++)
        {
            if (!_visibleIslands.Contains(unlocks[i]))
            {
                _visibleIslands.Add(unlocks[i]);
            }
        }
    }

    #endregion


    #region TIEN ÍCH:::

    public void SelectIsland(IslandId islandId)
    {
        if (this.IslandSelectedEvent == null)
        {
            return;
        }

        FireIslandSelectedEvent(islandId);
    }

    #endregion
}