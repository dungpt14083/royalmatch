using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PropellerItem : ActionItem
{
    public override void Use()
    {
        if (isUsed) return;
        isUsed = true;
        itemStatus = ItemStatus.Destroying;
        UsePropeller();
    }
    public void UsePropeller()
    {
        if (square == null) return;
        this.SetItemStatus(ItemStatus.Destroyed, "UsePropeller");
        LevelManager.Instance.SquareSetItem(square, null);
        var squareLeft = square.GetNeighborLeft();
        var squareRight = square.GetNeighborRight();
        var squareBottom = square.GetNeighborBottom();
        var squareTop = square.GetNeighborTop();
        squareLeft?.Attack();
        squareRight?.Attack();
        squareBottom?.Attack();
        squareTop?.Attack();
        LevelManager.Instance.GetItemFallOrGenItem(square);
        var target = LevelManager.Instance.GetSquareTarget();
        transform.DOMove(target.transform.position, 3f).OnComplete(()=> {
            target.Attack();
            Destroy(gameObject);
        });
    }
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.PROPELLER;
    }
}
