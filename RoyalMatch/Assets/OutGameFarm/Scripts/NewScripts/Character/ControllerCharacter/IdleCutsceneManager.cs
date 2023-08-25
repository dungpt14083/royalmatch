using System;
using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using Unity.VisualScripting;
using UnityEngine;

//100%%%%%%%%%%%%%%%%
//activeIdleCutsceneInfo chỉ được bơm cho chủ gây nên hành động idle các nhân vật phụ k đẩy vào:::QUANTROJNGGGGGG
//IDLECUTSCENEINFO PHẢI XEM XÉT THAAJT KĨ::
public class IdleCutsceneManager : MonoSingleton<IdleCutsceneManager>
{
    //IdleCutsceneInfo và list init ở trong IDLECUTSCENEINFO LIÊN QUAN Ở TRONG:::characterid + priority
    private Dictionary<KeyValuePair<int, int>, HashSet<int>> _idleCutsceneToInvolvedCharacters;
    private Dictionary<int, IdleCharacterCutsceneController> _cutsceneControllers;

    protected override void Awake()
    {
        base.Awake();
        //Debug.LogError("init " + Time.frameCount);
        _cutsceneControllers = new Dictionary<int, IdleCharacterCutsceneController>();
        _idleCutsceneToInvolvedCharacters = new Dictionary<KeyValuePair<int, int>, HashSet<int>>();
    }


    public void RegisterController(int characterId, IdleCharacterCutsceneController idleCharacterCutsceneController)
    {
        if (_cutsceneControllers == null)
        {
            Debug.LogError("hhhhhhhhhhhhhhh");
        }

        if (_cutsceneControllers.ContainsKey(characterId))
        {
            _cutsceneControllers.Remove(characterId);
            _cutsceneControllers.Add(characterId, idleCharacterCutsceneController);
        }
        else
        {
            _cutsceneControllers.Add(characterId, idleCharacterCutsceneController);
        }
    }

    public void UnregisterController(int charId)
    {
        if (_cutsceneControllers.ContainsKey(charId))
        {
            _cutsceneControllers.Remove(charId);
        }
    }


    #region ĐẨY CUTSCENE VÀO TRONG IDLECHARACTERCUTSCENCONTROLLER VÀ RELEASE Ở ĐÂY // ĐÂY LÀ RELEASE K LIÊN QUAN GÌ _cutsceneControllers

    private void RegisterCutscene(int charId, IdleCutsceneInfo idleCutsceneInfo, CutScene cutscene)
    {
        // yield return new WaitForEndOfFrame();
        // yield return new WaitForEndOfFrame();
        // yield return new WaitForEndOfFrame();

        HashSet<int> tmpInvolvedCharacters = cutscene.GetInvolvedCharacters();
        var tmpListCharacterAvailable = new HashSet<int>();
        foreach (var tmpId in tmpInvolvedCharacters)
        {
            if (!_cutsceneControllers.ContainsKey(tmpId)) continue;
            if (_cutsceneControllers[tmpId].ActiveIdleCutsceneInfo == null)
            {
                _cutsceneControllers[tmpId].QueueIdleCutscene(cutscene);
                _cutsceneControllers[tmpId].ActiveIdleCutsceneInfo = idleCutsceneInfo;
                tmpListCharacterAvailable.Add(tmpId);
            }
        }

        var tmpKey = new KeyValuePair<int, int>(charId, idleCutsceneInfo.Priority);
        if (!_idleCutsceneToInvolvedCharacters.ContainsKey(tmpKey))
        {
            _idleCutsceneToInvolvedCharacters.Add(tmpKey, tmpListCharacterAvailable);
        }
    }


    //RELEASE THÌ GO RA KHỎI MÀ THÔI:::khi release CUTSCENE NÀY GỌI TỚI CÁC NHÂN VẬT LIÊN QUAN Đ MÀ TỪ ĐÓ SẼ CANCEL ????
    public void ReleaseCutscene(int charId, IdleCutsceneInfo idleCutsceneInfo = null)
    {
        if (idleCutsceneInfo == null)
        {
            _cutsceneControllers[charId].ActiveIdleCutsceneInfo = null;
            return;
        }

        KeyValuePair<int, int> tmpKey = new KeyValuePair<int, int>(charId, idleCutsceneInfo.Priority);
        if (_idleCutsceneToInvolvedCharacters.ContainsKey(tmpKey))
        {
            var tmp = _idleCutsceneToInvolvedCharacters[tmpKey];

            if (tmp.Count == 0)
            {
                _cutsceneControllers[charId].ActiveIdleCutsceneInfo = null;
            }

            foreach (var tmpId in tmp)
            {
                if (_cutsceneControllers.ContainsKey(tmpId))
                {
                    _cutsceneControllers[tmpId].ActiveIdleCutsceneInfo = null;
                }
            }

            _idleCutsceneToInvolvedCharacters.Remove(tmpKey);
        }
    }

