using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialMainCharacterView : TutorialTextBalloonBaseView
{
    //Tí lật hướng nch thì lật nhưng phải lật text và bóng lại hướng ngược lại kẻo ngược hình
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private RectTransform balloonRectTransform;
    [SerializeField] private RectTransform balloonTextRectTransform;
    [SerializeField] private TMP_Text textView;

    private string _textTalk;
    private Vector3 _anchoredPosition;
    private Vector2 _anchorMin;
    private Vector2 _anchorMax;
    private bool _isShowing;

    public void SetFlipped(bool flipped)
    {
        if (flipped)
        {
            rectTransform.FlipScaleX();
            balloonTextRectTransform.FlipScaleX();
        }
        else
        {
            rectTransform.AbsScaleX();
            balloonTextRectTransform.AbsScaleX();
        }
    }

    public override void Show(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, string text)
    {
        base.gameObject.SetActive(true);
        _isShowing = true;
        _anchorMin = anchorMin;
        _anchorMax = anchorMax;
        _anchoredPosition = anchoredPosition;
        textView.text = text;
    }

    public override void Hide()
    {
        if (base.gameObject.activeSelf && _isShowing)
        {
            base.gameObject.SetActive(false);
            _isShowing = false;
            _textTalk = null;
        }
    }
}