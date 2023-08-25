using UnityEngine.EventSystems;


public interface IPinchHandler : IEventSystemHandler
{
    void OnPinch(PinchEventData pinchEvent);
}