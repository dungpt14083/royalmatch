using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Cái này sẽ được hủy khi mà::::
public class GatherableBuilding : ICanSerialize, IEnergyConsumer
{
    //Cho 2 sự kiện 1 là full tiền vào để hủy
    //2 LÀ SỰ KIỆN UPDATE GIÁ SAU KHI UPDATE::
    public delegate void FillFullDestroyCostEventHandler();

    public delegate void UpdateDestroyCostEventHandler();

    public event FillFullDestroyCostEventHandler FillFullDestroyCostEvent;
    public event UpdateDestroyCostEventHandler UpdateDestroyCostEvent;

    private void FireFillFullDestroyCostEventHandler()
    {
        if (this.FillFullDestroyCostEvent != null)
        {
            this.FillFullDestroyCostEvent();
        }
    }

    private void FireUpdateDestroyCostEventHandler()
    {
        if (this.UpdateDestroyCostEvent != null)
        {
            this.UpdateDestroyCostEvent();
        }
    }


    //Propeties thông số config cho thằng nhà này:::
    public GatherableProperties GatherableProperties { get; private set; }

    public List<TradeInfo> AdditionalReward { get; private set; }


    //CÒN BAO NHIÊU THÌ SẼ DESTROY::::LÚC ĐẦU KHỞI TẠO THÌ LẤY TỪ PROPERTIES::
    public int remainCostForDestroy;

    public GeneralBalance GeneralBalance { get; private set; }

    public IsLandInfo IsLandInfo { get; private set; }

    public Building Building { get; private set; }

    public TileManager TileManager { get; private set; }

    public bool IsProcessCollect { get; set; }

    public Vector3 PositionWorld { get; set; }


    #region SAVEANDLOAD

    private StorageDictionary _storage;

    public GatherableBuilding(GatherableProperties gatherableProperties, GeneralBalance generalBalance,
        PopupManager popupmanager, IsLandInfo isLandInfo, Building building)
    {
        InCollectQueue = false;
        GeneralBalance = generalBalance;
        GatherableProperties = gatherableProperties;
        remainCostForDestroy = GatherableProperties.EnergyCost;
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
        IsProcessCollect = false;
        //CHỈ CÓ GATHERABLEBUILINDG MỚI CÓ CÁI NÀY;:
        requirements = building.StartBuildingProperties.RequirementInfosForDestroyGatherable;
        AdditionalReward = building.StartBuildingProperties.AdditionalReward;
    }

