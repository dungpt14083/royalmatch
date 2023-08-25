using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class FinishQuestAction : MapAction
{

    //CHO THẰNG SỰ KIỆN QUEST COMPLETEEVENT:::
    private QuestEventData _questData;



    #region KHI MÀ KHỞI TẠO VÀ NGHE KẾT THÚC ACTION BẰNG SIGNAL QUESTFINISH

    //ĐƯA TẠO CONTRUCTOR VÀ Ở ĐÂY SẼ ĐĂNG KÍ NGHE SỰ KIỆN CỦA THẰNG FINISHQUEST ĐỂ COMPLETE CÁI NÀY ACTION:
    public FinishQuestAction(QuestEventData questData)
    {
        _questData = questData;
        QuestManagerSignals.QuestFinishEventSignal.AddListener(OnQuestFinish);
    }

    
    private void OnQuestFinish(UserQuestData data)
    {
        QuestManagerSignals.QuestFinishEventSignal.RemoveListener(OnQuestFinish);
        this.Complete();
    }

    #endregion
 
    

    public override void Play()
    {

        if (_questData==null)
        {
            Complete();
            return;
        }
        
        
        
        //CẦN PHÂN BIẾT RÕ 2 LOẠI QUEST:
        //1: LÀ KHI MÀ QUEST PHÁT RA Ở ĐẢO NÀY THÌ CHỈ CÁC VẬT LIỆU Ở ĐẢO ĐÓ:
        //2: LÀ KHI QUEST LIÊN QUAN TỚI ĐẢO NÀY ĐẢO KIA THÌ CHỈ CÓ XÂY NHÀ CẦN THU THẬP VẬT LIỆU NÀY KIA
        //VÀ TƯ ĐÂY KHI THU THẬP XONG ẤN BUILD STAGE NHÀ THÌ MỚI HOÀN THÀNH VÀ TỪ ĐÓ MS CHẠY CUTSCENE Ở ĐẢO ĐÓ
        
        
        
        //TASK LÀ BUIDRUIN// LÀ NHEIEFU ĐẢO TÍNH SAU::::
        
        //TRONG NÀY SẼ FINISH QUEST
        //CÁI NÀY CHIR DÀNH CHO THẰNG chuyển SCENE THÌ MỚI XÉT CHUYỂN XONG LÀ COMPLETE LUÔN KHÔNG CẦN SHOW LÊN PANEL
        // if (!_questData.QuestInfo.FinishRequirements.Any(info => info.RequirementType==RequirementType.Adventure))
        // {
        //     //Finish trự tiếp và không mở cái gì ra nữa::::
        //     FarmQuestManagerView.Instance.FinishQuest(_questData.QuestData);
        //     Complete();
        //     return;
        // }

        
        
        //ĐOẠN NÀY ĐẶC BIỆT CHẠY FINISH SHOW THWAFNG NHIỆM VỤ COMPLETE PANEL XONG MỚI CHẠY CUTSCENE
        //FINISH TRƯỚC KHI CHẠY CUTSCENE 
        //FINISH HIỆN LÊN POPUP FINISH TRƯỚC KHI CHẠY CÚUTSCENE
        //ÍT NHẤT CHẠY 1 LẦN XONG MẤY H HOẶC CÓ NÚT ẤN NẾU CÓ LEVELUP MỚI CÓ NÚT K THÌ SẼ TỰ CHUYỂN 
        //VÀ EXPT BAY LÊN XONG MỚI CHẠY CUTSCENE 
        
        
        //Show lên rồi 1 2 s nó tự động FINISH VÀ CHUYỂN SANG CUTSCENE BẰNG MAPACTION QUEUE
        QuestHudItemManager.Instance.ShowPanel(_questData.QuestData.Id);
    }
}