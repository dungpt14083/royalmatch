using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using EasyButtons;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

//[RequireComponent(typeof(BoxCollider2D))]
public class CameraControllerView : MonoSingleton<CameraControllerView>
{
    private enum AnimationMode
    {
        None = 0,
        Velocity = 1,
        Destination = 2
    }

    public delegate void CameraStoppedMovingEventHandler();

    public delegate void LevelOfDetailChangedEventHandler();

    private const float VelocityReductionFactor = 0.95f;
    private const float VelocityStartMagnitudeThreshold = 30f;
    private const float VelocityEndMagnitudeThreshold = 5f;

    [SerializeField] private IsLandInput _islandInput;
    [SerializeField] private Camera _cameraToOperate;
    [SerializeField] private float _destinationAnimationDuration = 0.6f;
    [SerializeField] private AnimationCurve _destinationAnimationCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
    [SerializeField] private float _minZoom = 5;
    [SerializeField] private float _minZoomRange = 200f;
    [SerializeField] private float _maxZoom = 15;
    [SerializeField] private float _maxZoomRange = 500f;
    [SerializeField] private float _zoomElasticity = 1f;
    [SerializeField] private float _zoomStiffness = 4f;
    [SerializeField] private Collider _cameraBounds;


    //ĐƯỜNG BAO CỦA CAMERA CHO TẰNG NÀY K VƯỢT QUÁ GIỚI HẠN
    //[SerializeField] private Collider _cameraBounds;

    private bool _pinching;

    private float _pinchingOrthoSize;

    private AnimationMode _animationMode;

    private Vector2 _animationVelocity;

    private Vector3 _animationSource;

    private Vector3 _animationDestination;

    private float _animationStartTime;

    private float _cameraY;

    private bool _hasBeenInitialised;

    public Vector3 CameraWorldPosition
    {
        get { return _cameraToOperate.transform.position; }
    }

    public Vector2 CameraSize
    {
        get
        {
            float num = _cameraToOperate.orthographicSize * 2f;
            float x = _cameraToOperate.aspect * num;
            return new Vector2(x, num);
        }
    }

    public Vector3 CameraTopLeftWorldPosition
    {
        get
        {
            Vector2 vector = new Vector2(CameraSize.x / -2f, CameraSize.y / 2f);
            return CameraWorldPosition + (Vector3)vector;
        }
    }

    public Vector3 CameraBottomLeftWorldPosition
    {
        get
        {
            Vector2 vector = new Vector2(CameraSize.x / -2f, CameraSize.y / -2f);
            return CameraWorldPosition + (Vector3)vector;
        }
    }


    public Vector3 CameraTopRightWorldPosition
    {
        get
        {
            Vector2 vector = new Vector2(CameraSize.x / 2f, CameraSize.y / 2f);
            return CameraWorldPosition + (Vector3)vector;
        }
    }

    public Vector3 CameraBottomRightWorldPosition
    {
        get
        {
            Vector2 vector = new Vector2(CameraSize.x / 2f, CameraSize.y / -2f);
            return CameraWorldPosition + (Vector3)vector;
        }
    }

    public float LevelOfDetail
    {
        get { return _cameraToOperate.orthographicSize; }
        private set { _cameraToOperate.orthographicSize = value; }
    }

    public event CameraStoppedMovingEventHandler CameraStoppedMovingEvent;
    public event LevelOfDetailChangedEventHandler LevelOfDetailChangedEvent;


    private void FireCameraStoppedMovingEvent()
    {
        if (this.CameraStoppedMovingEvent != null)
        {
            this.CameraStoppedMovingEvent();
        }
    }

    private void FireLevelOfDetailChangedEvent()
    {
        if (this.LevelOfDetailChangedEvent != null)
        {
            this.LevelOfDetailChangedEvent();
        }
    }

