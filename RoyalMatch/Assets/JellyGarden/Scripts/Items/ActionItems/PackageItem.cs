using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PackageItem : ActionItem
{
    public override void Use()
    {
        if (isUsed) return;
        isUsed = true;
        itemStatus = ItemStatus.Destroying;
        LevelManager.Instance.SquareSetItem(square, null);
        LevelManager.Instance.DelayedCall(0.2f, () => {

            UsedAtSquare(square);
            var target = LevelManager.Instance.FindTaget(this);
            LevelManager.Instance.DestroyItem(this, target, false);
            LevelManager.Instance.GetItemFallOrGenItem(square);
        });
    }
    public override void UsedAtSquare(Square target)
    {
        LevelManager.Instance.DestroyPackage(target, 2);
    }
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.PACKAGE;
    }
}
