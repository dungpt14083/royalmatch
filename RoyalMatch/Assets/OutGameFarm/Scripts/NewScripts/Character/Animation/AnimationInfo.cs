using System;
using UnityEngine;


[Serializable]
public class AnimationInfo
{
    public AnimationClip AnimationReference;

    public AudioClip soundClip;

    public string animationName;

    public float fadeDuration;

    public AnimationItemType animationItemType;

    public float baseOffset;

    public AgentType agentType;

    public bool HasSound()
    {
        return soundClip != null;
    }
}