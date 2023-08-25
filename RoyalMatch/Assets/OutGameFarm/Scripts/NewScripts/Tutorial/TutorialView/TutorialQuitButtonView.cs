using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TutorialQuitButtonView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
    private TutorialDirector _tutorialDirector;
    private PopupManager _popupManager;

    public void Init(TutorialDirector tutorialDirector, PopupManager popupManager)
    {
        _tutorialDirector = tutorialDirector;
        _popupManager = popupManager;
    }

    public void Show()
    {
        if (!base.gameObject.activeSelf)
        {
            base.gameObject.SetActive(true);
        }
    }

    public void Hide()
    {
        if (base.gameObject.activeSelf)
        {
            base.gameObject.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //hiện lên popup hỏi xác nhận finish alltutorial hay k tạm thời cho là đóng chắc thì là finish alltutorial
        Hide();
        //GenericPopupRequest request = new GenericPopupRequest(FinishAllTutorials, Show, Show, Localization.Key("quit_tutorial"), Localization.Key("tutorial_quit_confirm"), null, Localization.Key("ALERT_GENERIC_OK"), Localization.Key("ALERT_GENERIC_CANCEL"), true, false);
        //_popupManager.RequestPopup(request);
        FinishTutorial();
    }

    private void FinishTutorial()
    {
        if (_tutorialDirector != null)
        {
            //CÁI NÀY K NÊN CHỈ NÊN ĐỐNG TUTORIAL HIỆN TẠI CMNR ĐÓNG ALL LÀM GÌ::
            _tutorialDirector.FinishCurrentTutorial();
        }
    }
}