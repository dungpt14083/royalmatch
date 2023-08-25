using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CHO VIỆC NGHE SỰ KIỆN Ở BÊN click vào PLANE ĐỂ TỪ ĐÓ CHECK VỊ TRÍ NÀY NỌ ĐỂ TỪ ĐÓ QUYẾT ĐỊNH DỊCH CHUYỂN HAY K
public class MainCharacterPlaneClickTracker : MonoBehaviour
{
    public delegate void TilePlaneSuccessivePressHandler(Vector3 worldClickPosition);

    public event TilePlaneSuccessivePressHandler TilePlaneSuccessivePressEvent;

    public void FireTilePlaneSuccessiveEvent(Vector3 worldClickPosition)
    {
        if (this.TilePlaneSuccessivePressEvent != null)
        {
            this.TilePlaneSuccessivePressEvent(worldClickPosition);
        }
    }

    //[SerializeField] private CharacterAgentController characterAgentController;


    private Coroutine _tileManagerViewNull;
    private TileManagerView _tileManagerView;

    public void Start()
    {
        _tileManagerViewNull = StartCoroutine(WaitForTileManagerView());
    }

    public void OnDestroy()
    {
        if (_tileManagerViewNull != null && _tileManagerView != null)
        {
            StopAllCoroutines();
            TileManagerView.Instance.TilePlanePressEvent -= OnTilePlanePressEvent;
            _tileManagerView.TileCollectGatherablePressEvent -= OnTileCollectGatherableEvent;
            _tileManagerView.TileCollectTreeFruitPressEvent -= OnTileCollectFruitTreeEvent;
            _tileManagerView.TileCollectItemBonusPressEvent -= OnTileCollectBonusItemEvent;
            _tileManagerView.TileCollectBonusTreePressEvent -= OnTileCollectBonusTreeEvent;
        }
    }

    private IEnumerator WaitForTileManagerView()
    {
        yield return new WaitUntil(() => TileManagerView.Instance != null);
        _tileManagerView = TileManagerView.Instance;
        _tileManagerView.TilePlanePressEvent += OnTilePlanePressEvent;
        _tileManagerView.TileCollectGatherablePressEvent += OnTileCollectGatherableEvent;
        _tileManagerView.TileCollectTreeFruitPressEvent += OnTileCollectFruitTreeEvent;
        _tileManagerView.TileCollectItemBonusPressEvent += OnTileCollectBonusItemEvent;
        _tileManagerView.TileCollectBonusTreePressEvent += OnTileCollectBonusTreeEvent;
    }

    //Csai kia tạm thi thả nhân vật vào đây chạy chứ phải dùng lenh:::
    //PHẢI CHECK VỤ TRÓ HỢP LỆ K Ở ĐÂY TỪ ĐO MỚI INVOKE SỰ KIỆN ẤN THÀNH OCONG ĐỂ MAINCHARRACTER BẮT
    private void OnTilePlanePressEvent(Vector3 worldClickPosition)
    {
        //Chẹcđủ th traccker rồi ms phát tín hiệu cho maincharacter nhận để chạy::::::::

        if (_tileManagerView.IsTileReached(worldClickPosition) &&
            _tileManagerView.IsFreeAndValidPosition(worldClickPosition))
        {
            FireTilePlaneSuccessiveEvent(worldClickPosition);
        }
    }


    #region CHECK COLLECT VÀ PHÁT SỰ KIỆN

    public delegate void TileCollectGatherableSuccessiveHandler(GatherableBuilding gatherableBuilding);

    public event TileCollectGatherableSuccessiveHandler TileCollectGatherableSuccessiveEvent;

    public void FireTileCollectGatherableSuccessiveEvent(GatherableBuilding gatherableBuilding)
    {
        if (this.TileCollectGatherableSuccessiveEvent != null)
        {
            this.TileCollectGatherableSuccessiveEvent(gatherableBuilding);
        }
    }

    //Ở ĐÂY CHECK VỊ TRÍ HỢP LỆ K CHO THẰNG RÁC::
    private void OnTileCollectGatherableEvent(GatherableBuilding gatherableBuilding)
    {
        FireTileCollectGatherableSuccessiveEvent(gatherableBuilding);
    }
    
    // FruitTree
    public delegate void TileCollectFruitTreeSuccessiveHandler(FruitTreeBuilding fruitTreeBuilding);

    public event TileCollectFruitTreeSuccessiveHandler TileCollectFruitTreeSuccessiveEvent;

    public void FireTileCollectFruitTreeSuccessiveEvent(FruitTreeBuilding fruitTreeBuilding)
    {
        if (this.TileCollectFruitTreeSuccessiveEvent != null)
        {
            this.TileCollectFruitTreeSuccessiveEvent(fruitTreeBuilding);
        }
    }

    //Ở ĐÂY CHECK VỊ TRÍ HỢP LỆ K CHO THẰNG RÁC::
    private void OnTileCollectFruitTreeEvent(FruitTreeBuilding fruitTreeBuilding)
    {
        FireTileCollectFruitTreeSuccessiveEvent(fruitTreeBuilding);
    }
    
    // BonusItem

    public Action<ItemBonus> TileCollectBonusItemSuccessiveEvent;

    public void FireTileCollectBonusItemSuccessiveEvent(ItemBonus fruitTreeBuilding)
    {
        if (this.TileCollectBonusItemSuccessiveEvent != null)
        {
            this.TileCollectBonusItemSuccessiveEvent(fruitTreeBuilding);
        }
    }

    //Ở ĐÂY CHECK VỊ TRÍ HỢP LỆ K CHO THẰNG BonusItem::
    private void OnTileCollectBonusItemEvent(ItemBonus ItemBonus)
    {
        FireTileCollectBonusItemSuccessiveEvent(ItemBonus);
    }

    //BonusTree
    public delegate void TileCollectBonusTreSuccessiveHandler(BonusTreeBuilding bonusTreeBuilding);

    public event TileCollectBonusTreSuccessiveHandler TileCollectBonusTreeSuccessiveEvent;

    public void FireTileCollectBonusTreeSuccessiveEvent(BonusTreeBuilding bonusTreeBuilding)
    {
        if (TileCollectBonusTreeSuccessiveEvent != null)
        {
            this.TileCollectBonusTreeSuccessiveEvent(bonusTreeBuilding);
        }
    }
    //Ở ĐÂY CHECK VỊ TRÍ HỢP LỆ K CHO THẰNG RÁC::
    private void OnTileCollectBonusTreeEvent(BonusTreeBuilding fruitTreeBuilding)
    {
        FireTileCollectBonusTreeSuccessiveEvent(fruitTreeBuilding);
    }
    #endregion
}