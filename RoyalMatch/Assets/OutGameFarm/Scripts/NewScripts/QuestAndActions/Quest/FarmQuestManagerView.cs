using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

public class FarmQuestManagerView : MonoSingleton<FarmQuestManagerView>, IRequirementController, ITradeController
{
    [SerializeField] private RequirementManager requirementManager;
    [SerializeField] private TradeManager tradeManager;
    [SerializeField] private int maxActiveQuestCount;
    [SerializeField] private QuestInfoCollection questInfoCollection;

    public QuestInfoCollection QuestInfoCollection => questInfoCollection;

    //Day dataa cuar quest cua nguoi chowi vao day::
    public UserQuestsData QuestsData;

    public void Init(UserQuestsData data)
    {
        QuestsData = data;
    }

    private void Start()
    {
        //Khivaof thì nó đưang kí requirmentCnotroller để check nó :::
        requirementManager.RegisterRequirementController(RequirementType.Quest, this);
        tradeManager.RegisterTradeController(TradeType.Quest, this);
    }

    private void OnDestroy()
    {
        tradeManager.UnRegisterTradeController(TradeType.Quest);
    }

    //OK CHECK XEM QUEST ĐẪ FINISH CHƯA
    //TRUYỀN REQUIREMENT VÀO ĐỂ CHECK XEM CHO CONTROLLER CHECK XEM REQUIRMENT KIA ĐẠT ĐƯỢC YÊU CẦU HAY K
    public bool IsProvided(RequirementInfo requirement)
    {
        if (requirement.RequirementType != RequirementType.Quest) return false;
        if (QuestsData.FinishedQuests != null)
        {
            return QuestsData.FinishedQuests.Contains(requirement.Value);
        }

        return false;
    }


    #region TODO CHECK NEW QUEST

    //OKKK
    //KHI LEVEL UP HOẶC LÀ KHI MÀ HOÀN THÀNH 1 QUEST NÀO ĐÓ THÌ SẼ CHECKNEWQUEST::
    public void CheckNewQuests()
    {
        if (QuestsData.ActiveQuests.Count >= maxActiveQuestCount)
        {
            return;
        }

        var questsCollection = questInfoCollection.quests;

        for (int i = 0; i < questsCollection.Count; i++)
        {
            var tmp = questsCollection[i];
            if (IsQuestFinished(tmp.id) || IsQuestActive(tmp.id))
            {
                continue;
            }

            //CHECK REQUIRMENT VỚI QUEST INFO ĐOẠN NÀY HƠI LAG VÌ NÓ CHECK HẾT 
            //GỌI TỚI YÊU CẦU REQUIRMENT ĐẠT CHƯA THÌ CHẠY
            if (!requirementManager.IsRequirementsProvided(requirements: tmp.Requirements))
            {
                continue;
            }

            StartQuest(tmp);

            if (QuestsData.ActiveQuests.Count >= maxActiveQuestCount)
            {
                break;
            }
        }
    }


    //FINISH TỨC NẰM TRONG LIST FINISH RỒI:::
    public bool IsQuestFinished(int questId)
    {
        if (QuestsData.FinishedQuests != null)
        {
            return QuestsData.FinishedQuests.Contains(questId);
        }

        return false;
    }

    public bool IsQuestActive(int questId)
    {
        for (int i = 0; i < QuestsData.ActiveQuests.Count; i++)
        {
            if (QuestsData.ActiveQuests[i].Id == questId)
            {
                return true;
            }
        }

        return false;
    }

    //LÀ CÓ COMPLETE NHƯNG CHƯA FINISH VÌ LÍ DO GÌ ĐÓ????
    public bool IsQuestCompleted(int questId)
    {
        for (int i = 0; i < QuestsData.ActiveQuests.Count; i++)
        {
            if (QuestsData.ActiveQuests[i].Id == questId)
            {
                return QuestsData.ActiveQuests[i].Completed;
            }
        }

        return false;
    }

    #endregion


    #region TESTTTTTTTTTTTTTQUESSTTTTTTTT:::::

    [Button]
    public void TestQuest()
    {
        var questInfo = questInfoCollection.quests[0];
        StartQuest(questInfo);
    }

