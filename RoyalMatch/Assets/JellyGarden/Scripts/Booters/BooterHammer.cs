using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BooterHammer : BooterBase
{
    public void Init(BootersType _bootersType)
    {
        bootersType = _bootersType;
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(Vector3.one * 1.5f, 1).OnComplete(()=>{
            //transform.DOScale(Vector3.one * 1, 1);
        }));
    }

    public void SelectSquare(Square square)
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(transform.DOScale(Vector3.one * 1, 1).OnComplete(() => {
            //transform.DOScale(Vector3.one * 1, 1);
        }));
        sequence.Append(transform.DOMove(square.transform.position, 1).OnComplete(() => {
            //transform.DOScale(Vector3.one * 1, 1);
            square.Attack();
            Destroy(gameObject);
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
}
