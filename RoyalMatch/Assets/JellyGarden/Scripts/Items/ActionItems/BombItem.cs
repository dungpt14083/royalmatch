using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombItem : ActionItem
{
    private Item itemSwitch;
    public override void Use()
    {
        if (isUsed) return;
        Debug.Log($"{gameObject.name} 333333333333333 ActionItem Use");

        isUsed = true;
        itemStatus = ItemStatus.Destroying;
        LevelManager.Instance.SquareSetItem(square,null);
        LevelManager.Instance.GetItemFallOrGenItem(square);
        var bomb = LevelManager.Instance.CreatBombDestroy(square);
        int color;
        if (itemSwitch != null && itemSwitch is ColorItem)
        {
            color = (itemSwitch as ColorItem).color;
        }
        else
        {
            var rd = UnityEngine.Random.Range(0, 5);
            color = rd;
        }

        bomb.StartDestroy(color, itemSwitch);
        var target = LevelManager.Instance.FindTaget(this);
        LevelManager.Instance.DestroyItem(this, target, false);
    }
    public void SetItemNew(Item _itemNew)
    {
        itemSwitch = _itemNew;
    }
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.BOMB;
    }
}
