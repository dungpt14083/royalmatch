using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialTextBallonView : TutorialTextBalloonBaseView
{
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private TMP_Text textShow;

    public override void Show(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, string text)
    {
        base.gameObject.SetActive(true);
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
        rectTransform.anchoredPosition3D = anchoredPosition;
        textShow.text = text;
    }

    public override void Hide()
    {
        base.gameObject.SetActive(false);
    }
}