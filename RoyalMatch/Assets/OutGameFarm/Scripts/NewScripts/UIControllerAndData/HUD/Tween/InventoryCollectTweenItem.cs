using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class InventoryCollectTweenItem : MonoBehaviour
{
    public Image ItemIcon;

    public RectTransform RectTransform;

    public RectTransform ImageRectTransform;

    public GameObject TrailGameObject;

    public void SetTrailActive(bool status)
    {
        this.TrailGameObject.SetActive(value:  status);

    }

}