    #endregion


    #region THỬ ĐĂNG KÍ CUTSCENE::

    public bool TryRegisterCutscene(int charId, IdleCutsceneInfo idleCutsceneInfo, CutScene cutscene)
    {
        if (CutSceneManager.Instance.IsCutscenePlaying())
        {
            return false;

        }
        HashSet<int> tmpInvolvedCharacters = cutscene.GetInvolvedCharacters();


        //var tmpListAvailableCharacter = new List<int>();
        var tmpListNeedCancelCutSceneCharacter = new List<int>();

        //XEM ĐỐNG CONTROLLER KIA CASI NÀO K HỢP LÍ THÌ K XÉT VÌ DO ĐỘ ƯU TIÊN
        foreach (var tmpId in tmpInvolvedCharacters)
        {
            if (!_cutsceneControllers.ContainsKey(tmpId)) continue;


            var tmpController = _cutsceneControllers[tmpId];

            if (tmpController == null)
            {
                continue;
            }

            //ĐỘ ƯU TIÊN CỦA HÀNH ĐỘNG HIỆN TẠI:::
            //LẤY ACTIVE ĐỘ ƯU TIÊN CU ACTIVE MÀ ĐANG GẦN 1 HƠN THÌ SẼ CHO VÀO LIST VÀ SẼ CANCEL:::
            //
            var tmpPriorityIdleCutSceneInfo = idleCutsceneInfo.Priority;
            var activeActiveIdleCutsceneInfo = tmpController.ActiveIdleCutsceneInfo;

            if (activeActiveIdleCutsceneInfo != null)
            {
                //Debug.LogError("Độ ưu tiên hành động" + tmpPriorityIdleCutSceneInfo.ToString() + "mức độ currnet" +
                               //activeActiveIdleCutsceneInfo.Priority.ToString());
            }

            if (activeActiveIdleCutsceneInfo == null)
            {
                tmpController.QueueIdleCutscene(cutscene);
                tmpController.ActiveIdleCutsceneInfo = idleCutsceneInfo;
                //tmpListAvailableCharacter.Add(tmpId);
                continue;
            }

            if (tmpPriorityIdleCutSceneInfo > activeActiveIdleCutsceneInfo.Priority)
            {
                //Debug.LogError("cancel command not work");
                continue;
            }


            if (tmpPriorityIdleCutSceneInfo < activeActiveIdleCutsceneInfo.Priority)
            {
                tmpListNeedCancelCutSceneCharacter.Add(tmpId);
                //Debug.LogError("cancel walk when collect gatherable");
                continue;
            }


            //TRƯỜNG HỢP ĐƯA HÀNH ĐỘNG CHẠY KHI ĐANG CHẠY THÌ CANCEL CÁI ĐANG CHẠY DỞ
            if (tmpPriorityIdleCutSceneInfo == activeActiveIdleCutsceneInfo.Priority &&
                tmpPriorityIdleCutSceneInfo == 100)
            {
                tmpListNeedCancelCutSceneCharacter.Add(tmpId);
            }
            //TRỪNG HỢP ĐƯA HÀNH ĐỘNG GOM RÁC VÀO ĐÂY KHI ĐANG THỰC HIỆN GOM RASC
            else if (tmpPriorityIdleCutSceneInfo == activeActiveIdleCutsceneInfo.Priority &&
                     tmpPriorityIdleCutSceneInfo != 100)
            {
                tmpController.QueueIdleCutscene(cutscene);
                tmpController.ActiveIdleCutsceneInfo = idleCutsceneInfo;
            }
        }

        foreach (var tmp in tmpListNeedCancelCutSceneCharacter)
        {
            //Debug.LogError("tmplisst" + tmp);
            var tmpController = _cutsceneControllers[tmp];
            tmpController.CancelIdleCutScenes();
            if (tmpController.ActiveIdleCutsceneInfo == null) continue;
            ReleaseCutscene(tmp, tmpController.ActiveIdleCutsceneInfo);
        }

        //StartCoroutine(RegisterCutscene(charId, idleCutsceneInfo, cutscene));
        RegisterCutscene(charId, idleCutsceneInfo, cutscene);
        return true;
    }

    #endregion
}