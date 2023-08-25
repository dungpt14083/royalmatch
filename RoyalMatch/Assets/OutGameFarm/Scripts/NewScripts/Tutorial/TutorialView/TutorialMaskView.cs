using UnityEngine;
using UnityEngine.UI;

public class TutorialMaskView : MonoBehaviour
{
    [SerializeField] protected RectTransform rectTransform;
    [SerializeField] protected Image top;
    [SerializeField] protected Image bottom;
    [SerializeField] protected Image left;
    [SerializeField] protected Image right;
    
    private void Start()
    {
        UpdateImageSizes();
    }
    
    public virtual void Show(Rect localRect, Vector2 anchorMin, Vector2 anchorMax, bool clickable)
    {
        base.gameObject.SetActive(true);
        rectTransform.anchorMin = anchorMin;
        rectTransform.anchorMax = anchorMax;
        rectTransform.anchoredPosition = localRect.position;
        rectTransform.sizeDelta = localRect.size;
        top.raycastTarget = !clickable;
        bottom.raycastTarget = !clickable;
        left.raycastTarget = !clickable;
        right.raycastTarget = !clickable;
    }
    
    public virtual void Hide()
    {
        base.gameObject.SetActive(false);
    }
    private void UpdateImageSizes()
    {
        Vector2 vector = new Vector2(Screen.width, Screen.height);
        float num = 1f / top.canvas.rootCanvas.scaleFactor;
        vector *= num;
        Vector2 sizeDelta = top.rectTransform.sizeDelta;
        sizeDelta.x = vector.x * 2f;
        sizeDelta.y = vector.y;
        top.rectTransform.sizeDelta = sizeDelta;
        bottom.rectTransform.sizeDelta = sizeDelta;
        sizeDelta = left.rectTransform.sizeDelta;
        sizeDelta.x = vector.x;
        left.rectTransform.sizeDelta = sizeDelta;
        right.rectTransform.sizeDelta = sizeDelta;
    }
}