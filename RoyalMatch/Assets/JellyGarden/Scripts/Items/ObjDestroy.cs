using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D collision " + collision.gameObject.name);
        var item = collision.gameObject.GetComponent<Item>();
        if (item != null && item.itemStatus == ItemStatus.Creating) return;
        if (item != null && item.itemStatus != ItemStatus.Destroyed)
        {
            //item.itemStatus = ItemStatus.Destroyed;
            //var square = item.square;
            //if (item is ActionItem) (item as ActionItem).Use();
            //LevelManager.Instance.SquareSetItem(square, null);
            //LevelManager.Instance.GetItemFallOrGenItem(square);
            item.ColiderWithObjDestroy();
            //LevelManager.Instance.DestroyItem(item, item is ColorItem);
        }
        else
        {
            var obstacle = collision.gameObject.GetComponent<ObstacleBase>();
            if (obstacle != null) obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
        }
    }
}
