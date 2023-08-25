using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using EasyButtons;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using Sequence = DG.Tweening.Sequence;

public class TweenItem : MonoBehaviour
{
    [SerializeField] public Image TweenIcon;
    [SerializeField] public RectTransform RectTransform;
    //[SerializeField] public PositionSyncer PositionSyncer;
    
    private AnimationCurve _XCurve;
    private AnimationCurve _YCurve;
    private AnimationClip _animationClip;
    private GameObject _linkedObject;
    private Sequence _sequence;
    private Action _onBegin;
    private Action _onComplete;
    
    private Vector2 _targetSize;
    private Vector3 _startingPosition;
    private Vector3 _targetPosition;
    
    private bool _useWorldPosition;
    private bool _trailActive;
    private bool _isGatherable;
    private float _moveDuration;
    
    public int ChildId;
    
    //CÁC CÁI SERVICE BAY LÊN:::
    //private TweenTrailService _tweenTrailService;
    //private GatherableTweenTrailService _gatherableTweenTrailService;
    //private TweenTrailService TweenTrailService => null;
    //private GatherableTweenTrailService GatherableTweenTrailService => null;
    
    private void Awake()
    {
        this.ChildId = this.transform.GetSiblingIndex();
    }
    
    public TweenItem SetSprite(UnityEngine.Sprite sprite)
    {
        this.TweenIcon.sprite = sprite;
        return this;
    }
    
    public TweenItem SetSize(UnityEngine.Vector2 size)
    {
        this.RectTransform.sizeDelta = size;
        return this;
    }
    
    
    public TweenItem SetScale(UnityEngine.Vector3 scale)
    {
        this.RectTransform.localScale = scale;
        return this;
    }
    
    
    public TweenItem SetScale(float scale)
    {
        RectTransform.localScale = new Vector3(scale, scale, scale);
        return this;
    }
    
    public TweenItem SetTrailActive(bool status)
    {
        _trailActive = status;
        return this;
    }

    public TweenItem SetActive(bool status)
    {
        gameObject.SetActive(status);
        return this;
    }
    
    public TweenItem SetWorldPositionBased()
    {
        _useWorldPosition = true;
        return this;
    }
    
    
    
    public TweenItem CreateSequence()
    {
        _sequence = DOTween.Sequence();
        return this;
    }
    
    //apnd 1 tween vào trong sequen hiện tại
    public TweenItem AppendToSequence(Tween tween)
    {
        TweenSettingsExtensions.Append(_sequence, tween);
        return this;
    }
    
    
    public TweenItem AppendIntervalToSequence(float intervalDuration)
    {
        TweenSettingsExtensions.AppendInterval(_sequence, intervalDuration);
        return this;
    }

    public TweenItem JoinToSequence(Tween tween)
    {
        TweenSettingsExtensions.Join(_sequence, tween);
        return this;
    }
    
    public TweenItem InsertToSequence(float time, Tween tween)
    {
        TweenSettingsExtensions.Insert(_sequence, time, tween);
        return this;
    }
    
    
    public TweenItem SetStartingPosition(Vector3 position)
    {
        _startingPosition = GetStartingPosition(position);
        transform.position = _startingPosition;
        return this;
    }

    //TỪ ĐIỂM NGOÀI MÀN HÌNH VÀO TRONG ĐIỂM TỌA ĐỘ MÀN HÌNH 
    private UnityEngine.Vector3 GetStartingPosition(UnityEngine.Vector3 position)
    {
        if (position!=null)
        {
            Vector3 screenPoint = Camera.main.WorldToScreenPoint(position);
            return new Vector3(screenPoint.x, screenPoint.y, screenPoint.z); 
        }
        return Vector3.zero;
    }

    public TweenItem SetTargetPosition(Vector3 position)
    {
        _targetPosition = position;
        return this;
    }

    public TweenItem SetOnBeginAction(System.Action onBegin)
    {
        _onBegin = onBegin;
        return this;
    }

    public TweenItem SetLink(GameObject gameObject)
    {
        _linkedObject = gameObject;
        return this;
    }
    
