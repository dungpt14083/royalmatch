using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TRUYỀN ACTION VÀO ĐỂ KHI HOÀN THÀNH THÌ SẼ INVOKE:::
public class DialoguePopupData 
{
    public int DialogueId;
    public Action OnComplete;
    public DialoguePopupData(int dialogueId, Action onComplete = null)
    {
        DialogueId = dialogueId;
        OnComplete = onComplete;
    }
}
