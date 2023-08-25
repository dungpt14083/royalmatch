using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooterCannon : BooterBase
{
    public GameObject bullet;
    public void Init(BootersType _bootersType)
    {
        bootersType = _bootersType;
        gameObject.SetActive(false);
    }

    public void SelectSquare(Square square)
    {
        var squareRowMax = LevelManager.Instance.GetSquare(square.col, LevelManager.Instance.maxRows-1);
        if (squareRowMax == null) return;
        gameObject.SetActive(true);
        var squareRow0 = LevelManager.Instance.GetSquare(square.col, 0);
        transform.position = squareRowMax.transform.position + new Vector3(0, -2, 0);
        bullet.transform.localPosition = Vector3.zero;
        Sequence sequence = DOTween.Sequence();

        sequence.Append(bullet.transform.DOMove(squareRow0.transform.position + new Vector3(0, 2, 0), 1).OnComplete(() => {
            CompleteDestroy(square);
        }));
    }
    public override bool UseBooter(Square square)
    {
        if (square == null)
        {
            Destroy(gameObject);
            return false;
        }
        else
        {
            SelectSquare(square);
            return true;
        }
    }
    private void CompleteDestroy(Square square)
    {
        for (int row = LevelManager.Instance.maxRows - 1; row > -1; row--)
        {
            var _square = LevelManager.Instance.GetSquare(square.col, row);
            if (_square == null) continue;
            LevelManager.Instance.GetItemFallOrGenItem(_square);
        }
        Destroy(gameObject);
    }
}
