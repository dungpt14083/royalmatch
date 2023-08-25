using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePopupRequest : PopupRequest
{
    public DialoguePopupData DialoguePopupData { get; private set; }

    
    public DialoguePopupRequest(DialoguePopupData dialoguePopupData)
        : base(typeof(DialoguePopup), true, true)
    {
        DialoguePopupData = dialoguePopupData;
    }
}