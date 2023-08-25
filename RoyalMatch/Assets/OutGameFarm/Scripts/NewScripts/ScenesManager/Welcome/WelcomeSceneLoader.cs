using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WelcomeSceneLoader : SceneLoader
{
    [SerializeField] private EventSystem eventSystem;

    protected override void OnStartLoading()
    {
        this.eventSystem.enabled = false;
    }
}