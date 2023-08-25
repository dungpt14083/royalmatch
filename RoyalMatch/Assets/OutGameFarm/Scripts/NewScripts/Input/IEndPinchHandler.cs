using UnityEngine.EventSystems;

public interface IEndPinchHandler : IEventSystemHandler
{
    void OnEndPinch(PinchEventData pinchEvent);
}