    //NGHE INPUT ĐỂ CAMERA SANG PHẢI TRÁI VÀ VỆC ZOOM TO NHỎ THÌ TẠM CHƯA XÉT
    protected override void Awake()
    {
        base.Awake();
        _islandInput.OnPointerDown += OnPointerDown;
        _islandInput.OnPointerUp += OnPointerUp;
        _islandInput.OnBeginPinch += OnBeginPinch;
        _islandInput.OnPinch += OnPinch;
        _islandInput.OnEndPinch += OnEndPinch;

#if UNITY_EDITOR

        #region FORDRAGGGG

        _islandInput.OnDragEvent += OnDragEvent;
        _islandInput.OnEndDragEvent += OnEndDragEvent;

        #endregion

#endif

        _pinching = false;
        _animationMode = AnimationMode.None;
        _cameraY = _cameraToOperate.transform.position.y;
    }

    private void OnDestroy()
    {
        if (_islandInput != null)
        {
            _islandInput.OnPointerDown -= OnPointerDown;
            _islandInput.OnPointerUp -= OnPointerUp;
            _islandInput.OnBeginPinch -= OnBeginPinch;
            _islandInput.OnPinch -= OnPinch;
            _islandInput.OnEndPinch -= OnEndPinch;

#if UNITY_EDITOR

            #region FORDRAGGGG

            _islandInput.OnDragEvent -= OnDragEvent;
            _islandInput.OnEndDragEvent -= OnEndDragEvent;

            #endregion

#endif
        }
    }

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
            FireCameraStoppedMovingEvent();
        }
    }

    private void OnBeginPinch(PinchEventData pinchEvent)
    {
        _pinching = true;
        _pinchingOrthoSize = _cameraToOperate.orthographicSize;
        if (_animationMode != 0)
        {
            _animationMode = AnimationMode.None;
        }
    }


    private void OnPinch(PinchEventData pinchEvent)
    {
        _pinchingOrthoSize /= pinchEvent.ScaleDelta;
        float num = CalculateZoomOffset(_pinchingOrthoSize);
        float zoomRange = ((!(num < 0f)) ? _minZoomRange : _maxZoomRange);
        float num2 = DampenOffset(num, zoomRange);
        float orthographicSize = _pinchingOrthoSize + num - num2;
        Transform transform = _cameraToOperate.transform;

        //KÍCH THƯỚC CHIỀU CAO CAMERA DỰA TRÊN ORTHOGRAPHICSIZE
        float num3 = _cameraToOperate.orthographicSize * 2f;
        //KÍCH THƯỚC CHIỀU RỘNG CỦA CAMERA
        float num4 = num3 * _cameraToOperate.aspect;

        Vector2 zero = Vector2.zero;

        //CHUYỂN ĐÔ TỪ HỆ THỌA ĐỘ MÀN HÌNH SANG HỆ TỌA ĐỘ CỦA CAMERA::::::::::::CỦA PITCHCENTER
        zero.x = transform.localPosition.x - num4 * 0.5f +
                 pinchEvent.Center.x / (float)_cameraToOperate.pixelWidth * num4;
        zero.y = transform.localPosition.z - num3 * 0.5f +
                 pinchEvent.Center.y / (float)_cameraToOperate.pixelHeight * num3;

        //CHUYỂN DEALTA X Y TỪ HỆ TỌA ĐỘ MÀN HÌNH SANG HỆ TO ĐỘ CAMERA:::CỦA PITCHCENTER
        Vector3 zero2 = Vector3.zero;
        zero2.x = (0f - pinchEvent.Delta.x) / (float)_cameraToOperate.pixelWidth * num4;
        zero2.z = (0f - pinchEvent.Delta.y) / (float)_cameraToOperate.pixelHeight * num3;

        //DỰA TRÊN CỘNG THÊM 1 LƯỢNG dựa trên sxale delate của pitch event và 
        zero2.x += (transform.localPosition.x - zero.x) * (1f - pinchEvent.ScaleDelta);
        zero2.z += (transform.localPosition.z - zero.y) * (1f - pinchEvent.ScaleDelta);

        Quaternion rotation = Quaternion.Euler(0, -45f, 0);
        zero2 = rotation * zero2;

        transform.localPosition += zero2;


        _cameraToOperate.orthographicSize = orthographicSize;
    }

    private void OnEndPinch(PinchEventData pinchEvent)
    {
        if (_animationMode == AnimationMode.None && pinchEvent.Velocity.magnitude >= 30f)
        {
            _animationVelocity = pinchEvent.Velocity;
            _animationMode = AnimationMode.Velocity;
        }
        else
        {
            FireCameraStoppedMovingEvent();
        }

        _pinching = false;
        FireLevelOfDetailChangedEvent();
    }

    private float DampenOffset(float overStretching, float zoomRange)
    {
        if (Mathf.Approximately(overStretching, 0f))
        {
            return 0f;
        }

        return (1f - 1f / (Mathf.Abs(overStretching) / (_zoomStiffness * zoomRange) + 1f)) * zoomRange *
               Mathf.Sign(overStretching);
    }

    //XỬ LÍ VIỆC KÉO SANG PHẢI TRÁI.......
    private void LateUpdate()
    {
        SoftRestrictCameraZoom(Time.deltaTime);
        if (_animationMode == AnimationMode.None)
        {
            RestrictCameraBounds();
            return;
        }


        //ĐOAẠN NÀY LÀ CHẠY ĐÀ ĐOẠN CUỐI KHI MÀ KÉO MẠNH HOẶC LÀ CHO VỤ CHỈ ĐỊNH VỊ TRÍ ĐỂ NÓ TỰ CHẠY TỚI:::
        Transform transformX = _cameraToOperate.transform;
        float num = _cameraToOperate.orthographicSize * 2f;
        float num2 = num * _cameraToOperate.aspect;
        if (_animationMode == AnimationMode.Velocity)
        {
            _animationVelocity *= 0.95f;
            Vector3 zero = Vector3.zero;
            zero.x = (0f - _animationVelocity.x) * Time.deltaTime / (float)_cameraToOperate.pixelWidth * num2;
            zero.y = 0;
            zero.z = (0f - _animationVelocity.y) * Time.deltaTime / (float)_cameraToOperate.pixelHeight * num;

            Quaternion rotation = Quaternion.Euler(0, -45f, 0);
            zero = rotation * zero;

            transformX.localPosition += zero;
            if (_animationVelocity.magnitude < 5f)
            {
                _animationMode = AnimationMode.None;
                FireCameraStoppedMovingEvent();
            }
        }
        else if (_animationMode == AnimationMode.Destination)
        {
            float num3 =
                _destinationAnimationCurve.Evaluate((Time.time - _animationStartTime) / _destinationAnimationDuration);
            Vector3 position = transformX.position;
         //   Debug.LogError("TIME" + num3.ToString());
            if (num3 >= 1f)
            {
                position.x = _animationDestination.x;
                position.y = _animationDestination.y;
                position.z = _animationDestination.z;
                _animationMode = AnimationMode.None;
                FireCameraStoppedMovingEvent();
            }
            else
            {
                //Debug.LogError("xằ");
                position = Vector3.Lerp(_animationSource, _animationDestination, num3);
            }

            transformX.position = position;

            if (Vector3.Distance(position, _animationDestination) < 0.1f)
            {
                return;
            }
        }

        RestrictCameraBounds();
    }

    private void SoftRestrictCameraZoom(float deltaTime)
    {
        float orthographicSize = _cameraToOperate.orthographicSize;
        float num = CalculateZoomOffset(orthographicSize);
        if (!Mathf.Approximately(num, 0f))
        {
            float currentVelocity = 0f;
            orthographicSize = Mathf.SmoothDamp(orthographicSize, orthographicSize + num, ref currentVelocity,
                _zoomElasticity, float.PositiveInfinity, deltaTime);
            orthographicSize += currentVelocity;
            _cameraToOperate.orthographicSize = orthographicSize;
        }
    }

    //LÀM CHO CAMERA LUÔN NẰM TRONG ƯỜNG BAO
    private void RestrictCameraBounds()
    {
        Transform transform = _cameraToOperate.transform;
        float num = _cameraToOperate.orthographicSize * 2f; //giá trị heigh
        float num2 = num * _cameraToOperate.aspect; //giá trị 1.7

        //==>>>ra được thằng width ĐỘ RỘNG CỦA CAMERA VIEW
        Bounds bounds = _cameraBounds.bounds;

        //ĐÂY LÀ CHỈNH LIÊN QUAN TỚI CỰC CỦA ZOOMMMMM
        if (num2 > bounds.size.x)
        {
            num2 = bounds.size.x;
            num = num2 / _cameraToOperate.aspect;
            _cameraToOperate.orthographicSize = num * 0.5f;
        }

        if (num > bounds.size.z)
        {
            num = bounds.size.z;
            num2 = num * _cameraToOperate.aspect;
            _cameraToOperate.orthographicSize = num * 0.5f;
        }


        //ĐÂY LÀ LIÊN QUAN TỚI VỊ TRÍ::::CỦA CAMERA:::
        Vector3 position = transform.position;


        //VỊ TRÍ CAMERA TRỪ ĐI SIZE CHIA 2 VÀ CHẠM CẠNH THÌ SẼ VỊ TRÍ LÀ ĐÓ
        if (position.x - num2 * 0.5f < bounds.min.x)
        {
            position.x = bounds.min.x + num2 * 0.5f;
        }

        if (position.x + num2 * 0.5f > bounds.max.x)
        {
            position.x = bounds.max.x - num2 * 0.5f;
        }

        if (position.z - num * 0.5f < bounds.min.z)
        {
            position.z = bounds.min.z + num * 0.5f;
        }

        if (position.z + num * 0.5f > bounds.max.z)
        {
            position.z = bounds.max.z - num * 0.5f;
        }

        transform.position = position;
    }

    private float CalculateZoomOffset(float orthoSize)
    {
        float result = 0f;
        if (orthoSize < _minZoom)
        {
            result = _minZoom - orthoSize;
        }
        else if (orthoSize > _maxZoom)
        {
            result = _maxZoom - orthoSize;
        }

        return result;
    }


    #region SHAKECAMERA:::::::::::

    [SerializeField] private Ease _shakeEase;

    [Button]
    public Tween Shake(float shakeDuration = 1, float shakeStrength = 0.1f)
    {
        Tweener shakeTween =
            ShortcutExtensions.DOShakePosition(_cameraToOperate.transform, duration: shakeDuration,
                strength: shakeStrength);
        return TweenSettingsExtensions.SetEase(shakeTween, this._shakeEase);
    }

    #endregion


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
        var tmpY = _cameraToOperate.transform.position.y;
        _cameraToOperate.transform.Translate(new Vector3(movementX, 0, movementY).normalized * dragSpeed, Space.Self);
        var tmp = _cameraToOperate.transform.position;
        tmp.y = tmpY;
        _cameraToOperate.transform.position = tmp;
        previousMousePosition = eventData.position;
    }

    private void OnEndDragEvent(PointerEventData eventData)
    {
        previousMousePosition = Vector2.zero;
    }


    // private void OnDrawGizmos()
    // {
    //     if (_cameraToOperate == null) return;
    //
    //     Quaternion rotation = Quaternion.Euler(30f, -45f, 0f); // Góc xoay của camera
    //     Vector3 cameraDirection = rotation * Vector3.forward; // Hướng nhìn của camera
    //
    //     Vector3 rayStartPosition =
    //         _cameraToOperate.transform.position + cameraDirection * _cameraToOperate.nearClipPlane;
    //
    //     Ray ray = new Ray(rayStartPosition, cameraDirection);
    //
    //     Gizmos.color = Color.red;
    //     Gizmos.DrawRay(ray.origin, ray.direction * 100f);
    //
    //     RaycastHit hit;
    //     if (Physics.Raycast(ray, out hit))
    //     {
    //         Debug.LogError(hit.point);
    //     }
    // }
