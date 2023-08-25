using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldMapIslandView : MonoBehaviour
{
    [SerializeField] private Button buttonJoin;
    [SerializeField] private IslandId islandId;
    [SerializeField] private Image lockIcon;
    public IslandId IslandId => islandId;
    private WorldMap _worldMap;
    private Action<IslandId> _action;
    private IslandsManager _islandsManager;

    public void Init(IslandsManager islandsManager, WorldMap worldMap, Action<IslandId> action)
    {
        _worldMap = worldMap;
        _action = action;
        _islandsManager = islandsManager;
        _islandsManager.IslandUnlockedEvent += OnIslandUnlocked;
        buttonJoin.onClick.RemoveAllListeners();
        ShowView();
    }

    private void OnIslandUnlocked(IslandId islandId)
    {
        if (IslandId == islandId)
        {
            ShowView();
        }
    }

    private void ShowView()
    {
        buttonJoin.onClick.RemoveAllListeners();
        lockIcon.gameObject.SetActive(true);
        if (_islandsManager.GetAllUnlock().Contains(IslandId))
        {
            lockIcon.gameObject.SetActive(false);
            buttonJoin.onClick.AddListener(() => _action.Invoke(IslandId));
        }
    }

    private void OnDestroy()
    {
        _islandsManager.IslandUnlockedEvent -= OnIslandUnlocked;
    }
}