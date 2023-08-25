using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RuinQuestInfoPanel : MonoBehaviour
{
    #region REFACTORINGGGGG:::

    [SerializeField] private TextMeshProUGUI BuildNameText;
    [SerializeField] private TextMeshProUGUI StageText;
    [SerializeField] private RectTransform PanelRectTransform;

    [SerializeField] private Button GoButton;

    //[SerializeField] private OutsideTouchButton OutsideTouchButton;
    //ARROWW NÀY KHI LÀ QUÁ DÀI À???
    [SerializeField] private GameObject ArrowUpGO;

    [SerializeField] private GameObject ArrowDownGO;

    //TƯNG CÁI TASK ITEMMMMM::::
    [SerializeField] private List<ColoredCostItem> TaskItems;
    [SerializeField] private float PivotForTopDisplay;
    [SerializeField] private float PivotForBottomDisplay;


    //THÔNG TIN CỦA THẰNG TILEEEE::
    //private TileElementInfoService _tileElementInfoService;


    private TaskInfo _taskInfo;
    private ObjectiveType _objectiveType;
    private int _showFrame;
    private RectTransform _referenceRectTransform;
    private bool hide;

    private void Awake()
    {
    }

    public RuinQuestInfoPanel SetQuestInfo(TaskInfo taskInfo)
    {
        this._taskInfo = taskInfo;
        return this;
    }

    private void Refresh()
    {
        for (int i = 0; i < TaskItems.Count; i++)
        {
            TaskItems[i].gameObject.SetActive(false);
        }

        if (_taskInfo.Objective.ObjectiveType != ObjectiveType.BuildRuinExact) return;
        Building building = TileManagerView.Instance.FindBuildingByElementId(_taskInfo.Objective.IdInType);
        if (building == null) return;
        BuildNameText.text = building.BuildingProperties.BuildingName;
        StageText.text = "Ruin";

        //Chuyển từ currrency sang bên tradeInfo:::từ thằng current:::
        var merterials = building.buildingData.GetMerterials();
        var listBuildingMaterial = merterials.ToTradeInfos();
        for (int i = 0; i < listBuildingMaterial.Count && i < TaskItems.Count; i++)
        {
            TaskItems[i].SetCostInfo(listBuildingMaterial[i]);
            TaskItems[i].gameObject.SetActive(true);
        }
    }


    // public RuinQuestInfoPanel SetReferenceRectTransform(RectTransform referenceRectTransform)
    // {
    //     
    // }

    #region SHOWWWWWWWWWW::::

    public void Show()
    {
        this._showFrame = UnityEngine.Time.frameCount;
        this.gameObject.SetActive(true);
        this.Refresh();
    }

    #endregion


    #region HIDEEEEEEEEEEEE

    //TASK ITEM GỌI TI SHOW:::
    public void Hide()
    {
        if (this.hide == true)
        {
            return;
        }

        if (UnityEngine.Time.frameCount == this._showFrame)
        {
            return;
        }

        this.hide = true;

        HideImmediate();
    }

    public void HideImmediate()
    {
        this.gameObject.SetActive(value: false);
    }

    #endregion

    #endregion
}