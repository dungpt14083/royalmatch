using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeSceneRequest : SceneRequest
{
    //Sau khi mà loading tới scene này thì sẽ là scene 
    public override string SceneName
    {
        get { return "Welcome"; }
        set {}
    }

    //load scene trung gian ???
    public override string LoaderSceneName
    {
        get { return "FirstLoader"; }
    }

    public override float LoadingWeight
    {
        get { return 0.7f; }
    }

    //từ đây sẽ tạo cityisland và tạo ra đủ thử trong này như việc lấy data server xem game mới hay k bla bla 
    //SẼ MANG CITYISLAND DATA LƯU CHUYỂN KHẮP NƠI TỪ VIỆC TẠO INSTANCE MƯỚI Ở ĐÂY:::
    public FarmIsLandData FarmIsLandData { get; private set; }

    //trong request này sẽ được gọi ở loader sau khi gọi unload scene cũ và load resource scene nếu có
    public override IEnumerator LoadDuringSceneSwitch()
    {
        //INIT FIREBASE APP XONG THÌ TẠO INSTANCE NEW FARMISSLANDATA CHỜ INIT FIREBASE NẾU CÓ:::
        yield return new WaitForEndOfFrame();
        //TẠO MỘT CÁI NEW DATA TỪ ĐÓ SẼ : 
        FarmIsLandData = new FarmIsLandData();

        //TỪ ĐÂY SẼ CHỜ AUTH THÀNH CỘNG TỚI SERVER::ĐỌẠN NÀY CÓ TRẢ VỀ TRUE CHỨ K CÓ TRUE NGHĨA LÀ GAME NÀY OFFLINE ĐƯỢC SẼ CHẾ CHẨM DATABACKUP Ở ĐÂY::
        //SAU ĐÓ LẠI VÀO CLUNDSTORAGE SYNC WITH SERRVER DATA:::
        //KÉO  VỀ NẾU THÀNH CÔNG THÌ OK K THÌ CŨNG OK

        //TỪ ĐÂY SẼ XÉT XEM LÀ GAME HOÀN TOÀN MỚI HAY GAME CÓ LƯU TRỮ 1 LẦN R 
        bool isNewGame = FarmIsLandData.SaveLoadStorage.IsNewGame;

        //NẾU LÀ GAME MỚI THÌ SẼ ĐĂNG KÌ GÌ GÌ VỚI SERVER
        //NẾU KHÔNG THÌ GỌI TỚI SYNC WITH SERVER VỚI cityusland game lên trên đó::

        //sau đó sẽ load game vi cityissland là newgame hay k
        //và chạy 1 lần save all
        FarmIsLandData.LoadGame(isNewGame, !isNewGame);
        FarmIsLandData.SaveAll();

        //FarmIsLandData.LoadGame(isNewGame, !isNewGame);
        //FarmIsLandData.SaveAll();
        base.Progress = 1f;
        base.HasCompleted = true;
    }
}