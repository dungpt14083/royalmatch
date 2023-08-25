using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System;
using System.Drawing;
using System.Linq;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using Color = UnityEngine.Color;


public class BuildingPreviewView : MonoBehaviour, IDragHandler, IEndDragHandler,IPinchHandler, IPointerEnterHandler,
    IEventSystemHandler
{
    public delegate void PreviewBuildingPlacedEventHandler(BuildingPreviewView buildingPreviewView);

    public event PreviewBuildingPlacedEventHandler PreviewBuildingPlacedEvent;


    [SerializeField] private GridObjectView _gridObjectView;

    [SerializeField] private MeshCollider _collider;

    //[SerializeField] private Transform _buildingHoverTransform;
    [SerializeField] private SpriteRenderer _buildingRenderer;
    [SerializeField] private Transform localPositionIso;


    [SerializeField] private List<TilePlaneValidPreBuilder> listTilePlaneValidPreBuilder;
    //private static readonly GridSize ShadowTileDesignSize = new GridSize(2, 2);
    //[SerializeField] private GameObject _PlaneHoleGird;
    // [SerializeField] private SpriteRenderer _shadowTileRenderer;
    // [SerializeField] private GameObject ArrowsRenderer;
    //HOLE TILE 1 -4 TẠM THỜI:::


    public PreBuilderState State { get; private set; }

    //private Vector3 _initialBuildingOffset;
    private PreviewBuilding _previewBuilding;
    private GridIgridObjectView _gridIgridObjectView;
    private IsLandInfo _isLandInfo;
    private IGridObject _originalGridObject;
    private bool _placingBuilding = false;
    private bool _transferDrag = true;
    private TilePlaneValidPreBuilder _currentTilePlaneValidPreBuilder;


    public GridArea Area
    {
        get { return _previewBuilding.Area; }
    }


    public bool IsFlipped
    {
        get { return _previewBuilding.IsFlipped; }
        set { _previewBuilding.IsFlipped = value; }
    }

    public void Init(GridIgridObjectView gridIgridObjectView, IsLandInfo island, IGridObject original,
        SpriteRenderer renderer,
        MeshCollider collider)
    {
        Init(gridIgridObjectView, island, original, new PreviewBuilding(original.Area, original.IsFlipped), renderer,
            collider, true);
    }


    public void Init(GridIgridObjectView gridIgridObjectView, IsLandInfo island, GridArea area, SpriteRenderer renderer,
        MeshCollider collider)
    {
        Init(gridIgridObjectView, island, null, new PreviewBuilding(area, false), renderer, collider, true);
    }


    private void Init(GridIgridObjectView gridIgridObjectView, IsLandInfo islandInfo, IGridObject original,
        PreviewBuilding previewBuilding,
        SpriteRenderer renderer, MeshCollider collider, bool unlocked)
    {
        _originalGridObject = original;
        _previewBuilding = previewBuilding;
        _gridIgridObjectView = gridIgridObjectView;
        _isLandInfo = islandInfo;
        //_initialBuildingOffset = _buildingHoverTransform.localPosition;
        //NGHE SỰ KIỆN DI CHUYỂN ĐỂ DI CHUYỂN TỪ LÕI PREVIEWBUILDING::1 VÒNG TỪ BUILDING SANG LÕI PREVIEWBULING RỒI TỚI QUAY LẠI ĐÂY::
        _previewBuilding.MovedEvent += OnBuildingMoved;
        //Dưa thông tin grid vào tí di chuyển bla bla....nghe sự kiện để di chuyển vị tr thật
        _gridObjectView.Init(gridIgridObjectView, _previewBuilding);
        _collider.sharedMesh = collider.sharedMesh;
        collider.enabled = true;


        SetPositionIsoFollowSize();


        var tmpSize = previewBuilding.Area.Size.U;
        var tmpType = (TypeTilePlaneValidPreviewBuilder)tmpSize;
        for (int i = 0; i < listTilePlaneValidPreBuilder.Count; i++)
        {
            if (listTilePlaneValidPreBuilder[i].TypeTilePlaneValidPreviewBuilder == tmpType)
            {
                listTilePlaneValidPreBuilder[i].gameObject.SetActive(true);
                _currentTilePlaneValidPreBuilder = listTilePlaneValidPreBuilder[i];
            }
            else
            {
                listTilePlaneValidPreBuilder[i].gameObject.SetActive(false);
            }
        }

        if (renderer != null)
        {
            _buildingRenderer.sprite = renderer.sprite;
        }

        UpdatePlaceability();
    }


    private void SetPositionIsoFollowSize()
    {
        Vector3 tmpLocal = new Vector3(_previewBuilding.Area.Size.U / 2.0f, 0, _previewBuilding.Area.Size.V / 2.0f);
        if (_previewBuilding.Area.Size.U == 1)
        {
            tmpLocal.y = 0.2f;
        }

        localPositionIso.localPosition = tmpLocal;
    }


    private void UpdatePlaceability()
    {
        var tmp = CanPlacePreviewBuilding();
        if (_currentTilePlaneValidPreBuilder != null)
        {
            _currentTilePlaneValidPreBuilder.SetValid(tmp);
        }
    }


    public bool CanPlacePreviewBuilding()
    {
        return _isLandInfo.IsOpenArea(_previewBuilding.Area, _originalGridObject);
    }

    private void _setColorTileHole(Color color, GameObject TileHole)
    {
        TileHole.GetComponent<SpriteRenderer>().color = color;
    }

    public void OnPinch(PinchEventData pinchEvent)
    {
    }
    
    private void OnBuildingMoved(IGridObject gridObject)
    {
        //SingletonMonobehaviour<AudioPlayer>.Instance.Play(Clip.MoveBuilding);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (eventData.pointerPress != null && _transferDrag)
        {
            eventData.pointerPress = eventData.pointerEnter;
            eventData.pointerPressRaycast = eventData.pointerCurrentRaycast;
            eventData.pointerDrag = eventData.pointerEnter;
            _transferDrag = false;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!_placingBuilding)
        {
            
            //lỆCH Ở ĐÂY DO TIA RAY BẮN VÀO 
            if (eventData.pointerCurrentRaycast.isValid)
            {
                Vector3 worldPosition = eventData.pointerCurrentRaycast.worldPosition;
                //Debug.LogError("World Position " + worldPosition.ToString());
                GridPoint point;

                // point = _gridIgridObjectView.WorldVectorToGridPoint(worldPosition) -
                //         _previewBuilding.Area.Size.Half;
            
                if ( _previewBuilding.Area.Size.U>1)
                {
                    point = _gridIgridObjectView.WorldVectorToGridPoint(worldPosition) -
                            _previewBuilding.Area.Size.Half;
                }
                else
                {
                    point = _gridIgridObjectView.WorldVectorToGridPoint(worldPosition);
                    //Debug.LogError("point"+point.ToString());
                }
            
                //Debug.LogError("Position" + point.U + "Position V" + point.V+"HALF"+_previewBuilding.Area.Size.Half.ToString());
                GridIndex index = new GridIndex(point);
                MoveTo(index);
            }
        }
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    public void OnEndDrag(PointerEventData eventData)
    {
        if (!_placingBuilding)
        {
        }
    }

    //NẾU CÓ THỂ MOVE ĐƯỜNG TRONG ĐƯỜNG BAO THÌ MỚI CHO MOVE K TH K CHO MOVE RA NGOÀI MAP
    public void MoveTo(GridIndex index)
    {
        // if (_isLandInfo.IsWithinBounds(index, _previewBuilding.Area.Size))
        // {
        _previewBuilding.MoveTo(index);
        //}

        UpdatePlaceability();
    }


    //XOAYY TÒA NHÀ
    public void FlipBuilding()
    {
        if (this.IsInvoking(ApplyFlip))
        {
            this.CancelInvoke(ApplyFlip);
            ApplyFlip();
        }

        this.Invoke(ApplyFlip, 0.5f);
    }

    private void ApplyFlip()
    {
        _previewBuilding.IsFlipped = !_previewBuilding.IsFlipped;
    }

    public bool PlaceBuilding()
    {
        if (_placingBuilding)
        {
            return false;
        }

        _placingBuilding = true;
        _collider.enabled = false;
        StartCoroutine(DelayFrame());
        return true;
    }

    private IEnumerator DelayFrame()
    {
        yield return new WaitForSeconds(0.5f);
        OnPlaceBuildingFinishedPlaying();
    }

    private void OnPlaceBuildingFinishedPlaying()
    {
        FirePreviewBuildingPlacedEvent();
    }

    private void FirePreviewBuildingPlacedEvent()
    {
        if (this.PreviewBuildingPlacedEvent != null)
        {
            this.PreviewBuildingPlacedEvent(this);
        }

        _buildingRenderer.enabled = false;
        SetShadowBuildingPreview(false);
        StartCoroutine(DelayDestroy());
    }

    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(base.gameObject);
    }

    public void CancelPreview()
    {
        UnityEngine.Object.Destroy(base.gameObject);
    }

    //CÓ MỖI CÁI ANIMATION CHO THẰNG MŨI TÊN VÀ HOLE MÀ PHỨC TẠP QUÁ GỌI T PREBUILD LÀ SAI
    public void SetShadowBuildingPreview(bool isActive)
    {
        //     _shadowTileRenderer.enabled = isActive;
    }
}