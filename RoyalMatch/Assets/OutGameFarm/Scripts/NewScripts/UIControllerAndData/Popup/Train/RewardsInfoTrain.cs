using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardsInfoTrain : MonoBehaviour
{
    [SerializeField] private ItemRewardTrainInfo itemRewardTrainInfoPrefab;
    [SerializeField] private Transform parent;
    public void Show(Currencies rewards)
    {
        gameObject.SetActive(true);
        parent.ClearAllChild();
        for(int i = 0; i< rewards.KeyCount; i++)
        {
            var item = parent.CreateChild(itemRewardTrainInfoPrefab);
            var reward = rewards.GetCurrency(i);
            item.Show(reward);
        }
    }
}
