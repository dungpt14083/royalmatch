using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectiveManager : MonoSingleton<ObjectiveManager>
{
    //LƯU TƯƠNG ỨNG OBJECTUVETYPE VỚI tracker tương ứng của nó 
    private Dictionary<ObjectiveType, IObjectiveTracker> _objectiveTrackers =
        new Dictionary<ObjectiveType, IObjectiveTracker>();

    private int _requiredTrackerCount;


    public void RegisterObjectiveTracker(ObjectiveType type, IObjectiveTracker tracker)
    {
        this._objectiveTrackers.Add(key: type, value: tracker);
    }

    //GỌI TOWSI BỌN KIA ĐỂ  TỪ ID CỦA CHÚNG TRONG ĐÓNG QUN LÍ ĐÓ ĐỂ MÀ LẤY SPRITE RA TỪ ID ĐÓ
    public UnityEngine.Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (_objectiveTrackers.ContainsKey(objectiveType))
        {
            IObjectiveTracker iObjectiveTracker = this._objectiveTrackers[objectiveType];

            return iObjectiveTracker.GetSprite(objectiveType, idInType, amount);
        }

        return null;
    }

    public string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount,
        System.Collections.Generic.Dictionary<string, string> replacements)
    {
        IObjectiveTracker iObjectiveTracker = this._objectiveTrackers[objectiveType];

        return iObjectiveTracker.GetTranslationKey(objectiveType, idInType, amount, null);
    }


    //liên quan tới thằng //từ đây sẽ phân tích a và lấy translationkey
    public string GetTranslationKey(QuestInfo questInfo, TaskInfo taskInfo, int taskIndex,
        System.Collections.Generic.Dictionary<string, string> replacements)
    {
        //LẤY TỪ TRANSITION RA VỚI KẾT HỢP VỚI TÊN CỦA LOẠI OBJETIVE VỚI ĐỂ THÀNH MÔ TẢ NHIỆM VỤ:::
        string originalString = "collection_quest_{0}_task_{1}";
        int quest = questInfo.id;
        int index = taskIndex;
        string keyTranslation = string.Format(originalString, quest, index);

        var content = TranslationManager.Instance.GetTranslation(keyTranslation);
        var ObjectiveName = GetTranslationKey(taskInfo.Objective.ObjectiveType, taskInfo.Objective.IdInType,
            taskInfo.Amount, null);
        return content + ObjectiveName;
    }
}