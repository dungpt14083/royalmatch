using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Parser
{
    //PARSE DATA CHO THẰNG TEXT LOAD LÊN
    public static Dictionary<string, string> ParsePropertyFileFormat(string text)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        string[] array = text.Split('\n');
        foreach (string text2 in array)
        {
            if (!text2.StartsWith("#"))
            {
                //TÌM INDEX CỦA DẦU = TRONG TEXT
                int num = text2.IndexOf('=');
                if (num >= 0)
                {
                    //KEY LÀ TRUOC DAU = SAU DẤU BẰNG LÀ VALUE
                    string key = text2.Substring(0, num).Trim();
                    string value = text2.Substring(num + 1).Trim();
                    dictionary[key] = value;
                }
            }
        }

        return dictionary;
    }
    
    
}