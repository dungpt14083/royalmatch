using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragProductItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private Image icon;
    [SerializeField] private ProductItem product;
    private Transform parentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!product.CheckDrag()) return;
        icon.sprite = product.GetSpriteIcon();
        icon.color = Color.white;
        icon.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        this.transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        icon.raycastTarget = true;
        icon.color = new Color32(255,255,255,1);
        this.transform.localPosition = Vector3.zero;
    }
    public ProductProperties GetProductProperties()
    {
        return product.GetProductProperties();
    }
}
