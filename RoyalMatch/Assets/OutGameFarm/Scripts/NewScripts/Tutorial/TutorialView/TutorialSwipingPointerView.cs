using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSwipingPointerView : MonoBehaviour
{
    private static readonly Vector2 AnchorCenter = new Vector2(0.5f, 0.5f);

    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private RectTransform handRectTransform;

    //triueefm vokf tro xpau và chiều dài kéo
    public virtual void Show(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, float rotation,
        float swipeLength)
    {
        base.gameObject.SetActive(true);
        Clear();
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
        rectTransform.anchoredPosition3D = anchoredPosition;
        rectTransform.rotation = Quaternion.Euler(0f, 0f, rotation);
        handRectTransform.SetAnchoredPositionY(0f - swipeLength);
    }

    public virtual void Show(Vector3 worldPosition, float rotation, float swipeLength)
    {
        base.gameObject.SetActive(true);
        Clear();
        rectTransform.anchorMin = AnchorCenter;
        rectTransform.anchorMax = AnchorCenter;
        rectTransform.position = worldPosition;
        rectTransform.rotation = Quaternion.Euler(0f, 0f, rotation);
        handRectTransform.SetAnchoredPositionY(0f - swipeLength);
        //ở đây sẽ chạy animation vuốt vuốt mà tạm quên đi
    }


    public virtual void Hide()
    {
        Clear();
        base.gameObject.SetActive(false);
    }

    private void Clear()
    {
    }
}