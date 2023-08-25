using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CHO THÔNG TIN TRUỀN VÀO CHO VIỆC TƯƠNG TAC NCH
[Serializable]
public class SpeechInfo
{
    //Left character id là ai::
    public int leftCharacterId=0;

    //Tư thế
    public string leftCharacterPose;

    //Animation của người left 
    public string leftCharacterAnimationKey;

    //RIGH CHACTER ID LÀ NÀO
    public int rightCharacterId=0;

    public string rightCharacterPose;

    public string rightCharacterAnimationKey;

    //FLAG CHO VIỆC LÀTHAWFAWFNG BÊN PHẢI ĐANG NÓI PHẢI K
    public bool rightSpeaking;

    public string emotionIcon;

    public bool HasRightCharacter()
    {
        return rightCharacterId != 0;
    }

    public bool HasLeftCharacter()
    {
        return leftCharacterId != 0;
    }
}