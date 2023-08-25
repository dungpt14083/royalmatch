using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CharacterAnimationKeys
{
    public static string Idle;
    public static string Gesture;
    public static string Walk;
    public static string SingleSpeak;
    public static string Speak;
    public static string Normal;
    public static string Happy;
    public static string Sad;
    public static string Excited;
    public static string Shocked;
    public static string Thinking;
    
    static CharacterAnimationKeys()
    {
        CharacterAnimationKeys.Idle = "Idle";
        CharacterAnimationKeys.Gesture = "Gesture";
        CharacterAnimationKeys.Walk = "Walk";
        CharacterAnimationKeys.SingleSpeak = "SingleSpeak";
        CharacterAnimationKeys.Speak = "Speak";
        CharacterAnimationKeys.Normal = "Normal";
        CharacterAnimationKeys.Happy = "Happy";
        CharacterAnimationKeys.Sad = "Sad";
        CharacterAnimationKeys.Excited = "Excited";
        CharacterAnimationKeys.Shocked = "Shocked";
        CharacterAnimationKeys.Thinking = "Thinking";
    }
}
