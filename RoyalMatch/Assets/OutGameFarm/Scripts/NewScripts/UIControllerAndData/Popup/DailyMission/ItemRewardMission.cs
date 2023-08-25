using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ItemRewardMission : MonoBehaviour
{
   public Image icon;
   public Sprite SpriteUnlockReward;
   public Sprite SpriteLookReward;
   public Image Effect;
   public int missionPassed;
   public bool isReward;
   public bool isClaim;
   public RewardProssgressMisson RewardProssgressMisson;
   public Button btnClaimReward;
   private const string isRewardKey = "isRewardMissionKey";

   public delegate void OnclaimPrize(ItemRewardMission item);

   public OnclaimPrize onclaimPrize;

   private void Awake()
   {
      btnClaimReward.onClick.AddListener(ClaimReward);
   }

   public void Init(int MissionPassed, RewardProssgressMisson rewardProssgressMisson)
   {
      missionPassed = MissionPassed;
      RewardProssgressMisson = rewardProssgressMisson;
      isReward = true;
      isClaim = false;
      icon.sprite = SpriteLookReward;
      Effect.gameObject.SetActive(false);
      SaveIsReward(isReward);
      UpdateUI();
   }
   public void UpdateUI()
   {
      isReward = GetIsRewardFromPlayerPrefs();
      btnClaimReward.interactable =!isReward;
      if (!isReward)
      {
         Effect.gameObject.SetActive(true);
         Rotate();
      }
      if (isClaim)
      {
         btnClaimReward.interactable = !isClaim;
         Effect.gameObject.SetActive(false);
      }
   }
   private void Rotate()
   {
      Effect.transform.DORotate(new Vector3(0f, 0f, 360f), 1f, RotateMode.FastBeyond360)
         .SetLoops(-1, LoopType.Restart);
   }
   public void ClaimReward()
   {
      icon.sprite = SpriteUnlockReward;
      isClaim = true;
      if (onclaimPrize != null)
         onclaimPrize(this);
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
