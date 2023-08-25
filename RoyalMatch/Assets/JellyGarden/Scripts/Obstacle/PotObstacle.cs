using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PotObstacle : ObstacleChangeState
{
    public Item itemPrefab;
    public override void EndStateAction(List<Square> _squares)
    {
        base.EndStateAction(_squares);
        var items = LevelManager.Instance.GetItems().Where(x => x != null && x is ColorItem && x.itemStatus == ItemStatus.Idle).ToList();

        for (int i = 0; i < 3; i++)
        {
            if (items.Count == 0) break;
            int index = Random.Range(0, items.Count);
            var itemOld = items[index];
            items.RemoveAt(index);
            LevelManager.Instance.SquareChangeItem(itemOld.square,ItemsTypes.Diamon);
            //itemOld.square.ChangeItemByType(ItemsTypes.Pumpkin);
            Destroy(itemOld.gameObject);
        }
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.Pot;
    }
}