using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeManager : MonoSingleton<TradeManager>
{
    private Dictionary<TradeType, ITradeController> _tradeControllers = new Dictionary<TradeType, ITradeController>();
    private int _requiredTradeController;

    #region INITMANAAGER

    public void Init()
    {
        Array tmpValue = System.Enum.GetValues(typeof(RequirementType));
        this._requiredTradeController = tmpValue.Length;
    }

    public void RegisterTradeController(TradeType type, ITradeController controller)
    {
        if (!_tradeControllers.ContainsKey(type))
        {
            _tradeControllers.Add(type, controller);
        }

        if (_requiredTradeController != _tradeControllers.Count) return;
        //NẾU??READY KHI MÀ SỐ LƯỢNG CONTROLLER ĐƯANG KÍ ĐỦ THÌ SẼ READY CH K PHẢI THIẾU CONTROLLER:::
        //this.SetReady();
    }

    public void UnRegisterTradeController(TradeType type)
    {
        if (_tradeControllers.ContainsKey(type))
        {
            _tradeControllers.Remove(type);
        }
    }


    //lấy số lựng dạng tring cái này nếu tradetype là loại không giới hạn mới quan tm còn k thì chỉ la f bình thường
    public string GetAmountString(TradeInfo tradeInfo)
    {
        return tradeInfo.Amount.ToString();
    }

    #endregion


    #region CÁC CÁI LẤY Ở ITRADECONTROLLER::::::

    //get sprite dựa vào TRADE CONTROLLER DỰA VÀO LOẠI TYPE ĐÓ VÀ CẤP ẢNH NÓ CÓ THỂ LƯU ĐÂU ĐÓ NCH BỌN KIA XỬ LÍ
    public UnityEngine.Sprite GetSprite(TradeInfo tradeInfo)
    {
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.GetSprite(tradeInfo);
    }

    //liên quan tới biên dịch::
    public string GetTranslationKey(TradeInfo tradeInfo)
    {
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.GetTranslationKey(tradeInfo);
    }

    public long GetCurrentAmount(TradeInfo tradeInfo)
    {
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.GetCurrentAmount(tradeInfo);
    }

    
    //ADD THƯỜNG
    public bool Add(TradeInfo tradeInfo, string source)
    {
        if (_tradeControllers.ContainsKey(tradeInfo.TradeType))
        {
            var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
            return tmpTradeControllers.Add(tradeInfo, source);
        }
        return false;
    }

    //KHI MÀ ADD 1 LIST VÀO THÌ XÉ NHỎ lIST RA
    public bool Add(System.Collections.Generic.List<TradeInfo> tradeInfos, string source)
    {
        for (int i = 0; i < tradeInfos.Count; i++)
        {
            //Debug.LogError("XYYYYYYYYYYYYYYYY");
            Add(tradeInfos[i], source);
        }
        return true;
    }


    #region BÊN NGOÀI CHECK CANREMOVE XONG MƯỚI GỌI VÀO ĐÂY REMOVE

    //check có thể remove không so sánh số lượng tradeinfo và cái đang có sẵn
    //nếu số lượng trade vào lớn hơn thì có thể remove
    public bool CanRemove(TradeInfo tradeInfo)
    {
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.GetCurrentAmount(tradeInfo) >= tradeInfo.Amount;
    }

    //DUYỆT QUA CẢ LIST TRADE XEM CÓ THỂ REMOVE TOÀN BỘ K:::
    public bool CanRemove(System.Collections.Generic.List<TradeInfo> tradeInfos)
    {
        for (int i = 0; i < tradeInfos.Count; i++)
        {
            if (!CanRemove(tradeInfos[i]))
            {
                return false;
            }
        }

        return true;
    }

    #endregion


    public bool Remove(TradeInfo tradeInfo, string source)
    {
        if (!CanRemove(tradeInfo)) return false;
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.Remove(tradeInfo, source);
    }

    public bool Remove(System.Collections.Generic.List<TradeInfo> tradeInfos, string source)
    {
        if (!CanRemove(tradeInfos)) return false;
        for (int i = 0; i < tradeInfos.Count; i++)
        {
            Remove(tradeInfos[i], source);
        }
        return true;
    }


    //DIFF????????
    public int Diff(TradeInfo tradeInfo)
    {
        var tmpTradeControllers = _tradeControllers[tradeInfo.TradeType];
        return tmpTradeControllers.Diff(tradeInfo);
    }

    //CHECK XEM CÓ KHÁC BIỆT LẤY TRA SỐ LƯỢNG KHÁC BIỆT VÀ LÍT TRADEINFO MƯỚI:::
    public List<TradeInfo> Diff(List<TradeInfo> tradeInfos)
    {
        List<TradeInfo> differenceList = new List<TradeInfo>();

        foreach (TradeInfo tradeInfo in tradeInfos)
        {
            TradeType tradeType = tradeInfo.TradeType;
            ITradeController tradeController = _tradeControllers[tradeType];
            int difference = tradeController.Diff(tradeInfo);

            if (difference != 0)
            {
                TradeInfo differenceTradeInfo = new TradeInfo(tradeInfo.TradeType, 0, difference);
                differenceList.Add(differenceTradeInfo);
            }
        }

        return differenceList;
    }

    //chuyển thành gem số lượng và blablaCHUYỂN VỚI 1 TRADE
    public TradeInfo ToGem(TradeInfo tradeInfo)
    {
        TradeType tradeType = tradeInfo.TradeType;
        ITradeController tradeController = _tradeControllers[tradeType];
        var valueGem = tradeController.ToGem(tradeInfo);
        return new TradeInfo(TradeType.Currency, 1, valueGem);
        ;
    }

    public TradeInfo ToGem(List<TradeInfo> tradeInfos)
    {
        int totalAmount = 0;

        foreach (TradeInfo tradeInfo in tradeInfos)
        {
            TradeType type = tradeInfo.TradeType;
            ITradeController controller = null;
            if (this._tradeControllers.TryGetValue(type, out controller))
            {
                totalAmount += controller.ToGem(tradeInfo);
            }
        }

        return new TradeInfo(TradeType.Currency, 1, totalAmount);
    }

    #endregion

    //cCHỈ CÓ TYPE LÀ CUTSCNE THÌ MỚI FALSE CÒN K LÀ TRUE HẾT VÌ NÓ CHẠY TWEEN NHẢY SỐ MÀ:::
    public bool IsRewardTweenable(TradeType rewardTradeType)
    {
        if (rewardTradeType == TradeType.Cutscene) return false;
        return true;
    }

    //CHECK XEM THỬ CÓ TYPE NÀY Ở TRONG TRADEINFO KHÔNG DÙNG ĐỂ CHECK
    public bool HasTradeType(List<TradeInfo> tradeInfos, TradeType tradeType)
    {
        foreach (TradeInfo tradeInfo in tradeInfos)
        {
            if (tradeInfo.TradeType == tradeType)
            {
                return true;
            }
        }

        return false;
    }
}