    [Button]
    public void TestQuestComplete()
    {
        QuestInfo questInfo = QuestInfoCollection.GetQuestInfo(1);


        var tmp = QuestsData.ActiveQuests[0];
        tmp.TaskProgresses = new List<int>();
        for (int i = 0; i < questInfo.Tasks.Count; i++)
        {
            var x = questInfo.Tasks[i];
            tmp.TaskProgresses.Add(x.Amount);
        }

        if (tmp.Completed == true)
        {
            return;
        }

        int taskCount = questInfo.Tasks.Count;
        bool allTasksCompleted = true;
        for (int i = 0; i < taskCount; i++)
        {
            TaskInfo taskInfo = questInfo.Tasks[i];
            if (!IsTaskCompleted(taskInfo, tmp.TaskProgresses[i]))
            {
                allTasksCompleted = false;
                break;
            }
        }

        if (allTasksCompleted)
        {
            CompleteQuest(tmp, questInfo);
        }
    }

    #endregion


    //BẮT ĐẦU 1 QUEST MỚI:::::::
    public void StartQuest(QuestInfo questInfo)
    {
        //THÌ TẠO MỚI DATA USEQUEST DATA VÀ NHÉT VÀO
        var newUserQuestData = new UserQuestData(questInfo.id, true, false);
        //ADD THẰNG VÀO ĐỂ TASK MẢNG KHỞI ĐỘNG ?
        newUserQuestData.TaskProgresses = new List<int>();
        for (int i = 0; i < questInfo.Tasks.Count; i++)
        {
            newUserQuestData.TaskProgresses.Add(0);
        }

        QuestsData.ActiveQuests.Add(newUserQuestData);
        QuestManagerSignals.QuestActivateEventSignal.Dispatch(new QuestEventData(questInfo, newUserQuestData));
        this.CheckQuestComplete(newUserQuestData);
    }


    //KHI MÀ ĐÃ ẤN VÀO QUEST SEEN THÌ K HIỆN DẤU CHẤM THAN NỮA:::COI NHƯ NÓ ĐÃ SEEN R
    //KHÔNG CÒN HIỆN DẤU CHẤM THAN NỮA
    public void QuestSeen(UserQuestData questData)
    {
        questData.New = false;
    }


    #region QUEST PROCESSSS

    //DUYỆT QUA LIST QUEST ACTIVE Ở TRÊNHIEERAR CHY 
    //DUYỆT QUA THẰNG LIST ACTIVE QUEST VÀ PROGRESSCHECKER ĐỂ TỪ ĐÓ CHECK::::
    //check
    public void CheckQuestsProgress(IObjectiveTracker progressChecker)
    {
        for (int i = 0; i < QuestsData.ActiveQuests.Count; i++)
        {
            CheckQuestProgress(QuestsData.ActiveQuests[i], progressChecker);
        }
    }


    //SẼ ĐƯỢC 

    //okkkkkkkkkkkkkk
    //TRUYỀN THẰNG TRACKER VÀO THẰNG TRACKER LÀ THẰNG CHECK TASK CHECK LUÔN MSSSION HOÀN THÀNH LUÔN KHI HOÀN THÀNH 1 TRACKER::
    //CHECK RỒI NẾU MÀ TASK COMPLETEE HẾT THÌ SẼ CHECK QUEST COMPLETE K THÌ THôi
    public void CheckQuestProgress(UserQuestData questData, IObjectiveTracker progressChecker)
    {
        QuestInfo questInfo = QuestInfoCollection.GetQuestInfo(questId: questData.Id);
        int taskIndex = 0;
        bool allTasksCompleted = true;

        foreach (TaskInfo taskInfo in questInfo.Tasks)
        {
            if (taskIndex >= questData.TaskProgresses.Count)
            {
                break;
            }


            if (!CheckTaskProgress(questData: questData, questInfo, taskInfo, taskIndex, progressChecker))
            {
                allTasksCompleted = false;
            }

            taskIndex++;
        }

        if (allTasksCompleted)
        {
            CheckQuestComplete(questData);
        }
    }

    #endregion


    #region QUEST COMPLETEEEEEEEEEEEEE

    //CHECK QUESTCOMPLETED TỪ ĐÂU GỌI TỚI ĐỂ CHECK TẤT CẢ QUEST ACTIVE COMPLETE
    public void CheckQuestsCompleted()
    {
        for (int i = 0; i < QuestsData.ActiveQuests.Count; i++)
        {
            CheckQuestComplete(QuestsData.ActiveQuests[i]);
        }
    }

