using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CÁC TRACKER ĐỂ CHO CHECK QUEST PROCESS:::
public interface IObjectiveTracker 
{
    //CHO VIỆC GET processamuont và key tralation và sprite:::
    int GetTaskProgressAmount(ObjectiveType objectiveType, int idInType, int amount);

    string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount, Dictionary<string, string> replacements);

    Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount);
}
