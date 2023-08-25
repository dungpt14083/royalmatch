using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CÁC FUNC NHƯ LÀ : 
//CHO VIỆC ACTIVE PANEL LÊN + LẤY SỐ LƯỢNG NĂNG LƯỢNG CẦN CHO...+HÀM SET IN COLLECT QUEUE CÁI NÀY KHI CLICK VÀO NÚT KIA THÌ SẼ SET VÀO QUEU THUE HOẠCH
public interface IEnergyConsumer 
{
    GatherableContextStatusPanel ActivePanel { get; set; }

    //HIỆU ỨNG SÁNG LẤP LÁNH????
    void Glow();

    int GetEnergyCost();

    void SetInCollectQueue(bool value);
}
