using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialoguePopup : Popup
{
    //Tốc độ hiển thị văn bản
    [SerializeField] private float TextRevealSpeed;

    //PHẦN TÊN NHÂN VẬT BÊN TRÁI BÊN PHẢI
    [SerializeField] private GameObject CharacterNameLeftGO;
    [SerializeField] private GameObject CharacterNameRightGO;
    [SerializeField] private Button SkipButton;
    [SerializeField] private Button NextButton;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private float RewindSpeed;

    private DialogueInfo _dialogueInfo;
    private SpeechInfo _speechInfo;
    private int _speechIndex;

    //private Tween _textRevealTween;
    //private bool _textAreaAppearAnimationPlaying;
    private int _lastRightCharacterId;
    private int _lastLeftCharacterId;


    public DialoguePopupData DialoguePopupData { get; private set; }


    public override void Open(PopupRequest request)
    {
        base.Open(request);
        DialoguePopupRequest request2 = GetRequest<DialoguePopupRequest>();
        DialoguePopupData = request2.DialoguePopupData;

        //...
        CharacterNameLeftGO.SetActive(false);
        CharacterNameRightGO.SetActive(false);
        //this._textAreaAppearAnimationPlaying = false;
        _speechIndex = 0;
        _dialogueInfo = DialogueManager.Instance.DialogueInfoCollection.Get(DialoguePopupData.DialogueId);
        var tmpSpeechInfo = _dialogueInfo.Speeches[_speechIndex];
        SetSpeech(tmpSpeechInfo);
        CutSceneSignals.DialogueStartSignal.Dispatch(_dialogueInfo);
    }


    //CLICK Ở BÊN NGOÀI HOẶC LÀ NÚT CHO VIỆC NEXT NEXT ĐẶT 1 IMAGE XONG ẤN THÌ INVOKE
    public void OnOutsideClick()
    {
        this.Next();
    }

    public void OnBackButtonPressed()
    {
        this.Next();
    }


    private void Next()
    {
        //NẾU ĐANG CHẠY ANIMATION XUẤT HIỆN TEXT THÌ K THỂ NEXT
        //if (this._textAreaAppearAnimationPlaying) return;

        //next thì lập tc chạy tween urrrent compltete 
        // if (_textRevealTween != null)
        // {
        //     if (_textRevealTween.IsActive())
        //     {
        //         _textRevealTween.Complete();
        //         return;
        //     }
        // }

        _speechIndex = this._speechIndex + 1;
        if (_speechIndex >= _dialogueInfo.Speeches.Count)
        {
            this.Close();
            return;
        }

        SpeechInfo speechInfo = _dialogueInfo.Speeches[_speechIndex];
        SetSpeech(speechInfo);
    }

    private void SetSpeech(SpeechInfo speech)
    {
        _speechInfo = speech;
        SpeechStartData speechStartData = new SpeechStartData(_dialogueInfo, _speechIndex);
        CutSceneSignals.SpeechStartSignal.Dispatch(speechStartData);
        this.Text.text =
            TranslationManager.Instance.GetTranslation(_dialogueInfo.id + "Speech" + _speechIndex.ToString());
        //StartCoroutine(CoroutineTest1s());
        //SAU ĐÓ THÌ CHẠY TWEEEN SHOW TEXT 
        //VÀ CÓ TWEEN...trongTWEEN NÀY SẼ CÓ CALLBACK SPEECHFINISHEVENT
        //_textRevealTween.onComplete += () => CutSceneSignals.SpeechFinishSignal.Dispatch(_speechInfo);
    }

    private IEnumerator CoroutineTest1s()
    {
        yield return new WaitForSeconds(4f);
        //CutSceneSignals.SpeechFinishSignal.Dispatch(_speechInfo);
    }
    
    public override void Close()
    {
        OnCloseClicked();
        base.Close();
        CutSceneSignals.DialogueFinishSignal.Dispatch(_dialogueInfo);
        DialoguePopupData.OnComplete?.Invoke();
    }
}