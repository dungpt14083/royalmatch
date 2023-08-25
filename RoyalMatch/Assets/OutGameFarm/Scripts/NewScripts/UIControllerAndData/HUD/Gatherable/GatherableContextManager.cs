using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

//TƯƠNG TU CÁCH HOẠT ĐỌNG CỦA QUEST TEXT THÌ NÓ CŨNG V::::
public class GatherableContextManager : MonoSingleton<GatherableContextManager>
{
    [SerializeField] private List<GatherableContextStatusPanel> ReservedGatherableContextStatusPanels;
    [SerializeField] private List<GatherableContextStatusPanel> ActiveGatherableContextStatusPanels;
    [SerializeField] private GatherableStatusPanelOutsideClickButton OutsideClickButton;
    private int _showFrame;

    public void Start()
    {
        this.gameObject.SetActive(value: false);
        OutsideClickButton.onClick.AddListener(OnOutsideClick);
    }

    //từ gatherable gọi tới show lên truyền à dạng năng lượng:::
    public void Show(IEnergyConsumer consumer, bool active,Transform pivot)
    {
        this._showFrame = UnityEngine.Time.frameCount;
        //LẤY TỪ TRONG LIST DỰ TRỮ RA NGOÀI::::
        GatherableContextStatusPanel panel =
            ExtensionUtils.Pop<GatherableContextStatusPanel>(list: this.ReservedGatherableContextStatusPanels);
        this.ActiveGatherableContextStatusPanels.Add(item: panel);
        panel.Show(consumer: consumer, active: active, onComplete: null,pivot);
        //this.OutsideClickButton.SkipFrame();
        this.gameObject.SetActive(value: true);
    }


    //ACTIVE GATHERABLE CONTEXT PANEL LÊN  khi click VÀO THÌ set active lên 
    public void SetActivePanel(GatherableContextStatusPanel buildingActivePanel)
    {
        this._showFrame = UnityEngine.Time.frameCount;
        List<GatherableContextStatusPanel> panels = this.ActiveGatherableContextStatusPanels;

        foreach (var panel in panels)
        {
            panel.SetState(active: (panel == buildingActivePanel));
        }
    }

    //GỌI TỚI ĐỂ ĐƯA NÓ VÀO TRONG LIST DỰ TRỮU VÀ CHẠY HIDE ANIMTION:::
    public void HidePanel(GatherableContextStatusPanel panel)
    {
        bool removed = this.ActiveGatherableContextStatusPanels.Remove(item: panel);
        this.ReservedGatherableContextStatusPanels.Add(item: panel);
        panel.PlayHideAnimation();
    }


    //KHI ẤN VÀO HÌNH NĂNG LƯỢNG ĐỂ CHẠY::::
    //ẨN CÁI ĐƯỢC CHỌN VÀ HIỆN LÊN CSAI CÓ NĂNG LƯỢNG BÉ NHAT
    public void SelectNewMainPanel()
    {
        int minEnergyCost = int.MaxValue;
        GatherableContextStatusPanel selectedPanel = null;

        //DUYỆT QUA LIST ACTIVE CHỌN CÁI CÓ NWANG LƯỢNG BÉ NHẤT THÌ HIỆN LÊN 
        foreach (var panel in this.ActiveGatherableContextStatusPanels)
        {
            if (panel.GetEnergyCost() < minEnergyCost)
            {
                minEnergyCost = panel.GetEnergyCost();
                selectedPanel = panel;
            }
        }

        if (selectedPanel != null)
            selectedPanel.SetState(active: true);
    }


    [Button]
    private void OnOutsideClick()
    {
        this.Hide();
    }

    private void OnBackButtonPressed(bool arg0)
    {
        // Ẩn panel nếu đang hiển thị
        if (this.gameObject.activeInHierarchy)
        {
            this.Hide();
        }
    }

    
    public void Hide()
    {
        for (int i = 0; i < ActiveGatherableContextStatusPanels.Count; i++)
        {
            HidePanel(ActiveGatherableContextStatusPanels[i]);
        }
    }


    //SETACTIVE CẢ CÁI GỐC ??
    public void HideCompleted()
    {
        if (ActiveGatherableContextStatusPanels.Count<=0)
        {
            this.gameObject.SetActive(value: false);
        }
    }

    public int GetReservedCount()
    {
        return this.ReservedGatherableContextStatusPanels.Count;
    }

    public int GetActiveElementCount()
    {
        return this.ActiveGatherableContextStatusPanels.Count;
    }

    public bool HasFullyShownElement()
    {
        foreach (var panel in this.ActiveGatherableContextStatusPanels)
        {
            // if (panel.IsFullyShown())
            // {
            //     return true;
            // }
        }

        return false;
    }

    public GatherableContextStatusPanel GetFirstActiveElement()
    {
        if (this.ActiveGatherableContextStatusPanels.Count > 0)
        {
            return this.ActiveGatherableContextStatusPanels[0];
        }

        return null;
    }

    private void OnDisable()
    {
        this._showFrame = 0;
    }
}