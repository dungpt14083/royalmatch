using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using Sequence = DG.Tweening.Sequence;

public class SpeechBalloonManager : MonoSingleton<SpeechBalloonManager>
{
    [SerializeField] private RectTransform speechBalloon;
    [SerializeField] private float yOffSet;
    [SerializeField] private float scaleUpDuration;
    [SerializeField] private float scaleDownDuration;

    private Vector3 _revertedScale;
    private Sequence _sequence;
    private SpeechBalloonSpeakerChangedData _speechBalloonSpeakerChangedData;

    public void Init()
    {
        speechBalloon.gameObject.SetActive(false);
    }

    public void ShowSpeechBalloon(Vector3 position, bool isRight, int characterId)
    {
        //TẠM COMMAND TRÁNH VIỆC PHẢI SHOW 2 VẾ NCH 1 VỀ CŨNG ĐC
        // NẾU MÀ NGƯỜI NÓI CUỐI LÀ THẰNG NÀY THÌ RETURNK CHO NÓI MỘT MÌNH À
        //  if (_lastSpeakingCharacter == characterId)
        //  {
        //      return;
        //  }
        this.speechBalloon.position = position;
        if (_sequence != null)
        {
            DOTween.Kill(_sequence);
        }

        _sequence = null;
        this.speechBalloon.gameObject.SetActive(true);
        CutSceneSignals.SpeechBalloonSpeakerChanged.Dispatch(new SpeechBalloonSpeakerChangedData(characterId));
    }

    public void UpdatePosition(Vector3 position)
    {
        //Vector3 tmpPosition = Vector3Extensions.WithSetY(position, 0.5f);
        this.speechBalloon.position = position;
    }

    public void HideSpeechBalloon()
    {
        //this._lastSpeakingCharacter=
        if (_sequence != null)
        {
            DOTween.Kill(_sequence);
        }
        _sequence = null;
        this.speechBalloon.gameObject.SetActive(value: false);
        CutSceneSignals.SpeechBalloonSpeakerChanged.Dispatch(new SpeechBalloonSpeakerChangedData(0));
    }
}