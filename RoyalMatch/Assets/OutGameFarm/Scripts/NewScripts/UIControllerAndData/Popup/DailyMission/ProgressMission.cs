using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressMission : MonoBehaviour
{
   [SerializeField] private Slider _progressBar;
   [SerializeField] private TMP_Text _textValue;
   private int MissionPassed;
   public event Action UpdateMissionPassed;
   public DailyMission DailyMission;
   public ItemRewardMission item;
   private List<ItemRewardMission> _listRewardMission = new List<ItemRewardMission>();
  [SerializeField] private List<RewardProssgressMisson> _listRewardProgressMission;
   private void Awake()
   {
    
   }

   private void Start()
   {
      InitRewardProgressMission();
   }

   private void InitRewardProgressMission()
   {
      for (int i = 0; i < _listRewardProgressMission.Count; i++)
      {
         var reward = _listRewardProgressMission[i];
         intiRewardProgressMission(reward);
         _listRewardMission[i].onclaimPrize += CheckClaim;
      }
   }
   
   public void UpdateProgressUI(int updateMissionPassed)
   {
      MissionPassed = updateMissionPassed;
      _progressBar.value = MissionPassed;
      _textValue.text = $"{MissionPassed}/{_progressBar.maxValue}";
      for (int i = 0; i < _listRewardProgressMission.Count; i++)
      {
         ItemRewardMission itemRewardProgressDays = _listRewardMission[i];
         if (MissionPassed>=itemRewardProgressDays.RewardProssgressMisson.missionPassed)
         {
            CheckClaim(itemRewardProgressDays);
         }
      }
   }

   private void CheckClaim(ItemRewardMission itemRewardMission)
   {
      itemRewardMission.isReward = false;
      itemRewardMission.SaveIsReward(itemRewardMission.isReward);
      itemRewardMission.UpdateUI();
   }
   private void intiRewardProgressMission(RewardProssgressMisson reward)
   {
      var itemRW = Instantiate(item, _progressBar.transform);
      itemRW.name = "itemReward day" + reward.missionPassed;
      itemRW.gameObject.SetActive(true);
      itemRW.Init(reward.missionPassed,reward );
      float progressBarWidth = _progressBar.GetComponent<RectTransform>().rect.width;
      RectTransform itemRewardRectTransform = itemRW.GetComponent<RectTransform>();
      float handleRectPosition = reward.missionPassed / _progressBar.maxValue * progressBarWidth;
      itemRewardRectTransform.anchoredPosition = new Vector2(handleRectPosition - progressBarWidth / 2f,
         itemRewardRectTransform.anchoredPosition.y);
      _listRewardMission.Add(itemRW);
   }
}
