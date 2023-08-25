using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DÀNH CHO ACTIVE VÀ COMPLETEQUEST EVENT bắn signal đi::::
//FINISH EVENT THÌ CHỈ CẦN USERQUESTDATAA BẮN LÀ ĐƯỢC
public class QuestEventData
{
    public QuestInfo QuestInfo;

    public UserQuestData QuestData;

    public QuestEventData(QuestInfo questInfo, UserQuestData questData)
    {
        QuestInfo = questInfo;
        QuestData = questData;
    }
}

public class QuestTaskProgressEventData
{
    public QuestInfo QuestInfo;

    public UserQuestData QuestData;

    public TaskInfo TaskInfo;

    public int TaskIndex;

    public QuestTaskProgressEventData(QuestInfo questInfo, UserQuestData questData, TaskInfo taskInfo, int taskIndex)
    {
        QuestInfo = questInfo;
        QuestData = questData;
        TaskInfo = taskInfo;
        TaskIndex = taskIndex;
    }
}
