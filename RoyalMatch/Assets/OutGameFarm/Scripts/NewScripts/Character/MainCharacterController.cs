using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    [SerializeField] private Character character;
    [SerializeField] private MainCharacterPlaneClickTracker mainCharacterPlaneClickTracker;

    private CutSceneCommandInfoFactory _cutSceneCommandInfoFactory;
    private IdleCutsceneInfoFactory _idleCutsceneInfoFactory;
    private IdleCutsceneManager _idleCutsceneManager;


    void Start()
    {
        mainCharacterPlaneClickTracker.TilePlaneSuccessivePressEvent += OnTilePlanePressSuccess;
        mainCharacterPlaneClickTracker.TileCollectGatherableSuccessiveEvent += OnGatherableQueued;
        mainCharacterPlaneClickTracker.TileCollectFruitTreeSuccessiveEvent += OnFruitTreeQueued;
        mainCharacterPlaneClickTracker.TileCollectBonusItemSuccessiveEvent += OnItemBonusQueued;
        mainCharacterPlaneClickTracker.TileCollectBonusTreeSuccessiveEvent += OnBonusTreeQueued;

        _cutSceneCommandInfoFactory = CutSceneCommandInfoFactory.Instance;
        _idleCutsceneInfoFactory = IdleCutsceneInfoFactory.Instance;
        _idleCutsceneManager = IdleCutsceneManager.Instance;
    }

    public void OnDestroy()
    {
        mainCharacterPlaneClickTracker.TilePlaneSuccessivePressEvent -= OnTilePlanePressSuccess;
        mainCharacterPlaneClickTracker.TileCollectGatherableSuccessiveEvent -= OnGatherableQueued;
        mainCharacterPlaneClickTracker.TileCollectFruitTreeSuccessiveEvent -= OnFruitTreeQueued;
        mainCharacterPlaneClickTracker.TileCollectBonusItemSuccessiveEvent -= OnItemBonusQueued;
        mainCharacterPlaneClickTracker.TileCollectBonusTreeSuccessiveEvent -= OnBonusTreeQueued;
    }

    private void OnTilePlanePressSuccess(Vector3 worldClickPosition)
    {
        //Show cái nút bấm ở vị trí bấm
        //this._characterClickAnimationManager.Show( worldClickPosition});
        CutsceneCommandInfo cutsceneCommandInfo =
            _cutSceneCommandInfoFactory.GetNewCharacterFreeWalkCommandInfo(character.characterId, worldClickPosition);
        var tmp = new List<CutsceneCommandInfo>();
        tmp.Add(cutsceneCommandInfo);

        //Tạo lệnh gán lệnh vào database local
        CutSceneInfo cutSceneInfo = CutSceneInfo.CreateInOrder("CharacterWalkTo", tmp);
        //TỪ ĐÓ SẼ TẠO Ở ĐÂY THẰNG CUTSCENE VỚI DÒNG ĐÓ CÒN HÀNH VI THÌ DO CUTSCENE LẤY TỪ LOCAL LÊN???1 LỆNH NÀO ĐÓ ĐƯỢC COLLECT SẴN
        CutScene cutscene = new CutScene(cutSceneInfo, null);
        //Chỉ chứa độ ưu tiên của thằng lệnh chạy này
        IdleCutsceneInfo tmpIdleCutsceneInfo = this._idleCutsceneInfoFactory.GetMainCharacterWalkIdleCutsceneInfo();
        _idleCutsceneManager.TryRegisterCutscene(character.characterId, tmpIdleCutsceneInfo, cutscene);
    }


    //Đây chr tạo ra data thô còn cutscene tạo ra command thì mới là nó::::
    private void OnGatherableQueued(GatherableBuilding gatherableBuilding)
    {
        IdleCutsceneInfo idleCutsceneInfo;

        if (this.gameObject.activeInHierarchy == false)
        {
            return;
        }

        //Sản xuất ra command với id nhân vật và id rác
        CutsceneCommandInfo commandInfo =
            _cutSceneCommandInfoFactory.GetNewCharacterCollectGatherableInfo(character.characterId, gatherableBuilding.Building.Area.Index);
        var tmp = new List<CutsceneCommandInfo>();
        tmp.Add(commandInfo);

        //Tạo Cutsceneinfo và tạo cutscene 
        CutSceneInfo cutSceneInfo = CutSceneInfo.CreateInOrder("CharacterCollectGatherable", tmp);
        CutScene cutscene = new CutScene(cutSceneInfo, null);

        //VỪA TRUYỀN CẢ CUTSCENE VƯ TRUYỀN CẢ IDLECUTSCENEINFO VÀO ĐỂ MÀ???VẬY BÊN IDLE CUNG CẤP 1 LĨNH VỰC HOOÀN TOÀN KHÁC
        //Lấ THÔNG TN VỀ ĐỘ ƯU TIÊN 
        IdleCutsceneInfo tmpIdleCutsceneInfo = _idleCutsceneInfoFactory.GetMainCharacterCollectIdleCutsceneInfo();

        //tRONG IDLECUTSCEEINFO TRỐNG HẾT CHỈ CÓ MỖI THẰNG ĐỘ ƯU TIÊN:::
        _idleCutsceneManager.TryRegisterCutscene(character.characterId, tmpIdleCutsceneInfo, cutscene);
    }
    
    //Đây chr tạo ra data thô còn cutscene tạo ra command thì mới là nó::::
    private void OnFruitTreeQueued(FruitTreeBuilding fruitTreeBuilding)
    {
        IdleCutsceneInfo idleCutsceneInfo;

        if (this.gameObject.activeInHierarchy == false)
        {
            return;
        }

        //Sản xuất ra command với id nhân vật và id rác
        CutsceneCommandInfo commandInfo =
            _cutSceneCommandInfoFactory.GetNewCharacterCollectFruitTreeInfo(character.characterId, fruitTreeBuilding.Building.Area.Index);
        var tmp = new List<CutsceneCommandInfo>();
        tmp.Add(commandInfo);

        //Tạo Cutsceneinfo và tạo cutscene 
        CutSceneInfo cutSceneInfo = CutSceneInfo.CreateInOrder("CharacterCollectFruitTree", tmp);
        CutScene cutscene = new CutScene(cutSceneInfo, null);

        //VỪA TRUYỀN CẢ CUTSCENE VƯ TRUYỀN CẢ IDLECUTSCENEINFO VÀO ĐỂ MÀ???VẬY BÊN IDLE CUNG CẤP 1 LĨNH VỰC HOOÀN TOÀN KHÁC
        //Lấ THÔNG TN VỀ ĐỘ ƯU TIÊN 
        IdleCutsceneInfo tmpIdleCutsceneInfo = _idleCutsceneInfoFactory.GetMainCharacterCollectIdleCutsceneInfo();

        //tRONG IDLECUTSCEEINFO TRỐNG HẾT CHỈ CÓ MỖI THẰNG ĐỘ ƯU TIÊN:::
        _idleCutsceneManager.TryRegisterCutscene(character.characterId, tmpIdleCutsceneInfo, cutscene);
    }
    private void OnBonusTreeQueued(BonusTreeBuilding bonusTreeBuilding)
    {
        IdleCutsceneInfo idleCutsceneInfo;

        if (this.gameObject.activeInHierarchy == false)
        {
            return;
        }

        //Sản xuất ra command với id nhân vật và id rác
        CutsceneCommandInfo commandInfo =
            _cutSceneCommandInfoFactory.GetNewCharacterCollectBonusTreeInfo(character.characterId, bonusTreeBuilding.Building.Area.Index);
        var tmp = new List<CutsceneCommandInfo>();
        tmp.Add(commandInfo);

        //Tạo Cutsceneinfo và tạo cutscene 
        CutSceneInfo cutSceneInfo = CutSceneInfo.CreateInOrder("CharacterCollectBonusTree", tmp);
        CutScene cutscene = new CutScene(cutSceneInfo, null);

        //VỪA TRUYỀN CẢ CUTSCENE VƯ TRUYỀN CẢ IDLECUTSCENEINFO VÀO ĐỂ MÀ???VẬY BÊN IDLE CUNG CẤP 1 LĨNH VỰC HOOÀN TOÀN KHÁC
        //Lấ THÔNG TN VỀ ĐỘ ƯU TIÊN 
        IdleCutsceneInfo tmpIdleCutsceneInfo = _idleCutsceneInfoFactory.GetMainCharacterCollectIdleCutsceneInfo();

        //tRONG IDLECUTSCEEINFO TRỐNG HẾT CHỈ CÓ MỖI THẰNG ĐỘ ƯU TIÊN:::
        _idleCutsceneManager.TryRegisterCutscene(character.characterId, tmpIdleCutsceneInfo, cutscene);
    }

    //Đây chr tạo ra data thô còn cutscene tạo ra command thì mới là nó::::
    private void OnItemBonusQueued(ItemBonus itemBonus)
    {
        IdleCutsceneInfo idleCutsceneInfo;

        if (this.gameObject.activeInHierarchy == false)
        {
            return;
        }

        //Sản xuất ra command với id nhân vật và id rác
        CutsceneCommandInfo commandInfo =
            _cutSceneCommandInfoFactory.GetNewCharacterCollectItemBonusInfo(character.characterId, itemBonus.Building.Area.Index);
        var tmp = new List<CutsceneCommandInfo>();
        tmp.Add(commandInfo);

        //Tạo Cutsceneinfo và tạo cutscene 
        CutSceneInfo cutSceneInfo = CutSceneInfo.CreateInOrder("CharacterCollectItemBonus", tmp);
        CutScene cutscene = new CutScene(cutSceneInfo, null);

        //VỪA TRUYỀN CẢ CUTSCENE VƯ TRUYỀN CẢ IDLECUTSCENEINFO VÀO ĐỂ MÀ???VẬY BÊN IDLE CUNG CẤP 1 LĨNH VỰC HOOÀN TOÀN KHÁC
        //Lấ THÔNG TN VỀ ĐỘ ƯU TIÊN 
        IdleCutsceneInfo tmpIdleCutsceneInfo = _idleCutsceneInfoFactory.GetMainCharacterCollectIdleCutsceneInfo();

        //tRONG IDLECUTSCEEINFO TRỐNG HẾT CHỈ CÓ MỖI THẰNG ĐỘ ƯU TIÊN:::
        _idleCutsceneManager.TryRegisterCutscene(character.characterId, tmpIdleCutsceneInfo, cutscene);
    }

    #region SẼ Ở ĐÂY LÀ CÁC HÀM CHO SỰ KIỆN CONTROLLER nhân vật các hành ộng ngoài lề

    #endregion
}