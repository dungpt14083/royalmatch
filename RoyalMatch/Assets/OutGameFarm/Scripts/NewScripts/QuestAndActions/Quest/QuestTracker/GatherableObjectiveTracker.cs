using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GatherableObjectiveTracker : MonoSingleton<GatherableObjectiveTracker>, IObjectiveTracker
{
    [SerializeField] private List<GatherableCollection> gatherableCollections;

    private GatherableBuilding _collectedGatherable;
    private FruitTreeBuilding _collectedFruitTree;
    private ItemBonus _collectItemBonus;

    private void Start()
    {
        ObjectiveTrackerSignals.GatherableCollectedEvent.AddListener(OnGatherableCollected);
        QuestManagerSignals.QuestActivateEventSignal.AddListener(OnQuestActivated);
        ObjectiveTrackerSignals.FruitTreeCollectedEvent.AddListener(OnFruitTreeCollected);
        ObjectiveTrackerSignals.ItemBonusCollectedEvent.AddListener(OnItemBonusCollected);

        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.CollectGatherableAny, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.CollectGatherableKind, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.CollectGatherableExact, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.CollectGatherableType, this);
    }

    private void OnDestroy()
    {
        ObjectiveTrackerSignals.GatherableCollectedEvent.RemoveListener(OnGatherableCollected);
        QuestManagerSignals.QuestActivateEventSignal.RemoveListener(OnQuestActivated);
        ObjectiveTrackerSignals.FruitTreeCollectedEvent.RemoveListener(OnFruitTreeCollected);
        ObjectiveTrackerSignals.ItemBonusCollectedEvent.RemoveListener(OnItemBonusCollected);
    }


    //KHI MỘT QUEST ĐƯỢC KÍCH HOẠT????
    //ĐỂ MÀ TRÁNH LỖI LỠ CÓ CÁI NÀO ĐÓ THU THP RÔỒI THÌ CÁI NÀY TỰ COMPLETED LUN VÌ ĐÃ LÀM RỒI 
    //sẽ chọc vào trong gatherablierequimentcnotroller
    //check cả trong general xem thử số lượng rác đã gom à??? hơi lạ đoạn này
    private void OnQuestActivated(QuestEventData data)
    {
        for (int taskIndex = 0; taskIndex < data.QuestInfo.Tasks.Count; taskIndex++)
        {
            //Lấy task ra để xét
            TaskInfo taskInfo = data.QuestInfo.Tasks[taskIndex];
            if (!ObjectiveTypeExtensions.IsObjectiveTypeGatherable(taskInfo.Objective.ObjectiveType))
            {
                continue;
            }

            //CHECK XEM ĐÃ THU HOẠCH NÓ CHƯA LÀ ĐƯỢC CÁC CÁI CHECK KHÁC TẠM BỎ QUA ĐI TRONG INVENTORY GÌ GÌ ĐÓ TẠM BỎ QUA KHÔNG TÍNH SỐ ĐÁ Ở TRONG À???
            //loại rác ở trong à?????::::
            //CÓ NHỮNG CÁI RÁC SẼ Ở TRONG NHƯNG SẼ BÀN BẠC VỚI GD TÍNH TOÁN NÓ SAU
            if (taskInfo.Objective.ObjectiveType == ObjectiveType.CollectGatherableExact)
            {
                int gatherableId = data.QuestInfo.Tasks[taskIndex].Objective.IdInType;
                bool isGatherableCollected =
                    GatherableRequirementManagerView.Instance.IsGatherableCollected(id: gatherableId);
                if (isGatherableCollected)
                {
                    FarmQuestManagerView.Instance.ProgressTask(data.QuestData, data.QuestInfo,
                        data.QuestInfo.Tasks[taskIndex], taskIndex, 1);
                }
            }

            //ĐOẠN NÀY CHO XỬ LÍ NẾU LÀ LOẠI COLLECT TYPE THÌ XEM THỬ TRONG INVENTORY CÁI NÀY SẼ NCH VS BÊN GD
            // if (taskInfo.ObjectiveType == ObjectiveType.CollectGatherableType)
            // {
            //     gatherableId = data.QuestInfo.Tasks[taskIndex].IdInType;
            //     GatherableInfo gatherableInfo = _gatherableInfoCollection.Get(prefabId: gatherableId);
            //     if (gatherableInfo.Category != GatherableCategory.Neighbour)
            //         continue;
            //
            //     if (_gatherableInfoCollection.InQueue.ZDistance == 0f)
            //         continue;
            //
            //     int itemId = _gatherableInfoCollection.InQueue.Alpha;
            //     int amount = _inventoryService.GetAmount(itemId: itemId);
            //     bool progressResult = _questService.ProgressTask(questData: data.QuestData,
            //         questInfo: data.QuestInfo,
            //         taskInfo: taskInfo, taskIndex: taskIndex, amount: amount);
            // }
        }
    }


    private void OnGatherableCollected(GatherableCollectedEventData data)
    {
        _collectedGatherable = data.GatherableBuilding;
        Debug.LogError("CHECK GATHERABLE::::::::" + _collectedGatherable.Building.ElementId);
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _collectedGatherable = null;
    }

    private void OnFruitTreeCollected(FruitTreeCollectedEventData data)
    {
        _collectedFruitTree = data.FruitTreeBuilding;
        Debug.LogError("CHECK GATHERABLE::::::::" + _collectedFruitTree.Building.ElementId);
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _collectedFruitTree = null;
    }

    private void OnItemBonusCollected(ItemBonusCollectedEventData data)
    {
        _collectItemBonus = data.itemBonus;
        Debug.LogError("CHECK GATHERABLE::::::::" + _collectItemBonus.Building.ElementId);
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _collectItemBonus = null;
    }

    //PROCESS KHI TRUYỀN OBJECTYPE KIA VÀO 
    //CHECK CHO CẢ SỰ KIỆN CÁC GATHERABLE VÙNG TỪ 
    public int GetTaskProgressAmount(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (_collectedGatherable == null) return 0;
        //NẾU KHÔNG PHẢI LOẠI TYPE NÀY CHECK THÌ RETURN LÀ SỐ LƯỢNG 0 LUÔN
        if (!ObjectiveTypeExtensions.IsObjectiveTypeGatherable(objectiveType))
        {
            return 0;
        }

        int progressAmount = 0;

        //THEO TỪNG LOẠI MÀ XỬ LÍ THÔI::::
        switch (objectiveType)
        {
            case ObjectiveType.CollectGatherableAny:
                //THÌ CHỈ CẦN SỐ LƯỢNG AMOUNT CỦA TASK VÔ 
                progressAmount += 1;
                break;
            //loại loa này tính sau????
            case ObjectiveType.CollectGatherableKind:
                progressAmount += 1;
                break;
            //nếu đúng chính xác thì phải có id 
            case ObjectiveType.CollectGatherableExact:
                if (idInType == _collectedGatherable.Building.ElementId)
                {
                    progressAmount += 1;
                }

                break;
            case ObjectiveType.CollectGatherableType:
                if ((GatherableCategory)idInType == _collectedGatherable.GatherableProperties.GatherableCategory)
                {
                    progressAmount += 1;
                }

                break;
            default:
                break;
        }

        return progressAmount;
    }

    public string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount,
        Dictionary<string, string> replacements)
    {
        return TileManagerView.Instance.FindBuildingByElementId(idInType).BuildingProperties.BuildingName;
    }

    public Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (objectiveType == ObjectiveType.CollectGatherableExact)
        {
            Building building = TileManagerView.Instance.FindBuildingByElementId(idInType);
            return gatherableCollections.Find(collection =>
                collection.SpriteName == building.BuildingProperties.SpriteReference).Sprite;
        }

        // if (objectiveType == ObjectiveType.CollectGatherableAny)
        // {
        //     return gatherableCollections.Find(collection => collection.Id == 0).Sprite;
        // }
        // else if (objectiveType == ObjectiveType.CollectGatherableKind ||
        //          objectiveType == ObjectiveType.CollectGatherableType)
        // {
        //     return gatherableCollections.Find(collection => collection.Id == idInType).Sprite;
        // }
        // else if (objectiveType == ObjectiveType.CollectGatherableExact)
        // {
        //     return gatherableCollections.Find(collection => collection.Id == idInType).Sprite;
        //     
        //     
        // }

        return null;
    }
    
    // private void OnValidate()
    // {
    //     if (gatherableCollections!=null)
    //     {
    //         for (int i = 0; i < gatherableCollections.Count; i++)
    //         {
    //             var tmp = gatherableCollections[i];
    //             if (string.IsNullOrEmpty(tmp.SpriteName))
    //             {
    //                 tmp.SpriteName = tmp.Sprite.name;
    //             }
    //         }
    //     }
    // }
    
}

[Serializable]
public class GatherableCollection
{
    public int Category = -1;
    public string SpriteName;
    public Sprite Sprite;
}