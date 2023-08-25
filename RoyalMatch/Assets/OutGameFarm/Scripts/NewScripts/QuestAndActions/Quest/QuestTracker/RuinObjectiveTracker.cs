using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CHECK BUILD RUIN VÀ STAGE CỦA NÓ::::
public class RuinObjectiveTracker : MonoSingleton<RuinObjectiveTracker>, IObjectiveTracker
{
    private UpgradeHouse _ruinData;
    private bool _built;

    private void Start()
    {
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.BuildRuin, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.BuildRuinExact, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.StageRuin, this);


        QuestManagerSignals.QuestActivateEventSignal.AddListener(OnQuestActivated);
        ObjectiveTrackerSignals.BuildRuinEvent.AddListener(OnRuinBuild);
    }

    private void OnDestroy()
    {
        QuestManagerSignals.QuestActivateEventSignal.RemoveListener(OnQuestActivated);
        ObjectiveTrackerSignals.BuildRuinEvent.RemoveListener(OnRuinBuild);
    }


    //KHI MỘT QUEST KÍCH HOẠT SẼ KIỂM TRA VỚI CÁC MISTION MÀ 11 12 KIỂM TRA XEM TH CÓ BUILD MẤY CÁI ĐÓ CHƯA BUILD SỐ LƯỢNG ĐÓ RỒI THÌ HOÀN THÀNH PROCESSQUEST Ở ĐÂY
    private void OnQuestActivated(QuestEventData data)
    {
        int taskCount = data.QuestInfo.Tasks.Count;
        // for (int i = 0; i < taskCount; i++)
        // {
        // }
    }

    private void OnRuinBuild(UpgradeHouse upgradeHouse)
    {
        _ruinData = upgradeHouse;
        _built = true;
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _ruinData = null;
        _built = false;
    }


    //ID của house::::
    public int GetTaskProgressAmount(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (objectiveType == ObjectiveType.BuildRuinExact && _built)
        {
            return _ruinData != null && _ruinData.Building.ElementId == idInType ? 1 : 0;
        }

        // else if (objectiveType == ObjectiveType.StageRuin)
        // {
        //     return _ruinData != null && _ruinData.PrefabId == idInType ? 1 : 0;
        // }
        return 0;
    }

    public string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount,
        Dictionary<string, string> replacements)
    {
        if (objectiveType != ObjectiveType.BuildRuinExact) return "";
        return TileManagerView.Instance.FindBuildingByElementId(idInType).BuildingProperties.BuildingName;
    }

    public Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount)
    {
        //LOẠI 13 THÌ LÀ STAGE RUIN CÒN 12 THÌ LÀ LOẠI HÌNH RUIN CHÍNH XÁC GAME CÓ 1 RUIN NÊN GỘP
        if (objectiveType != ObjectiveType.BuildRuinExact) return null;
        return TileManagerView.Instance.GetSpriteByElementId(idInType);
    }
}