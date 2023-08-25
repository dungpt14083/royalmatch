using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneEventListener : MonoBehaviour
{
    private void Awake()
    {
        QuestManagerSignals.QuestCompleteEventSignal.AddListener(OnQuestCompleted);

        //Ở ĐÂY NGHE SỰ KIỆN CUTSCNE ĐỂ K CHO THAO TÁC VỚI CAMERA NỮA:::::
    }

    private void OnDestroy()
    {
        QuestManagerSignals.QuestCompleteEventSignal.RemoveListener(OnQuestCompleted);
    }

    //NẾU NHƯ MÀ CÓ CUTSCENE THÌ ĐUA VÀO QUEUE CÒN K THÌ PLAY LUN::::
    private void OnQuestCompleted(QuestEventData data)
    {
        FinishQuestAction finishQuestAction = new FinishQuestAction(data);

        //Cho thằng bool này cho việc keep popup ..SẼ GIỮ POPUP KHÔNG SHOW TẠI THƯỜI ĐIỂM HIỆN TẠI::
        finishQuestAction.KeepPopups = TradeManager.Instance.HasTradeType(data.QuestInfo.Rewards, TradeType.Cutscene);
        MapActionQueueManager.Instance.QueueAction(finishQuestAction);
    }
}