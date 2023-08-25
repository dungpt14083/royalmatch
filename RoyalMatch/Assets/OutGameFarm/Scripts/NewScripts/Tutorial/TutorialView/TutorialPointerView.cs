using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPointerView : MonoBehaviour
{
    private static readonly Vector2 AnchorCenter = new Vector2(0.5f, 0.5f);

    [SerializeField] protected RectTransform _rectTransform;

    private Vector3? _worldPosition;
    private RectTransform _parentTransform;
    private float _rotation;
    private Camera _uiCamera;
    private Camera _worldCamera;

    public virtual void Show(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, float rotation)
    {
        base.gameObject.SetActive(true);
        Clear();
        UpdatePointerTransform(anchoredPosition, anchorMin, anchorMax, rotation);
    }

    public virtual void Show(Vector3 worldPosition, float rotation, RectTransform parentTransform, Camera uiCamera,
        Camera worldCamera)
    {
        base.gameObject.SetActive(true);
        Clear();
        _worldPosition = worldPosition;
        _rotation = rotation;
        _parentTransform = parentTransform;
        _uiCamera = uiCamera;
        _worldCamera = worldCamera;
        UpdatePointerTransform();
    }

    //2 trường hợp 1 là chỉ vào canvas 2 là chỉ vào toa độ the giới:::đây là chỉ vào tọa độ thế giới vị trí thế giới
    private void UpdatePointerTransform()
    {
        if (_worldPosition.HasValue)
        {
            //2 CUNG BẬC ĐƯA RA TỌA ĐỘ ÀN HÌNH
            Vector2 vector = _worldCamera.WorldToScreenPoint(_worldPosition.Value);
            Vector2 vector2 = _uiCamera.ScreenToViewportPoint(vector);
            float rotation;
            if (vector2.x < 0f || vector2.x > 1f || vector2.y < 0f || vector2.y > 1f)
            {
                Vector3 vector3 = vector;
                vector2.x = Mathf.Clamp01(vector2.x);
                vector2.y = Mathf.Clamp01(vector2.y);
                vector = _uiCamera.ViewportToScreenPoint(vector2);
                Vector2 from = (Vector2)vector3 - vector;
                rotation = Vector2.Angle(from, Vector2.up) * Mathf.Sign(vector.x - vector3.x);
            }
            else
            {
                rotation = _rotation;
            }

            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(_parentTransform, vector, _uiCamera,
                out localPoint);
            UpdatePointerTransform(localPoint, AnchorCenter, AnchorCenter, rotation);
        }
    }

    //ĐÂY LÀ CHỈ VÀO VỊ TRÍ TRANFORM:::
    private void UpdatePointerTransform(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, float rotation)
    {
        _rectTransform.anchorMin = anchorMin;
        _rectTransform.anchorMax = anchorMax;
        _rectTransform.anchoredPosition3D = anchoredPosition;
        _rectTransform.rotation = Quaternion.Euler(0f, 0f, rotation);
    }

    public virtual void Hide()
    {
        Clear();
        base.gameObject.SetActive(false);
    }

    private void Clear()
    {
        _worldPosition = null;
        _parentTransform = null;
        _uiCamera = null;
        _worldCamera = null;
    }
}