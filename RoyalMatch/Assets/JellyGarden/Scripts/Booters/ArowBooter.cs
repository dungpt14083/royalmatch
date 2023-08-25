using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArowBooter : BooterBase
{
    public GameObject arow;
    public void Init(BootersType _bootersType)
    {
        bootersType = _bootersType;
        gameObject.SetActive(false);
    }

    public void SelectSquare(Square square)
    {
        var squareCol0 = LevelManager.Instance.GetSquare(0, square.row);
        if (squareCol0 == null) return;
        gameObject.SetActive(true);
        var squareColMax = LevelManager.Instance.GetSquare(LevelManager.Instance.maxCols-1, square.row);
        transform.position = squareCol0.transform.position + new Vector3(-2, 0, 0);
        arow.transform.localPosition = Vector3.zero;
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(arow.transform.DOMove(squareColMax.transform.position + new Vector3(2, 0, 0), 1).OnComplete(() => {
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
        for (int col = 0; col < LevelManager.Instance.maxCols; col++)
        {
            var _square = LevelManager.Instance.GetSquare(col, square.row);
            if (_square == null) continue;
            LevelManager.Instance.GetItemFallOrGenItem(_square);
        }
        Destroy(gameObject);
    }
}
