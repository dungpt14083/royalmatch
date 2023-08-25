using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

//Là script cho tât cả nhà cửa bla bla và farm bla bla...Theo các level nữa luôn
public class BuildingView : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IBeginDragHandler,
    IPointerClickHandler, IEventSystemHandler
{
    //public static readonly Color GreyScaleTintColor = new Color(0.4f, 0.4f, 0.8745098f);

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private MeshCollider collider;
    [SerializeField] private GridObjectView _gridAreaView;
    [SerializeField] private GameObject objStatusBuilding;

    //private ContructionSiteStating _construction;
    private IsLandInput _islandInput;

    public Building Building { get; private set; }
    public BuildingData BuildingData { get; private set; }

    public SpriteRenderer SpriteRenderer
    {
        get { return spriteRenderer; }
    }

    public MeshCollider BuildingCollider
    {
        get { return collider; }
    }


    public void Init(GridIgridObjectView gridIgridObjectView, IsLandInput islandInput,
        Building building)
    {
        Building = building;
        BuildingData = building.buildingData;
        //_construction = building.Construction;
        _islandInput = islandInput;
        _gridAreaView.Init(gridIgridObjectView, Building);

        if (Building.buildingData != null && Building.buildingData is UpgradeHouse)
        {
            (Building.buildingData as UpgradeHouse).changeStatusBuilding += ChangeStatusBuilding;
        }

        Building.UpdateStatusBuilding();
        InitBuildingBehaviour();


        //BỎ QUA CONTRUCTIONSTATE TIME::::KHÔNG DÙNG ĐẾN CHẠY TIME NỮA
        //UpdateBuildingStateLook();
        //DUYỆT QUA NGHE SỰ KIỆN INVOKE CỦA:::
        //CHẠY SỰ KIỆN CHO VIỆC KẾT THÚC TTIME VÀ HOÀN HÀNH COMPLETE NHÀ NÀY VÀ KHI COMPLETE THÌ SẼ INITBULDING BEHAVIOUT
        // switch (_construction.State)
        // {
        //     case ConstructionState.Constructing:
        //         _construction.ConstructionFinishedEvent += OnConstructionFinished;
        //         break;
        //     case ConstructionState.Constructed:
        //         _construction.ConstructionCompletedEvent += OnConstructionCompleted;
        //         break;
        //     case ConstructionState.Completed:
        //         InitBuildingBehaviour();
        //         break;
        //     default:
        //         break;
        // }
    }

    //NẾU TRẠNG THÁI LÀ CONTRUCTIONSTATE LÀ GÌ THÌ HIỆN LÊN CÁI OBJECT CHẠY TIME:::
    public virtual void ChangeStatusBuilding(ConstructionState buildingStage)
    {
        switch (buildingStage)
        {
            case ConstructionState.Constructing:
                objStatusBuilding.SetActive(true);
                break;
            default:
                objStatusBuilding.SetActive(false);
                break;
        }
    }


    //SHOW YÊU CẦU ẬT LIỆU ĐỂ HỂN THỊ LN KHI YÊU CẦU COMPLETE CUỐI BẰNG VẬT LIỆU:::
    private void ShowRequireBuildingMaterialsBalloon(bool playsound = true)
    {
    }

    //THỰC HIỆN HÀNH VI CUA NHÀ:::::
    //xong hết mới init hành vi nên hành vi chỉ có trong bên kia quản lí nơi ây k cần quản lí
    private void InitBuildingBehaviour()
    {
        //DŨNG VẪN XÀI::::
        if (Building.Decoration != null)
        {
            DecorationBuildingView tmp = gameObject.GetComponent<DecorationBuildingView>();
            tmp.Init(Building.Decoration);
        }
        else if (Building.Farmfield != null)
        {
            FarmFieldBuildingView tmp = gameObject.GetComponent<FarmFieldBuildingView>();
            tmp.Init(Building);
        }
        else if (Building.Gatherable != null)
        {
            GatherableView tmp = gameObject.GetComponent<GatherableView>();
            tmp.Init(Building.Gatherable);
        }
        else if (Building.FruitTreeBuilding != null)
        {
            FruitTreeView tmp = gameObject.GetComponent<FruitTreeView>();
            tmp.Init(Building.FruitTreeBuilding);
        }
        else if (Building.Warehouse != null)
        {
            WareHouseBuildingView tmp = gameObject.GetComponent<WareHouseBuildingView>();
            tmp.Init(Building.Warehouse);
        }
           else if(Building.BonusTreeBuilding!=null)
        {
            BonusTreeView tmp = gameObject.GetComponent<BonusTreeView>();
            tmp.Init(Building.BonusTreeBuilding);
        }
        //FACTORY HOUSE::::
        //ANGOCANH2 THÊM VÀO VỚI DẠNG BUILDINGDATA THÌ INIT HÀNH VI VÀO ĐÂY:::
        //INIT XONG CHỜ BỌN KIA OVERIDE VỚI BUILDINGVIEW:::
        //HÀNH VI Ở NGAY TRONG BULDINGVIEW ĐƯỢC KẾ THỪA TỪ BASE NÀY CHỨ K Ở CLASS KHÁC:::
        else if (BuildingData != null)
        {
            Init(BuildingData);
        }
    }


    public virtual void Init(BuildingData _BuildingData)
    {
    }


    protected virtual void OnDestroy()
    {
        // if (_construction != null)
        // {
        //     _construction.ConstructionFinishedEvent -= OnConstructionFinished;
        //     _construction.ConstructionCompletedEvent -= OnConstructionCompleted;
        // }

        if (_islandInput != null)
        {
            _islandInput.EnableIslandInteraction(this);
            //islandInput.OnPointerClick -= CloseInfoOverlay;
        }

        if (Building.buildingData != null && Building.buildingData is UpgradeHouse)
            (Building.buildingData as UpgradeHouse).changeStatusBuilding -= ChangeStatusBuilding;
        this.CancelInvoke(OnLongPress);
    }


    #region INTERATIONBUILDINGVIEWWWWWW:::::

    //khi click ở satte nào thì hiện mấy cái gọi ý....popup nhỏ hiện lên::
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        //CHỈ XÉT STATE CONTRUCTIING CÒN STATE KIA THÌ BÊN KIA TEST V KIỂM SOÁT NCH 2 SỰ KIỆN BUILDINGVIEW VÀ FARMVIEW CÓ LIÊN KẾT NHAU THẰNG NÀY XỬ LÍ NÀY THẰNG KIA XỬ LÍ KIA
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Sau khi 0.35s thì invoke thwafng onlongpress
        this.Invoke(OnLongPress, 0.35f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.CancelInvoke(OnLongPress);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        this.CancelInvoke(OnLongPress);
    }

    //Truyền building cho thằng popupmanager yêu ầu popup hiện lên
    //ẤN LONG ĐỂ HIỆN EDIT
    //VỚI CÁC NHÀ LEVEL THÌ OVERRIDE NÓ Ở BÊN KIA VÀ CHỈ LEVEL 1 TRỞ ĐI MỚI CHO MOVE VÀ CÓ THỂ KÈM THEO TRẠNG THÁI ĐANG XÂY DỰNG K THỂ MOVE:::
    protected virtual void OnLongPress()
    {
        if (Building != null && !PopupManagerView.Instance.PopupManager.IsShowingPopup &&
            Building.BuildingProperties.Moveable)
        {
            PopupManagerView.Instance.PopupManager.RequestPopup(new BuildConfirmPopupRequest(Building, SpriteRenderer));
        }
        //tạm bỏ qua state coi là state ok//mở popup iển hiện vụ moving satte bên kia
        // if (Building != null && !_construction.PopupManager.IsShowingPopup && Building.BuildingProperties.Moveable &&
        //     _construction.State == ConstructionState.Completed && Building.BuildingProperties.Moveable)
        // {
        //     _construction.PopupManager.RequestPopup(new BuildConfirmPopupRequest(Building, SpriteRenderer));
        // }
    }

    public SpriteRenderer GetSpriteRenderer()
    {
        return spriteRenderer;
    }

    #endregion


    #region DRAGCODE:::::::::

    // private void UpdateBuildingStateLook()
    // {
    //     switch (Building.Construction.State)
    //     {
    //         case ConstructionState.Constructing:
    //
    //             //nếu là loại đang contructing thì nó màu xám::
    //             SpriteRenderer.color = GreyScaleTintColor;
    //             break;
    //         default:
    //             SpriteRenderer.color = Color.white;
    //             break;
    //     }
    // }
    //BỎ QUA TRẠNG THÁI XÂY DỰNG KẾT THÚC SAU TIME NGƯỢC
    // private void OnConstructionFinished(ContructionSiteStating constructionSite)
    // {
    //     constructionSite.ConstructionFinishedEvent -= OnConstructionFinished;
    //     //UPDATE HÌNH ẢNH XÁM.....THÀNH MÀU////
    //     //UpdateBuildingStateLook();
    //     //SAU ĐÓ THÌ NGHE SỰ KIỆN COMPLETE NHƯNG KHẢ NĂNG BỊ LỖI DO INVOKE SỰ KIỆN Ở ĐÂY:::
    //     constructionSite.ConstructionCompletedEvent += OnConstructionCompleted;
    // }

    //CHẠY COMPLETED KHI XONG KHI MÀ VẬT LIỆU YÊU CẦU COMPELTED L TRỐNG
    //TRẠNG THÁI SANG HOÀN HÀNH TOÀN BỘ THÌ SẼ NHƯ SAU CÁI NÀY CHẮC  CHẠY VÀO VÌ LỖI DELAY KHUNG HÌNH::
    // private void OnConstructionCompleted(ContructionSiteStating constructionSite)
    // {
    //     constructionSite.ConstructionCompletedEvent -= OnConstructionCompleted;
    //     //UpdateBuildingStateLook();
    //     InitBuildingBehaviour();
    // }

    #endregion
}