    //OKKKKK1111
    //CÁC TASK HOÀN THÔI RỒI thì còn việc check
    public void CheckQuestComplete(UserQuestData questData)
    {
        if (questData.Completed == true)
        {
            return;
        }

        QuestInfo questInfo = QuestInfoCollection.GetQuestInfo(questId: questData.Id);

        int taskCount = questInfo.Tasks.Count;
        bool allTasksCompleted = true;
        for (int i = 0; i < taskCount; i++)
        {
            TaskInfo taskInfo = questInfo.Tasks[i];
            if (!IsTaskCompleted(taskInfo, questData.TaskProgresses[i]))
            {
                allTasksCompleted = false;
                break;
            }
        }

        if (allTasksCompleted)
        {
            CompleteQuest(questData, questInfo);
        }
    }

    //okkkkk
    public void CompleteQuest(UserQuestData questData, QuestInfo questInfo)
    {
        questData.Completed = true;
        QuestManagerSignals.QuestCompleteEventSignal.Dispatch(new QuestEventData(questInfo, questData));
    }


    //OKKKK HOẶC GỌI BỞI QUEST CONTEXXT PANEL HIEERN THỊ PANEL NHIỆM VU TẮT ĐI THÌ FINISH
    //THỰC HIỆN BỞI ACTION Ể ĐƯA VÀO TRONG FINISH CHỨ THƯỜNG THÌ CHỈ COMPLETE
    //KHI CÓ ACTION THÌ MỚI FINISH NHIỆM VỤ CHỨ CHỈ LÀ HOÀN THÀNH THÌ NÓ CÓ THỂ K TỰ HOÀN THÀNH
    public void FinishQuest(UserQuestData quest)
    {
        if (quest.Completed != true)
        {
            return;
        }

        if (QuestsData.ActiveQuests.Contains(quest))
        {
            var questInfo = questInfoCollection.GetQuestInfo(quest.Id);
            QuestsData.FinishedQuests.Add(quest.Id);
            QuestsData.ActiveQuests.Remove(quest);
            QuestManagerSignals.QuestFinishEventSignal.Dispatch(quest);
            tradeManager.Add(questInfo.Rewards, "Quest");
            CheckNewQuests();
            //UpdateSeenQuestUserProperty();
            return;
        }
    }

    #endregion


    #region TASLCONTROLLER AND CHECK:::

    //CHECK TASK PRCESS TỪ THẰNG CHECKER
    //BỌN TRACKER SSẼ CHECK ĐỂ XỬ LÍ NHIỆM VỤ:::
    public bool CheckTaskProgress(UserQuestData questData, QuestInfo questInfo, TaskInfo taskInfo, int taskIndex,
        IObjectiveTracker progressChecker)
    {
        Objective objective = taskInfo.Objective;
        if (objective == null) return false;


        //ĐOẠN NÀY CHECK progresscheck kẻ xong thì xún progressTask:::
        //TỪ CHẲNG CHECKER KIA CHECK SỐ LƯỢNG PROCEESS CỦA CHECKER ĐÓ CUNG CẤP
        //TRUYỀN S LƯỢNG CỦA TASKINFO VÀO ĐỂ LẤY SỐ LƯỢNG ĐÃ CÓ XEM NTN 
        int progressAmount =
            progressChecker.GetTaskProgressAmount(objective.ObjectiveType, objective.IdInType, taskInfo.Amount);
        if (progressAmount < 1) return false;

        return (bool)ProgressTask(questData, questInfo, taskInfo, taskIndex, progressAmount);
    }


    //OKKKK
    //TRUYỀN QUEST INFO TASK INFO TASK INDEX SỐ LƯỢNG VÀO CHECK XEM XỬ LÍ TASK TRONG QUEST
    //gọi từ cái ádđ::TRẢ VỀ TRUE FLASE XONG HAY K XỬ LÍ ĐƯỢC K
    public bool ProgressTask(UserQuestData questData, QuestInfo questInfo, TaskInfo taskInfo, int taskIndex, int amount)
    {
        if (taskIndex < 0 || taskIndex >= questInfo.Tasks.Count)
        {
            return false;
        }

        //CỘNG SỐ LỰNG VÀO TRONG trong task process với index trong data
        questData.TaskProgresses[taskIndex] += amount;
        QuestManagerSignals.QuestTaskProgressEventSignal.Dispatch(
            new QuestTaskProgressEventData(questInfo, questData, taskInfo, taskIndex));

        //NẾU MÀ HOAN THÀNH TASK LUÔN THÌ TRẢ VE TRUE:::
        if (taskInfo.Amount <= questData.TaskProgresses[taskIndex])
        {
            QuestManagerSignals.QuestTaskCompleteEventSignal.Dispatch(
                new QuestTaskProgressEventData(questInfo, questData, taskInfo, taskIndex));
            return true;
        }

        return false;
    }


