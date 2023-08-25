using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;
using UnityEngine.Events;

//SẼ CHẠY SAU FINISH QUESTTT
public class CutSceneAction : MapAction
{
    public int CutsceneId;
    public Actions CurrentActions;


    public CutSceneAction(int cutsceneId)
    {
        this.CutsceneId = cutsceneId;
    }

    public override void Play()
    {
        CurrentActions = CutSceneManager.Instance.Play(CutsceneId);
        //CẦN KIỂM SOÁT KHI NÀO THÌ NÓ INVOKE TRỞ LẠI NGHE SỰ KIỆN KẾT THÚC CUTSCENE ĐỂ MÀ TỪ ĐÓ COPLETE CHẠY ACTION KHÁC À
        CurrentActions.onCompleted += CompleteActions;
        //Callback trở lại :::
    }

    private void CompleteActions()
    {
        Complete();
        CurrentActions.onCompleted -= CompleteActions;
        CurrentActions = null;
    }
}