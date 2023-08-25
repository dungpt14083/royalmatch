using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalDestroy : MonoBehaviour
{
    [SerializeField]
    private GameObject objLeft;
    [SerializeField]
    private GameObject objRight;
    public void Init(Vector3 posInit, Square square)
    {
        Debug.Log("----------------------------->HorizontalDestroy");
        transform.position = posInit;
        MoveObjsDestroy(square);
    }
    public void MoveObjsDestroy(Square square)
    {
        float distanceRight = 10 - objRight.transform.position.x;
        float distanceLeft = objLeft.transform.position.x + 10;
        if(distanceRight > distanceLeft)
        {
            objLeft.transform.DOMoveX(-10, 10).SetEase(Ease.Linear).SetSpeedBased(true);
            objRight.transform.DOMoveX(10, 10).SetEase(Ease.Linear).SetSpeedBased(true).OnComplete(() =>CompleteDestroy(square));
        }
        else
        {
            objLeft.transform.DOMoveX(-10, 10).SetEase(Ease.Linear).SetSpeedBased(true).OnComplete(() => CompleteDestroy(square));
            objRight.transform.DOMoveX(10, 10).SetEase(Ease.Linear).SetSpeedBased(true);
        }
    }
    private void CompleteDestroy(Square square)
    {
        for(int col = 0; col < LevelManager.Instance.maxCols; col++)
        {
            var _square = LevelManager.Instance.GetSquare(col, square.row);
            if (_square == null) continue;
            LevelManager.Instance.GetItemFallOrGenItem(_square);
        }
        Destroy(gameObject);
    }
}
