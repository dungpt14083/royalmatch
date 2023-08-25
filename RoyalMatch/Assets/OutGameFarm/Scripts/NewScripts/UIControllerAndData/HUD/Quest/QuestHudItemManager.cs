using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

//QUẢN LÍ ĐỐNG HUDITEM KIAAA:::
public class QuestHudItemManager : MonoSingleton<QuestHudItemManager>
{
    //LiST QUEST cho controller hiển
    [SerializeField] private List<QuestHudItem> IdleQuestItems;
    [SerializeField] private RectTransform QuestFloatArea;
    [SerializeField] private CanvasGroup CanvasGroup;
    [SerializeField] private RectTransform QuestArea;

    [SerializeField] private int MinEnergyToAnimate;

    //CÁC SỰ KIỆN CỦA active event hoặc finish:::

    //lưu id là questID VÀ huditem đang active
    private Dictionary<int, QuestHudItem> _activeItems = new Dictionary<int, QuestHudItem>();


    //DUYỆT QUA LIST IDLEQUESTITEMS ĐỂ SETROOTPARENT CHO NÓ:::
    private void Start()
    {
        Init();
        //Tìm từ daily xem có thử quest k có thì để hiển thị lên:::
        //NGHE SỰ KIỆN QUEST FINISH VÀ QUEST ACTIVE
        QuestManagerSignals.QuestActivateEventSignal.AddListener(OnQuestActivate);
        QuestManagerSignals.QuestFinishEventSignal.AddListener(OnQuestFinish);
    }

    private void OnDestroy()
    {
        QuestManagerSignals.QuestActivateEventSignal.RemoveListener(OnQuestActivate);
        QuestManagerSignals.QuestFinishEventSignal.RemoveListener(OnQuestFinish);
    }


    //INIT BAN ĐẦU INIT THÌ ẨN HẾT VÀ ĐƯA NÓ SANG flooot hết 
    //NƠI ĐÓ LÀ NƠI DỰ TRỮ ITEM À
    public void Init()
    {
        for (int i = 0; i < IdleQuestItems.Count; i++)
        {
            IdleQuestItems[i].SetRootParent(QuestFloatArea);
            IdleQuestItems[i].gameObject.SetActive(false);
        }

        //đoạn này dựa vào check dailyquesst đê tạo ra item
        //cho nó lấy POPUP Ở TRONG LIST RA CÁI LÀ CÁI ĐẦU TIÊN TRONG LISTtừ đó hiển thị:::

        //VÀ DUYỆT QUA LIST NHIỆM VỤ ĐANG CHƯA HOÀN THÀNH VÀ TẠO ITEM CHO NÓ KHI KHỞI ĐỘNG 
        var tmpListQuest = FarmQuestManagerView.Instance.QuestsData.ActiveQuests;
        for (int i = 0; i < tmpListQuest.Count; i++)
        {
        }
    }


    private void OnQuestActivate(QuestEventData data)
    {
        //TÌM ACTIVE CÓ THWAFNG DATA.ID theo kiểu quản LÍ 
        QuestHudItem takeQuestHudItem = null;
        if (IdleQuestItems.Count > 0)
        {
            takeQuestHudItem = IdleQuestItems[0];
            IdleQuestItems.Remove(takeQuestHudItem);
        }

        if (takeQuestHudItem == null)
        {
            //báo lỗi ngay vì lỗi k đủ cho quest chạy
            return;
        }

        takeQuestHudItem.SetQuestData(data.QuestData);
        takeQuestHudItem.Refresh();
        takeQuestHudItem.transform.SetAsFirstSibling();
        takeQuestHudItem.gameObject.SetActive(value: true);

        if (data.QuestData.Completed)
        {
            takeQuestHudItem.SetCompleteState();
        }
        else
        {
            takeQuestHudItem.SetNewState();
            takeQuestHudItem.CheckHighEnergy();
        }

        _activeItems.Add(data.QuestData.Id, takeQuestHudItem);

        //foce ljai thwafng ui cho nó ::::
        //UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot:  0);

        //từ đo set rootactiveposition
        takeQuestHudItem.SetRootActivatePosition();
        foreach (var tmp in _activeItems.Values)
        {
            tmp.ResetHighEnergyState();
        }
    }


    //quest khi finish thì se đưa vào trong IDLE
    private void OnQuestFinish(UserQuestData data)
    {
        if (_activeItems.ContainsKey(data.Id))
        {
            var questHudItem = _activeItems[data.Id];
            questHudItem.gameObject.SetActive(false);
            _activeItems.Remove(data.Id);
            IdleQuestItems.Add(questHudItem);
        }

        //Duyệt qua bọn quest hiện tại active để đặt lại trạng thái năng lượng cao cho nó
        for (int a = 0; a < _activeItems.Count; a++)
        {
            _activeItems[a].ResetHighEnergyState();
        }
    }


    //TỪ QUEST ID LẤY RA QUESTHUDITEM:::
    public QuestHudItem GetQuestItem(int questId)
    {
        if (_activeItems.ContainsKey(questId))
        {
            return _activeItems[questId];
        }

        return null;
    }

    public QuestHudItem GetFirstActiveItem()
    {
        if (_activeItems != null)
        {
            return _activeItems[0];
        }

        return null;
    }

    //SETVISSIBILITY CHO THẰNG NÀY TRUE FLASE::HIỂN THỊ
    public void SetVisibility(bool value)
    {
        CanvasGroup.alpha = value ? 1f : 0f;
        CanvasGroup.blocksRaycasts = value;
    }


    //KHI GỌI TỚI SHOW PANEL VỚI RỒI AI GỌI TỚI 
    public void ShowPanel(int questId)
    {
        QuestHudItem questHudItem = this._activeItems[questId];
        questHudItem.Show();
    }

    //FLAG NÀY hơi lạ:>>>
    public bool IsInScreen()
    {
        return true;
    }

    //NĂNG LƯỢNG TỐI THIỂU ĐỂ HOẠT HÌNH:::
    public int GetMinEnergyToAnimate()
    {
        return (int)this.MinEnergyToAnimate;
    }

    //CHECK HAS COMPLETEITEM:::
    //CHỈ CẦN CÓ 1 COMPLETED THÌ SẼ RETURN TRUE CÒN K RETURN FALSE
    public bool HasCompletedItem()
    {
        foreach (QuestHudItem item in _activeItems.Values)
        {
            if (item.IsCompleted())
            {
                return true;
            }
        }

        return false;
    }
}