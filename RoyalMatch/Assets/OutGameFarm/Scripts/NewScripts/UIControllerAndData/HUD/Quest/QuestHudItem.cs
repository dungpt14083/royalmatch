using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening.Core;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class QuestHudItem : MonoBehaviour
{
    public Transform Root;

    [SerializeField] private float MoveSpeedMultiplier;
    [SerializeField] private float MoveLeftDistance;
    [SerializeField] private float MinMagnitude;
    [SerializeField] private float RotationDegree;
    [SerializeField] private GameObject ProgressIconGO;
    [SerializeField] private Transform ContentTransform;
    [SerializeField] private TextMeshProUGUI QuestStatusText;
    //[SerializeField] private TranslatedText QuestStatusTranslatedTextText;
    [SerializeField] private Image QuestIcon;
    //CHẮC FRONT PANEL
    [SerializeField] private Image QuestPanelImage;
    [SerializeField] private Button button;
    [SerializeField] private Canvas Canvas;
    [SerializeField] private CanvasGroup CanvasGroup;
    [SerializeField] private Animator Animator;

    //PRIVATE PROPERTIES:::
    //ODER ỦA THẰNG TEXT VÀ THẰNG NÀY ĐỂ KHI MÀ ẤN CHI HOLD NÓ VÀ POPUP để hiện nó lên trền cùng 
    private int _overContextCanvasSortingOrder = 99;
    private int _overContextOnFinishCanvasSortingOrder = 99;
    private int _behindContextCanvasSortingOrder = 99;

    private UserQuestData _questData;
    private bool _openWhenInPosition;

    //Hijue ứng cho việc currency chạy
    //private CurrencyCollectTweenManager _currencyCollectTweenManager;
    //private Hud _hud;


    public void SetRootParent(RectTransform questFloatArea)
    {
        this.Root.SetParent(questFloatArea);
    }


    public void ResetHighEnergyState()
    {
    }


    public void SetRootActivatePosition()
    {
        //throw new System.NotImplementedException();
    }


    #region INITFORBUTTON AND PRESSED SHOW CONEXTPANEL

    //KHI CLICK VÀO ICON CỦA QUEST THÌ SHOW INFO CỦA QUEST::
    public void OnClick()
    {
        if (QuestHudItemManager.Instance.IsInScreen() == false)
        {
            return;
        }

        if (QuestContextPanel.Instance.IsClosing == true)
        {
            return;
        }

        Refresh();
        Show();
    }


    public void SetQuestData(UserQuestData questData)
    {
        _questData = questData;
    }


    //BÊN NGOÀI GỌI VÀO HOẶC CLICK VÀO SHOWW LÊN CÁI QUESTCONEXT:::
    public void Show()
    {
        if (QuestHudItemManager.Instance.IsInScreen())
        {
            this.Canvas.sortingOrder = this._overContextCanvasSortingOrder;
            QuestContextPanel.Instance.Show(_questData, 0, this);
            return;
        }

        _openWhenInPosition = true;
    }

    #endregion


    #region CHƯA XÁC ĐỊNH:::::

    public bool IsCompleted()
    {
        if (_questData != null)
        {
            return _questData.Completed;
        }

        return false;
    }


    //CHI HIỆU ỨNG ĐỂ SAU CHO KHI MÀ CÓ THAY ĐỔI DATA ENERRY???HƠI LẠ
    // private void OnCurrencyChange(CurrencyChangeEvent.Data data)
    // {
    //     CheckHighEnergy();
    // }
    public void CheckHighEnergy()
    {
        //CÁI NÀY LÀ ANIMATION TẠM THỜI BỎ QUA KHÔNG XSET
    }


    //CHO MỘT CÁI QUEST HOÀN TOÀN MỚI THÌ ĐÁNH DẤU ICON:::
    public void SetNewState()
    {
        this.ProgressIconGO.SetActive(value: false);
        //CÁI TEXT Ở DƯỚI ĐẤY CỦA ICON LÀ COMPLETED NEW BLA BLA Ở ĐÂY
        QuestStatusText.text = "new";
        QuestStatusText.gameObject.SetActive(true);
    }

    public void Refresh()
    {
        CheckHighEnergy();
        QuestInfo questInfo = FarmQuestManagerView.Instance.QuestInfoCollection.GetQuestInfo(_questData.Id);
        
        
        //IConid ở trong quest + với 1 csai lấy từ atlast nào nữa:::::
        //
        //TẠO ATLAST ĐLAASLAY RA NGOÀI INIT VÀO TRONG NÀY 
        QuestIcon.sprite = null;
        
        
        
        
        this.SetNormalState();
        if (this._questData.New == true)
        {
            this._questData.New = this;
            this.SetNewState();
        }

        if (this._questData.Completed == false)
        {
            return;
        }

        this.SetCompleteState();

        //
    }

    private void SetNormalState()
    {
        QuestPanelImage.sprite = null;
        ProgressIconGO.gameObject.SetActive(false);
        QuestStatusText.gameObject.SetActive(false);
    }


    public void SetCompleteState()
    {
        //GASNANHR CHO THẰNG QUEST PANEL XANH COMPLETE
        QuestPanelImage.sprite = null;
        this.ProgressIconGO.SetActive(value: false);
        //SET TEXT TIẾP
        //show text status là complete hay gì và vật liệu màu chữ::::nó tự set chữ cho thằng textt bwafng script luôn
        //this.QuestStatusTranslatedTextText.SetKey(key:  212964672);
        //this.QuestStatusText.fontMaterial = 2621443;
        QuestStatusText.text = "Completed";
        QuestStatusText.gameObject.SetActive(value: true);
    }


    public void SetQuestActivateState()
    {
        this.SetNewState();
        this.CheckHighEnergy();
    }

    public void SetQuestCompleteState()
    {
        this.SetCompleteState();
    }

    #endregion


    //SUY NGHĨ CÓ NÊN POPUP KHÔNG CHẮC ĐỂ RIÊNG NÓ K CÓ ĐỂ POPUP TẠM K ĐỂ NÓ LÀ POPUP NÓ CHỈ LÀ INFO THÔNG TIN MISSION:::

    #region TODOQUEST::::

    private void OnEnable()
    {
        Quaternion quaternion = Quaternion.Euler(x: 0, y: 0, z: RotationDegree);
        //content là cái nó lệch chút so với backpanel
        this.ContentTransform.rotation = quaternion;
        this.Root.gameObject.SetActive(value: true);
        this.CheckHighEnergy();
    }

    private void OnDisable()
    {
        this.Root.gameObject.SetActive(value: false);
        _questData = null;
    }

    private void Awake()
    {
        //NGHE CÁC TÍN HIỆU CỦA THẰNG QUEST VẬY THÌ PHẢI ONENABLE ONDISABLE CHO CÁC SỰ KIỆN QUEST :::

        //NÚT CLASCK THÌ SHOW LÊN QUEST CONTEXT PANEL::
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(Show);
    }

    private void Start()
    {
        QuestManagerSignals.QuestCompleteEventSignal.AddListener(OnQuestCompleted);
        QuestManagerSignals.QuestTaskCompleteEventSignal.AddListener(OnQuestTaskComplete);
        QuestManagerSignals.QuestFinishEventSignal.AddListener(OnQuestFinished);
    }

    private void OnDestroy()
    {
        QuestManagerSignals.QuestCompleteEventSignal.RemoveListener(OnQuestCompleted);
        QuestManagerSignals.QuestTaskCompleteEventSignal.RemoveListener(OnQuestTaskComplete);
        QuestManagerSignals.QuestFinishEventSignal.RemoveListener(OnQuestFinished);
    }

    #endregion


    #region TODOCODEEVENTSIGNAL

    private void OnQuestCompleted(QuestEventData data)
    {
        if (_questData==null)return;
        if (data.QuestData.Id != this._questData.Id) return;
        this.SetCompleteState();
    }


    //HIỆU ỨNG MỜ DẦN ICON NHƯNG TÍNH SAU:::
    private void OnQuestFinished(UserQuestData data)
    {
        if (_questData==null)return;
        //     if (data.Id != this._questData.Id) return;
        //     
        //     //LY QUESTINFO RA NGOÀI TỪ THẰNG ID LẤY QUÊN QUESTMANAAGER
        //     //LẤY RA THẰNG IDDĐ
        //     FarmQuestManagerView.Instance.QuestInfoCollection.GetQuestInfo(data.Id);
        //     //CHẠY TWEEN LÀM Mờ 
        //     TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTweenModuleUI.DOFade( this.CanvasGroup, endValue:  0,
        //         duration:  1.0f);
        //     DG.Tweening.TweenCallback val_5 = new DG.Tweening.TweenCallback();
        //     object val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<System.Object>(t:  this.CanvasGroup, action:  212140032);
        //     

        // if (data.Id == _questData.Id)
        // {
        //     QuestInfo questInfo = FarmQuestManagerView.Instance.QuestInfoCollection.GetQuestInfo(data.Id);
        //
        //     if (questInfo != null)
        //     {
        //         DG.Tweening.Tween fadeTween = DG.Tweening.DOTweenModuleUI.DOFade(CanvasGroup, 0, 1);
        //         fadeTween.onComplete += () =>
        //         {
        //             Complete();
        //             //int xpRewardAmount = _questService.QuestInfoCollection.GetXpRewardAmount();
        //             //int remainingXp = _mapLevelService.GetRemainingXpForNextLevel();
        //
        //             bool levelUp = false; //xpRewardAmount >= remainingXp;
        //
        //             //cái này show có 
        //             //_questContextPanel.Show(data, levelUp, _questHudItemManager);
        //         };
        //     }
        //
        //     Refresh();
        // }
    }

    //khi complete thì sẽ ????
    private void Complete()
    {
        this.Root.localScale = Vector3.one;
        this.CanvasGroup.alpha = Vector3.one.x;
        this.button.enabled = true;
    }


    private void OnQuestTaskComplete(QuestTaskProgressEventData data)
    {
        if (_questData==null)return;
        if (this.gameObject.activeInHierarchy == false) return;
        if (data.QuestData.Id != this._questData.Id) return;
        this.ShowTaskCompleteBanner();
    }

    private void ShowTaskCompleteBanner()
    {
        //khi cái info kia hiện thì sẽ tắt đi không có showtask complete:::
        if (QuestContextPanel.Instance.gameObject.activeInHierarchy) return;
        //chắc là frontpanel chắc đổi ảnh cho nó:::
        //this.QuestPanelImage.sprite;
        this.ProgressIconGO.SetActive(value: true);

        //ĐỂ NÓ VỀ 0,0,0 CHỨ K CHO NGHIÊNG NỮA:::
        //show text status là complete hay gì và vật liệu màu chữ::::nó tự set chữ cho thằng textt bwafng script luôn
        //this.QuestStatusTranslatedTextText.SetKey(key:  212964672);
        //this.QuestStatusText.fontMaterial = 2621443;
        //this.QuestStatusText.gameObject.SetActive(value:  true);
    }
    

    #endregion


    public void OnContextPanelHide()
    {
    }
}