using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using GameCreator.Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class CutSceneManager : MonoSingleton<CutSceneManager>
{
    #region TODOEVENT CUTSCENE

    public delegate void ActionsStartHandler(Actions actions);

    public delegate void ActionsFinishHandler(Actions actions);

    public ActionsStartHandler actionsStartEvent;
    public ActionsFinishHandler actionsFinishEvent;


    private void FireActionsStartEvent(Actions actions)
    {
        if (this.actionsStartEvent != null)
        {
            this.actionsStartEvent(actions);
        }
    }

    private void FireActionsFinishEvent(Actions actions)
    {
        if (this.actionsFinishEvent != null)
        {
            this.actionsFinishEvent(actions);
        }
    }

    #endregion

    [SerializeField] private CutsceneInfoCollection _cutsceneInfoCollection;
    [SerializeField] private RequirementManager _requirementManager;
    [SerializeField] private List<ActionsInfo> InteractionModes;

    //THẢ VÀO ĐỂ BLOCK LẠI CANVAS:::
    public CanvasScaler Blocker;


    private Actions _currentActions;
    private int _cutsceneId;
    private int _prevCutsceneId;

    public CutsceneInfoCollection CutsceneInfoCollection => _cutsceneInfoCollection;

    public void Init()
    {
        //this.enabled = false;
    }

    public bool IsCutscenePlaying()
    {
        if (_currentActions != null)
        {
            return true;
        }

        return false;
    }

    public int GetPreviousCutsceneId()
    {
        return (int)this._prevCutsceneId;
    }

    public void SkipCutscene()
    {
        this._currentActions.Stop();
    }

    public void CancelCutscene()
    {
        this._currentActions.Stop();
        this.CompleteCutscene();
    }

    private void CompleteCutscene()
    {
        Blocker.gameObject.SetActive(false);
        _currentActions.onFinish?.Invoke();
        this._currentActions = null;
        this._prevCutsceneId = this._cutsceneId;
        this._cutsceneId = 0;
        //this.enabled = false;
    }


    //CUTSCENE NÓ TỰ GỌI UPDATE NÊN K CẦN QUAN TÂM LÀ KHI NAFO NÓ BẮN SỰ KIỆN VỀ LÀ ĐƯỢC R
    private void Update()
    {
    }


    #region CUNG CẤP TIỆN ÍCH TRA CỨU TRONG GAME:::

    //THỬ LẤY ACTIONS INFO VỚI ID::::
    private bool TryGetActionsInfo(int id, out ActionsInfo value)
    {
        foreach (var info in InteractionModes)
        {
            if (info.Id == id)
            {
                value = info;
                return true;
            }
        }

        value = default;
        return false;
    }

    public bool TryGetActionsInfoValue(int id, out Actions value)
    {
        if (!TryGetActionsInfo(id, out var info))
        {
            value = default;
            return false;
        }

        value = info.Value;
        return true;
    }

    #endregion


    #region PLAYCUTSCENE::::


    [Button]
    public void TestCutScene()
    {
        Play(1);
    }
    
    

    //GỌI TOI PLAY CUTSCENE TỪ CUTSCENETRADEMANAGER ĐỂ GỌI trả về là vì muốn lấy callback::::
    public Actions Play(int id)
    {
        CutSceneInfo tmpCutSceneInfo = CutsceneInfoCollection.Get(id: id);
        if (tmpCutSceneInfo == null) return null;
        Actions actions = Play(tmpCutSceneInfo);
        if (actions == null) return null;
        this._currentActions = actions;
        this._cutsceneId = tmpCutSceneInfo.Id;
        return actions;
    }

    public Actions Play(CutSceneInfo info)
    {
        if (_currentActions == null)
        {
            if (TryGetActionsInfo(info.Id, out ActionsInfo actions))
            {
                FireActionsStartEvent(actions.Value);
                PlayActions(actions.Value);
                //this.Blocker.gameObject.SetActive(value: true);
                return actions.Value;
            }
        }

        return null;
    }

    private static readonly object[] NO_OBJECT = new object[0];

    private void PlayActions(Actions actions)
    {
        actions.Execute(null, NO_OBJECT);
        actions.onCompleted += () =>
        {
            _currentActions = null;
            FireActionsFinishEvent(actions);
        };
    }

    [Button]
    private void TestPlayCutScene(int id)
    {
    }

    #endregion
}

[Serializable]
public class ActionsInfo
{
    public int Id;
    public Actions Value;
}