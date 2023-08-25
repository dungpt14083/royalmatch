using System;
using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using Unity.VisualScripting;
using UnityEngine;

//DONEEEEEEEEEEE
//ENABLE BẬT TẮT HÀM UPDATE CHẠY+CÁI CHÀY CHỈ CONTROLLER ĐỘNG CUTSCENE CỦA IDLE K LIEEN QUAN CUTSCENEMANAGER VÌ BỌN KIA CÓ CÁI CONTROLLER RIÊNG
public class IdleCharacterCutsceneController : MonoBehaviour
{
    [SerializeField] private Character Character;

    [NonSerialized] public CutScene activeCutscene;
    public bool Locked;

    private Queue<CutScene> _cutsceneQueue;
    private CutSceneManager _cutSceneManager;
    private IdleCutsceneManager _idleCutsceneManager;

    public IdleCutsceneInfo ActiveIdleCutsceneInfo
    {
        get { return _activeIdleCutsceneInfo; }
        set
        {
            _activeIdleCutsceneInfo = value;
            if (_activeIdleCutsceneInfo != null)
            {
                //Debug.LogError("thangxxxxx" + _activeIdleCutsceneInfo.Priority.ToString());
            }
        }
    }

    private IdleCutsceneInfo _activeIdleCutsceneInfo;

    public void Start()
    {
        _cutsceneQueue = new Queue<CutScene>();
        StartCoroutine(WaitCutSceneManager());
        StartCoroutine(WaitIdleCutSceneManager());
    }


    #region CẮT NGANG HẾT ACTION KHI CUTSCENE HOẠT ĐỘNG

    private IEnumerator WaitCutSceneManager()
    {
        yield return new WaitUntil(() => CutSceneManager.Instance != null);
        _cutSceneManager = CutSceneManager.Instance;
        _cutSceneManager.actionsStartEvent += OnActionsStart;
        _cutSceneManager.actionsFinishEvent += OnActionsFinish;
    }

    private IEnumerator WaitIdleCutSceneManager()
    {
        yield return new WaitUntil(() => IdleCutsceneManager.Instance != null);
        _idleCutsceneManager = IdleCutsceneManager.Instance;
        //Debug.LogError("frame register controller characrer" + Time.frameCount);
        _idleCutsceneManager.RegisterController(Character.characterId, this);
    }

    private void OnActionsFinish(Actions actions)
    {
        this.enabled = true;
    }

    private void OnActionsStart(Actions actions)
    {
        this.CancelIdleCutScenes();
        this.enabled = false;
    }

    //CLEAR HẾT BỌN
    public void CancelIdleCutScenes()
    {
        if (activeCutscene != null)
        {
            activeCutscene.Cancel();
            activeCutscene = null;
        }

        foreach (var tmp in _cutsceneQueue)
        {
            tmp.Cancel();
        }

        _cutsceneQueue.Clear();
        this.Locked = false;
    }

    #endregion


    #region ADD and process QUEUE

    public void QueueIdleCutscene(CutScene cutScene)
    {
        _cutsceneQueue.Enqueue(cutScene);
        //Debug.LogError("CUTSCENEQUEUE" + _cutsceneQueue.Count.ToString());
        CheckQueue();
    }

    public void CheckQueue()
    {
        if (enabled == false)
        {
            return;
        }

        if (activeCutscene != null)
        {
            return;
        }

        if (_cutsceneQueue != null && _cutsceneQueue.Count >= 1)
        {
            activeCutscene = _cutsceneQueue.Dequeue();
        }
        else
        {
            activeCutscene = null;
        }
    }


    private void Update()
    {
        if (_cutSceneManager == null) return;

        //KHI CÓ 1 CUTSCENEMANAGER CHẠY THÌ SẼ LẬP TUWSCCANCEL TÂT CẢ IDLECUTSCENE::
        if (_cutSceneManager.IsCutscenePlaying())
        {
            CancelIdleCutScenes();
            this.enabled = false;
            return;
        }

        if (activeCutscene == null) return;

        //Nếu như mà vẫn chạy update được của activeCutScene thì sẽ chạy k thì xuôống dưới là compltele r
        if (activeCutscene.Update())
        {
            return;
        }

        //active không thành công thì gọi vào tự complete:::
        CompleteCutscene();
    }

    private void CompleteCutscene()
    {
        activeCutscene = null;

        //activeidlecutscene này dành cho nhân vật chính ::nếu nó khascn ull gọi tới cancel hết actions
        if (ActiveIdleCutsceneInfo != null)
        {
            _idleCutsceneManager.ReleaseCutscene(Character.characterId, ActiveIdleCutsceneInfo);
            Debug.LogError("complete cutscene");
            ActiveIdleCutsceneInfo = null;
        }

        //CHECK QUEUE ĐỂ CHẠY CUTSCENE TIẾP THEO
        CheckQueue();
    }


    //Khi nhân vật 
    private void OnDisable()
    {
        CancelIdleCutScenes();
        if (ActiveIdleCutsceneInfo == null || Character == null) return;
        _idleCutsceneManager.ReleaseCutscene(Character.characterId, ActiveIdleCutsceneInfo);
        ActiveIdleCutsceneInfo = null;
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        if (_cutSceneManager != null)
        {
            _cutSceneManager.actionsStartEvent -= OnActionsStart;
            _cutSceneManager.actionsFinishEvent -= OnActionsFinish;
        }

        CancelIdleCutScenes();


        if (ActiveIdleCutsceneInfo != null || Character != null)
        {
            _idleCutsceneManager.ReleaseCutscene(Character.characterId, ActiveIdleCutsceneInfo);
        }

        ActiveIdleCutsceneInfo = null;
        _idleCutsceneManager.UnregisterController(Character.characterId);
    }

    #endregion


    #region TIỆN ÍCH:::

    public bool IsCutscenePlaying()
    {
        if (activeCutscene != null)
        {
            return true;
        }

        return false;
    }

    #endregion
}