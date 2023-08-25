using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.EventSystems;


//GENERIC CHO TÂT CẢ UI IMAGE ĐỂ NÓ SẼ....invoke THẰNG T LÀ BE CURRENT 
public abstract class InteractiveCurrencyView<T> : MonoBehaviour, IBeginDragHandler, IDragHandler, IPinchHandler,
    IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler where T : EntityCurrencyProperties
{
    public delegate void BeginDragEventHandler(PointerEventData pointerData, InteractiveCurrencyView<T> view);

    public delegate void DragEventHandler(PointerEventData pointerData, InteractiveCurrencyView<T> view);

    public delegate void EndDragEventHandler(PointerEventData pointerData, InteractiveCurrencyView<T> view);

    public delegate void PointerDownEventHandler(PointerEventData pointerData, InteractiveCurrencyView<T> view);

    public delegate void PointerUpEventHandler(PointerEventData pointerData, InteractiveCurrencyView<T> view);

    [SerializeField] protected Image _icon;
    [SerializeField] private CanvasGroup _group;
    public T Props { get; private set; }


    public virtual int DragThresholdInPixels
    {
        get { return 30; }
    }

    public virtual bool Unlocked
    {
        get { return true; }
    }

    public bool Draggable { get; private set; }

    public event BeginDragEventHandler BeginDragEvent;
    public event DragEventHandler DragEvent;
    public event EndDragEventHandler EndDragEvent;
    public event PointerDownEventHandler PointerDownEvent;
    public event PointerUpEventHandler PointerUpEvent;

    private void FireBeginDragEvent(PointerEventData eventData)
    {
        if (this.BeginDragEvent != null)
        {
            this.BeginDragEvent(eventData, this);
        }
    }

    private void FireDragEvent(PointerEventData eventData)
    {
        if (this.DragEvent != null)
        {
            this.DragEvent(eventData, this);
        }
    }

    private void FireEndDragEvent(PointerEventData eventData)
    {
        if (this.EndDragEvent != null)
        {
            this.EndDragEvent(eventData, this);
        }
    }

    private void FirePointerDownEvent(PointerEventData eventData)
    {
        if (this.PointerDownEvent != null)
        {
            this.PointerDownEvent(eventData, this);
        }
    }

    private void FirePointerUpEvent(PointerEventData eventData)
    {
        if (this.PointerUpEvent != null)
        {
            this.PointerUpEvent(eventData, this);
        }
    }

    private void OnDestroy()
    {
        Deinit();
    }

    public virtual void Deinit()
    {
        Props = (T)null;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (Draggable)
        {
            FireBeginDragEvent(eventData);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Draggable)
        {
            FireDragEvent(eventData);
        }
    }

    public void OnPinch(PinchEventData pinchEvent)
    {
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Draggable)
        {
            FireEndDragEvent(eventData);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (!Draggable)
        {
            return;
        }

        FirePointerDownEvent(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (!Draggable)
        {
            return;
        }

        FirePointerUpEvent(eventData);
    }

    public void EndDrag()
    {
        Deinit();
        base.gameObject.SetActive(false);
    }

    public void ToggleProduct(bool active)
    {
        Draggable = active;
    }

    protected void InitInternal(T properties, bool dragging = false)
    {
        Props = properties;
        Draggable = true;
        //nếu mà không tể drag thì blockraybase sẽ false nếu thật thự khóa
        _group.blocksRaycasts = !dragging;
        //hình ảnh lấy từ currentcyassetcollection với tên....
        _icon.sprite =
            SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(
                Currency.GetCurrencyTypeByName(properties.CurrencyName));
    }
    protected void InitInternalCollec(T properties, bool dragging = false)
    {
        Props = properties;
        Draggable = true;
        //nếu mà không tể drag thì blockraybase sẽ false nếu thật thự khóa
        _group.blocksRaycasts = !dragging;
    }
}