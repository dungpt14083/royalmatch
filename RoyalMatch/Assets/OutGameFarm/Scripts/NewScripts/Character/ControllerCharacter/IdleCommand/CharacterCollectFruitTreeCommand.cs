using System.Collections;
using System.Collections.Generic;
using Animancer;
using UnityEngine;

public class CharacterCollectFruitTreeCommand : CutSceneCommand
{
    private CharacterManagerView _characterManager;
    private Character _character;

    private bool _walking;
    private AnimancerState _animancerState;
    private Building building;
    private Vector3 positionGatherable;
    private FruitTreeBuilding _fruitTreeBuilding;
    public override void OnCreate()
    {
        _characterManager = CharacterManagerView.Instance;
        _character =
            _characterManager.GetCharacter(ExtensionUtils.GetIntParameter(CommandInfo.Parameters, "characterId"));
        building = (Building)TileManagerView.Instance.FindGridObject(
            new GridPoint(ExtensionUtils.GetVector2IntParameter(CommandInfo.Parameters, "gatherablePosition")));
      
        if (building.FruitTreeBuilding != null)
        {
            _fruitTreeBuilding = building.FruitTreeBuilding;
        }

        positionGatherable = TileManagerView.Instance.GridIndexToLocalVector(building.Area.Index);
    }

    public override void Execute()
    {
        this.StartWalkFruitTree();
    }

    public override void ExecuteInstant()
    {
    }

    public override void OnSkip()
    {
        if (_fruitTreeBuilding != null)
        {
            _fruitTreeBuilding.IsProcessCollect = false;
        }
    }

    public override void OnCancel()
    {
        if (_fruitTreeBuilding != null)
        {
            _fruitTreeBuilding.IsProcessCollect = false;
        }
    }
      private void StartWalkFruitTree()
    {
        this._walking = false;

        if (building == null || _fruitTreeBuilding == null)
        {
            base.Complete();
            return;
        }
        

        if (building != null && _fruitTreeBuilding != null && _fruitTreeBuilding.CanSpendCurrencies())
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
        
        _fruitTreeBuilding.IsProcessCollect = _fruitTreeBuilding.SpendCostForDestroy(); 
        Complete(); 
    }
        
    //KHI DI CHUYỂN ỐI THÀNH CÔNG THÌ SẼ CHẠY ANIMATION KIA VÀ GOM RÁC
    private void OnAgentMoveCompletedFruitItem()
    {
        this._walking = false;
        this._character.LookAt(positionGatherable);
        var animationCollectionForGatherable = GatherableAnimationCollection.Instance.GetAnimationInfo(
            _fruitTreeBuilding
                .FruitTreeProperties
                .GatherableCategory);

        AnimancerState stateAnimation = _character.PlayClip(animationCollectionForGatherable.AnimationReference);
        stateAnimation.Events.Add(0.7f, OnFruitTreeAnimationEnd);
    }
    private new void Complete()
    {
        base.Complete();
    }

}
