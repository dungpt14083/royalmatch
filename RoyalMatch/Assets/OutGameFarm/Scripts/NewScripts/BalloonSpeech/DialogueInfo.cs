using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//DỰA VÀO DIALOGUE ID VÀ SPEECHINDEX ĐỂ LẤY TEXT ĐI
[Serializable]
public class DialogueInfo 
{
    public int id;

    //public int UnityId;

    public string Name;

    public List<SpeechInfo> Speeches;
    
    //Check xem nhân vật đã nói với thằng indexx này?:
    public bool DidCharacterSpokenBefore(int characterId, int speechIndex)
    {
        return false;
    }
}
