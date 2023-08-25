using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameCreator.Core;
using UnityEngine;

public class FarmActionZoomCamera : IAction
{
    public float sizeZoom = 10f;
    public float timeZoom = 2f;


    private Tween _sizeTween;
    private bool _zoomDone = false;

    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        _sizeTween = CameraControllerView.Instance.ZoomTo(sizeZoom, timeZoom);
        TweenCallback tweenCallback = new DG.Tweening.TweenCallback(CompleteZoom);
        _sizeTween.onComplete += tweenCallback;

        while (!_zoomDone)
        {
            yield return null;
        }

        yield return 0;
    }

    private void CompleteZoom()
    {
        _zoomDone = true;
    }
    
    public override void Stop()
    {
        if (_sizeTween == null) return;
        TweenExtensions.Kill(t: this._sizeTween, complete: false);
    }
    
#if UNITY_EDITOR
    public static new string NAME = "FarmActionCamera/Farm Camera Zoom";
    private const string NODE_TITLE = "Farm Camera Zoom";
#endif
    
}