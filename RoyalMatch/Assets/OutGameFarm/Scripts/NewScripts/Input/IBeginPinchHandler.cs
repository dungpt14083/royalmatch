using UnityEngine.EventSystems;

public interface IBeginPinchHandler : IEventSystemHandler
{
    void OnBeginPinch(PinchEventData pinchEvent);
}
