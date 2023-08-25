using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GatherableCategoryToAnimation 
{
    public GatherableCategory Category;
    public AnimationClip AnimationReference;
    public string SoundFxName;
    public float NormalizedSoundDelay;
    public float NormalizedTimeDoAction=0.7f;

}
