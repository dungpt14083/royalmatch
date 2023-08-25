using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//QUEST THEO ĐẢO NÀY ĐẢO KIA À???????
[Serializable]
[CreateAssetMenu(fileName = "QuestInfoCollection", menuName = "Scriptable Objects/QuestInfoCollection")]
public class QuestInfoCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public List<QuestInfo> quests;

    //ĐÁNG LÀ RA NÓ NẰM Ở GROUPD NÀO DÀNH CHO TEST CÓ QUEST AB GÌ GÌ ĐÓ NHƯNG TẠM BỎ QUA::::
    private Dictionary<int, QuestInfo> _cache;

    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<int, QuestInfo>();
        for (int i = 0; i < quests.Count; i++)
        {
            if (!_cache.ContainsKey(quests[i].id))
            {
                _cache.Add(quests[i].id, quests[i]);
            }
        }
    }

    public void OnBeforeSerialize()
    {
    }

    public QuestInfo GetQuestInfo(int questId)
    {
        if (_cache.ContainsKey(questId))
        {
            return _cache[questId];
        }

        return null;
    }


    //LẤY QUEST INFO VÀ TRẢ VỀ RESULT NẾU TRUE
    public bool TryGetQuestInfo(int questId, out QuestInfo result)
    {
        if (_cache.ContainsKey(questId))
        {
            result = _cache[questId];
            return true;
        }

        result = null;
        return false;
    }


    //QUEST A B C D THEO ĐẢO NÀY ĐẢO KIA À???
    //LẤY LIST QUEST THEO GROUP::
    public void GetQuestsVisibleToGroupNonAlloc(System.Collections.Generic.List<QuestInfo> quests, int group)
    {
    }

    public bool HasQuestWithId(int questId)
    {
        return _cache.ContainsKey(questId);
    }
}