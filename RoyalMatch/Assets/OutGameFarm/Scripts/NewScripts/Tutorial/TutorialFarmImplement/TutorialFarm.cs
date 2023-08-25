using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TutorialFarm
{
    public delegate void StepChangedEventHandler();

    public event StepChangedEventHandler StepChangedEvent;

    protected TutorialDirector _tutorialDirector;

    public abstract TutorialType Type { get; }
    public ITutorialData TutorialData { get; private set; }
    public PopupManager PopupManager { get; private set; }
    public CameraOperator CameraOperator { get; private set; }
    public abstract bool AllowedToSkip { get; }

    public TutorialFarm(TutorialDirector tutorialDirector)
    {
        _tutorialDirector = tutorialDirector;
        PopupManager = _tutorialDirector.PopupManager;
        CameraOperator = _tutorialDirector.CameraOperator;
    }

    protected void FireStepChangedEvent()
    {
        if (this.StepChangedEvent != null)
        {
            this.StepChangedEvent();
        }
    }

    public abstract bool ShouldStartTutorial(ITutorialData tutorialData);

    public virtual void StartTutorial(ITutorialData tutorialData)
    {
        TutorialData = tutorialData;
        PopupManager.PopupOpenedEvent += OnPopupOpened;
        PopupManager.PopupClosedEvent += OnPopupClosed;
    }

    public virtual void EndTutorial()
    {
        PopupManager.PopupOpenedEvent -= OnPopupOpened;
        PopupManager.PopupClosedEvent -= OnPopupClosed;
        TutorialData = null;
    }

    public virtual void ResetTutorial()
    {
        PopupManager.PopupOpenedEvent -= OnPopupOpened;
        PopupManager.PopupClosedEvent -= OnPopupClosed;
        TutorialData = null;
    }

    protected virtual void OnPopupOpened(PopupRequest request)
    {
    }

    protected virtual void OnPopupClosed(PopupRequest request)
    {
    }
}