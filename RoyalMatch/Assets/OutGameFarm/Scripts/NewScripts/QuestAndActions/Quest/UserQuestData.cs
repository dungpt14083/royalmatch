using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UserQuestData : ICanSerialize
{
    //LÀ MI ID QUEST VÀ ĐÃ HOÀN HÀNH HAY CHƯA???
    public int Id;
    public bool New;
    public bool Completed;
    //PROCESS CỦA TASK
    public List<int> TaskProgresses;
    
    
    
    #region SAVEANDLOAD

    public UserQuestData()
    {
    }

    public UserQuestData(int id,bool isNew,bool completed,List<int> list)
    {
        Id = id;
        New = isNew;
        Completed = completed;
        TaskProgresses = list;
    }
    
    public UserQuestData(int id,bool isNew,bool completed)
    {
        Id = id;
        New = isNew;
        Completed = completed;
        TaskProgresses = new List<int>();
    }
    
    private StorageDictionary _storage;

    public UserQuestData(StorageDictionary storage)
    {
        _storage = storage;
        Id = (int)_storage.Get("Id", 0);
        New = (bool)_storage.Get("New", true);
        List<int> list = _storage.GetList<int>("TaskProgresses");
        TaskProgresses = list;
    }
    
    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }
        _storage.Set("Id", Id);
        _storage.Set("New", New);
        _storage.Set("Completed", Completed);
        _storage.Set("TaskProgresses", TaskProgresses);
        return _storage;
    }

    #endregion
    
}
