using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using GameCreator.Core;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//ĐƯỢC THẢ VÀO MAPSCENE NHƯNG TẠM LÀM MONO ĐỂ CHẠY::::
public class QuestContextPanel : MonoSingleton<QuestContextPanel>
{
    [SerializeField] private Canvas Canvas;
    [SerializeField] private TMP_Text TitleQuest;

    //CHỖ KHI COMPLETEQUEST THÌ NÓ HIỆN LÊN VÀ CÓ REWARD Ở ĐÁY
    [SerializeField] private GameObject CompletedContentGO;
    [SerializeField] private List<QuestContextCompletedQuestTaskItem> CompletedTaskItems;
    [SerializeField] private TMP_Text CompletedQuestText;
    [SerializeField] private GameObject OnGoingContentGO;
    [SerializeField] private List<QuestContextTaskItem> TaskItems;
    [SerializeField] private RuinQuestInfoPanel RuinQuestInfoPanel;

    [SerializeField] private Image BlackBlocker;
    [SerializeField] private Button BlackBlockerButton;


    //2 CÁI NOI SẼ ĐỘNG CHẠM VÀO RECTTRANFORM
    [SerializeField] private RectTransform CompletedContentRectTransform;
    [SerializeField] private RectTransform OnGoingContentRectTransform;

    //2 NƠI HIỆN TEXT CỦA REWARD AMOUNT HƠI LẠ?????
    [SerializeField] private TMP_Text RewardAmountTextCompleted;
    [SerializeField] private TMP_Text RewardAmountTextOnGoing;

    //????????
    [SerializeField] private float _autoCompleteWaitTime = 3f;
    public bool IsActive;
    public bool IsClosing;
    private float yOffSet = 35f;
    private int OnQuestFinishCanvasSortingOrder = 5001;
    private int DefaultSortingOrder = 300;


    //CÁC SỰ KIỆN CHO POPUPSHOWEVENT
    //BACKBUTTON ẤN

    //SỰ KIỆN CỦA THẰNG QUEST TASKPROCESS VÀ SỰ KIỆN QUEST COMPLETE
    //SỰ KIỆN KHI MÀ CUTSCENE START

    private UserQuestData _questData;
    private QuestInfo _questInfo;
    private QuestHudItem _questHudItem;

    private int _showFrame;
    private bool _claimClicked;
    private float _yPosition;

    
    
    
    
    
    
    
    
    
    
    #region AWAKE INIT

