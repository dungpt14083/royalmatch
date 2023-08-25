using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalDestroy : MonoBehaviour
{
    [SerializeField]
    private GameObject objTop;
    [SerializeField]
    private GameObject objBottom;
    public void Init(Vector3 posInit, Square square)
    {
        Debug.Log("----------------------------->VerticalDestroy");
        transform.position = posInit;
        MoveObjsDestroy(square);
    }
    public void MoveObjsDestroy(Square square)
    {
        float distanceTop = 10 - objTop.transform.position.y;
        float distanceBottom = objBottom.transform.position.y + 10;
        if (distanceBottom > distanceTop)
        {
            objTop.transform.DOMoveY(10, 10).SetSpeedBased(true).SetEase(Ease.Linear);
            objBottom.transform.DOMoveY(-10, 10).SetSpeedBased(true).SetEase(Ease.Linear).OnComplete(() => CompleteDestroy(square));
        }
        else
        {
            objTop.transform.DOMoveY(10, 10).SetSpeedBased(true).SetEase(Ease.Linear).OnComplete(() => CompleteDestroy(square)); 
            objBottom.transform.DOMoveY(-10, 10).SetSpeedBased(true).SetEase(Ease.Linear);
        }
    }
    private void CompleteDestroy(Square square)
    {
        for (int row = LevelManager.Instance.maxRows-1; row >-1; row--)
        {
            var _square = LevelManager.Instance.GetSquare(square.col, row);
            if (_square == null) continue;
            LevelManager.Instance.GetItemFallOrGenItem(_square);
        }
        Destroy(gameObject);
    }
}
