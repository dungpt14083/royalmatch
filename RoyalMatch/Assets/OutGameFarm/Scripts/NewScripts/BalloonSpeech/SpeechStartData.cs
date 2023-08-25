using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpeechStartData 
{
    public DialogueInfo DialogueInfo;
    public int SpeechIndex;
    
    public SpeechStartData(DialogueInfo dialogueInfo, int speechIndex)
    {
        DialogueInfo = dialogueInfo;
        SpeechIndex = speechIndex;
    }
}