#endif


    //CUỘN CAMERA TRỎ TỚI THẰNG TÒA NHÀ NTN::::
    public void ScrollTo(GameObject go, bool animated)
    {
        MeshCollider component = go.GetComponentInChildren<MeshCollider>();
        Vector3 position = component == null ? go.transform.position : component.bounds.center;
        ScrollTo(position, animated);
    }

    //TRUYỀN VÀO LÀ VỊ TRÍ THẾ GIỚI CỦA VẬT CẦN NHÌN VÀO
    [Button]
    public void ScrollTo(Vector3 worldPosition, bool animated)
    {
        Vector3 hitPosition;
        if (RayCastFromCameraExtensions.GetHitPlaneFromCamera(out hitPosition))
        {
            var distance = worldPosition - hitPosition;
            Debug.LogError("move distance" + distance);
            if (animated)
            {
                _animationSource = _cameraToOperate.transform.position;
                _animationDestination = _animationSource + distance;
                _animationStartTime = Time.time;
                _animationMode = AnimationMode.Destination;
            }
            else
            {
                _animationMode = AnimationMode.None;
                _cameraToOperate.transform.position += distance;
                FireCameraStoppedMovingEvent();
            }
        }
    }


    #region KIỂM SOÁT TIME DI CHUYỂN TỪ A TỚI B V INVOKE LẠI CALLBACK THÌ THÀNH CÔNG //CÁI NÀY CHỈ MOVE CƠ BẢN KHÔNG CÓ THAO TÁC PHỨC TẠP NHU VỪA MOVE VỪA ZOOM:::

    private Tween _moveTween;


    [Button]
    public void TestMoveCamera(Vector3 positionWorld)
    {
        var distanceTargetPositionCamera =
            RayCastFromCameraExtensions.GetDistanceTargetCameraPositionFromWorldPosition(positionWorld);
        var targetPositionCamera = _cameraToOperate.transform.position + distanceTargetPositionCamera;
        MoveToPosition(targetPositionCamera, 2);
    }


    //move và zoom là 2 hành động khác nha
    ////VỪA MOVE VỪA ZOOM THÌ SAU NÀY SẼ VIẾT CẢI TIN THÊM CHO ĐẸP KHI CÓ TIME:::
    /// CÁI DURATION CHỈ DÀNH CHO CÁI ZOOM KHI MOVE CÁI NÀY TÍNH SAU:::

    //TỌA ĐỘ NÀY LÀ TỌA ĐỘ CAMERA CHO NÓ MOVE THÌ BÊN NGOÀI PHẢI XỬ LÍ RA ĐƯỢC ĐIỂM CẦN MOVE TỚI
    [Button]
    public Tween MoveToPosition(Vector3 position, float duration, bool autoSpeedOnLongDurations = false)
    {
        TweenerCore<Vector3, Vector3, DG.Tweening.Plugins.Options.VectorOptions> moveTween;
        moveTween = ShortcutExtensions.DOMove(target: _cameraToOperate.transform,
            endValue: new Vector3(position.x, position.y, position.z),
            duration: Vector3.Distance(new Vector3(position.x, position.y, position.z),
                _cameraToOperate.transform.position),
            snapping: autoSpeedOnLongDurations);
        moveTween.SetEase(Ease.Linear);
        this._moveTween = moveTween;
        return TweenSettingsExtensions.SetEase(this._moveTween, Ease.Linear);
    }

    #endregion


    #region ZOOMCAMERA

    private DOGetter<float> _getWidthValue;
    private DOSetter<float> _setWidthValue;

    public float SizeZoom
    {
        get { return _cameraToOperate.orthographicSize; }
        set
        {
            float num = CalculateZoomOffset(value);
            float zoomRange = ((!(num < 0f)) ? _minZoomRange : _maxZoomRange);
            float num2 = DampenOffset(num, zoomRange);
            float orthographicSize = value + num - num2;
            _cameraToOperate.orthographicSize = orthographicSize;
        }
    }


    private void Start()
    {
        this._getWidthValue = () => this.SizeZoom;
        this._setWidthValue = (v) => this.SizeZoom = v;
    }


    //ZOOMMMMM TOOO::::
    [Button]
    public Tween ZoomTo(float size, float duration)
    {
        //GET SET VÀ GIÁ TRỊ END Ở TRONG ĐÓ
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>
            widthTween =
                DG.Tweening.DOTween.To(getter: this._getWidthValue, setter: this._setWidthValue, endValue: size,
                    duration: duration);
        return widthTween;
    }

    #endregion
}