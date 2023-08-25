using System;
using UnityEngine;

public class TutorialView<T> : MonoBehaviour where T : TutorialFarm
{
    //KIỂU OFFSET 1 KHOẢNG ĐIỂM BAO NHIU
    protected static readonly GridPoint CityAdvisorBuildingScrollToOffset = new GridPoint(2f, 3f);
    protected static readonly GridPoint BuildingPointerOffsetPercentage = new GridPoint(0.7f, 0.1f);

    protected TutorialDirectorView _tutorialDirectorView;
    private PopupManagerView _popupManagerView;
    protected T tutorial;
    protected Type currentStepPopup;


    //TRUYỀN TUTORIAL VIEW VÀO GỌI SHOW CÁC TH?>>
    //khi được BẮT ĐU TUTORIAL THÌ MỚI ĐƯỢC INIT KHI ĐÓ TRUYỀN CÁC THÔNG SỐ VÀO NGHE CALLBACK ĐỂ XỬ LÍ
    //CÁI NÀY CNG ĐI KÈM VỚI DEINIT ĐỂ DEINIT BỎ CÁC SỰ KIỆN RA NGOÀI KHI XONG TUTORIAL
    public virtual void Init(TutorialDirectorView tutorialDirectorView, T tutorialX)
    {
        _tutorialDirectorView = tutorialDirectorView;
        tutorial = tutorialX;
        _popupManagerView = _tutorialDirectorView.PopupManagerView;
        currentStepPopup = null;

        //NGHE SỰ KIỆN KHI MÀ POPUP SHOW HIDE BÊN POPUPMANAGER:VÀ SỰ KIỆN STEPCHANGE:
        _popupManagerView.PopupShownEvent += OnPopupShown;
        _popupManagerView.PopupHiddenEvent += OnPopupHidden;
        tutorial.StepChangedEvent += OnTutorialStepChanged;


        if (!tutorial.PopupManager.IsShowingPopup)
        {
            OnTutorialStepChanged();
        }

        if (tutorial.AllowedToSkip)
        {
            //_tutorialDirectorView.ShowQuitTutorialButton();
        }
    }

    protected virtual void OnDestroy()
    {
        Deinit();
    }

    public virtual void Deinit()
    {
        if (tutorial != null)
        {
            tutorial.StepChangedEvent -= OnTutorialStepChanged;
            tutorial = (T)null;
        }

        if (_popupManagerView != null)
        {
            _popupManagerView.PopupShownEvent -= OnPopupShown;
            _popupManagerView.PopupHiddenEvent -= OnPopupHidden;
            _popupManagerView = null;
        }

        if (_tutorialDirectorView != null)
        {
            //_tutorialDirectorView.HideQuitTutorialButton();
            _tutorialDirectorView.ScreenClickedEvent -= OnScreenClickedEvent;
            _tutorialDirectorView = null;
        }

        currentStepPopup = null;
    }


    protected virtual void OnTutorialStepChanged()
    {
        currentStepPopup = null;
        _tutorialDirectorView.ScreenClickedEvent -= OnScreenClickedEvent;
        Clear();
    }

    protected virtual void OnScreenClickedEvent()
    {
    }

    protected virtual void OnPopupShown(Popup popup)
    {
        _tutorialDirectorView.ScreenClickedEvent -= OnScreenClickedEvent;
        Clear();
    }

    protected virtual void Clear()
    {
        _tutorialDirectorView.Clear();
    }

    protected virtual void OnPopupHidden(Popup popup)
    {
        if (!tutorial.PopupManager.IsShowingPopup || tutorial.PopupManager.IsCurrentPopup(currentStepPopup))
        {
            OnTutorialStepChanged();
        }
    }
}