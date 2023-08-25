using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AirplaneQuestItem : MonoBehaviour
{
    [SerializeField] private TMP_Text txtGoldReward;
    [SerializeField] private TMP_Text txtXPReward;
    [SerializeField] private TMP_Text txtNameQuest;
    [SerializeField] private Image imageStatusRemoved;
    [SerializeField] private Image imageStatusCompleted;
    [SerializeField] private Button btClick;
    public AirplaneQuestProperties airplaneQuest;
    Action<AirplaneQuestItem> actionShowDetail;
    public int index;
    private void Awake()
    {
        btClick.onClick.AddListener(Click);
    }
    public void Show(int _index, Action<AirplaneQuestItem> _actionShowDetail)
    {
        index = _index;
        gameObject.SetActive(true);
        actionShowDetail = _actionShowDetail;
        imageStatusRemoved.gameObject.SetActive(false);
        imageStatusCompleted.gameObject.SetActive(false);
        txtGoldReward.transform.parent.gameObject.SetActive(false);
        txtXPReward.transform.parent.gameObject.SetActive(false);
        airplaneQuest = null;
        txtNameQuest.text = "Unknown"; 

    }
    public void Show(int _index,bool IsDelivery, AirplaneQuestProperties airplaneQuestProperties, Action<AirplaneQuestItem> _actionShowDetail)
    {
        index = _index;
        gameObject.SetActive(true);
        actionShowDetail = _actionShowDetail;
        airplaneQuest = airplaneQuestProperties;
        imageStatusRemoved.gameObject.SetActive(airplaneQuest.statusRemoved);
        txtNameQuest.text = airplaneQuestProperties.BaseKey;
        if (airplaneQuest.statusRemoved)
        {
            imageStatusCompleted.gameObject.SetActive(false);
        }
        else
        {
            imageStatusCompleted.gameObject.SetActive(IsDelivery);
        }
        txtGoldReward.transform.parent.gameObject.SetActive(!airplaneQuest.statusRemoved);
        txtXPReward.transform.parent.gameObject.SetActive(!airplaneQuest.statusRemoved);
        if (!airplaneQuest.statusRemoved)
        {
            txtGoldReward.text = airplaneQuest.goldReward.ToString();
            txtXPReward.text = airplaneQuest.xpReward.ToString();
        }
    }
    public void Removed()
    {
        imageStatusRemoved.gameObject.SetActive(true);
        imageStatusCompleted.gameObject.SetActive(false);
        txtGoldReward.transform.parent.gameObject.SetActive(false);
        txtXPReward.transform.parent.gameObject.SetActive(false);
    }
    //public void Completed()
    //{
    //    imageStatusRemoved.gameObject.SetActive(false);
    //    imageStatusCompleted.gameObject.SetActive(true);
    //    txtGoldReward.transform.parent.gameObject.SetActive(true);
    //    txtXPReward.transform.parent.gameObject.SetActive(true);
    //}
    public void Selected()
    {
        btClick.image.color = Color.yellow;
    }
    public void UnSelected()
    {
        btClick.image.color = Color.white;
    }
    public void Click()
    {
        actionShowDetail?.Invoke(this);
        Selected();
    }
}
