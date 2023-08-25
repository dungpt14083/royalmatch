using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CollecPopup : Popup
{
   [SerializeField] private CollecCurrencyView _productPrefab;

   [SerializeField] private CollecCurrencyView _dragProduct;

   [SerializeField] private LayoutGroup _productGrid;
   [SerializeField] private RectTransform _rectTransform;
   [SerializeField] private Vector2 _dragProductOffset;

   [SerializeField] private Camera _islandCamera;

   [SerializeField] private GridIgridObjectView gridIgridObjectView;
   public FarmFieldBuilding Building { get; private set; }

   public override void Open(PopupRequest request)
   {
      base.Open(request);
      CollecPopupRequest collecPopupRequest2 = GetRequest<CollecPopupRequest>();
      Building = collecPopupRequest2.FarmField;

     // ProductProperties productProperties = Building.FarmfieldBuildingProperties;
     CollecCurrencyView collecCurrencyView = _productPrefab;
      collecCurrencyView.Init();
      collecCurrencyView.BeginDragEvent += OnProductBeginDrag;
      collecCurrencyView.DragEvent += OnProductDrag;
      collecCurrencyView.EndDragEvent += OnProductEndDrag;

      _dragProduct = _productPrefab.InstantiatePrefab(this);
      _dragProduct.gameObject.SetActive(false);

   }

   public override void Close()
   {
      CollecCurrencyView collecCurrencyView = _productPrefab;
      collecCurrencyView.BeginDragEvent -= OnProductBeginDrag;
      collecCurrencyView.DragEvent -= OnProductDrag;
      collecCurrencyView.EndDragEvent -= OnProductEndDrag;
      if (_dragProduct != null)
      {
         UnityEngine.Object.Destroy(_dragProduct.gameObject);
         _dragProduct = null;
      }
      base.Close();
   }
   
   private void OnProductBeginDrag(PointerEventData eventData, InteractiveCurrencyView<ProductProperties> productView)
   {
      _dragProduct.gameObject.SetActive(true);
      _dragProduct.Init( true);
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
         if (farmfield != null )
         {
            if (farmfield.Collect())
            {
               Debug.Log("Thu Hoạch Thành công");
            }
            else
            {
               Debug.Log("Thu Hoạch Thất bại");
            }
            //  farmfield.StartGrowing((BasicMaterialProperties)productView.Props);
            // _dragProduct.Drop();
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
