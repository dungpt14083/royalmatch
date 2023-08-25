using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HatObstacle : ObstacleChangeState
{
    public Item itemPrefab;
    public override void EndStateAction(List<Square> _squares)
    {
        base.EndStateAction(_squares);
        //Todo : lam sau
        //var items = LevelManager.Instance.GetItems().Where(x=>x!=null && x.currentType == ItemsTypes.NONE).ToList();

        //for(int i = 0; i < 3; i++)
        //{
        //    if (items.Count == 0) break;
        //    int index = Random.Range(0, items.Count);
        //    var itemOld = items[index];
        //    items.RemoveAt(index); 
        //    Destroy(itemOld.gameObject);
        //    var square = itemOld.square;
        //    var itemNew = GameObject.Instantiate(itemPrefab, square.transform.position,Quaternion.identity, square.transform.parent);
        //    itemNew.color = 600;
        //    itemNew.gameObject.name = "itemDiamonTest";
        //    itemNew.debugType = ItemsTypes.INGREDIENT;
        //    itemNew.currentType = ItemsTypes.INGREDIENT;
        //    itemNew.NextType = ItemsTypes.NONE;
        //    itemNew.square = square;
        //    square.SetItem(itemNew);
            
        //}
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.Hat;
    }
}
