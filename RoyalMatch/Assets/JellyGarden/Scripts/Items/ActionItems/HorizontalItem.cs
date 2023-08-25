using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorizontalItem : ActionItem
{
    public override void Use()
    {
        if (isUsed) return;
        isUsed = true;
        itemStatus = ItemStatus.Destroyed;

        var target = LevelManager.Instance.FindTaget(this);
        LevelManager.Instance.SquareSetItem(square, null);
        LevelManager.Instance.DestroyItem(this, target,false);
        UsedAtSquare(square);
        //LevelManager.Instance.GetItemFallOrGenItem(square);
    }
    public override void UsedAtSquare(Square target)
    {
        var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, target.transform.parent);
        horizontalDestroy.Init(target.transform.position, target);
    }
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.HORIZONTAL_STRIPPED;
    }
}
