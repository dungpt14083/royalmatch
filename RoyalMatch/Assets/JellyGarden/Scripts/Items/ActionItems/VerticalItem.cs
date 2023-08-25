using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VerticalItem : ActionItem
{
    public override void Use()
    {
        if (isUsed) return;
        isUsed = true;
        itemStatus = ItemStatus.Destroyed;
        LevelManager.Instance.SquareSetItem(square, null);
        //LevelManager.Instance.GetItemFallOrGenItem(square);
        var target = LevelManager.Instance.FindTaget(this);
        LevelManager.Instance.DestroyItem(this, target,false);
        UsedAtSquare(square);
    }
    public override void UsedAtSquare(Square target)
    {
        var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, target.transform.parent);
        verticalDestroy.Init(target.transform.position, target);
    }
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.VERTICAL_STRIPPED;
    }
}
