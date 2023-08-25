using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeTutorialView : TutorialView<WelcomeTutorial>
{
    public override void Deinit()
    {
        this.CancelInvoke(ShowWelcomeText);
        base.Deinit();
    }

    //NGHE SỰ KỆN THAY ĐỔIĐỂ CHẠY CÁC BƯỚC TUTORIAL TỪ THẰNG ỪNG BƯỚC 
    protected override void OnTutorialStepChanged()
    {
        base.OnTutorialStepChanged();
        switch (tutorial.Step)
        {
            //sau khi welcome thì tự kích tới step tiếp theo luôn
            case WelcomeTutorial.TutorialStep.TextWelcome:
                _tutorialDirectorView.ToggleClickHandler(true);
                this.Invoke(ShowWelcomeText, 1f);
                break;
            case WelcomeTutorial.TutorialStep.TextIntro:
                tutorial.TextShown();
                break;
            case WelcomeTutorial.TutorialStep.TextArrival:
                //SANG BÊN NÀY RỒI HÌ NGHE SỰ KIỆN CLOICKED ENT ĐỂ??TỪ ĐÓ TRONG STRP NÀY NGHE SỰ KIEJN CLOCK ĐỂ 
                _tutorialDirectorView.ScreenClickedEvent += OnScreenClickedEvent;
                _tutorialDirectorView.ShowCityAdvisor(TutorialDirectorView.TextPositionType.AdvisorDefault,
                    "tutorial.welcome_grow_crops");
                break;
            default:
                Debug.LogWarningFormat("Unknown Tutorial '{0}' Step '{1}'", tutorial.Type, tutorial.Step);
                break;
        }
    }

    //????????//MỖI LẦN ẤN THÌ MỖI LẦN CHẠY TUTORIAL TEXT SHOW Ở TRONG WELCOME
    protected override void OnScreenClickedEvent()
    {
        WelcomeTutorial.TutorialStep step = tutorial.Step;
        if (step == WelcomeTutorial.TutorialStep.TextWelcome || step == WelcomeTutorial.TutorialStep.TextIntro ||
            step == WelcomeTutorial.TutorialStep.TextArrival)
        {
            tutorial.TextShown();
        }
    }

    //NGƯỜI MAINCHARACTER SẼ NÓI WELCOME
    private void ShowWelcomeText()
    {
        _tutorialDirectorView.ScreenClickedEvent += OnScreenClickedEvent;
        _tutorialDirectorView.ShowCityAdvisor(TutorialDirectorView.TextPositionType.AdvisorDefault, "tutorial.welcome_to_island_intro");
    }
}