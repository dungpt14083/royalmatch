using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NGOÀI NÀY SOLUTION CHO VIỆC TẢI VÀ NHẬN LUÔN các cách LƯU TRỮ
public class FarmIsLandData
{
    public delegate void SavedAllEventHandler();

    private SavedAllEventHandler m_SavedAllEvent;
    public event SavedAllEventHandler SavedAllEvent;


    //Data trong game
    public GameData GameData { get; private set; }
    public SaveLoadStorage SaveLoadStorage { get; private set; }


    //Contructor tạo data
    public FarmIsLandData()
    {
        //SẼ LẤY RA TỪ CLOUND STORAGE ĐỂ LẤY RA THÔNG TIN ĐỂ BỎ VÀO GAME 
        //LOAD DATA TỪ LOCAL LÊN VÀO ĐÂY
        SaveLoadStorage = new SaveLoadStorage();
        //NẾU KHÔNG PHẢI NEWGAME THÌ SẼ LOAD GAME
        //CÒN NẾU NEWGAME THÌ SAO?????

        //  if (!SaveLoadStorage.IsNewGame)
        //  {
        //      //LOAD 2 LẦN À?
        //      LoadGame(false, false);
        // }

        //TẠM THỜI Ở ĐÂY ĐẶT FLAG CHO VIỆC TEST NEWGAME

        //LoadGame(true, false);
    }

    private void FireSavedAllEvent()
    {
        if (this.SavedAllEvent != null)
        {
            this.SavedAllEvent();
        }
    }

    //LOAD GAME VỚI DẠNG NEW GAME HAY K
    public void LoadGame(bool isNewGame, bool countSession)
    {
        GameData = new GameData();

        //TẠM COMMENT ĐỂ NEW HẾT

        // //nếu newgame thì tạo gamedata mới hoàn toàn
        // if (isNewGame)
        // {
        //     GameData = new GameData();
        // }
        // //CÒN K THÌ LY T CLOUND BỎ VÀO 
        // else
        // {
        //     GameData = new GameData(SaveLoadStorage.GameRoot);
        //     GameData.ResolveDependencies();
        // }

        //chạy auto tick 
        GameData.Time.AutoTick();
    }

    //TẠO RA 1 GAME MỚI HOÀN
    public void NewGame()
    {
        SaveLoadStorage.NewGame();
        GameData = new GameData();
    }

    public void SaveAll()
    {
        SaveLoadStorage.Save(GameData);
        FireSavedAllEvent();
    }
}