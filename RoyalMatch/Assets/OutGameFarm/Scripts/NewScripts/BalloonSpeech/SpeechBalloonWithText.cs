using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Sequence = DG.Tweening.Sequence;

//CÁI NÀY LÀ CẤN HỆN ĐỂ THẰNG CHARACTER NÓ GET VÀ TỪ ĐÓ SẼ SHOWW LÊN ĐẦU
public class SpeechBalloonWithText : MonoBehaviour
{
    [SerializeField] private TMP_Text speechBalloonText;
    [SerializeField] private RectTransform speechBalloonTextRectTransform;
    [SerializeField] private LayoutElement textLayoutElement;
    [SerializeField] public RectTransform rectTransform;

    //MANAGER VÀ THNG SỰ KIỆN HIDE
    //private SpeechBalloonWithTextService _speechBalloonWithTextService;
    //private SpeechBalloonWithTextHideEvent _speechBalloonWithTextHideEvent;

    [SerializeField] private float scaleUpDuration;

    [SerializeField] private float scaleDownDuration;

    //MIN WIDTH MAX WIDTH
    [SerializeField] private float minWidth;
    [SerializeField] private float maxWidth;

    private float _autoCloseDuration;
    private int _characterId;
    private bool _hiding;
    private bool _showing;
    private Vector3 _currentScale;
    private Vector3 _revertedScale;
    private Sequence _sequence;

    private void Start()
    {
        //DÙNG EVENT BÊN KIA CÓ THỂ SẼ INVOKE

        this.gameObject.SetActive(value: false);
    }

    //KHI CHARACTER NHẬN ĐƯỢC SPEEECHBALLONWITHTEXT TRUYỀN STRING VÀO ĐỂ NCH::::
    public void ShowSpeechBalloonWithText(UnityEngine.Vector3 position, bool isRight, string speech, int characterId)
    {
        if (_showing)
        {
            return;
        }

        //Để MIRROR SANG BÊN PHẢI BÊN TRÁI::::
        Vector3 flip = isRight ? Vector3.one : -Vector3.one;

        //NẾU MÌNH ĐANG SHOW MÀ LẠI SHOWW TIẾP THÌ PHẢI KILL Ể LÀM SENE MỚI
        if (this._characterId == characterId)
        {
            DOTween.Kill(_sequence);
            _sequence = DOTween.Sequence();
            Tween tmpTween = HideTween(CallBackHide);
            _sequence.Join(tmpTween);
            Sequence tmpSequence = ShowHideCycle();
            _sequence.Append(tmpSequence);
            return;
        }

        //NẾU KHONG THÌ HOÀN TOÀN MƯỚI THÌ PHẢI RESET VÀ XỬ LÍ 
        _sequence = DOTween.Sequence();
        this._characterId = characterId;

        RefreshVisuals(speech);
        SetSpeechText(speech);
        rectTransform.position = position;
        //rectTransform.pivot
        rectTransform.gameObject.SetActive(true);
        _showing = true;

        Sequence tmpSequenceShow = this.ShowHideCycle();
        _sequence.Join(tmpSequenceShow);
    }


    //RESET HIỂN THỊ TRƯỚC KHI MÀ SET SPEECH TEXT :::
    private void RefreshVisuals(string speech)
    {
        this.speechBalloonText.text = speech;

        if (speechBalloonText.text.Length <= 0)
        {
            if (textLayoutElement != null)
            {
                //textLayoutElement??
            }
        }

        this.rectTransform.gameObject.SetActive(true);

        //FORCE REBUILDLAYOUTELEMENT?? PHẢI GỌI THỦ CÔNG
        UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(speechBalloonText.rectTransform);
    }

    //SET TEXT VÀO VÀ DỰA VÀO THẰNG CHIỀU DÀI TEXT Ể TỪ ĐÓ TÍNH TOÁN TIME ĐÓNG
    private void SetSpeechText(string text)
    {
        this.speechBalloonText.text = text;
        float tmp = (float)text.Length;
        _autoCloseDuration = tmp * 0.75f;
    }

    //Show và ẩn cycle:::liên quan scale showw ẩn nch xong lại hiện lên hiện xuống
    public DG.Tweening.Sequence ShowHideCycle()
    {
        return null;
    }

    //KHI CHARACTER GỌI HOẶC LÀ HIDEIMMEDIATE:::
    public void HideImmediate()
    {
        if (_sequence != null)
        {
            DOTween.Kill(_sequence);
        }

        rectTransform.gameObject.SetActive(false);
        this._hiding = false;
        this._characterId = 0;
        SpeechBalloonWithTextManager.Instance.BackToPool(this);
    }

    //Character update goọi tới update
    public void UpdatePosition(UnityEngine.Vector3 position)
    {
        rectTransform.position = position;
    }


    //SHOW TWEEN VÀ INVOKE CALLBACK KHI HOÀN THÀNH CHO SHOWW HIDE CÁI KIA GỌI DOSCALE VÀ CÓ DÙNG TIME SCALE
    private DG.Tweening.Tween ShowTween(System.Action onComplete)
    {
        return null;
        //CALLBACK CHO VỆC SHOWWING
    }

    private void CallBackShowing()
    {
        this._showing = false;
    }


    private Tween HideTween(System.Action onComplete)
    {
        return null;
    }

    private void CallBackHide()
    {
        this.rectTransform.gameObject.SetActive(false);
        this._hiding = false;
        this._characterId = 0;
        SpeechBalloonWithTextManager.Instance.BackToPool(this);
    }
}