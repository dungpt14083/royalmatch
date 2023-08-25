using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ItemRewardProgressDays : MonoBehaviour
{
    public Image icon;
    public Sprite SpriteUnLookReward;
    public Sprite SpriteLookReward;
    public int day;
    public bool isReward;
    public Reward30Days _reward30Days;
    public Button BtnClaimReward;
    private const string isRewardKey = "isRewardKey";
    
    public delegate void OnClaimPrize(ItemRewardProgressDays item);                 // When the player claims the prize
    public OnClaimPrize onClaimPrize;

    private void Awake()
    {
        BtnClaimReward.onClick.AddListener(ClaimReward);
    }

    public void Init(int _day, Reward30Days reward30Days)
    {
        day = _day;
        _reward30Days = reward30Days;
        isReward = GetIsRewardFromPlayerPrefs();
        icon.sprite = isReward ? SpriteLookReward : SpriteUnLookReward;
        UpdateUI();
    }

    public void UpdateUI()
    {
        isReward = GetIsRewardFromPlayerPrefs();
        icon.sprite = isReward ? SpriteLookReward : SpriteUnLookReward;
        BtnClaimReward.interactable =!isReward;
    }

    public void ClaimReward()
    {
        if (onClaimPrize != null)
            onClaimPrize(this);
    }
    public string GetIsRewardKey()
    {
        return isRewardKey;
    }

    public void SaveIsReward(bool _isReward)
    {
        int isRewardValue = _isReward ? 1 : 0;
        PlayerPrefs.SetInt(isRewardKey, isRewardValue);
        PlayerPrefs.Save();
    }

    private bool GetIsRewardFromPlayerPrefs()
    {
        int isRewardValue = PlayerPrefs.GetInt(isRewardKey, 1); // 0 là giá trị mặc định nếu không tìm thấy khóa
        
        return isRewardValue == 1;
    }
}