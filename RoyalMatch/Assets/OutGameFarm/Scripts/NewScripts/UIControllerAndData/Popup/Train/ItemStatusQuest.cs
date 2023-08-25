using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStatusQuest : MonoBehaviour
{
    [SerializeField] private GameObject statusCompleted;
    [SerializeField] private GameObject statusRemoved;
    [SerializeField] private Button btReward;
    Currencies rewards;
    Action actionShowReward;
    public void Show(bool isCompleted, bool isRemoved)
    {
        gameObject.SetActive(true);
        statusCompleted.SetActive(isCompleted);
        statusRemoved.SetActive(isRemoved);
        btReward.gameObject.SetActive(false);
    }
    public void LoadReward(Sprite sprReward,Action _actionShowReward)
    {
        btReward.image.sprite = sprReward;
        actionShowReward = _actionShowReward;
        if (actionShowReward != null)
        {
            btReward.onClick.RemoveAllListeners();
            btReward.onClick.AddListener(ShowRewardsInfo);
        }
        btReward.gameObject.SetActive(true);
    }
    public void ShowRewardsInfo()
    {
        actionShowReward?.Invoke();
    }
}
