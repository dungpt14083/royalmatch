using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class IsLandInput : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler,
    IBeginPinchHandler, IPinchHandler, IEndPinchHandler, IDragHandler, IEndDragHandler, IEventSystemHandler
{
    public delegate void PointerClickEventHandler(PointerEventData eventData);

    public delegate void PointerDownEventHandler(PointerEventData eventData);

    public delegate void PointerUpEventHandler(PointerEventData eventData);

    public delegate void BeginPinchEventHandler(PinchEventData pinchEvent);

    public delegate void PinchEventHandler(PinchEventData pinchEvent);

    public delegate void EndPinchEventHandler(PinchEventData pinchEvent);

    public delegate void OnDragEventHandler(PointerEventData eventData);

    public delegate void OnEndDragEventHandler(PointerEventData eventData);


    private const string GridObjectsLayerName = "GridObjects";

    public event PointerClickEventHandler OnPointerClick;
    public event PointerDownEventHandler OnPointerDown;

    public event PointerUpEventHandler OnPointerUp;
    public event BeginPinchEventHandler OnBeginPinch;


    public event OnDragEventHandler OnDragEvent;
    public event OnEndDragEventHandler OnEndDragEvent;


    public event PinchEventHandler OnPinch;
    public event EndPinchEventHandler OnEndPinch;


    //THWAFNG PHYSIC2DRAYCAST Ở CAMERA:::DÙNG TẮT BẬT CÁI NÀY ĐỂ ĐIỀU KHIỂN CAMERA
    [SerializeField] private PhysicsRaycaster _islandRaycaster;
    private int _gridObjectsLayerID;
    private readonly List<object> _requesters = new List<object>();

    private void Awake()
    {
        _gridObjectsLayerID = LayerMask.NameToLayer("GridObjects");
    }

    //BẬT THAO TÁC VỚI CÁC GAMEOBJECT ISLAND TRÊN MAP::VA CHẠM VS TẤT CẢ MỌI THỨ TRONG GAME
    public void EnableIslandInteraction(object requester)
    {
        _requesters.Remove(requester);
        if (_requesters.Count == 0)
        {
            _islandRaycaster.eventMask = -1;
        }
    }

    //CHỈ THAO TÁC ĐƯỢC VỚI THẰNG BỎ QUA GRIDOBJECT???:::CÀI NÀY CHỈ CHO THẰNG LÀ CHẰM VÀO THẰNG NÀY CÒN BỎ QUA TẤT CẢ?KHI MỞ POPUP THÌ CHỈ QUAN TÂM POPUP
    public void DisableIslandInteraction(object requester)
    {
        _requesters.Add(requester);
        _islandRaycaster.eventMask = ~(1 << _gridObjectsLayerID);
    }


    #region CÁC INPUT VÀO TỪ THAO TÁC CHUỘT::::

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (this.OnPointerClick != null)
        {
            this.OnPointerClick(eventData);
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        if (this.OnPointerDown != null)
        {
            this.OnPointerDown(eventData);
        }
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        if (this.OnPointerUp != null)
        {
            this.OnPointerUp(eventData);
        }
    }

    void IBeginPinchHandler.OnBeginPinch(PinchEventData pinchEvent)
    {
        if (this.OnBeginPinch != null)
        {
            this.OnBeginPinch(pinchEvent);
        }
    }

    void IPinchHandler.OnPinch(PinchEventData pinchEvent)
    {
        if (this.OnPinch != null)
        {
            this.OnPinch(pinchEvent);
        }
    }

    void IEndPinchHandler.OnEndPinch(PinchEventData pinchEvent)
    {
        if (this.OnEndPinch != null)
        {
            this.OnEndPinch(pinchEvent);
        }
    }


    #region TODO CAMERA FOR CHUỘT::::CÁI KIA CHỈ HỖ TRỢ CHO THĂNG KIA

    public void OnDrag(PointerEventData eventData)
    {
        if (this.OnDragEvent != null)
        {
            this.OnDragEvent(eventData);
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (this.OnEndDragEvent != null)
        {
            this.OnEndDragEvent(eventData);
        }
    }

    #endregion

    #endregion
}