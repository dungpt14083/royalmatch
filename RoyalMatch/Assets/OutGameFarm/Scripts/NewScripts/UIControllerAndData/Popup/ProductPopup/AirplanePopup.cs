using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AirplanePopup : Popup
{
    [SerializeField] private Image progessQuest;
    [SerializeField] private TMP_Text txtProgessQuest;
    [SerializeField] private Button btClose;
    [SerializeField] private Button btRevecieReward;
    [SerializeField] private Sprite sprRevecieReward;
    [SerializeField] private AirplaneQuestItem airplaneQuestItem;
    [SerializeField] private Transform airplaneQuestItemParent;
    [SerializeField] private AirplaneQuestDetailInfo airplaneQuestDetailInfo;
    int limitShowItem = 5;

    private AirplaneBuilding buildingData;
    private List<AirplaneQuestItem> airplaneQuestItems;
    AirplaneProperties airplaneProperties;
    AirplaneQuestItem currentAirplaneQuestProperties;
    public override void Open(PopupRequest request)
    {
        base.Open(request);
        airplaneQuestItems = new List<AirplaneQuestItem>();
        AirplanePopupRequest request1 = GetRequest<AirplanePopupRequest>();
        buildingData = request1.data;
        airplaneProperties = buildingData.BuildingProperties as AirplaneProperties;
        
        buildingData.updateData += UpdateData;
        btClose.onClick.RemoveAllListeners();
        btClose.onClick.AddListener(OnCloseClicked);
        btRevecieReward.onClick.RemoveAllListeners();
        btRevecieReward.onClick.AddListener(RevecieReward);
        LoadData(airplaneProperties);
    }

    public void LoadData(AirplaneProperties airplaneProperties)
    {
        airplaneQuestDetailInfo.gameObject.SetActive(false);
        if(airplaneQuestItems == null || airplaneQuestItems.Count == 0)
        {
            airplaneQuestItemParent.ClearAllChild();
            for (int i = 0; i < limitShowItem; i++)
            {
                var item = airplaneQuestItemParent.CreateChild(airplaneQuestItem);
                airplaneQuestItems.Add(item);
            }
        }
        
        for (int i = 0; i < airplaneQuestItems.Count; i++)
        {
            var item = airplaneQuestItems[i];
            if (!airplaneProperties.airplaneQuestsActived.ContainsKey(i))
            {
                item.Show(i,ShowDetail);
                
                continue;
            }
            var quest = airplaneProperties.airplaneQuestsActived[i];
            var IsDelivery = quest.IsDelivery();
            item.Show(i,IsDelivery,quest, ShowDetail);
        }
        
        if(currentAirplaneQuestProperties == null)
        {
            currentAirplaneQuestProperties = airplaneQuestItems[0];
        }
        currentAirplaneQuestProperties.Click();
        txtProgessQuest.text = $"{airplaneProperties.countQuestCompleted}/{airplaneProperties.countQuestCompletedToReward}";
        progessQuest.fillAmount = airplaneProperties.countQuestCompleted / airplaneProperties.countQuestCompletedToReward;
        if(airplaneProperties.isRevecedReward) btRevecieReward.image.sprite = sprRevecieReward;
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        buildingData.updateData -= UpdateData;
    }

    public override void Close()
    {
        base.Close();
        buildingData.updateData -= UpdateData;
    }
    public override void OnCloseClicked()
    {
        base.OnCloseClicked();
        buildingData.updateData -= UpdateData;
    }
    public void ShowDetail(AirplaneQuestItem airplaneQuestItem)
    {
        airplaneQuestDetailInfo.updateData = UpdateData;
        airplaneQuestDetailInfo.Show(airplaneQuestItem, Remove, Delivery, Skip);
        foreach(var item in airplaneQuestItems)
        {
            item.UnSelected();
        }
        currentAirplaneQuestProperties = airplaneQuestItem;
        airplaneQuestItem.Selected();
    }
    public bool Remove(AirplaneQuestItem _airplaneQuestItem)
    {
        if (buildingData.Remove(_airplaneQuestItem.index))
        {
            _airplaneQuestItem.Removed();
            return true;
        }
        return false;
    }
    public bool Delivery(AirplaneQuestItem _airplaneQuestItem)
    {
        if (buildingData.Delivery(_airplaneQuestItem.airplaneQuest))
        {
            _airplaneQuestItem.Click();
            return true;
        }
        return false;
    }
    public bool Skip(AirplaneQuestItem airplaneQuestItem)
    {
        if (buildingData.Skip(airplaneQuestItem.index))
        {
            return true;
        }
        return false;
    }
    public void UpdateData()
    {
        Debug.Log("--------------->AirplanePopup UpdateData");
        LoadData(buildingData.BuildingProperties as AirplaneProperties);
    }
    public void RevecieReward()
    {
        if (buildingData.RevecieReward()) 
        {
            btRevecieReward.image.sprite = sprRevecieReward;
        }
    }
}
