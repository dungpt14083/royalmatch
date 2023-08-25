using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

public class TutorialDirectorView : MonoBehaviour
{
    public enum PointerType
    {
        ShopMenu = 0,
        ShopMenuResidentialCategory = 1,
        BuildingShopPopupFirstShopItem = 2,
        BuildConfirmPopupOKButton = 3,
        SpeedupPopupButton = 4,
    }


    //KỂU TEXT VỊ TRÍ NCH L Ở GIỮA MÀN HAY GÌ::
    public enum TextPositionType
    {
        CenterScreen = 0,
        TopCenterScreen = 1,
        AdvisorDefault = 2
    }

    //KIỂU MASK HƯỚNG DẪN BẤM VÀO NÚT NÀO NÚT NÀO:
    //SHOPMENU+SHOP RESIDENTIAL + SHOPITEMBUILDING+BUILDING COMFIM+...VÀ CÁC SHOP ĐẶC BIỆT
    public enum MaskType
    {
        ShopMenu = 0,
        ShopMenuResidentialCategory = 1,
        BuildingShopPopupFirstShopItem = 2,
        BuildConfirmPopupOKButton = 3,
    }

    //KIỂU SWIPING POINTER
    public enum SwipingPointerType
    {
        Dummy = 0
    }

    //SỰ KỆN KHI MÀ ẤN MÀN HÌNH THÌ NEXT STEP::
    public delegate void ScreenClickedEventHandler();

    //CLASS DATA CHO CON TRỎ CÓ VỊ TRÍ KIỂU CON TRỎ SẼ CÓ V TRÍ TRỎ....THEO TUTORIAL::
    [Serializable]
    private class Pointer
    {
        [SerializeField] private PointerType type;
        [SerializeField] private Vector3 position;

        //ngoài vị trí ra còn anchomin max???
        [SerializeField] private Vector2 anchorMin = new Vector2(0.5f, 0.5f);
        [SerializeField] private Vector2 anchorMax = new Vector2(0.5f, 0.5f);
        [SerializeField] private float rotation;

        public PointerType Type
        {
            get { return type; }
        }

        public Vector3 Position
        {
            get { return position; }
        }

        public Vector2 AnchorMin
        {
            get { return anchorMin; }
        }

        public Vector2 AnchorMax
        {
            get { return anchorMax; }
        }

        public float Rotation
        {
            get { return rotation; }
        }
    }

    //Setting vị trí cho text Serializable::
    [Serializable]
    private class TextPosition
    {
        [SerializeField] private TextPositionType type;
        [SerializeField] private Vector3 position;
        [SerializeField] private Vector2 anchorMin = new Vector2(0.5f, 0.5f);
        [SerializeField] private Vector2 anchorMax = new Vector2(0.5f, 0.5f);

        public TextPositionType Type
        {
            get { return type; }
        }

        public Vector3 Position
        {
            get { return position; }
        }

        public Vector2 AnchorMin
        {
            get { return anchorMin; }
        }

        public Vector2 AnchorMax
        {
            get { return anchorMax; }
        }
    }

    //class seri cho việc mask ở đâu:::setting
    [Serializable]
    private class MaskRect
    {
        [SerializeField] private MaskType type;
        [SerializeField] private Rect rect;
        [SerializeField] private Vector2 anchorMin = new Vector2(0.5f, 0.5f);
        [SerializeField] private Vector2 anchorMax = new Vector2(0.5f, 0.5f);

        public MaskType Type
        {
            get { return type; }
        }

        public Rect Rect
        {
            get { return rect; }
        }

        public Vector2 AnchorMin
        {
            get { return anchorMin; }
        }

        public Vector2 AnchorMax
        {
            get { return anchorMax; }
        }
    }

    //swipPointer vuốt từ đâu tới đâu chỉ dành cho farm nên mỗi một cái
    [Serializable]
    private class SwipingPointer
    {
        [SerializeField] private SwipingPointerType type;
        [SerializeField] private Vector3 position;
        [SerializeField] private Vector2 anchorMin = new Vector2(0.5f, 0.5f);
        [SerializeField] private Vector2 anchorMax = new Vector2(0.5f, 0.5f);
        [SerializeField] private float rotation;
        [SerializeField] private float swipeLength;
        [SerializeField] private bool usesSafeArea;

        public SwipingPointerType Type
        {
            get { return type; }
        }

        public Vector3 Position
        {
            get { return position; }
        }

        public Vector2 AnchorMin
        {
            get { return anchorMin; }
        }

        public Vector2 AnchorMax
        {
            get { return anchorMax; }
        }

        public float Rotation
        {
            get { return rotation; }
        }

        public float SwipeLength
        {
            get { return swipeLength; }
        }
    }

    public event ScreenClickedEventHandler ScreenClickedEvent;

    //DANH SÁCH CÁC VIEWTUTORIAL:::
    [SerializeField] private WelcomeTutorialView gameStartTutorialView;