    public GatherableBuilding(StorageDictionary storage)
    {
        _storage = storage;
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        return _storage;
    }

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
        IsLandInfo = isLandInfo;
        Building = building;
        TileManager = IsLandInfo.TileManager;
        InCollectQueue = false;
        //gatherable propeties???khi load lên
        //GatherableProperties=
    }

    #endregion


    #region REFACTORING GATHERABLE::::

    //REQUIREMENT LIST ĐÁP ỨNG NHƯ CẦU REQUIREEMENT THÌ MOI DƯỢC THAO TÁC:::
    public List<RequirementInfo> requirements { get; private set; }

    //CHECK XEM THỬ ĐẠT YÊU CẦU CHƯA THÌ MỚI CÓ THỂ HỦY
    public bool IsRequirementsProvided()
    {
        return RequirementManager.Instance.IsRequirementsProvided(requirements);
    }

    #endregion


    #region TODOSHOW POPUP AND COLLECT

    //FLAG CHO VIỆC Ơ TRONG COLLECT QUEUE
    public bool InCollectQueue { get; set; }

    //khi active thì sẽ set cho nó
    public GatherableContextStatusPanel ActivePanel { get; set; }

    //CHƯA ĐỘNG VÀO LIÊN QUAN TỚI MỜ MỜ GÌ ĐÓ???
    public void Glow()
    {
        //throw new System.NotImplementedException();
    }

    public int GetEnergyCost()
    {
        return remainCostForDestroy;
    }

    //BẮT ĐẦU ĐƯA VÀO TRONG QUEUE ĐỂ COLLECTOR:::
    //DÙNG ĐỂ TỚI LÀM MỜ CÁI RÁC VÀ TỪ ĐÓ SẼ 
    //CHẠY XUỐNG ĐÂY LÀ CHECK XONG TIỀN RỒI NÓ SẼ LÀ THU HOẠCH ĐƯỢC RỒI 
    public void SetInCollectQueue(bool value)
    {
        if (!InCollectQueue && value)
        {
            TileManagerView.Instance.FireTileCollectGatherableEvent(this);
        }

        InCollectQueue = value;
        //CÁI NÀY LÀ APPLY HÌNH ẢNH ĐỘ ANPHA VÀ THẰNG KHOARNG CÁCH CỦA NÓ:ĐÂY LÀ ANPHA CỦA HÌNH ẢNH RÁC BỊ MỜ VÌ ĐƯỢC CHỌN
        this.Refresh();
    }

    public int GetRemainingEnergy()
    {
        return remainCostForDestroy;
    }

    #endregion


    #region REFRESHHHHHHHHHH:::

    public delegate void RefreshViewGatherableEventHandler();

    public event RefreshViewGatherableEventHandler RefreshViewGatherableEvent;

    private void FireRefreshViewGatherableEventHandler()
    {
        if (this.RefreshViewGatherableEvent != null)
        {
            this.RefreshViewGatherableEvent();
        }
    }

    //GỌI TỚI VIEW REFRESH:::::
    public void Refresh()
    {
        FireRefreshViewGatherableEventHandler();
    }

    #endregion


    #region TODOREGION END CHARACTER ANIMATION::::

    //Phát tín hiệu cho view nó nghe để nó gọi tới show context:::
    public delegate void ShowContextMenuEventHandler(bool showOthers, bool ignoreRaycastBlock);

    public event ShowContextMenuEventHandler ShowContextMenuEvent;

    private void FireShowContextMenuEventHandler(bool showOthers, bool ignoreRaycastBlock)
    {
        if (this.ShowContextMenuEvent != null)
        {
            this.ShowContextMenuEvent(showOthers, ignoreRaycastBlock);
        }
    }


    //Debug.LogError("THỰC HIỆN HÀNH ĐỘNG CỦA RÁCCCCCCCCCC!!!!!!");
    public void Work()
    {
        //SỐ TIỀN CÒN LJAI PHẢI TRẢ
        int energyCost = this.GetEnergyCost();
        int availableEnergy = (int)InventoryManagerView.Instance.GetCurrency(CurrencyType.energy);
        int consumedEnergy = Mathf.Min(availableEnergy, energyCost);
        if (consumedEnergy < 1)
        {
            // Not enough energy to perform the work, so return early.
            return;
        }

        //ở đoạn này k cần gọi trade khi nào trade gọi mới gọi ở đây chắc k cần
        InventoryManagerView.Instance.DecCurrency(new Currency(CurrencyType.energy, consumedEnergy));
        remainCostForDestroy = remainCostForDestroy - consumedEnergy;

        //int workReward = this.GetWorkReward();
        //int collectedAmount = this.GetItemAmount(this.GatherableData.RemainingEnergy, consumedEnergy);

        //nếukhoongcos reward nhận thì tự return đi đoan sau k cần xét???
        // if (collectedAmount <= 0)
        // {
        //     return;
        // }

        //_inventoryService.IncAmount(itemId: this.GatherableInfo.Rewards[0].TypeId, amount: collectedAmount, source: 46134448);
        //Dictionary<TradeInfo, int> rewards = new Dictionary<TradeInfo, int>();
        //rewards.Add(this.GatherableInfo.Rewards[1], workReward);


        // if (remainingEnergy > 0 && this.gameObject.activeInHierarchy)
        // {
        //     _itemCollectTweener.StartSpawnWorldJump(worldPosition: BottomCenterPosition, rewards: rewards, reason: "GatherableCollect");
        // }

        //nếu remainenergy bé hơn k thì chạy collect chạy hiệu ứng còn k thì chạy showcontextmeny với xascm màu
        if (remainCostForDestroy <= 0)
        {
            Collect();
        }
        else
        {
            FireShowContextMenuEventHandler(false, false);
        }
    }


    //tham số worker tính sau::
    public void Collect(TradeInfo workedReward = null, int amount = 0)
    {
        //THM WORKED NÀY VÀO TRONG LIST QUÀ VÀ TRADE NÓ LÊN::::

        if (GatherableProperties.DestroyRewards.Count > 0)
        {
            Dictionary<TradeInfo, int> dictionaryTrade = new Dictionary<TradeInfo, int>();
            var listReward = new List<TradeInfo>();
            listReward.AddRange(GatherableProperties.DestroyRewards);
            listReward.AddRange(AdditionalReward);
            TradeManager.Instance.Add(listReward, "GatherableCollect");
            foreach (var tmp in listReward)
            {
                AddToRewardDictionary(dictionaryTrade, tmp);
            }

            PlayRewardAnimation(dictionaryTrade, reason: "GatherableCollect");
        }

        Destruct();
    }


    public void Destruct()
    {
        FireFillFullDestroyCostEventHandler();
        IsLandInfo.RemoveBuilding(Building);
    }


    public void AddToRewardDictionary(System.Collections.Generic.Dictionary<TradeInfo, int> rewards,
        TradeInfo tradeInfo)
    {
        if ((rewards.ContainsKey(key: tradeInfo)) != false)
        {
            rewards.Add(key: tradeInfo, value: tradeInfo.Amount + rewards[tradeInfo]);
            return;
        }

        rewards.Add(key: tradeInfo, value: tradeInfo.Amount);
    }


    //CÁI NÀY NHƯ LÀ BONUS THÊM 1 CHÚT GÌ ĐÓ LIÊN QUAN TRẢ VỀ SỐ LƯỢNG NĂNG LƯỢNG Đ BỎ RA???
    private int GetItemAmount(int remainingEnergy, int consumedEnergy)
    {
        int energyCost = GatherableProperties.EnergyCost;
        int energyNeeded = energyCost - remainingEnergy;

        if (energyNeeded <= 0)
        {
            // If energyNeeded is non-positive, it means no additional energy is required to complete the task,
            // so the result will be 0 (no items will be received).
            return 0;
        }

        // Calculate the number of items based on energyNeeded and consumedEnergy.
        // Assumption: R4 is a constant or a parameter, which is not provided in the code snippet.
        int val_2 = energyNeeded + consumedEnergy;
        int itemAmount = Mathf.FloorToInt(val_2 / energyCost);

        return itemAmount;
    }


    //cái này chạy animation reward cần phải 
    private void PlayRewardAnimation(System.Collections.Generic.Dictionary<TradeInfo, int> rewards, string reason)
    {
        Dictionary<TradeInfo, int> tmpRewards = new Dictionary<TradeInfo, int>();

        foreach (var tmp in rewards)
        {
            tmpRewards.Add(tmp.Key, GetRewardAmount(tmp.Key, tmp.Value));
        }

        ItemCollectTweener.Instance.StartSpawnWorldJump(PositionWorld, tmpRewards, "GatherableCollect");
        //mem[1152921513243783108].StartSpawnWorldJump(worldPosition:  new UnityEngine.Vector3(), rewards:  null, reason:  "");
        //public void StartSpawnWorldJump(UnityEngine.Vector3 worldPosition, System.Collections.Generic.Dictionary<TradeInfo, int> rewards, string reason = "")
    }

    //NẾU LÀ LOẠI CURRENCY THÌ CỘN 1 ĐỒNG VÀNG THÔI 
    private int GetRewardAmount(TradeInfo tradeInfo, int amount)
    {
        //là currency thì sẽ là số lượn 1:::nch iều chỉnh khoang giới hạn số lượng
        return tradeInfo.Amount;
    }

    // public bool CanSpendCurrencies()
    // {
    //     return GeneralBalance.CanSpendCurrencies(new Currencies("Energy",remainCostForDestroy));
    // }

    // public bool SpendCostForDestroy()
    // {
    //     //Check xem nó trong reachable không neu khong thì k the pha huy nó phải đi theo path
    //     if (TileManagerView.Instance != null && TileManagerView.Instance.IsTileReached(Building.Area))
    //     {
    //         if (GeneralBalance.SpendCurrencies(new Currencies("Energy", remainCostForDestroy), false,
    //                 Drain.DestroyGatherable))
    //         {
    //             //IsDestroy = true;
    //             FireFillFullDestroyCostEventHandler();
    //             IsLandInfo.RemoveBuilding(Building);
    //             return true;
    //         }
    //     }
    //     else
    //     {
    //         Debug.LogError("Phai pha vo theo path quy luat k the pha vo tuy y duoc !");
    //     }
    //
    //     return false;
    // }

    #endregion
}