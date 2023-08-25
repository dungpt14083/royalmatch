using DG.Tweening;
using UnityEngine;

public class KeyColor : MonoBehaviour
{
    public int color;
    public int target;
    public int countColor;
    public GameObject key;
    public Vector3 posOpenKey;
    public bool isOpened;

    public void AddColor()
    {
        if (isOpened) return;
        countColor += 1;
        Debug.Log($"KeyColor AddColor countColor {countColor}");
        if (countColor == target)
        {
            isOpened = true;
            key.transform.DOLocalMove(posOpenKey, 1f);

        }
    }
}
