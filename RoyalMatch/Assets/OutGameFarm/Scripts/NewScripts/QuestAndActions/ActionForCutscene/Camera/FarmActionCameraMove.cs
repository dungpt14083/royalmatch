using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameCreator.Core;
using UnityEngine;

public class FarmActionCameraMove : IAction
{
    public Vector3 positionFocus;
    public float timeMove;

    private bool _cameraMoveDone = false;
    private DG.Tweening.Tween _moveTween;

    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        if (CameraControllerView.Instance == null) yield return 0;

        var distanceTargetPositionCamera =
            RayCastFromCameraExtensions.GetDistanceTargetCameraPositionFromWorldPosition(positionFocus);
        var targetPositionCamera = CameraControllerView.Instance.transform.position + distanceTargetPositionCamera;
        _moveTween = CameraControllerView.Instance.MoveToPosition(targetPositionCamera, timeMove);
        TweenCallback tweenCallback = new DG.Tweening.TweenCallback(EndMoveCamera);
        _moveTween.onComplete += tweenCallback;
        while (!_cameraMoveDone)
        {
            yield return null;
        }

        yield return 0;
    }

    private void EndMoveCamera()
    {
        _cameraMoveDone = true;
    }

    public override void Stop()
    {
        if (_moveTween == null) return;
        TweenExtensions.Kill(t: this._moveTween, complete: false);
    }

#if UNITY_EDITOR
    public static new string NAME = "FarmActionCamera/Farm Camera Move To";
    private const string NODE_TITLE = "Farm Camera Move To";
#endif
}