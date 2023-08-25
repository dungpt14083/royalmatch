using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TutorialTextBalloonBaseView : MonoBehaviour
{
    public abstract void Show(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, string text);

    public abstract void Hide();
}