using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserQuestsData : ICanSerialize
{
    //lisst quesst ddax FInish
    public List<int> FinishedQuests;
    //lisst quest dang active
    public List<UserQuestData> ActiveQuests;


    //quest GROUP NAFO THIF BOR QUA VI K COS TESST AB O TRONG GAME NAY::::
    public UserQuestsData()
    {
        FinishedQuests = new List<int>();
        ActiveQuests = new List<UserQuestData>();
    }


    #region SAVEANDLOADDD::::

    private StorageDictionary _storage;

    public UserQuestsData(StorageDictionary storage)
    {
        _storage = storage;
        List<int> list = _storage.GetList<int>("FinishedQuests");
        FinishedQuests = list;
        ActiveQuests = storage.GetModels("ActiveQuests", (StorageDictionary sd) => new UserQuestData(sd));
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }
        _storage.Set("FinishedQuests", FinishedQuests);
        _storage.Set("ActiveQuests", ActiveQuests);
        return _storage;
    }

    #endregion
}