    protected override void Awake()
    {
        base.Awake();
        CutSceneSignals.CutSceneStart.AddListener(OnCutsceneStarted);
        QuestManagerSignals.QuestTaskProgressEventSignal.AddListener(OnQuestTaskProgress);
        QuestManagerSignals.QuestCompleteEventSignal.AddListener(OnQuestCompleted);

    }


    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
       
    }

    private void OnDestroy()
    {
        
        CutSceneSignals.CutSceneStart.RemoveListener(OnCutsceneStarted);
        QuestManagerSignals.QuestTaskProgressEventSignal.RemoveListener(OnQuestTaskProgress);
        QuestManagerSignals.QuestCompleteEventSignal.RemoveListener(OnQuestCompleted);
        
    }

    #endregion


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region INITFIRST:::::::::

    
    public void Show(UserQuestData questData, float yPosition, QuestHudItem questHudItem)
    {
        IsClosing = false;
        this.gameObject.SetActive(true);
        this.IsActive = true;
        this.Canvas.sortingOrder = DefaultSortingOrder;
        this._questHudItem = questHudItem;
        this._showFrame = UnityEngine.Time.frameCount;
        this._questData = questData;
        _questInfo = FarmQuestManagerView.Instance.QuestInfoCollection.GetQuestInfo(questData.Id);

        // string questIdText =
        //     $"collection_quest_{_questService.QuestInfoCollection.UnityId}_{_questService.QuestsData.QuestGroup}_name";
        // string questTitle;
        // if (!_translationService.TryGetTranslation(questIdText, out questTitle))
        // {
        //     questTitle = _questService.QuestInfoCollection.UnityId.ToString();
        // }
        //this.Title.SetTranslatedText(questTitle);

        TitleQuest.text = _questInfo.Name;

        //this.CompletedQuestText.SetTranslatedText(questTitle);

        //khi mà quest completed thì sẽ xét như sau 
        if (questData.Completed)
        {
            //VÌ CÓ CUTSCENE THÌ PHẢI MỞ SCENE KIA XONG MỚI CHẠY CUTSCENE 
            
            //NẾU CÓ CUTSCENE HOẶC LÀ TỪ ĐÂY SẼ NẾU K CÓ CTSSCENREWARD THÌ SẼ HIỆN NÚT CLAIMACTION VÀ FINISH QUÉT
            //NẾU KHÔNG CÓ CUTSCENE THÌ SẼ  ĐI TỚI LUÔN
            if (!_questInfo.HasCutsceneReward())
            {
                this.ClaimAction();
            }
            //ĐOẠN NÀY BỎ QUAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA CHO LOAD SCENE
            //NẾU CÓ CUTSCENE THÌ PHẢI XÉT NỮA fINISHREQUIERENT 
            else
            {
                //NẾU KHÔNG THÕA MÃN REQUIREMENT THÌ SẼ CHẠY LẤY REQUIREMENT DẠNG TYPE LÀ 11 VÀ LOAD ADVENTYRE CÓ CALLBACL CALIM ACTION 
                if (!RequirementManager.Instance.IsRequirementsProvided(_questInfo.FinishRequirements))
                {
                    //....
                }
                //TRƯỜNG HỢP MÀ ĐẠT ĐƯỢC REQUIREMENT THÌ CHẠY CLAIMACTION VÀ CHẠY CUTSCENE NHƯ THƯỜNG 
                else
                {
                    this.ClaimAction();
                }
            }
        }
        
        
        Color color = Color.black;
        color.a = 0.5f;
        UnityEngine.Events.UnityAction onClickBlackBlocker = new UnityEngine.Events.UnityAction(Hide);
        this.ShowBlocker(color, onClickBlackBlocker);
        this.RefreshContent();
    }

    #endregion


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region SHOWWWWWWWWW

    public void ShowBlocker(UnityEngine.Color color, UnityEngine.Events.UnityAction onClickBlackBlocker)
    {
        BlackBlockerButton.onClick.RemoveAllListeners();
        BlackBlockerButton.onClick.AddListener(onClickBlackBlocker);
        this.BlackBlocker.color = color;
        this.BlackBlocker.gameObject.SetActive(true);
    }

    //Show vị trí và chạy tí animation thôi tạm bỏ qua
    public void ShowContent(UnityEngine.RectTransform content)
    {
    }

    #endregion


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region HIDEEEEEEEEEE

    //CHO ẤN NÚT BACK
    private void OnBackButtonPressed(bool arg0)
    {
        if (!this.gameObject.activeInHierarchy) return;
        Hide();
    }

    public void Hide()
    {
        if (Time.frameCount == this._showFrame)
        {
            return;
        }

        if (IsClosing)
        {
            return;
        }

        IsClosing = true;

        //BẮN SỰ KIỆN CHO QUEST HUDITEM RẰNG CONTEXTPANEL HIDE
        _questHudItem.OnContextPanelHide();
        RuinQuestInfoPanel.HideImmediate();
        this.HideBlocker();
        this.HideContent(OnGoingContentGO.activeInHierarchy
            ? OnGoingContentRectTransform
            : CompletedContentRectTransform);
    }

    //CALLBACK KHI MÀ HIDEFINISH ::::
    //CHỈ KHI MÀ 
    private void OnHideFinish()
    {
        //CompletedContentRectTransform.localScale = Vector3.one;
        //OnGoingContentRectTransform.localScale = Vector3.one;
        //OnGoingContentRectTransform.gameObject.SetActive(false);
        //this.Canvas.sortingOrder = DefaultSortingOrder;
        this.IsActive = false;
        this.IsClosing = false;
        Hide();
        // if (!_claimClicked)
        // {
        //     return;
        // }

        //this._claimClicked = false;
        //KHÔNG CHO MỞ 
        //KHÔNG CHO THAO TÁC NGOẠI TRỪ NHIỆM VỤ:::::hud để:::
        //this._hud.ApplyConfig(config:  val_4);
        FarmQuestManagerView.Instance.FinishQuest(_questData);
    }

    public void HideBlocker()
    {
        this.BlackBlockerButton.onClick.RemoveAllListeners();
        BlackBlocker.gameObject.SetActive(false);
    }

    public void HideContent(UnityEngine.RectTransform content)
    {
        content.gameObject.SetActive(false);
        // DG.Tweening.ShortcutExtensions.DOComplete(content, true);
        // DG.Tweening.ShortcutExtensions.DOScale(content, Vector3.zero, 0.2f)
        //     .OnComplete(() => content.gameObject.SetActive(false));
    }

    #endregion

    
    
    
    
    
    
    
    
    
    
    

    #region EVENTUPDATEQUESTANDTASK::::

    //NGHE SỰ KIỆN PPOPUP NÀO ĐÓ BẬT LÊN TH ẨN CÁI NÀY ĐI:::
    // private void OnPopupShow(BasePopup data)
    // {
    //     this.Hide();
    // }

    private void OnQuestTaskProgress(QuestTaskProgressEventData data)
    {
        if (IsClosing)return;
        if (_questData==null)return;
        if (data.QuestData.Id != _questData.Id)
        {
            return;
        }

        this.RefreshTaskItems();
    }

    //KHI MÀ QUEST HOÀN THÀNH THÌ REFRESH CẢ TOÀN BỘ CÁI POPUP NÀY 
    private void OnQuestCompleted(QuestEventData data)
    {
        if (IsClosing)return;
        if (_questData==null)return;
        if (data.QuestData.Id != this._questData.Id)
        {
            return;
        }

        this.RefreshContent();
    }

    
    //dựa vào quest hoàn thành hay chưa để hiện lên popup nào::
    //ví dụ ở đảo khac complete à mà chưa finish à???::::
    public void RefreshContent()
    {
        bool isQuestCompleted = _questData.Completed;
        OnGoingContentGO.gameObject.SetActive(!isQuestCompleted);
        CompletedContentGO.gameObject.SetActive(isQuestCompleted);

        //LẤY TEXT REWARD RA GÁN CHO THẰNG REWARD AMOUNT
        //ĐẨY VÀO THUI CÒN THẰNG NÀO ACTIVE THÌ THẰNG ĐÓ HIỆN
        RewardAmountTextCompleted.text = "";
        RewardAmountTextOnGoing.text = "";

        if (isQuestCompleted)
        {
            RefreshCompletedQuestTaskItems();
            ShowContent(content: this.OnGoingContentRectTransform);
        }
        else
        {
            RefreshTaskItems();
            ShowContent(content: this.CompletedContentRectTransform);
        }
    }

    
    
    
    
    
    
    
    
    
    //THẰNG PANEL NÀY 
    private void RefreshTaskItems()
    {
        // Hide all task items first
        foreach (var taskItem in TaskItems)
        {
            taskItem.gameObject.SetActive(false);
        }

        //QUESTDATAA:::CHỨA CÁI QUEST GỌI MỞ PANEL NÀY DATA CỦA NÓ 

        for (int i = 0; i < _questData.TaskProgresses.Count; i++)
        {
            if (i < TaskItems.Count)
            {
                // Show the task item and update its information
                var taskItem = TaskItems[i];
                taskItem.gameObject.SetActive(true);
                taskItem.SetInfo(_questInfo, _questInfo.Tasks[i], i, _questData.TaskProgresses[i]);
            }
        }
    }
    
    
    
    
    
    
    
    private void RefreshCompletedQuestTaskItems()
    {
        foreach (var taskItem in CompletedTaskItems)
        {
            taskItem.gameObject.SetActive(false);
        }

        for (int i = 0; i < _questInfo.Tasks.Count; i++)
        {
            TaskInfo taskInfo = _questInfo.Tasks[i];
            if (i < CompletedTaskItems.Count)
            {
                var taskItem = CompletedTaskItems[i];
                taskItem.Init(taskInfo);
                taskItem.gameObject.SetActive(true);
            }
            // else
            // {
            //     // If not, create a new CompletedTaskItem and add it to the CompletedTaskItems list
            //     //taskItem = Instantiate(CompletedQuestTaskItemPrefab, CompletedContentRectTransform);
            //     //CompletedTaskItems.Add(taskItem);
            // }
        }
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #endregion

    
    
    
    
    
    
    
    
    
    
    
    
    
    

    #region FORTUTORIAL::::::::::::

    public UnityEngine.UI.Button GetForwardButtonOfFirstUnfinishedItem()
    {
        return null;
    }

    public UnityEngine.UI.Button GetForwardButtonOfFirstTaskItem()
    {
        return null;
    }

    #endregion

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    #region UNTILS::

    //CLAIM ACTION::::THÌ KHÔNG CẦN CUTSCENE GỌI TỚI THÌ NÓ FINISH 
    private void ClaimAction()
    {
        this._claimClicked = true;
        //SAU KHI NHẬN XONG THÌ BAO NHIÊU LÂU ĐÓ THÌ HIDE CÁI NÀY ĐI
        this.ShowBlocker(Color.black, null);
        TweenCallback onCompleteCallback = new TweenCallback(OnHideFinish);
        DOVirtual.DelayedCall(_autoCompleteWaitTime, onCompleteCallback, false);
    }

    //NGHE SỰ KIỆN CUTSCENE ĐỂ MÀ HIDE ĐI CÁI NÀY
    private void OnCutsceneStarted(Actions cutsecene)
    {
        if (IsClosing)return;
        if (_questData==null)return;
        this.Hide();
    }

    public bool IsShowingCompletedQuest()
    {
        return _questData != null;
    }

    #endregion
}