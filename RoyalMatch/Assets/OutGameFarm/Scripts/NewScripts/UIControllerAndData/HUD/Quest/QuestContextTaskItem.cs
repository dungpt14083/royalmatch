using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class QuestContextTaskItem : MonoBehaviour
{
    [SerializeField] private List<Sprite> BackgroundImageSprites;
    [SerializeField] private Image TaskIcon;

    [SerializeField] private Image TaskIconBackgroundImage;

    //[SerializeField] private RectTransform LeftArea;
    [SerializeField] private TMP_Text ProgressText;
    [SerializeField] private GameObject CompleteTextGO;
    [SerializeField] private TMP_Text DescriptionText;
    [SerializeField] private TMP_Text CompletedDescriptionText;
    [SerializeField] private Button ForwardButton;
    [SerializeField] private Button InfoButton;
    [SerializeField] private RuinQuestInfoPanel RuinQuestInfoPanel;

    private QuestInfo _questInfo;
    private TaskInfo _taskInfo;
    private int _taskIndex;
    private int _progress;

    private void Start()
    {
        //KHI MÀ ẤN VÀO ĐỂ MÀ ĐIỀU HƯƠG TỚI NƠI KIẾM HOẶC LÀ INFO MATION KHI MÀ RUIN:::
        this.ForwardButton.onClick.AddListener(Forward);
        this.InfoButton.onClick.AddListener(ShowRuinQuestInfo);
    }

    //ĐI TỚI THẰNG nhiệm vujchir hướng::::
    private void Forward()
    {
        //Có một cái ObjectiveFởardController:==>>>
        //this._objectiveForwardController.Forward(objective:  this._taskInfo.Objective);
    }

    [Button]
    //cái này là khi ở đảo khác và hiện lên thông tin ruin thay vì phải chỉ vào nhà ấn khi ở cùng đảo::::
    private void ShowRuinQuestInfo()
    {
        //Ruinqest ìnopanel nếu đang hide thì sẽ 
        if (RuinQuestInfoPanel.gameObject.activeInHierarchy)
        {
            RuinQuestInfoPanel.Hide();
        }

        RuinQuestInfoPanel.SetQuestInfo(taskInfo: this._taskInfo);
        //RuinQuestInfoPanel val_5 = this.RuinQuestInfoPanel.SetReferenceRectTransform(referenceRectTransform:  0);
        this.RuinQuestInfoPanel.Show();
    }

    private bool IsTaskCompleted()
    {
        return this._progress >= this._taskInfo.Amount;
    }

    
    
    
    
    //Truyền questinfo và tkinfo và taskindex và process vào để chạy 
    public void SetInfo(QuestInfo questInfo, TaskInfo taskInfo, int taskIndex, int progress)
    {
        _questInfo = questInfo;
        _taskInfo = taskInfo;
        _taskIndex = taskIndex;
        _progress = progress;

        //ĐẢM BẢO OBJECTTIVESERRVICE OK
        //nếu mà objectservice cho việc điều hướng nhiệm vụ mà null thì sẽ chạy awake 1 lần để init 
        // if (objectiveManager==null)
        // {
        //     Awake();
        // }

        //các taskicon các thứ lấy ở trong 
        this.TaskIcon.sprite = ObjectiveManager.Instance.GetSprite(_taskInfo.Objective.ObjectiveType,
        _taskInfo.Objective.IdInType, _taskInfo.Amount);

        
        //ĐOẠN NÀY ĐƯA VÀO TRONG NÀY THÔI CHỨ CHƯA SETACTIVE ::::
        //Cả truyền vô để thay thế đoạn mô tả:::
        
        DescriptionText.text = ObjectiveManager.Instance.GetTranslationKey(_questInfo, _taskInfo, _taskIndex, null);
        //CompletedDescriptionText.text=


        if (_progress < _taskInfo.Amount)
        {
            ForwardButton.gameObject.SetActive(true);
            //TaskIconBackgroundImage.sprite = null;
            CompleteTextGO.gameObject.SetActive(false);
            DescriptionText.gameObject.SetActive(true);
            CompletedDescriptionText.gameObject.SetActive(false);
        }
        else
        {
            //TaskIconBackgroundImage.sprite = null;
            ForwardButton.gameObject.SetActive(false);
            _progress = _taskInfo.Amount;
            DescriptionText.gameObject.SetActive(false);
            CompletedDescriptionText.gameObject.SetActive(true);
            this.CompleteTextGO.SetActive(value: true);
        }

        CheckInfoButton(_taskInfo);
        ProgressText.text = _progress.ToString() + "/" + _taskInfo.Amount;
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    //ĐIỀU HƯỚNG TỚI MẤY CÁI XÂY NHÀ CỦA CẦN VẬT LIỆU
    private void CheckInfoButton(TaskInfo task)
    {
        InfoButton.gameObject.SetActive(false);
        if (_progress > _taskInfo.Amount)
        {
            return;
        }

        //NẾU  NHƯU MÀ TASK KHÔNG PHẢI 11 12 HOẶ LÀ 13 TỨC LÀ LOẠI:
        //BUID RUIN, RUINEXACT , STAGERUIN:::
        if (task.Objective.ObjectiveType != ObjectiveType.BuildRuin &&
            task.Objective.ObjectiveType != ObjectiveType.BuildRuinExact &&
            task.Objective.ObjectiveType != ObjectiveType.StageRuin)
        {
            return;
        }
        
        this.InfoButton.gameObject.SetActive(value: true);

        //ĐOẠN DƯỚI NÀY LIÊN QUAN THỦ THUẬT ACTIVE RUIN ĐỂ ẤN VÀO THÌ NTN NTN::::
        
        
        
        //ấy thằng ADVANDE LẤY THWAFNG RUIN RA ĐỂ HIỂN THỊ LÊN YÊU CẦU VẬT LIỆU :::
        //FarmMatch.Map.Ruin val_4 = val_11.GetActiveRuinByPrefabId(buildingPrefabId:  task.Objective.IdInType);
        // Building building = null;
        // if (building == null)
        // {
        //     return;
        // }

        //VỚI THẰNG NÀY sẽ lấy vbowri elementid nếu type 
        //LẤY BẰNG 2 CÁI NẾU CÓ THÌ K RETURN VÀ CHẠY VỀ BÊN DƯI ĐỂ NÚT INFOBUTTON SÁNG LN 
        // this.InfoButton.gameObject.SetActive(value: true);
        // this.ForwardButton.gameObject.SetActive(value: false);
    }
}