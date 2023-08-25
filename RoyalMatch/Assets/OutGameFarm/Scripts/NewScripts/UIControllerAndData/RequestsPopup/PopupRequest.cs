using System;


public abstract class PopupRequest
{
    public virtual bool IsValid
    {
        get { return true; }
    }

    public Type GetPopupType { get; private set; }

    //CHO VIỆC CHẠY NỀN POPUP CŨ HAY KHÔNG KIỂU KHÔNG TẮT POPUP CŨ::
    public bool UseModalBackground { get; private set; }

    public bool Enqueue { get; private set; }

    //KHÔNG CHO THAO TÁC VỚI GRIDOBJECT
    public bool DisableGridObjectInteractions { get; set; }

    //ẨN POPUP CON?
    public bool HideChildPopups { get; private set; }


    public PopupRequest(Type popup, bool enqueue, bool useModalBackground)
        : this(popup, enqueue, useModalBackground, false, false)
    {
    }

    public PopupRequest(Type popup, bool enqueue, bool useModalBackground, bool disableGridObjectInteractions,
        bool hideChildPopups)
    {
        GetPopupType = popup;
        UseModalBackground = useModalBackground;
        Enqueue = enqueue;
        DisableGridObjectInteractions = disableGridObjectInteractions;
        HideChildPopups = hideChildPopups;
    }
}