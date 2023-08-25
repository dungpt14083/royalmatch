using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SpeechBalloonWithTextData
{
    public int character;

    public string text;

    public bool isImmediate;

    public SpeechBalloonWithTextData(int character, string text, bool isImmediate = false)
    {
        character = character;
        text = text;
        isImmediate = isImmediate;
    }
}