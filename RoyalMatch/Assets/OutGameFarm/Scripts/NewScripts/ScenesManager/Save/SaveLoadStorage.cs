using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SaveLoadStorage
{
    //public delegate void ConflictResolutionCompleteEventHandler(ConflictResolver.ConflictSolution result);
    public delegate void PushCompletedEventHandler();

    public const string RootFolder = "Storage";
    //public const string DeviceRootKey = "DeviceRoot";
    public const string GameRootKey = "GameRoot";

    //LƯU TRỮ CÁI NÀY KHẢ NĂNG TỪ LOCAL xong hết hợp 
    private StorageDictionary _cloudStorageRoot;
    private readonly Storage _storage;

    //NƠI CHƯA DATA ĐƯỢC LOAD LÊN VÀ CÁI NÀY LÀ GAMEROOT CHỨA HÊT DATA CỦA GAME DẠNG STOREDICTIONARY
    public StorageDictionary GameRoot { get; private set; }

    //ĐÂY LÀ NEW GAME THÌ SẼ CHƯA CÓ GÌ Ở LOCAL THÌ SẼ 
    public bool IsNewGame { get; private set; }


    #region LOAD FROM LOCAL INTO

    //SẼ TẠO INSTANCE KHI TẠO MỚI CITY ISLAND:::
    //được gọi sau khi chạy cái này gọi là init authen để nhận authen từ server phản hồi
    public SaveLoadStorage()
    {
        // //ĐỌ NÀY SẼ GỌI TỚI AUTH CỦA SERVER OK THÌ INVOKE TRỞ LẠI 
        // if (IsAllowedToPull)
        // {
        //     Pull();
        // }

        //LẤY STORAGE LÊN VỚI PATH LÀ NƠI LƯU TRỮ VÀ KẾT HỢP STORAGE FILE OR TỆP
        //ĐỌC GHI FILE LOCAL đây là LOAD FILE LÊN RỒI LẤY VÀO ROOT
        
        _storage = new Storage(Path.Combine(Application.persistentDataPath, "Storage"));
        LoadStorageDictionaries();
        //NẾU TRÔNG DICTINARRY THÌ SẼ LÀ GAME MỚI
        IsNewGame = GameRoot.InternalDictionary.Count == 0;
    }

    //
    private void LoadStorageDictionaries()
    {
        //ĐÂY RỒI LOAD RA FILE ĐÂY RỒI LẤY RA VÀO GAMEROOOT
        _cloudStorageRoot = new StorageDictionary(_storage.GetDictionary("CloudStorageRoot"));
        GameRoot = _cloudStorageRoot.GetStorageDict("GameRoot");
    }

    #endregion

    #region SAVE TO LOCAL:::

    //LƯU TRỮ VỚI CÁC THỨ  PLAYER LEVEL VS DEVICE TẠM BỎ QUA
    public void Save(ICanSerialize game)
    {
        IsNewGame = false;
        //BỎ VÀO CLOUNDSTORAROOT GAME VÀO SET VÀO
        _cloudStorageRoot.Set("GameRoot", game);
        //SAU ĐÓ ĐƯA THẰNG CLOUNDSTORAROOT VÀO STORAGE ĐỂ LƯU LOCLA
        _storage.Root["CloudStorageRoot"] = _cloudStorageRoot.InternalDictionary;
        _storage.Save();
    }

    #endregion


    #region TODO LOAD FROM SERVER

    //BACK UP LÀ CHỈ KHI MÀ TRN SERVER VÀ CLIENT KHI SERVER KHÔNG LOAD ĐƯỢC THÌ LẤY FILE CLIENT CŨ LƯU LÀM BACKUP
    //TỪ THẰNG SIGNEDUSER ID VÀ CÁI STRING DẠNG SAVEGAMETOSTRING
    //LOAD TỪ BACKUP THÌ CHỈ CẦN LOAD TỪ LOCAL LÊN VÀ CONVERT SANG::
    //Dictionary<string, object> value = ((!IsNewGame) ? _storage.StringToDict(input) : new Dictionary<string, object>());

    

    //CHỈ CÓ KHI SAVEGAMETISTRING GỬI LÊN SERVER LƯU MỚI CÓ CÁI NÀY::
    private string SaveGameToString
    {
        get
        {
            return _storage.DictToString(_cloudStorageRoot.InternalDictionary);
        }
    }
    
    
    //CHO PHÉP LẤY VỀ TỪ SERVER:::
    // private bool IsAllowedToPull
    // {
    //     get
    //     {
    //         return true; //_gameSparksServer.Authenticator.CurrentAuthentication.IsAuthenticated;
    //     }
    // }
    // private void OnPullCompleted(LogEventResponse response)
    // {
    // }

    // private CloudGameState ConvertPullReponse(LogEventResponse response)
    // {
    //     //CONVERT GSDATAA SANG STRING ĐỂ XÀI 
    //     string text = PullSchema.Validate(response.ScriptData);
    //     if (!string.IsNullOrEmpty(text))
    //     {
    //         Debug.LogErrorFormat("Validation error in `ConvertPullReponse`: ", text);
    //         return null;
    //     }
    // }

    //KÉO TỪ LƯU TRỮ VỀ DT 
    // private void Pull(Action<LogEventResponse> onSuccess, Action<GameSparksException> onError)
    // {
    // }

    #endregion

    #region NEWGAME

    public void NewGame()
    {
        _storage.NewGame();
        IsNewGame = true;
    }

    #endregion

}