    //Camera cho thế giới và camera UI
    [SerializeField] private Camera worldCamera;
    [SerializeField] private Camera uiCamera;

    //CÁC GAMEOBJECT PHỤC VỤ CHO VIỆC TRỎ MASK TEXT:::
    [SerializeField] private GameObject clickHandler;
    [SerializeField] private TutorialPointerView pointer;
    [SerializeField] private TutorialMaskView mask;
    [SerializeField] private TutorialTextBallonView viewBalloonSubCharacter;
    [SerializeField] private TutorialMainCharacterView viewMainCharacter;
    [SerializeField] private TutorialQuitButtonView quitTutorialButton;
    [SerializeField] private TutorialSwipingPointerView swipingPointer;

    //LIST TRIỂN KHAI VỊ TRÍ CHO TỪNG LOẠI CHUỘT LOẠI TEXT LOẠI MASK
    [SerializeField] private List<Pointer> pointers;
    [SerializeField] private List<TextPosition> textPositions;
    [SerializeField] private List<MaskRect> maskRects;
    [SerializeField] private List<SwipingPointer> swipingPointers;

    //cả phần view và phần tutorial director
    private TutorialDirector _tutorialDirector;
    private GridIgridObjectView _gridIgridObjectView;

    public Camera UICamera
    {
        get { return uiCamera; }
    }

    public Camera WorldCamera
    {
        get { return worldCamera; }
    }

    public GridIgridObjectView GridIgridObjectView
    {
        get { return _gridIgridObjectView; }
    }

    public RectTransform RectTransform { get; private set; }

    public PopupManagerView PopupManagerView { get; private set; }

    public PreBuilderView BuilderView { get; private set; }

    //SẼ INVOKE SỰ KIỆN TT CẢ MỌI NƠI VIEWTUTORIAL NGHE VÀ XỬ LÍ ::
    private void FireScreenClickedEvent()
    {
        if (this.ScreenClickedEvent != null)
        {
            this.ScreenClickedEvent();
        }
    }

    private void Awake()
    {
        RectTransform = (RectTransform)base.transform;
        Clear();
    }

    public void Init(TutorialDirector tutorialDirector, PopupManager popupManager, GridIgridObjectView gridIgridObjectView,
        PopupManagerView popupManagerView,
        PreBuilderView builderView /*, FeatureFlagsProperties featureFlagsProperties*/)
    {
        _tutorialDirector = tutorialDirector;
        _gridIgridObjectView = gridIgridObjectView;
        PopupManagerView = popupManagerView;
        BuilderView = builderView;
        //_featureFlagProperties = featureFlagsProperties;
        _tutorialDirector.TutorialStartedEvent += OnTutorialStarted;
        _tutorialDirector.TutorialFinishedEvent += OnTutorialFinished;
        _tutorialDirector.TutorialEndedEvent += OnTutorialEnded;
        _tutorialDirector.TutorialResetEvent += OnTutorialReset;
        if (_tutorialDirector.CurrentTutorial != null)
        {
            OnTutorialStarted(_tutorialDirector.CurrentTutorial);
        }

        PopupManagerView.PopupHiddenEvent += OnPopupHidden;
        quitTutorialButton.Init(_tutorialDirector, popupManager);
    }

    private void Deinit()
    {
        if (PopupManagerView != null)
        {
            PopupManagerView.PopupHiddenEvent -= OnPopupHidden;
            PopupManagerView = null;
        }

        if (_tutorialDirector != null)
        {
            _tutorialDirector.TutorialStartedEvent -= OnTutorialStarted;
            _tutorialDirector.TutorialFinishedEvent -= OnTutorialFinished;
            _tutorialDirector.TutorialEndedEvent -= OnTutorialEnded;
            _tutorialDirector.TutorialResetEvent -= OnTutorialReset;
            _tutorialDirector = null;
        }
    }

    private void OnTutorialStarted(TutorialFarm tutorial)
    {
        switch (tutorial.Type)
        {
            case TutorialType.WelcomeTutorial:
                gameStartTutorialView.Init(this, (WelcomeTutorial)tutorial);
                break;
            // case TutorialType.FirstResidentialBuildingTutorial:
            //     _firstResidentialBuildingTutorialView.Init(this, (FirstResidentialBuildingTutorial)tutorial);
            //     break;
            default:
                break;
        }
    }

    //KHI MÀ ẤN CLICKED VÀO MÀN HÌNH THÌ SẼ:::CHẠY VÀO NGƯỜI CHƠI TẮT NÓI NẾU NÓ ĐANG NÓI::
    public void OnScreenClicked()
    {
        //TẮT ANIMATION NÓI NẾU TẠM K CÓ THÌ PHÁT SỰ KIỆN THÔI::
        FireScreenClickedEvent();
    }

