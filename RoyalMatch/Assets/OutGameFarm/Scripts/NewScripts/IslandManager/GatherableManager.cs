using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GatherableManager : ICanSerialize
{
    //CÁI NÀY SẼ ĐƯA VÀO RUNTIME CHO NGƯỜI CHƠI BIẾT ::::CHO BỌN KIA CHECK GÌ THÌ CHECK::::
    //THÊM CON TRỎ Ở ĐÂY TỚI BỌN KIA:::
    //public List<Building> ActiveGatherables;

    //CÁI NÀY SẼ LƯU VÀ LOAD LÊN RÁC ĐÃ HOÀN THÀNH//sẽ đƯỢC BÊN KIA ADD KHI VÀO GAME À??V CÁI NÀY PHẢI TẠO TRƯỚC
    //public List<int> ActiveGatherables;
    public List<int> CompletedGatherables;


    public void AddCompletedGatherable(int id)
    {
        if (CompletedGatherables != null)
        {
            if (!CompletedGatherables.Contains(id))
            {
                CompletedGatherables.Add(id);
            }
        }

        // if (ActiveGatherables.Contains(id))
        // {
        //     ActiveGatherables.Remove(id);
        // }
    }


    public bool IsCompletedGatherableWithId(int id)
    {
        return CompletedGatherables.Contains(id);
    }


    #region TODO SAVE AND LOAD CONTRUCTOR:::

    public GatherableManager()
    {
        CompletedGatherables = new List<int>();
    }

    private StorageDictionary _storage;

    public GatherableManager(StorageDictionary getStorageDict)
    {
        _storage = getStorageDict;
        CompletedGatherables = new List<int>();
        List<int> list = _storage.GetList<int>("CompletedGatherables");
        int count = list.Count;
        for (int i = 0; i < count; i++)
        {
            CompletedGatherables.Add(list[i]);
        }
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("CompletedGatherables", CompletedGatherables);
        return _storage;
    }

    public void ResolveDependencies(GameData game)
    {
    }

    #endregion
}