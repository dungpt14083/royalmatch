using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class TranslationInfo 
{
    public string Key;
    public string Value;
    
    public TranslationInfo(string key, string value)
    {
        this.Key = key;
        this.Value = value;
    }
}
