using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrainPopup : Popup
{
    private int limitQuestActive = 4;
    [SerializeField] private Button btClose;
    [SerializeField] private TMP_Text txtNoti;
    [SerializeField] private TMP_Text txtTime;
    [SerializeField] private StatusQuestTrain statusQuestTrain;
    [SerializeField] private TMP_Text txtPendingQuests;
    [SerializeField] private ItemQuestTrain itemQuestTrainPrefab;
    [SerializeField] private Transform itemQuestTrainParent;


    private TrainBuilding buildingData;
    public override void Open(PopupRequest request)
    {
        base.Open(request);
        btClose.onClick.AddListener(OnCloseClicked);
        TrainPopupRequest request1 = GetRequest<TrainPopupRequest>();
        buildingData = request1.data;
        buildingData.actionReset += ResetData;
        LoadData();
    }
    public void LoadData()
    {
        TrainProperties trainProperties = buildingData.BuildingProperties as TrainProperties;
        int totalQuest = trainProperties.quests.KeyCount;
        int totalQuestRemoved = trainProperties.questsDeleted.Count;
        int totalQuestCompleted = trainProperties.questsCompleted.Count;
        statusQuestTrain.Show(totalQuest, totalQuestCompleted, totalQuestRemoved, trainProperties.rewards);
        var questsActive = trainProperties.quests.Filter((string c, long v) => !trainProperties.questsDeleted.Contains(c) && !trainProperties.questsCompleted.Contains(c));
        int totalQuestActive = questsActive.KeyCount;
        int totalQuestPending = totalQuestActive < limitQuestActive ? 0 : totalQuestActive - limitQuestActive;
        txtPendingQuests.text = totalQuestPending.ToString();

        itemQuestTrainParent.ClearAllChild();

        for (int i = 0; i < questsActive.KeyCount; i++)
        {
            if (i >= limitQuestActive) break;
            var item = itemQuestTrainParent.CreateChild(itemQuestTrainPrefab);
            Currency currency = questsActive.GetCurrency(i);
            item.Show(i, currency, RemoveQuest, Give);
        }
    }
    protected override void OnDestroy()
    {
        base.OnDestroy();
        buildingData.actionReset -= ResetData;
    }

    public override void Close()
    {
        base.Close();
        buildingData.actionReset -= ResetData;
    }
    public override void OnCloseClicked()
    {
        base.OnCloseClicked();
        buildingData.actionReset -= ResetData;
    }
    public void RemoveQuest(string questName)
    {
        var statusRemove = buildingData.RemoveQuest(questName);
        if (statusRemove)
        {
            LoadData();
        }
    }
    public bool Give(string questName)
    {
        var statusGive = buildingData.Give(questName);
        if (statusGive)
        {
            LoadData();
        }
        return statusGive;
    }
    public void ResetData()
    {
        LoadData();
    }
    private void Update()
    {
        if (buildingData == null) return;
        if (buildingData.resetProcess == null) {
            txtTime.text = "";
            return;
        }
        var time = TimeSpan.FromSeconds(buildingData.resetProcess.RemainingTimeSeconds);
        txtTime.text = time.ToString(@"hh\:mm\:ss");
    }
}
