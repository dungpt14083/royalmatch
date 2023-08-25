using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

//TẠO RA ĐỐNG ITEM THÌ PHẢI ĐỂ Ý ĐỂ QUẢN LÍ CHÚNG
public class FarmFieldPopup : Popup
{
    //PREFAB THẰNG HẠT GIỐNG ĐỂ CHỌN NÓ THẢ VÀO Ô ĐẤT
    [SerializeField] private SowingCurrencyView _productPrefab;

    //vị trí sẽ tạo ra
    [SerializeField] private RectTransform _rectTransform;
    [SerializeField] private LayoutGroup _productGrid;
    [SerializeField] private Vector2 _dragProductOffset;
    [SerializeField] private ScrollRect _productScrollRect;

    //NÚT NEXT....VÀ PRE CHO VỆC HIỂN THỊ HẠT GIỐNG::
    [SerializeField] private Button _prevPageButton;
    [SerializeField] private Button _nextPageButton;
    [SerializeField] private Camera _islandCamera;

    //GRIDVIEW ĐỂ CHECK CÁ THỨ  TRONG NÀY:::
    [FormerlySerializedAs("gridIgridGridView")] [FormerlySerializedAs("_gridView")] [SerializeField]
    private GridIgridObjectView gridIgridObjectView;

    [SerializeField] private float _initialVelocity;

    [SerializeField] private PopupDetailSowingCurrencyView _popupDetailSowingCurrencyView;

    //LIST SẢN PẨM CÓ THỂ TRỒNG:::
    private readonly List<SowingCurrencyView> _products = new List<SowingCurrencyView>();

    //CURRENT CÁI MÀ ĐANG DRAG
    private SowingCurrencyView _dragProduct;

    private int _pageIndex;
    private int _maxPageIndex;
    private float _productScrollRectHorizontalPosition;
    private float _velocity;

    public FarmFieldBuilding Building { get; private set; }

    public override void Open(PopupRequest request) 
    {
        base.Open(request);
        FarmFieldPopupRequest request2 = GetRequest<FarmFieldPopupRequest>();
        Building = request2.FarmField;
        int num = 0;
        //SỐ LƯỢNG PROPERTIES
        int count = Building.FarmfieldBuildingProperties.SowingMaterialProperties.Count;
        for (int i = 0; i < count; i++)
        {
            ProductProperties productProperties = Building.FarmfieldBuildingProperties.SowingMaterialProperties[i];
            //check level currency view
            if (productProperties.levelPlayerRequire > FarmMapController.Instance.GetLevelPlayer()) continue;
            
            SowingCurrencyView sowingCurrencyView = _productPrefab.InstantiatePrefab(_productGrid);
            sowingCurrencyView.Init(productProperties);
            //SAU ĐÓ THÌ NGHE SỰ KIỆN VẬT PHẨM ĐỂ INVOKE LẠI ĐỂ MÀ XỬ LÍ 
            sowingCurrencyView.BeginDragEvent += OnProductBeginDrag;
            sowingCurrencyView.DragEvent += OnProductDrag;
            sowingCurrencyView.EndDragEvent += OnProductEndDrag;
            sowingCurrencyView.ClickEvent += () => LogSowingCurrencyViewIndex(sowingCurrencyView);
            // sowingCurrencyView.PointerDownEvent += OnProductPointerDown;
            // sowingCurrencyView.PointerUpEvent += OnProductPointerUp;
            _products.Add(sowingCurrencyView);

        }

        //_prevPageButton.gameObject.SetActive(active);
        //_nextPageButton.gameObject.SetActive(active);

        //VÀO POPUP PHÁT TẠO PRODUCT DRAG LUÔN:::
        //prefab này để drag
        _dragProduct = _productPrefab.InstantiatePrefab(this);
        _dragProduct.gameObject.SetActive(false);
    }

