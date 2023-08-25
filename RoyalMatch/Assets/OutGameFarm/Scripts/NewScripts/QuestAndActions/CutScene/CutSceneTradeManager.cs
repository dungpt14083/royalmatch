using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//NÓ LÀ QUẢN LÍ NGHE TRADE TỪ MISSION VÀ CÁC LOẠI THU HOẠCH KÍCH HOẠT CUTSCENE:::
public class CutSceneTradeManager : MonoSingleton<CutSceneTradeManager>, ITradeController
{
    [SerializeField] private RequirementManager _requirementManager;
    [SerializeField] private TradeManager _tradeManager;


    public void Start()
    {
        _tradeManager.RegisterTradeController(TradeType.Cutscene, this);
    }

    public void OnDestroy()
    {
        _tradeManager.UnRegisterTradeController(TradeType.Cutscene);
    }

    //KHI ADD MỘT TRADE VÀO THÌ SẼ XEM THỬ LÀ LOẠI kích hoạt CUTSCENE KHÔNG 
    public bool Add(TradeInfo tradeInfo, string source)
    {
        if (tradeInfo.TradeType != TradeType.Cutscene) return false;
        // if(FarmMatch.Map.CutsceneEventListener.SkipCutscenes == true)
        // {
        //     return;
        // }
        CutSceneInfo tmpCutScene = CutSceneManager.Instance.CutsceneInfoCollection.Get(tradeInfo.IdInType);
        if (!_requirementManager.IsRequirementsProvided(tmpCutScene.Requirements)) return false;
        CutSceneAction cutSceneAction = new CutSceneAction(tmpCutScene.Id);
        MapActionQueueManager.Instance.QueueAction(cutSceneAction);
        return true;
    }

    public bool Remove(TradeInfo tradeInfo, string source)
    {
        return false;
    }

    public int Diff(TradeInfo tradeInfo)
    {
        return 0;
    }

    public int ToGem(TradeInfo tradeInfo)
    {
        return 0;
    }


    public UnityEngine.Sprite GetSprite(TradeInfo tradeInfo)
    {
        return null;
    }

    public string GetTranslationKey(TradeInfo tradeInfo)
    {
        return "";
    }

    public long GetCurrentAmount(TradeInfo tradeInfo)
    {
        return 0;
    }
}