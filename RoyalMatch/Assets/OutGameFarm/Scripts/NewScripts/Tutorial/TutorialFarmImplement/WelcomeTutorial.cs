using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeTutorial : TutorialFarm
{
    public enum TutorialStep
    {
        None = 0,
        TextWelcome = 1,
        TextIntro = 2,
        TextArrival = 3
    }

    public override TutorialType Type
    {
        get { return TutorialType.WelcomeTutorial; }
    }

    public TutorialStep Step { get; private set; }

    public override bool AllowedToSkip
    {
        get { return true; }
    }

    public WelcomeTutorial(TutorialDirector tutorialDirector)
        : base(tutorialDirector)
    {
    }

    public override bool ShouldStartTutorial(ITutorialData tutorialData)
    {
        return true;
    }

    public override void StartTutorial(ITutorialData tutorialData)
    {
        base.StartTutorial(tutorialData);
        Step = TutorialStep.TextWelcome;
    }

    public override void ResetTutorial()
    {
        base.ResetTutorial();
        Step = TutorialStep.None;
    }

    public void TextShown()
    {
        switch (Step)
        {
            case TutorialStep.TextWelcome:
                Step = TutorialStep.TextArrival;
                FireStepChangedEvent();
                break;
            case TutorialStep.TextIntro:
                Step = TutorialStep.TextArrival;
                FireStepChangedEvent();
                break;
            case TutorialStep.TextArrival:
                _tutorialDirector.FinishTutorial(this);
                break;
        }
    }
}