using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using Unity.VisualScripting;

public class GatherableView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
    //True chính là các item cho nhiệm vụ::::
    [SerializeField] private bool treasure = false;
    
    [SerializeField] private bool flagFence = false;

    private GatherableBuilding _building;
    private HashSet<GatherableBuilding> _selectedGatherables;

    public void Init(GatherableBuilding building)
    {
        _building = building;
        _selectedGatherables = new HashSet<GatherableBuilding>();
        _building.RefreshViewGatherableEvent += OnRefresh;
        _building.ShowContextMenuEvent += ShowContextMenu;
        _building.PositionWorld = this.transform.position;
    }


    public void OnDestroy()
    {
        _building.RefreshViewGatherableEvent -= OnRefresh;
        _building.ShowContextMenuEvent -= ShowContextMenu;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        //ĐẦU TIÊN PHẢI CHECK THỬ XEM NÓ CÓ Ở TRONG có thể mở hay k VỊ TRÍ HỢP LỆ HAY K
        if (flagFence)return;
        if (_building != null)
        {
            // if (_building != null)
            // {
            //     _building.SpendCostForDestroy();
            // }

            if (_building.IsProcessCollect) return;

            //SẼ DÙNG ACESSABLE VÀ ĐSANH FLAG CÓ THỂ THAO TÁC KHÔNG
            //Check ở đây vị trí khả dụng k trng tilemanageview TRONG GATHERABLEBUILINDG CHUYỂN SANGG:
            //cả diện tích ntn thì phải lưu ý ::::
            if (TileManagerView.Instance == null ||
                !TileManagerView.Instance.IsTileReached(_building.Building.Area))
            {
                Debug.LogError("phải làm theo đúng quy luật mở gatherable");
                return;
            }
            
            
            //check trước khu vực này thõa mãn yêu cầu hay chưa và thông báo là cần phải làm gì gì trước
            if (!_building.IsRequirementsProvided())
            {
                
                Debug.LogError("cần phải hoàn thành requirement" +
                               (_building.requirements.Count > 0
                                   ? _building.requirements[0].RequirementType.ToString()
                                   : "null"));
                //đúng chính nó là trnog fionas là hiện lên phải hoàn thành quest nào::
                //this._completeCurrentQuestController.Show(questIds:  this._requirements);
                return;
            }

            if (!treasure)
            {
                //TRƯỚC CÁI NÀY CÒN CÓ CÁI BẮN SỰ KỆN ELEMENTPRESSSERDEVENT CHO NÓ LÀM GÌ THÌ LÀM:::
                //NCH CÁI ĐÓ TÍNH SAU LIÊN QUAN ĐIỀU KHIỂN NHÂN VẬT TRYPLAYWWITHCONDITIONONCHARRACTER
                ShowContextMenu(true, false);
                return;
            }
            
            //LOẠI ITEM::::
            this._building.Collect();
            return;
        }
    }




    //SHOW LÊN CÁI HIỆN NĂNG LƯỢNG ĐỂ ẤN VÀO::::
    public void ShowContextMenu(bool showOthers, bool ignoreRaycastBlock)
    {
        //CHECK NẾU NHƯ MÀ NÓ Ở TRONG QUEUE RỒI THÌ SẼ K HIỆN NỮA
        //CECK NẾU K THỂ ACESSSIBLE THÌ CŨNG K HIỆN
        //CHECK NU REQUIREMENT FALSE THÌ CŨNG K HIỆN
        //NẾU CÓ ACTIVEPANEL KHÁC NULL CHO CÁI NÀY THÌ SETACTIVEPANEL VÀ RETURN:::

        //ĐANG XỬ LÍ QUEUE THÌ K THỂ XỬ LÍ TIẾP:::
        if (_building.IsProcessCollect) return;
        if (!this._building.IsRequirementsProvided()) return;

        if (_building.ActivePanel != null)
        {
            GatherableContextManager.Instance.SetActivePanel(_building.ActivePanel);
            return;
        }

        //ĐỂ HIDE HẾT CÁC HIỂN THỊ NĂNG LƯỢNG CŨ CHO RÁC::
        GatherableContextManager.Instance.Hide();
        GatherableContextManager.Instance.Show(_building, true, this.gameObject.transform);
        _selectedGatherables.Clear();
        if (!showOthers) return;
        //CHECK CÁC THỨ Ở STATUS XUNG QUANH 
    }

    //BÊN UI NGHE SỰ KIỆN CỦA BUILDING ĐỂ REFRESH:::::
    public void OnRefresh()
    {
    }
}