using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChangeState : Item
{
    public ChangeStateTypes changeStateType;
    public Sprite[] sprStates;
    public int lastState;
    public int currentState;
    public bool isCanDestroy = true;
    public void EffectChangeState()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScaleX(1.2f, 0.1f).OnComplete(() => transform.DOScaleX(1f, 0.1f)));
        sequence.Append(transform.DOScaleY(1.2f, 0.1f).OnComplete(() => transform.DOScaleY(1f, 0.1f)));
    }
    private void OnChangeState(int nextState)
    {
        currentState = nextState;
        EffectChangeState();
        if (currentState < lastState)//con trang thai de thay doi
        {
            if (currentState < sprStates.Length)
            {
                //Todo : effect 
                sprRenderer.sprite = sprStates[currentState];
            }
        }
        else//het trang thai de thay doi
        {
            if (!isCanDestroy) return;
            LevelManager.Instance.SquareSetItem(square, null);
            square.type = SquareTypes.EMPTY;
            var target = LevelManager.Instance.FindTaget(this);
            LevelManager.Instance.DestroyItem(this, target, false);
            //EndStateAction(squaresCache);
        }
    }
    //private void HideAllBlock()
    //{
    //    foreach (var b in blocks)
    //    {
    //        if (b.activeSelf) b.SetActive(false);
    //    }
    //    Destroy(this.gameObject);
    //}
    private void OnNextState()
    {
        Debug.Log("Obstacle OnNextState " + currentState);
        if (currentState <= lastState)
        {
            int nextState = currentState + 1;
            OnChangeState(nextState);
        }
    }
    public virtual bool IsCanChangeState(ChangeStateTypes type, int _color = -1)
    {
        bool status = false;
        if (changeStateType == ChangeStateTypes.None) return status;
        if (type == ChangeStateTypes.None) return status;
        if (changeStateType != ChangeStateTypes.All && type != changeStateType) return status;
        return true;
    }
    public void CheckState(ChangeStateTypes type, int _color = -1)
    {
        if (!IsCanChangeState(type, _color)) return;
        OnNextState();
    }
    public override void OnMatchesOrPowerUp(ChangeStateTypes type, int _color = -1)
    {
        if (itemStatus != ItemStatus.Idle) return;
        base.OnMatchesOrPowerUp(type, _color);
        CheckState(type, _color);
    }
    public virtual void EndStateAction(List<Square> _squares)
    {

    }
    //public override void Package()
    //{
    //    OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
    //}
    //public override void Propeller()
    //{
    //    OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
    //}
    public override void ColiderWithObjDestroy()
    {
        OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
    }
    public override void AttackItem()
    {
        OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
    }
}
