using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using EasyButtons;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraControllerT : MonoBehaviour
{
    [SerializeField] internal Camera Camera;
    [SerializeField] internal BoxCollider BoxCollider;
    [SerializeField] internal Rigidbody Rigidbody;

    [SerializeField] private float PositionTweenSpeed;
    [SerializeField] private Ease PositionTweenEase;
    [SerializeField] private float PositionTweenConstantSpeedDistance;

    private Ease _shakeEase;

    private DOGetter<float> _getWidthValue;
    private DOSetter<float> _setWidthValue;
    private Tween _moveTween;
    private static float a;


    //DÙNG CHO THẰNG SETMOVE VÀ SETZOOM GIÁ TRỊ::::
    public void SetMove(bool value)
    {
        //Move.enabled = value;
    }

    public void SetZoom(bool value)
    {
        //Zoom.enabled = value;
    }

    public Tween GetMoveTween()
    {
        return this._moveTween;
    }


    public static Vector3 WorldToIsometricPoint(Vector3 worldPoint)
    {
        float heightRatio = 1; //Camera..MoveToPosition.a;
        float isometricX = worldPoint.x;
        float isometricY = worldPoint.y - (heightRatio * worldPoint.z);
        float isometricZ = worldPoint.z;
        Vector3 isometricPoint = new Vector3(isometricX, isometricY, isometricZ);
        return isometricPoint;
    }


    #region NEW FUTURE DONE::::

    [Button]
    public void Test(float value)
    {
        Width = value;
    }

    public float Width
    {
        get { return this.Height * this.Camera.aspect; }
        set
        {
            //CÁI NÀY ĐỂ Ý VÀ SỬA LẠI CHUAARN NHẤT:::
            this.Height = value / this.Camera.aspect;
            //Debug.LogError("Aspect" + Camera.aspect.ToString());
            //Debug.LogError(Height.ToString());
            //SIZE CHỈ ĐỂ CHO VA CHẠM:::::::
            Vector3 size = this.BoxCollider.size;
            this.BoxCollider.size = new Vector3(value, value, size.z);
        }
    }

    //HEIGHT SẼ CÀI ĐẶT ĐỘ ZOOM CỦA CAMERA:::
    public float Height
    {
        get { return this.Camera.orthographicSize * 2; }
        set { this.Camera.orthographicSize = value / 2; }
    }

    private void Start()
    {
        this._getWidthValue = () => this.Width;
        this._setWidthValue = (v) => this.Width = v;
        Vector3 size = this.BoxCollider.size;
        this.BoxCollider.size = new Vector3(size.x, size.y, this.Width);
    }


    [Button]
    public Tween Shake(float shakeDuration = 1, float shakeStrength = 0.1f)
    {
        Tweener shakeTween =
            ShortcutExtensions.DOShakePosition(target: transform, duration: shakeDuration, strength: shakeStrength);
        return TweenSettingsExtensions.SetEase(shakeTween, this._shakeEase);
    }


    //CHỈNH WIDTH RỒI NƠI NÀO DÙNG WIDTH
    [Button]
    public Tween ToWidth(float width, float duration)
    {
        TweenerCore<float, float, DG.Tweening.Plugins.Options.FloatOptions> widthTween =
            DOTween.To(getter: this._getWidthValue, setter: this._setWidthValue, endValue: width, duration: duration);
        return widthTween;
    }

    //DI CHUYỂN TỚI VỊ TRÍ...VÀ SET WIDTH CHO BOX COLLIDER À??


    [Button]
    public Tween MoveToPosition(Vector3 position, float duration, bool autoSpeedOnLongDurations = true,
        float? width = 0)
    {
        float posY = position.y;
        TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions> moveTween;

        if (width.HasValue && width.Value > 0)
        {
            moveTween = ShortcutExtensions.DOMove(target: transform,
                endValue: new Vector3(position.x, posY, position.z), duration: this.PositionTweenSpeed);
            moveTween.SetEase(this.PositionTweenEase);
            moveTween.SetSpeedBased();
            this._moveTween = moveTween;

            if (width.Value != 0)
            {
                this.ToWidth(width.Value, duration);
            }

            return TweenSettingsExtensions.SetEase(this._moveTween, this.PositionTweenEase);
        }
        else
        {
            moveTween = ShortcutExtensions.DOMove(target: transform,
                endValue: new Vector3(position.x, posY, position.z),
                duration: Vector3.Distance(new Vector3(position.x, posY, position.z), transform.position),
                snapping: autoSpeedOnLongDurations);
            moveTween.SetEase(Ease.Linear);
            this._moveTween = moveTween;

            if (width.Value != 0)
            {
                this.ToWidth(width.Value, duration);
            }

            return TweenSettingsExtensions.SetEase(this._moveTween, Ease.Linear);
        }
    }

    #endregion

    
    

    #region GENENRAL FIELD AND FUCN

    [SerializeField] private IsLandInput islandInput;
    [SerializeField] private Camera cameraToOperate;

    private bool _pinching;
    private AnimationMode _animationMode;
    private float _cameraY;
    private float _pinchingOrthoSize;


    private enum AnimationMode
    {
        None = 0,
        Velocity = 1,
        Destination = 2
    }


    //DỰA VÀO ANIMATIONMODE
    private void Awake()
    {
        islandInput.OnPointerDown += OnPointerDown;
        islandInput.OnPointerUp += OnPointerUp;
        islandInput.OnBeginPinch += OnBeginPinch;
        islandInput.OnPinch += OnPinch;
        //islandInput.OnEndPinch += OnEndPinch;
        _pinching = false;
        _animationMode = AnimationMode.None;
        _cameraY = cameraToOperate.transform.position.z;


#if UNITY_EDITOR

        #region FORDRAGGGG

        islandInput.OnDragEvent += OnDragEvent;
        islandInput.OnEndDragEvent += OnEndDragEvent;

        #endregion

#endif
    }


    private void OnDestroy()
    {
        if (islandInput != null)
        {
            islandInput.OnPointerDown -= OnPointerDown;
            islandInput.OnPointerUp -= OnPointerUp;
            islandInput.OnBeginPinch -= OnBeginPinch;
            islandInput.OnPinch -= OnPinch;
            //islandInput.OnEndPinch -= OnEndPinch;

#if UNITY_EDITOR

            #region FORDRAGGGG

            islandInput.OnDragEvent -= OnDragEvent;
            islandInput.OnEndDragEvent -= OnEndDragEvent;

            #endregion

#endif
        }
    }

#if UNITY_EDITOR
    private Vector2 previousMousePosition;
    public float dragSpeed = 0.5f;

    private void OnDragEvent(PointerEventData eventData)
    {
        if (_animationMode != 0)
        {
            _animationMode = AnimationMode.None;
        }

        Vector2 delta = eventData.position - previousMousePosition;
        float movementX = -delta.x;
        float movementY = -delta.y;
        var tmpY = transform.position.y;
        transform.Translate(new Vector3(movementX, 0, movementY).normalized * dragSpeed, Space.Self);
        var tmp = transform.position;
        tmp.y = tmpY;
        transform.position = tmp;
        previousMousePosition = eventData.position;
    }

    private void OnEndDragEvent(PointerEventData eventData)
    {
        previousMousePosition = Vector2.zero;
    }


#endif


    private void OnPointerDown(PointerEventData eventData)
    {
        if (_animationMode != 0)
        {
            _animationMode = AnimationMode.None;
        }
    }

    private void OnPointerUp(PointerEventData eventData)
    {
        if (_animationMode == AnimationMode.None)
        {
            //_fpsLimiter.PopUnlimitedFPSRequest(this);
            FireCameraStoppedMovingEvent();
        }
    }


    //ĐỂ FOCUS VÀO CÁI GÌ ĐÓ:::CITYBUILDER
    private void FireCameraStoppedMovingEvent()
    {
        // if (this.CameraStoppedMovingEvent != null)
        // {
        //     this.CameraStoppedMovingEvent();
        // }
    }


    //BẮT ĐẦU CHẠY PICH:::
    private void OnBeginPinch(PinchEventData pinchEvent)
    {
        _pinching = true;
        PushStartTime = Time.timeSinceLevelLoad;

        //_pinchingOrthoSize = cameraToOperate.orthographicSize;
        if (_animationMode != 0)
        {
            _animationMode = AnimationMode.None;
        }
    }


    //cái này vừa xử lí cả zoom vừa xử lí...cả MOVE DO GAME CỦA MÌNH ĐỂ CHUNG DATA THAO TÁC TRONG NÀY
    private void OnPinch(PinchEventData pinchEvent)
    {
        _force = Vector3.zero;
        //CalculateZoomOffsetAndZoom(pinchEvent);

        //_pinchingOrthoSize /= pinchEvent.ScaleDelta;
        //float num = CalculateZoomOffset(_pinchingOrthoSize);
        // float zoomRange = ((!(num < 0f)) ? _minZoomRange : _maxZoomRange);
        // _cameraToOperate.orthographicSize = orthographicSize;


        //TRÁNH ADD LỰC VÔ TẬN THÌ KIỂM SOÁT TIME ADD LỰC 
        float pushDuration = Time.timeSinceLevelLoad - PushStartTime;
        if (pushDuration < MinForceApplyDuration || pushDuration > MaxForceApplyDuration)
        {
            return;
        }
        float pushForce = Mathf.Lerp(MinPushForce, MaxPushForce,
            (pushDuration - MinForceApplyDuration) / (MaxForceApplyDuration - MinForceApplyDuration));

        Vector3 moveDirection = Camera.ScreenToWorldPoint(-pinchEvent.Velocity).normalized;
        //pinchEvent.Velocity.
        //normalized;
        Vector3 pushVelocity = moveDirection * pushForce;
        Rigidbody.AddForce(pushVelocity);
    }


    private void OnEndPinch(PinchEventData pinchEvent)
    {
        if (_animationMode == AnimationMode.None && pinchEvent.Velocity.magnitude >= 30f)
        {
            //_animationVelocity = pinchEvent.Velocity;
            //_animationMode = AnimationMode.Velocity;
        }
        else
        {
            // FireCameraStoppedMovingEvent();
        }

        _pinching = false;

        //FireLevelOfDetailChangedEvent();
    }


    // [Button]
    // public void TESTPUSHADDFORCE(float pushDuration, Vector3 velocity)
    // {
    //     float pushForce = Mathf.Lerp(MinPushForce, MaxPushForce,
    //         (pushDuration - MinForceApplyDuration) / (MaxForceApplyDuration - MinForceApplyDuration));
    //     Debug.LogError(pushForce);
    //     Vector3 moveDirection = velocity.normalized;
    //     Vector3 pushVelocity = moveDirection * pushForce;
    //     Debug.LogError("PUSH"+pushVelocity.ToString());
    //     Rigidbody.AddForce(pushVelocity);
    // }

    #endregion


    #region ZOOM:::::

    [SerializeField] private IsLandInput isLandInput;

    //MIN MAX CỦA ZOOM ĐỘ VÀ PHẦN MỀM DÙNG CHO TRIGGER HAY GÌ ĐÓ
    [SerializeField] private Vector2 SoftWidthLimits;

    [SerializeField] private Vector2 WidthLimits;

    //Tốc độ thu phóng camera khôi phục 1 chút sau khi thả tay ra
    [SerializeField] private float ZoomRestoreSpeed;

    public Vector2 GetZoomLimits()
    {
        return WidthLimits;
    }

    public Vector2 GetSoftZoomLimits()
    {
        return SoftWidthLimits;
    }

    public void SetZoomLimits(Vector2 v)
    {
        WidthLimits = v;
    }

    public void SetSoftZoomLimits(Vector2 v)
    {
        SoftWidthLimits = v;
    }


    private void CalculateZoomOffsetAndZoom(PinchEventData pinchEvent)
    {
        _pinchingOrthoSize = pinchEvent.ScaleDelta;
        //CalculateZoomOffset(_pinchingOrthoSize);
        float zoomAmount = _pinchingOrthoSize * Time.deltaTime;
        float newWidth = Width + zoomAmount;
        newWidth = Mathf.Clamp(newWidth, WidthLimits.x, WidthLimits.y);
        Width = newWidth;
    }


    [Button]
    private void TestCalculateZoomOffsetAndZoom(float _pinchingOrthoSize)
    {
        //_pinchingOrthoSize = pinchEvent.ScaleDelta;
        //CalculateZoomOffset(_pinchingOrthoSize);
        float zoomAmount = _pinchingOrthoSize * Time.deltaTime;
        float newWidth = Width + Width * zoomAmount;
        newWidth = Mathf.Clamp(newWidth, WidthLimits.x, WidthLimits.y);
        Width = newWidth;
    }


    private float CalculateZoomOffset(float orthoSize)
    {
        float result = 0f;
        if (orthoSize < WidthLimits.x)
        {
            result = WidthLimits.x - orthoSize;
        }
        else if (orthoSize > WidthLimits.y)
        {
            result = WidthLimits.y - orthoSize;
        }

        return result;
    }

    #endregion


    #region MOVETOOOOOOOOOOOOOOOO:::

    [SerializeField] private float MaxMovePerFrame = 10f;
    [SerializeField] private float PushForce = 1000f;
    [SerializeField] private float MaxPushForce = 1000f;
    [SerializeField] private float MinPushForce = 1000f;
    [SerializeField] private float MaxForceApplyDuration;

    [SerializeField] private float MinForceApplyDuration;

    //KHNG PUSHHHH TRONG QUÁ TRÌNH ZOOMMMMM::
    [SerializeField] private float NoPushAfterZoomDuration;

    //LỰC NẨY LẠI KHI TRIGGER
    [SerializeField] private float TriggerStayPushPower = 10f;

    [SerializeField] private float PushStartTime;
    [SerializeField] private float ZoomStartTime;

    private Vector3 _force;


    //ĐẨY LẠI KHI MÀ CHUẨN thả tay RA Ở TRONG VA CHẠM VỚI MÉP
    private void OnTriggerStay(Collider other)
    {
        if (Input.touchCount != 0)
        {
            return;
        }

        Transform otherTransform = other.transform;
        Vector3 pushDirection = (transform.position - otherTransform.position).normalized;
        Vector3 pushForce = pushDirection * TriggerStayPushPower;
        Rigidbody.AddForce(pushForce, ForceMode.Force);
    }

    #endregion
}