using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameCreator.Core;
using UnityEngine;

public class FarmActionShakeCamera : IAction
{
    public float shakeDuration = 1f;
    public float shakeStrength = 0.5f;

    private DG.Tweening.Tween _shakeTween;
    private bool _shakeDone = false;


    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        _shakeTween = CameraControllerView.Instance.Shake(shakeDuration, shakeStrength);
        TweenCallback tweenCallback = new DG.Tweening.TweenCallback(CompleteShake);
        _shakeTween.onComplete += tweenCallback;
        while (!_shakeDone)
        {
            yield return null;
        }

        yield return 0;
    }

    private void CompleteShake()
    {
        _shakeDone = true;
    }


    public override void Stop()
    {
        if (_shakeTween == null) return;
        TweenExtensions.Kill(t: this._shakeTween, complete: false);
    }

#if UNITY_EDITOR
    public static new string NAME = "FarmActionCamera/Farm Camera Shake";
    private const string NODE_TITLE = "Farm Camera Shake";
#endif
}