    private void DeinitTutorialView(TutorialFarm tutorial)
    {
        switch (tutorial.Type)
        {
            case TutorialType.WelcomeTutorial:
                gameStartTutorialView.Deinit();
                break;
            default:
                Debug.LogWarningFormat("Missing Tutorial '{0}' View Deinit", tutorial.Type);
                break;
        }
    }

    #region ENDTUTORIALANDCLEAR::

    public void Clear()
    {
        HideMask();
        HidePointer();
        HideTextBalloon();
        HideCityAdvisor();
        HideSwipingPointer();
        ToggleClickHandler(false);
    }

    public void HideMask()
    {
        mask.Hide();
    }

    public void HidePointer()
    {
        pointer.Hide();
    }

    public void HideTextBalloon()
    {
        ToggleClickHandler(false);
        viewBalloonSubCharacter.Hide();
    }

    public void ToggleClickHandler(bool enabled)
    {
        clickHandler.SetActive(enabled);
    }

    public void HideCityAdvisor()
    {
        ToggleClickHandler(false);
        viewMainCharacter.Hide();
    }

    public void HideSwipingPointer()
    {
        swipingPointer.Hide();
    }

    #endregion

    #region TODOVIEWUITUTORIAL

    //SHOW POINTER CON CHUỘT::
    public void ShowPointer(PointerType pointerType)
    {
        Pointer pointer = pointers.Find((Pointer x) => x.Type == pointerType);
        if (pointer == null)
        {
            Debug.LogWarningFormat("Missing pointer type '{0}' settings.", pointerType);
            return;
        }

        PointTo(pointer.Position, pointer.AnchorMin, pointer.AnchorMax, pointer.Rotation);
    }

    public void PointTo(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, float rotation)
    {
        pointer.Show(anchoredPosition, anchorMin, anchorMax, rotation);
    }


    //show mask typw với tìm trong list mask
    public void ShowMask(MaskType maskType, bool clickable)
    {
        MaskRect maskRect = maskRects.Find((MaskRect x) => x.Type == maskType);
        if (maskRect == null)
        {
            Debug.LogWarningFormat("Missing mask rect type '{0}' settings.", maskType);
            return;
        }

        ShowMask(maskRect.Rect, maskRect.AnchorMin, maskRect.AnchorMax, clickable);
    }

    public void ShowMask(Rect rect, Vector2 anchorMin, Vector2 anchorMax, bool clickable)
    {
        mask.Show(rect, anchorMin, anchorMax, clickable);
    }

    //SHOW HỘI THOẠI VỚI NHÂN VẬT CHÍNH::
    public void ShowCityAdvisor(TextPositionType textType, string text, bool flip = false)
    {
        TextPosition textPosition = textPositions.Find((TextPosition x) => x.Type == textType);
        if (textPosition == null)
        {
            Debug.LogWarningFormat("Missing text balloon type '{0}' settings.", textType);
        }
        else
        {
            ShowCityAdvisor(textPosition.Position, textPosition.AnchorMin, textPosition.AnchorMax, text, flip);
        }
    }

    public void ShowCityAdvisor(Vector3 anchoredPosition, Vector2 anchorMin, Vector2 anchorMax, string text, bool flip)
    {
        ToggleClickHandler(true);
        viewMainCharacter.SetFlipped(flip);
        viewMainCharacter.Show(anchoredPosition, anchorMin, anchorMax, text);
    }

    //TẠM THỜI XÉT VIỆC VUỐT Ở TỌA ĐỘ THẾ GIỚI::TRƯỜNG HỢP VUỐT KIA BỎ QUA TẠM
    public void SwipingPointTo(Vector3 worldPosition, float rotation, float swipeLength)
    {
        swipingPointer.Show(worldPosition, rotation, swipeLength);
    }

    public Vector3 GridPointToWorldVector(GridPoint gridPoint)
    {
        return _gridIgridObjectView.GridPointToWorldVector(gridPoint);
    }

    #endregion

    //NGHE SỰ KIỆN KHI MÀ kết thú TUTORIAL PHẢI DỌN TRÁNH NÓ INVOKE SỰKIJIEEJN NGHE NỮA...::
    private void OnTutorialEnded(TutorialFarm tutorial)
    {
        DeinitTutorialView(tutorial);
        Clear();
    }

    private void OnTutorialFinished(TutorialFarm tutorial)
    {
        DeinitTutorialView(tutorial);
        Clear();
    }

    private void OnTutorialReset(TutorialFarm tutorial)
    {
        DeinitTutorialView(tutorial);
        Clear();
    }

    //KHI ẤN POPUP THÌ THỬ CHẠY TUTORIAL KHÁC NHƯNG CÁI NÀY BỎ QUA TẠM::
    private void OnPopupHidden(Popup popup)
    {
        if (!_tutorialDirector.PopupManager.IsShowingPopup)
        {
            _tutorialDirector.TryStartingATutorial();
        }
    }

    [Button]
    public void TryStartTutorial(TutorialType type)
    {
        _tutorialDirector.TryStartingTutorial(type);
    }
}