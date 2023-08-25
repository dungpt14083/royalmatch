using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemDailyMission : MonoBehaviour
{
    public TMP_Text txtNameMission;
    public TMP_Text txtTarget;
    public TMP_Text txtQualityReward;
    public Image ImgItem;
    public Image ImgReward;
    public Button btnFind;
    public Button btnReward;
    public Image PanelDiasble;
    public DailyQuest _DailyQuest;
    public event Action QuestComplete;
    public event Action QuestUpdate;
    public event Action<ItemDailyMission> EventReward;
   [SerializeField] private Sprite _spriteRewardComplete;

   private void Awake()
   {
       btnReward.onClick.AddListener(Reward);
   }

   public void Init(DailyQuest dailyQuest)
    {
        _DailyQuest = dailyQuest;
        txtNameMission.text = _DailyQuest.NameQuest;
        txtTarget.text = string.Format("{0}/{1}", _DailyQuest.QuestGoal.CurrentAmount,
            _DailyQuest.QuestGoal.RequiredAmount);
        txtQualityReward.text = _DailyQuest.RewardDailyQuest.Reward.ToString();
        ImgItem.sprite = _DailyQuest.SpriteQuest;
        ImgReward.sprite = _DailyQuest.RewardDailyQuest.SpriteReward;
        if (_DailyQuest.isCompleted)
        {
            PanelDiasble.gameObject.SetActive(true);
            btnReward.gameObject.SetActive(true);
            ImgReward.sprite = _spriteRewardComplete;
        }
        else
        {
            ImgReward.sprite = _DailyQuest.RewardDailyQuest.SpriteReward;
            PanelDiasble.gameObject.SetActive(false);
            btnReward.gameObject.SetActive(false);
        }
    }

    public void Reward()
    {
        _DailyQuest.isclaim = true;
        if(EventReward!=null)
           EventReward.Invoke(this);
    }

    [Button]
    public void Complete()
    {
        _DailyQuest.isCompleted = true;
        _DailyQuest.isclaim = false;
        UpdateUI();
        QuestComplete?.Invoke();
    }

    public void UpdateUI()
    {

        if (_DailyQuest.QuestGoal.IsReached())
        {
            _DailyQuest.isCompleted = true;
        }
        else
        {
            _DailyQuest.isCompleted = false;
        }
        txtNameMission.text = _DailyQuest.NameQuest;
        txtTarget.text = string.Format("{0}/{1}", _DailyQuest.QuestGoal.CurrentAmount,
            _DailyQuest.QuestGoal.RequiredAmount);
        txtQualityReward.text = _DailyQuest.RewardDailyQuest.Reward.ToString();
        ImgItem.sprite = _DailyQuest.SpriteQuest;
        PanelDiasble.color = _DailyQuest.isclaim ? Color.green : Color.gray;
        if (_DailyQuest.isCompleted)
        {
            ImgReward.sprite = _spriteRewardComplete;
            PanelDiasble.gameObject.SetActive(true);
            btnReward.gameObject.SetActive(true);
            txtQualityReward.text = "";
            txtTarget.color = Color.green;
        }
        else
        {
            ImgReward.sprite = _DailyQuest.RewardDailyQuest.SpriteReward;
            txtTarget.color = Color.red;
            PanelDiasble.gameObject.SetActive(false);
            btnReward.gameObject.SetActive(false);
        }
    }
    [Button]
    public void UpdateCurrentAmount(int amount)
    {
        
        _DailyQuest.QuestGoal.CurrentAmount += amount;
        if (_DailyQuest.QuestGoal.CurrentAmount > _DailyQuest.QuestGoal.RequiredAmount)
        {
            _DailyQuest.QuestGoal.CurrentAmount = _DailyQuest.QuestGoal.RequiredAmount;
        }
        UpdateUI();
        if (_DailyQuest.QuestGoal.IsReached())
        {
            Complete();
        }
    }
}
