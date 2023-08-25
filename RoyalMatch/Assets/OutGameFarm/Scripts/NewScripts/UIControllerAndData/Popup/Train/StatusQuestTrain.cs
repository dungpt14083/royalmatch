using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusQuestTrain : MonoBehaviour
{
    [SerializeField] private List<Sprite> sprIconRewards;
    [SerializeField] private TMP_Text txtTotalQuest;
    [SerializeField] private ItemStatusQuest itemStatusQuestPrefab;
    [SerializeField] private Transform itemStatusQuestParent;
    [SerializeField] private RewardsInfoTrain rewardsInfoTrain;

    Dictionary<long,ItemStatusQuest> itemStatusQuests;

    public void Show(int totalQuest, int totalQuestCompleted, int totalQuestRemoved, Currencies rewards)
    {
        rewardsInfoTrain.gameObject.SetActive(false);
        txtTotalQuest.text = (totalQuest - totalQuestCompleted - totalQuestRemoved).ToString();
        itemStatusQuestParent.ClearAllChild();
        int countQuestActive = totalQuest - totalQuestRemoved;
        itemStatusQuests = new Dictionary<long, ItemStatusQuest>();
        for (int i=0; i< totalQuest; i++)
        {
            var item = itemStatusQuestParent.CreateChild(itemStatusQuestPrefab);
            bool isCompleted = i < totalQuestCompleted;
            bool isRemoved = i >= countQuestActive;
            item.Show(isCompleted, isRemoved);
            itemStatusQuests.Add(i,item);
        }
        for (int i = 0; i < rewards.KeyCount; i++)
        {
            var reward = rewards.GetCurrency(i);
            if (reward == null) continue;
            var posReward = reward.Amount -1;
            if (itemStatusQuests.ContainsKey(posReward))
            {
                Sprite spr = null;
                if (i < sprIconRewards.Count) spr = sprIconRewards[i];
                var rewardsInfo = FarmMapController.Instance.GetRewardPropertiesBykey(reward.Name);
                itemStatusQuests[posReward].LoadReward(spr,()=> {
                    rewardsInfoTrain.Show(rewardsInfo.rewards);
                });
            }
        }
    }
}
