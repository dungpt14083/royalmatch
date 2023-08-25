using Animancer;
using UnityEngine;

public class CharacterCollectItemBonusCommand : CutSceneCommand
{
    private CharacterManagerView _characterManager;
    private Character _character;

    private bool _walking;
    private AnimancerState _animancerState;
    private Building building;
    private Vector3 positionItemBonus;
    private ItemBonus itemBonus;
    public override void OnCreate()
    {
        _characterManager = CharacterManagerView.Instance;
        _character =
            _characterManager.GetCharacter(ExtensionUtils.GetIntParameter(CommandInfo.Parameters, "characterId"));
        building = (Building)TileManagerView.Instance.FindGridObject(
            new GridPoint(ExtensionUtils.GetVector2IntParameter(CommandInfo.Parameters, "itemBonusPosition")));
        if (building.buildingData != null)
        {
            itemBonus = building.buildingData as ItemBonus;
        }

        positionItemBonus = TileManagerView.Instance.GridIndexToLocalVector(building.Area.Index);
    }

    public override void Execute()
    {
        this.StartWalk();
    }

    public override void ExecuteInstant()
    {
    }

    public override void OnSkip()
    {
        if (itemBonus != null)
        {
            itemBonus.IsProcessCollect = false;
        }
    }

    public override void OnCancel()
    {
        if (itemBonus != null)
        {
            itemBonus.IsProcessCollect = false;
        }
    }
    private void StartWalk()
    {
        this._walking = false;

        if (building == null || itemBonus == null)
        {
            base.Complete();
            return;
        }


        if (building != null && itemBonus != null && itemBonus.CanSpendCurrencies())
        {
            if (TileManagerView.Instance.GetClosePositionToElement(building.Area, out Vector3 positionToWalk))
            {

                UnityEngine.AI.NavMeshPath navMeshPath = new UnityEngine.AI.NavMeshPath();
                if (NavMeshPathExtensions.AssignPath(navMeshPath, _character.transform.position,
                        positionToWalk))
                {
                    this._character.SetDestination(positionToWalk, OnAgentMoveCompletedItemBonus);

                }
                else
                {
                    _character.SetPosition(positionToWalk);
                    OnAgentMoveCompletedItemBonus();
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
    private void OnItemBonusAnimationEnd()
    {
        itemBonus.IsProcessCollect = itemBonus.SpendCostForDestroy();
        Complete();
    }

    //KHI DI CHUYỂN ỐI THÀNH CÔNG THÌ SẼ CHẠY ANIMATION KIA VÀ GOM RÁC
    private void OnAgentMoveCompletedItemBonus()
    {
        this._walking = false;
        this._character.LookAt(positionItemBonus);
        var animationCollectionForItemBonus = GatherableAnimationCollection.Instance.GetAnimationInfo(
            (itemBonus.BuildingProperties as ItemBonusProperties).GatherableCategory);

        AnimancerState stateAnimation = _character.PlayClip(animationCollectionForItemBonus.AnimationReference);
        stateAnimation.Events.Add(0.7f, OnItemBonusAnimationEnd);
    }
    private new void Complete()
    {
        base.Complete();
    }
}
