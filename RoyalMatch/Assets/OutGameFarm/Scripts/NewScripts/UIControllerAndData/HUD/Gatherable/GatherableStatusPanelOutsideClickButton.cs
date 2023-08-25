using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GatherableStatusPanelOutsideClickButton : MonoBehaviour
{
    public float MaxPositionMove;
    public UnityEvent onClick;
    private Vector2? _mouseDownPosition;
    private bool _skipFrame;

    public void SkipFrame()
    {
        _skipFrame = true;
    }

    private void LateUpdate()
    {
        if (_skipFrame)
        {
            _skipFrame = false;
            return;
        }

        if (Input.GetMouseButton(0))
        {
            var currentEventSystem = UnityEngine.EventSystems.EventSystem.current;
            if (currentEventSystem != null && currentEventSystem.currentSelectedGameObject != null)
            {
                return;
            }

            Vector3 mousePosition = Input.mousePosition;
            Vector2 mouseDelta = Vector2.zero;

            if (_mouseDownPosition.HasValue)
            {
                mouseDelta = mousePosition - (Vector3)_mouseDownPosition.Value;
            }

            if (mouseDelta.magnitude > MaxPositionMove)
            {
                _mouseDownPosition = null;
                return;
            }

            _mouseDownPosition = mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (!_mouseDownPosition.HasValue)
            {
                return;
            }

            Vector3 mouseUpPosition = Input.mousePosition;
            Vector2 mouseDelta = mouseUpPosition - (Vector3)_mouseDownPosition.Value;

            if (mouseDelta.magnitude <= MaxPositionMove)
            {
                var currentEventSystem = UnityEngine.EventSystems.EventSystem.current;
                if (currentEventSystem != null && currentEventSystem.currentSelectedGameObject != null)
                {
                    return;
                }

                if (onClick != null)
                {
                    onClick.Invoke();
                }
            }

            _mouseDownPosition = null;
        }
    }
}