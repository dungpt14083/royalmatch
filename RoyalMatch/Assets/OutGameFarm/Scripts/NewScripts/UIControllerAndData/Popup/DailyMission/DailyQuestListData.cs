using System;
using System.Collections.Generic;

[Serializable]
public class DailyQuestListData
{
    public List<DailyQuest> questList;

    public DailyQuestListData(List<DailyQuest> questList)
    {
        this.questList = questList;
    }
}