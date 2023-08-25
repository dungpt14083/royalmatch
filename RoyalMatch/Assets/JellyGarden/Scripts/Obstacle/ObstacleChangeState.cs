using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleChangeState : ObstacleBase
{
    public ChangeStateTypes changeStateType;
    public GameObject[] blocks;
    public int lastState;
    public int currentState;
    public bool isLoop = false;

    public override void Init(List<Square> _squares)
    {
        base.Init(_squares);
        currentState = 0;
        lastState = blocks.Length - 1;
        for (int i = 0; i < blocks.Length; i++)
        {
            blocks[i].SetActive(false);
        }
        blocks[currentState].SetActive(true);
    }
    public void EffectChangeState()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScaleX(1.2f, 0.1f).OnComplete(() => transform.DOScaleX(1f, 0.1f)));
        sequence.Append(transform.DOScaleY(1.2f, 0.1f).OnComplete(() => transform.DOScaleY(1f, 0.1f)));
    }
    private void OnChangeState(int nextState)
    {
        int oldState = currentState;
        currentState = nextState;
        EffectChangeState();
        if (currentState <= lastState)//con trang thai de thay doi
        {
            if (blocks.Length > oldState)
            {
                //Todo : effect 
                blocks[oldState].SetActive(false);
                blocks[currentState].SetActive(true);
            }
        }
        else//het trang thai de thay doi
        {
            var squaresCache = new List<Square>();
            squaresCache.AddRange(squares);
            if (!isLoop)
            {
                DestroyObstacle();
            }
            else
            {
                currentState = 0;
                //for (int i = 0; i < blocks.Length; i++)
                //{
                //    blocks[i].SetActive(i <= lastState);
                //}
                blocks[oldState].SetActive(false);
                blocks[currentState].SetActive(true);
            }
            EndStateAction(squaresCache);
        }
    }
    private void HideAllBlock()
    {
        foreach (var b in blocks)
        {
            if (b.activeSelf) b.SetActive(false);
        }
        Destroy(this.gameObject);
    }
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
        base.OnMatchesOrPowerUp(type, _color);
        CheckState(type, _color);
    }
    public virtual void EndStateAction(List<Square> _squares)
    {

    }
    public override void DestroyObstacle()
    {
        //thay doi cac trang thai cua square khong co vat can
        foreach (var s in squares)
        {
            s.obstacle = null;
            s.GetItemFallOrGenItem();
            //if (s.type == SquareTypes.SOLIDBLOCK) s.type = SquareTypes.EMPTY;
        }
        squares.Clear();
        //an het cac trang thai cua block
        HideAllBlock();
    }
}