    private void LogSowingCurrencyViewIndex(SowingCurrencyView sowingCurrencyView)
    {
        for (int i = 0; i < _products.Count; i++)
        {
            SowingCurrencyView view = _products[i];
            view.Background.gameObject.SetActive(view == sowingCurrencyView);
        }

        _popupDetailSowingCurrencyView.gameObject.SetActive(true);


        Sprite sprite =
            SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(
                Currency.GetCurrencyTypeByName(sowingCurrencyView.Props.CurrencyName));
        
        
        _popupDetailSowingCurrencyView.Init(sowingCurrencyView.Props.CurrencyName, sprite,
            sowingCurrencyView.Props.ProductionTimeSeconds, 25, sowingCurrencyView.Props.PurchaseCost.Amount);
    }


    public override void Close()
    {
        int i = 0;
        for (int count = _products.Count; i < count; i++)
        {
            SowingCurrencyView sowingCurrencyView = _products[i];
            sowingCurrencyView.BeginDragEvent -= OnProductBeginDrag;
            sowingCurrencyView.DragEvent -= OnProductDrag;
            sowingCurrencyView.EndDragEvent -= OnProductEndDrag;
            // sowingCurrencyView.PointerDownEvent -= OnProductPointerDown;
            // sowingCurrencyView.PointerUpEvent -= OnProductPointerUp;
            UnityEngine.Object.Destroy(sowingCurrencyView.gameObject);
        }

        _products.Clear();
        if (_dragProduct != null)
        {
            UnityEngine.Object.Destroy(_dragProduct.gameObject);
            _dragProduct = null;
        }

        _popupDetailSowingCurrencyView.gameObject.SetActive(false);

        base.Close();
    }

    private void OnProductBeginDrag(PointerEventData eventData, InteractiveCurrencyView<ProductProperties> productView)
    {
        _dragProduct.gameObject.SetActive(true);
        _dragProduct.Init(productView.Props, true);
        UpdateDragProductPosition(eventData);
    }

    private void UpdateDragProductPosition(PointerEventData eventData)
    {
        Vector2 localPoint;
        //CONVERT :::
        //cHUYỂN ĐỔI TỪ ĐIỂM CHUỘT VÀO ĐIỂM RECT TRANFORM CỦA CẢ MÀN HÌNH POPUP RECT VÀ TRUYỀN VỊ TRÍ VÀ CAMERA VÀO
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(_rectTransform, eventData.position,
                eventData.enterEventCamera, out localPoint))
        {
            localPoint += _dragProductOffset;
            _dragProduct.transform.localPosition = localPoint;
        }
    }

    private void OnProductDrag(PointerEventData eventData, InteractiveCurrencyView<ProductProperties> productView)
    {
        UpdateDragProductPosition(eventData);
        //VỪA DI CHUYỂN KIA VỪA CHECK Ở TRONG HỆ THỐNG GRID TÌM GAMEOBJET LOẠI FARM THÌ TRỒNG CMNR LUÔN::

        Vector3 worldPosition = _islandCamera.ScreenToWorldPoint(eventData.position);

        Ray ray = Camera.main.ScreenPointToRay(eventData.position); // Tạo một ray từ điểm chuột trên màn hình
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            worldPosition = hit.point; // Lấy tọa độ điểm giao cắt giữa ray và đối tượng trong không gian thế giới

            // Sử dụng worldPosition để thực hiện những xử lý mong muốn
        }

        //CHUYỂN TỪ VỊ TRÍ THẾ THÀNH THÀNH GRIDPOINT VÀ TÌM OBJECT Ở TRONG ĐÓ NẾU L ĐẤ THÌ MỚI STARTGROWING
        GridPoint gridPoint = gridIgridObjectView.WorldVectorToGridPoint(worldPosition);
        IGridObject gridObject = gridIgridObjectView.FindGridObject(gridPoint);
        if (gridObject == null)
        {
            return;
        }

        Building building = gridObject as Building;
        if (building != null)
        {
            FarmFieldBuilding farmfield = building.Farmfield;
            if (farmfield != null && farmfield.CanGrow)
            {
                farmfield.StartGrowing((BasicMaterialProperties)productView.Props);
                _dragProduct.Drop();
            }
        }
    }

    private void OnProductEndDrag(PointerEventData eventData, InteractiveCurrencyView<ProductProperties> productView)
    {
        _dragProduct.gameObject.SetActive(false);
        _dragProduct.EndDrag();
        OnCloseClicked();
    }
}