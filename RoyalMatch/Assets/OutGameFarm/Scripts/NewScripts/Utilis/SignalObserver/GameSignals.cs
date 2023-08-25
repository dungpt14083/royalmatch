using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;

public static class GameSignals
{
    public static readonly Signal<bool> EnableClickPlaneWhenShowPreBuilding = new Signal<bool>();
}


public static class CutSceneSignals
{
    public static readonly Signal<Actions> CutSceneStart = new Signal<Actions>();
    public static readonly Signal CutSceneFinish = new Signal();


    public static readonly Signal<SpeechStartData> SpeechStartSignal = new Signal<SpeechStartData>();
    public static readonly Signal<SpeechInfo> SpeechFinishSignal = new Signal<SpeechInfo>();

    public static readonly Signal<SpeechBalloonSpeakerChangedData> SpeechBalloonSpeakerChanged =
        new Signal<SpeechBalloonSpeakerChangedData>();


    public static readonly Signal<DialogueInfo> DialogueStartSignal = new Signal<DialogueInfo>();
    public static readonly Signal<DialogueInfo> DialogueFinishSignal = new Signal<DialogueInfo>();
}

public static class QuestManagerSignals
{
    public static readonly Signal<QuestEventData> QuestActivateEventSignal = new Signal<QuestEventData>();
    public static readonly Signal<QuestEventData> QuestCompleteEventSignal = new Signal<QuestEventData>();
    public static readonly Signal<UserQuestData> QuestFinishEventSignal = new Signal<UserQuestData>();


    public static readonly Signal<QuestTaskProgressEventData> QuestTaskProgressEventSignal =
        new Signal<QuestTaskProgressEventData>();
    public static readonly Signal<QuestTaskProgressEventData> QuestTaskCompleteEventSignal =
        new Signal<QuestTaskProgressEventData>();
}

public static class ObjectiveTrackerSignals
{
    public static readonly Signal<GatherableCollectedEventData> GatherableCollectedEvent = new Signal<GatherableCollectedEventData>();

    public static readonly Signal<FarmPlantEventData> FarmPlantEvent = new Signal<FarmPlantEventData>();
    public static readonly Signal<FarmPlantEventData> FarmHarvestEvent = new Signal<FarmPlantEventData>();
    
    public static readonly Signal<FruitTreeCollectedEventData> FruitTreeCollectedEvent = new Signal<FruitTreeCollectedEventData>();
    public static readonly Signal<ItemBonusCollectedEventData> ItemBonusCollectedEvent = new Signal<ItemBonusCollectedEventData>();

    //CHO TẤT CẢ RUIN
    public static readonly Signal<UpgradeHouse> BuildRuinEvent = new Signal<UpgradeHouse>();
    
    
    //2 SỰ KIỆN KHI MÀ TẠO ITEM CŨNG NHƯ THU HOẠCH ITEM::::
    public static readonly Signal<FactoryEventData> FactoryProductionStartEvent = new Signal<FactoryEventData>();
    public static readonly Signal<FactoryEventData> FactoryCollectItemEvent = new Signal<FactoryEventData>();
    
    //SỰ KIỆN TIÊU THỤ VẬT PHẨM ĐỂ SẢN XUAT DANH CHO NHÀ ĐẶC BIỆT LÀ DINNERTABLE THEO YÊU CAAFU GD:::
}