    public TweenItem SetOnCompleteAction(System.Action onComplete)
    {
        _onComplete = onComplete;
        return this;
    }
    
    public TweenItem SetMoveDuration(float duration)
    {
        _moveDuration = duration;
        return this;
    }
    
    public TweenItem SetXCurve(AnimationCurve animationCurve)
    {
        _XCurve = animationCurve;
        return this;
    }

    public TweenItem SetYCurve(AnimationCurve animationCurve)
    {
        _YCurve = animationCurve;
        return this;
    }
    
    public TweenItem SetGatherableMode(bool status)
    {
        _isGatherable = status;
        return this;
    }
    
    
    public TweenItem SetAnimationClip(AnimationClip animationClip)
    {
        _animationClip = animationClip;
        return this;
    }

    private AnimationCurve GetXCurve()
    {
        if (_XCurve != null)
        {
            return _XCurve;
        }
        return AnimationCurve.Linear(0f, 0f, 1f, 1f);
    }


    private AnimationCurve GetYCurve()
    {
        if (_YCurve != null)
        {
            return _YCurve;
        }
        return AnimationCurve.Linear(0f, 0f, 1f, 1f);
    }


    public void KillAll()
    {
        if(this._sequence == null)
        {
            return;
        }
        DOTween.Kill(targetOrId:  this._sequence, complete:  false);
    }
    
    public TweenItem SetDefault()
    {
        //Color color = TweenIcon.color;
        //Color newColor = ColorExtensions.WithSetAlpha(new Color(-1.101638E+33f, -1.101638E+33f, -1.101638E+33f), color.r);
        //TweenIcon.color = newColor;

        _YCurve = null;
        _XCurve = null;
        _sequence = null;
        _onBegin = null;
        _onComplete = null;
        _targetSize = Vector2.zero;
        transform.localScale = Vector3.one;
        _animationClip = null;
        _linkedObject = null;

        return this;
    }

    
    #region RUN TWEEEN::::

    //liên quan tới linkobject tạm bỏ qua::::
    public void ApplySequence()
    {
        if (_onBegin != null)
        {
            _onBegin.Invoke();
        }
        
        _sequence.OnComplete(() =>
        {
            if (_onComplete != null)
            {
                _onComplete.Invoke();
            }
        });
        
       GameObject linkedObj = _linkedObject ?? gameObject;
       _sequence.SetLink(linkedObj, LinkBehaviour.CompleteAndKillOnDisable);
        _sequence.Play();
    }
    
    
    public void Tween()
    {
        if(this._onBegin != null)
        {
            this._onBegin.Invoke();
        }

        if (_sequence==null)
        {
            //bảo log....:::
            return;
        }
        
        this.gameObject.SetActive(true);
        
        
        //TẠO TWEEN VÀ GÁN VO SEQUENCE:::
        Transform transform = this.transform;
        TweenerCore<Vector3, Vector3,  DG.Tweening.Plugins.Options.VectorOptions> xTween = ShortcutExtensions.DOMoveX(
            target: transform,
            endValue: _targetPosition.x,
            duration: _moveDuration,
            snapping: false
        );
        AnimationCurve xCurve = _XCurve ?? TweenCurveService.Instance.Linear;
        xTween.SetEase(xCurve);
        Sequence sequence = TweenSettingsExtensions.Join(_sequence, xTween);
        TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions> yTween = ShortcutExtensions.DOMoveY(
            target: transform,
            endValue: _targetPosition.y,
            duration: _moveDuration,
            snapping: false
        );
        AnimationCurve yCurve = _YCurve ??  TweenCurveService.Instance.Linear;
        yTween.SetEase(yCurve);
        sequence.Join(yTween);

        sequence.OnComplete(() =>
        {
            if (_onComplete != null)
            {
                _onComplete.Invoke();
            }
        });
        
        GameObject linkedObj = _linkedObject ?? gameObject;
        sequence.SetLink(linkedObj, LinkBehaviour.CompleteAndKillOnDisable);
        sequence.Play();
    }

    #endregion
}
