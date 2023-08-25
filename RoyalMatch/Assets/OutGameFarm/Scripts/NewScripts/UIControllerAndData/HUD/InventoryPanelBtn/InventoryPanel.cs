using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    [SerializeField] private GameObject InventoryTargetGO;
    [SerializeField] private RectTransform InvetoryTargetRectTransform;

    
    public UnityEngine.Transform GetTargetTransform()
    {
        return InvetoryTargetRectTransform.transform;
    }
}