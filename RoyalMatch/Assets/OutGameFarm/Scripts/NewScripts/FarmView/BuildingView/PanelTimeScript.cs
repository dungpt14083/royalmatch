using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PanelTimeScript : MonoBehaviour
{
    public Button btn_CompleteWithDiamond;
    public TMP_Text Txt_CostDiamond;
    public TMP_Text Txt_TimeGrowing;
    public TMP_Text Txt_Name;

    private FarmFieldBuilding _fieldBuilding;
    
    public static PanelTimeScript ActivePopup { get; private set; }

    private void Awake()
    {
        btn_CompleteWithDiamond.onClick.AddListener(CompleteBuy);
    }

    public void Init(int cost,float timeGrowing,string nameBuilding,FarmFieldBuilding farmFieldBuilding)
    {
        SetActive();

        _fieldBuilding = farmFieldBuilding;
        Txt_Name.text = nameBuilding;
        Txt_CostDiamond.text = cost.ToString();
        Txt_TimeGrowing.text = timeGrowing.ToString();
    }

    private void Update()
    {
        if (_fieldBuilding.FieldProcess.RemainingTimeSeconds > 0)
        {
            Txt_TimeGrowing.text = ConvertToTimeFormat(_fieldBuilding.FieldProcess.RemainingTimeSeconds);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
    public static void SetActivePopupInactive()
    {
        if (ActivePopup != null)
        {
            ActivePopup.gameObject.SetActive(false);
            ActivePopup = null;
        }
    }
    public void SetActive()
    {
        SetActivePopupInactive();
        ActivePopup = this;
        this.gameObject.SetActive(true);
    }
    public void Close()
    {
        this.gameObject.SetActive(false);
    }
    public void CompleteBuy()
    {
         _fieldBuilding.FieldProcess.CompleteAction();
    }
    
    private string ConvertToTimeFormat(double time)
    {
        int hours = (int)(time / 3600);
        int minutes = (int)((time % 3600) / 60);
        int seconds = (int)(time % 60);

        string formattedTime = "";

        if (hours > 0)
        {
            formattedTime += hours.ToString("00") + "h:" + minutes.ToString("00") + "m";
        }
        else
        {
            formattedTime += minutes.ToString("00") + "m";
        }

        if (seconds > 0 && hours == 0)
        {
            formattedTime += ":" + seconds.ToString("00") + "s";
        }


        return formattedTime;
    }
}
