using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;

public class FarmActionDialogueStart : IAction
{
    public int idDialogue;

    private bool _dialogueDone = false;


    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        PopupManagerView.Instance.PopupManager.RequestPopup(
            new DialoguePopupRequest(new DialoguePopupData(idDialogue, EndDialogue)));
        while (!_dialogueDone)
        {
            yield return null;
        }
        yield return 0;
    }

    private void EndDialogue()
    {
        _dialogueDone = true;
    }


#if UNITY_EDITOR
    public static new string NAME = "FarmDialogue/Dialogue Start";
    private const string NODE_TITLE = "Dialogue Start";
#endif
}