    //OKKKK
    //TRUYỀN SỐ LƯỢNG VÀO SO SÁNH VỚI TASK NẾU SỐ LƯỢNG LỚN HƠN AMOUNT CỦA TASKINFO THÌ LÀ TRUE
    public bool IsTaskCompleted(TaskInfo taskInfo, int amount)
    {
        return taskInfo.Amount <= amount;
    }

    #endregion


    #region FOR TRADE:::::::::controller KHI NHẬN CÁC THỨ VÀO::::::

    //TRADE ĐÓ NÓ HOÀN HÀNH 1 CÁI THƯỞNG LÀ 1 CÁI QUEST:::BÊN TRADEMANAGER GỌI KÍCH HOẠT QUEST KHÁC DỰA TRÊN QUEST ĐÃ QUA:::
    //KÍCH HOẠT TẠO MỚI QUEST Ở ĐÂY MÀ ?????ĐÂU PHẢI LÀ CÁI NÀY ĐÂU:::
    //Để process quest thôi
    public bool Add(TradeInfo tradeInfo, string source)
    {
        //CHO TRADE QUEST
        if (tradeInfo.TradeType == TradeType.Quest && !IsQuestActive(tradeInfo.IdInType))
        {
            UserQuestData questData = null;
            foreach (var activeQuest in QuestsData.ActiveQuests)
            {
                if (activeQuest.Id == tradeInfo.IdInType)
                {
                    questData = activeQuest;
                    break;
                }
            }

            if (questData != null)
            {
                QuestInfo questInfo = QuestInfoCollection.GetQuestInfo(tradeInfo.IdInType);
                for (int i = 0; i < questInfo.Tasks.Count; i++)
                {
                    TaskInfo taskInfo = questInfo.Tasks[i];
                    ProgressTask(questData, questInfo, taskInfo, i, tradeInfo.Amount);
                }

                CheckQuestComplete(questData);
            }

            return false;
        }

        //CHO TRADE TASK:::COMPLETE TASK VÀ QUEST THÌ NHẬN VÀO ĐÂY
        //THÌ DỰA VÀO ID CỦA QUEST VÀ AMOUNT LÀ INDEX CỦA TASK
        if (tradeInfo.TradeType == TradeType.Task && !IsQuestActive(tradeInfo.IdInType))
        {
            UserQuestData questData = null;
            foreach (var activeQuest in QuestsData.ActiveQuests)
            {
                if (activeQuest.Id == tradeInfo.IdInType)
                {
                    questData = activeQuest;
                    break;
                }
            }

            if (questData != null)
            {
                //NẾU INDEX CỦA TASK LỚN HƠN OR BÉ HƠN HOẶC BẰNG COUNT THÌ SẼ RETRN VÌ INDEX VƯỢT QUÁ
                if (questData.TaskProgresses.Count <= tradeInfo.Amount || tradeInfo.Amount < 0) return false;
                QuestInfo questInfo = QuestInfoCollection.GetQuestInfo(tradeInfo.IdInType);
                //DỰA VÀO ĐÂY ĐỂ MÀ CHẠY COMPLETE TASK ĐÓ:::
                TaskInfo taskInfo = questInfo.Tasks[tradeInfo.Amount];
                ProgressTask(questData, questInfo, taskInfo, tradeInfo.Amount, 1);
                CheckQuestComplete(questData);
                return true;
            }
        }
        return false;
    }


    public bool Remove(TradeInfo tradeInfo, string source)
    {
        return false;
    }

    public int Diff(TradeInfo tradeInfo)
    {
        return 0;
    }

    public int ToGem(TradeInfo tradeInfo)
    {
        return 0;
    }


    public UnityEngine.Sprite GetSprite(TradeInfo tradeInfo)
    {
        return null;
    }

    public string GetTranslationKey(TradeInfo tradeInfo)
    {
        return "";
    }

    public long GetCurrentAmount(TradeInfo tradeInfo)
    {
        return 0;
    }

    #endregion
}