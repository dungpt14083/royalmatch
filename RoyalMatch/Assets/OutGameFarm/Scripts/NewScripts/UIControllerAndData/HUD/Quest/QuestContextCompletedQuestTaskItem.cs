using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestContextCompletedQuestTaskItem : MonoBehaviour
{
    [SerializeField] private Image TaskIcon;
    [SerializeField] private TextMeshProUGUI ProgressText;

    public void Init(TaskInfo taskInfo)
    {
        if (taskInfo.Objective != null)
        {
            Sprite objectiveSprite = ObjectiveManager.Instance.GetSprite(
                objectiveType: taskInfo.Objective.ObjectiveType,
                idInType: taskInfo.Objective.IdInType,
                amount: taskInfo.Amount
            );
            this.TaskIcon.sprite = objectiveSprite;
            string amountText = taskInfo.Amount.ToString();
            string formattedText = $"[Amount: {amountText}]";
            this.ProgressText.text = formattedText;
        }
    }
}
