using System.Collections;
using System.Collections.Generic;
using Animancer;
using UnityEngine;

public class CharacterCollectBonusTreeCommand : CutSceneCommand
{
   private CharacterManagerView _characterManager;
    private Character _character;

    private bool _walking;
    private AnimancerState _animancerState;
    private GatherableBuilding gatherableBuilding;
    private Building building;
    private Vector3 positionGatherable;
    private BonusTreeBuilding BonusTreeBuilding;


    public override void OnCreate()
    {
        _characterManager = CharacterManagerView.Instance;
        _character =
            _characterManager.GetCharacter(ExtensionUtils.GetIntParameter(CommandInfo.Parameters, "characterId"));
        building = (Building)TileManagerView.Instance.FindGridObject(
            new GridPoint(ExtensionUtils.GetVector2IntParameter(CommandInfo.Parameters, "gatherablePosition")));
      


        if (building.BonusTreeBuilding != null)
        {
            BonusTreeBuilding = building.BonusTreeBuilding;
        }

        //Lấy tâm của thằng vị trí cần dọn rác chứ k phải là góc phải dưới cùng
        positionGatherable = TileManagerView.Instance.GridIndexToLocalVector(building.Area.Index);
    }


    public override void Execute()
    {
        this.StartWalkFruitTree();
    }


    //DI CHUYỂN TỚI 
    private void StartWalk()
    {
        this._walking = false;

        //CHECK HẾT TIỀN Ở ĐÂY LUÔN K ĐỦ THÌ DỪNG
        if (building == null || BonusTreeBuilding == null ||
            InventoryManagerView.Instance.GetCurrency(CurrencyType.energy) < 1)
        {
            base.Complete();
            return;
        }


        if (building == null || BonusTreeBuilding == null)
        {
            base.Complete();
            return;
        }


        //ĐỦ TRỪ TIN THÌ MỚI CHO XÉT K THÌ BASE COMPLETE SẼ CHẠY::
        if (building != null && BonusTreeBuilding != null)
        {
            //PHẢI KIẾM SOÁT CHẶT ĐIỂM NÀY K THÌ PHẢI INVOKE NGAY LẬP TỨC KHÔNG ĐỂ BUG Ở ĐÂY
            //PHẢI XÉT CẢ TIME KHÔNG NẾU K TỚI ĐƯỢC CHẨN VỊ TRÍ THÌ PHẢI HỦY??
            if (TileManagerView.Instance.GetClosePositionToElement(building.Area, out Vector3 positionToWalk))
            {
                //gatherableBuilding.IsInProcessCollect = true;
                //Debug.LogError("positionWalk" + positionToWalk.ToString());
                positionToWalk.y = 0;

                //Xét tính toán vị trí hợp lí ở đây đã
                UnityEngine.AI.NavMeshPath navMeshPath = new UnityEngine.AI.NavMeshPath();
                var characterPosition = _character.transform.position;
                characterPosition.y = 0;
                if (NavMeshPathExtensions.AssignPath(navMeshPath, characterPosition,
                        positionToWalk))
                {
                    this._character.SetDestination(positionToWalk, OnAgentMoveCompleted);
                }
                else
                {
                    _character.SetPosition(positionToWalk);
                    OnAgentMoveCompleted();
                }

                this._walking = true;
                return;
            }
            //KHÔNG TÌM ĐƯỢC VỊ TRÍ SẼ COMPLETE DẠNG BASE VÀ CHẢ LÀM GÌ CHO THẰNG RÁC CẢ ::K GOM RÁC
            else
            {
                base.Complete();
                return;
            }
        }
        //ĐỦ TRỪ TIN THÌ MỚI CHO XÉT K THÌ BASE COMPLETE SẼ CHẠY::
    }


    //KHI DI CHUYỂN ỐI THÀNH CÔNG THÌ SẼ CHẠY ANIMATION KIA VÀ GOM RÁC
    private void OnAgentMoveCompleted()
    {
        this._walking = false;
        this._character.LookAt(positionGatherable);
        var animationCollectionForGatherable = GatherableAnimationCollection.Instance.GetAnimationInfo(
            BonusTreeBuilding
                .BonusTreeProperties
                .GatherableCategory);

        //không có aniatmion thì kết thúc luôn
        if (animationCollectionForGatherable == null || animationCollectionForGatherable.AnimationReference == null)
        {
            OnGatherAnimationEnd();
        }
        else
        {
            AnimancerState stateAnimation = _character.PlayClip(animationCollectionForGatherable.AnimationReference);
            stateAnimation.Events.Add(0.7f, OnGatherAnimationEnd);
        }
    }


    private void OnGatherAnimationEnd()
    {
        //gatherableBuilding.SpendCostForDestroy();
        //CHẠY VÀO ĐÂY
   //     gatherableBuilding.Work();
        Complete();
    }


    public override void ExecuteInstant()
    {
    }

    public override void OnSkip()
    {
        if (gatherableBuilding != null)
        {
            gatherableBuilding.IsProcessCollect = false;
            gatherableBuilding.SetInCollectQueue(false);
        }
    }

    public override void OnDiscard()
    {
    }

    public override void OnCancel()
    {
        if (gatherableBuilding != null)
        {
            gatherableBuilding.IsProcessCollect = false;
        }

        gatherableBuilding.SetInCollectQueue(false);

        if (BonusTreeBuilding != null)
        {
            BonusTreeBuilding.IsProcessCollect = false;
        }
    }


    private new void Complete()
    {
        base.Complete();
   //     BonusTreeBuilding.SetInCollectQueue(false);
    }

    #region FruitTree

    private void StartWalkFruitTree()
    {
        this._walking = false;

        if (building == null || BonusTreeBuilding == null)
        {
            base.Complete();
            return;
        }


        if (building != null && BonusTreeBuilding != null && BonusTreeBuilding.CanSpendCurrencies())
        {
            if (TileManagerView.Instance.GetClosePositionToElement(building.Area, out Vector3 positionToWalk))
            {
                UnityEngine.AI.NavMeshPath navMeshPath = new UnityEngine.AI.NavMeshPath();
                if (NavMeshPathExtensions.AssignPath(navMeshPath, _character.transform.position,
                        positionToWalk))
                {
                    this._character.SetDestination(positionToWalk, OnAgentMoveCompletedFruitItem);
                }
                else
                {
                    _character.SetPosition(positionToWalk);
                    OnAgentMoveCompletedFruitItem();
                }

                this._walking = true;
                return;
            }
            else
            {
                base.Complete();
                return;
            }
        }
    }

    private void OnFruitTreeAnimationEnd()
    {
        BonusTreeBuilding.IsProcessCollect = BonusTreeBuilding.SpendCostForDestroy();
        Complete();
    }

    //KHI DI CHUYỂN ỐI THÀNH CÔNG THÌ SẼ CHẠY ANIMATION KIA VÀ GOM RÁC
    private void OnAgentMoveCompletedFruitItem()
    {
        this._walking = false;
        this._character.LookAt(positionGatherable);
        var animationCollectionForGatherable = GatherableAnimationCollection.Instance.GetAnimationInfo(
            BonusTreeBuilding
                .BonusTreeProperties
                .GatherableCategory);

        AnimancerState stateAnimation = _character.PlayClip(animationCollectionForGatherable.AnimationReference);
        stateAnimation.Events.Add(0.7f, OnFruitTreeAnimationEnd);
    }

    #endregion
}
