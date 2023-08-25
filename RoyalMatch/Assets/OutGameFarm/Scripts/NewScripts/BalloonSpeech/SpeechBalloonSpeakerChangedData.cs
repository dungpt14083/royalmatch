using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpeechBalloonSpeakerChangedData 
{
    public int character;

    
    public SpeechBalloonSpeakerChangedData(int characterId)
    {
        character = characterId;
    }
}
