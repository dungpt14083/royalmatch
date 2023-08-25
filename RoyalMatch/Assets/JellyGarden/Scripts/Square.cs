using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class Square : MonoBehaviour
{
    public Item item;
    public int row;
    public int col;
    public SquareTypes type;
    public ObstacleBase obstacle;
    public bool isCanGenItem = false;
    public List<ItemsTypes> GenItems = new List<ItemsTypes>();
    
    // Use this for initialization
    void Start()
    {

    }
    public bool isCanGenItemNew()
    {
        if (GenItems == null || GenItems.Count == 0) return false;
        if (item != null) return false;
        if (!CanGoInto()) return false;
        if (IsNone()) return false;
        return true;
    }
    //public bool CheckCanGenItemNew()
    //{
    //    if (GenItems == null || GenItems.Count == 0) return false;
    //    if (item != null) return false;
    //    if (!CanGoInto()) return false;
    //    if (IsNone()) return false;
    //    return true;
    //}
    
    public void SetItem(Item _item)
    {
        try
        {
            Debug.Log($"{gameObject.name} SetItem col = {col} row {row} item old {item?.name} item new {_item?.name}");
        }catch(System.Exception e)
        {
            Debug.Log($"{gameObject.name} SetItem col = {col} row {row} Exception {e.StackTrace}");
        }
        item = _item;
        if (item != null) item.square = this;
        //GetItemFallOrGenItem();
    }
    public void GetItemFallOrGenItem()
    {
        if (isCanGenItemNew())
        {
            GenItem();
        }
        else if (item == null)
        {
            LevelManager.Instance.FindItemFall(this);
        }
        else if(item != null)
        {
            item.StartFalling();
        }
    }
    public void Attack()
    {
        if(obstacle != null)
        {
            obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
            return;
        }
        if (item == null) return;
        item.AttackItem();
    }
    public void AttackItem()
    {
        if (obstacle != null)
        {
            return;
        }
        if (item == null) return;
        item.AttackItem();
    }
    public void GenItem()
    {
        if (!isCanGenItemNew()) return;
        int color = UnityEngine.Random.Range(1, 6);
        var itemNew = LevelManager.Instance.GetItemByType((ItemsTypes)color);
        if (itemNew == null) return;
        var _item = Instantiate(itemNew, transform.parent);
        _item.transform.localScale = Vector3.one * 0.6f;
        _item.transform.position = transform.position + Vector3.back * 0.2f + Vector3.up * 2f;
        _item.Init(_item.transform.position);
        _item.SetItemStatus(ItemStatus.Creating, "CheckGenItem");
        
        SetItem(_item);
        _item.StartFalling();
        if(itemNew is ColorItem)
        {
            var bomb = LevelManager.Instance.FindBombDestroy((itemNew as ColorItem).color);
            if(bomb != null && !bomb.isDestroy)
            {
                item.SetMes("_bomb.AddItemToPending");
                item.bombDestroy = bomb;
                bomb.AddItemToPending(_item);
            }
        }
    }
    public void ChangeItemByType(ItemsTypes itemsType)
    {
        var itemNew = LevelManager.Instance.GetItemByType(itemsType);
        if (itemNew == null) return;
        var _item = Instantiate(itemNew, transform.parent);
        _item.square = this;
        _item.transform.localScale = Vector3.zero;
        _item.transform.position = transform.position;
        _item.Init(_item.transform.position);
        _item.SetItemStatus(ItemStatus.Creating, "ChangeItemByType");
        LevelManager.Instance.SquareSetItem(this,_item);
        _item.transform.DOScale(Vector3.one * 0.8f, 0.25f).OnComplete(()=> {
            _item.transform.DOScale(Vector3.one * 0.6f, 0.25f);
        });
        DOVirtual.DelayedCall(0.5f, () =>
        {
            _item.SetItemStatus(ItemStatus.Idle, "ChangeItemByType");
            LevelManager.Instance.CheckFalling(_item);
        });
    }
    public void BombChangeItemByItem(Item itemNew)
    {
        if (itemNew == null) return;
        var itemOld = item;
        if(itemOld != null)
        {
            Destroy(itemOld.gameObject);
        }
        
        Item itemChange = itemNew;
        if (itemNew is HorizontalItem || itemNew is VerticalItem)
        {
            ItemsTypes typeNew = ItemsTypes.HORIZONTAL_STRIPPED;
            int rd = Random.Range(0, 2);
            if (rd == 0) typeNew = ItemsTypes.VERTICAL_STRIPPED;
            itemChange = LevelManager.Instance.GetItemByType(typeNew);
        }
        if (itemChange == null) return;
        var _item = Instantiate(itemChange, transform.parent);
        _item.square = this;
        _item.transform.localScale = Vector3.one * 0.8f;
        _item.transform.position = transform.position;
        _item.Init(_item.transform.position);
        _item.SetItemStatus(ItemStatus.Destroying, "BombChangeItemByItem");
        //SetItem(_item);
        LevelManager.Instance.SquareSetItem(this, _item);
    }
    
    public Square GetNeighborLeft(bool safe = false)
    {
        if (col == 0 && !safe)
            return null;
        return LevelManager.Instance.GetSquare(col - 1, row, safe);
    }

    public Square GetNeighborRight(bool safe = false)
    {
        if (col >= LevelManager.Instance.maxCols && !safe)
            return null;
        return LevelManager.Instance.GetSquare(col + 1, row, safe);
    }

    public Square GetNeighborTop(bool safe = false)
    {
        if (row == 0 && !safe)
            return null;
        return LevelManager.Instance.GetSquare(col, row - 1, safe);
    }

    public Square GetNeighborBottom(bool safe = false)
    {
        if (row >= LevelManager.Instance.maxRows && !safe)
            return null;
        return LevelManager.Instance.GetSquare(col, row + 1, safe);
    }

    public void ItemOnMatchesOrPowerUp(ChangeStateTypes type, int _color = -1)
    {
        if (item == null) return;
        if (obstacle != null) return;
        item.OnMatchesOrPowerUp(type, _color);
    }
    public bool IsNone()
    {
        return type == SquareTypes.NONE;
    }

    public bool IsHaveDestroybleObstacle()
    {
        return obstacle != null;
    }

    public bool CanGoOut()
    {
        if(obstacle == null) return true ;
        return obstacle.CanGoOut();
    }

    public bool CanGoInto()
    {
        return obstacle == null && type == SquareTypes.EMPTY;
    }

    public List<Square> GetAllNeghbors()
    {
        List<Square> sqList = new List<Square>();
        Square nextSquare = null;
        nextSquare = GetNeighborBottom();
        if (nextSquare != null)
            sqList.Add(nextSquare);
        nextSquare = GetNeighborTop();
        if (nextSquare != null)
            sqList.Add(nextSquare);
        nextSquare = GetNeighborLeft();
        if (nextSquare != null)
            sqList.Add(nextSquare);
        nextSquare = GetNeighborRight();
        if (nextSquare != null)
            sqList.Add(nextSquare);
        return sqList;
    }
}
