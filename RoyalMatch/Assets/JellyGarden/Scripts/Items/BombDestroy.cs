using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class BombDestroy : MonoBehaviour
{
    public int color;
    List<Item> pendingItems = new List<Item>();
    List<Square> selectedItems = new List<Square>();
    Item itemSwitch;
    public GameObject objEffectSelectPrefab;
    int countDestroy;
    public bool isDestroy = false;

    public void StartDestroy(int _color, Item _itemNew = null)
    {
        Debug.Log("StartDestroy _color " + _color);
        color = _color;
        itemSwitch = _itemNew;
        pendingItems = LevelManager.Instance.GetColorItemsByColor(color);
        if (itemSwitch != null && itemSwitch is ActionItem) AddItemToSelectedItems(itemSwitch,false);
        foreach (var item in pendingItems)
        {
            item.bombDestroy = this;
        }
        countDestroy = pendingItems.Count;
        Debug.Log($"---------------------> countDestroy color {color} {countDestroy}");
        StartCoroutine(DestroyColorItems());
    }
    private IEnumerator DestroyColorItems()
    {
        
        float timeLoop = 0.2f;
        yield return new WaitForSeconds(1);
        while (!AllEndSelect())
        {
            Debug.Log("StartDestroy pendingItems " + pendingItems.Count);
            if (pendingItems.Count > 0)
            {
                var index = UnityEngine.Random.Range(0, pendingItems.Count);
                var item = pendingItems[index];
                pendingItems.RemoveAt(index);
                item.BombSelectDestroy();
            }
            yield return new WaitForSeconds(timeLoop);
        }
        Debug.Log("---------------> End DestroyColorItems ");
        isDestroy = true;
        LevelManager.Instance.bombDestroys.Remove(this);
        float timeDelay = 0;
        if (itemSwitch is ActionItem) timeDelay = 0.05f;
        LevelManager.Instance.DelayedCall(1, () => LevelManager.Instance.BombDestroySelected(selectedItems, timeDelay));
        Destroy(this.gameObject);
    }
    public bool AllEndSelect()
    {
        if (pendingItems.Count > 0) return false; 
        if (LevelManager.Instance.CanGenItem()) return false; 
        return true;
    }
    public void AddItemToPending(Item item)
    {
        if(((ColorItem)item).color != color)
        {
            Debug.Log($"---------------->AddItemToPending {item.gameObject.name} fail");
            return;
        }
        pendingItems.Add(item);
        countDestroy += 1;
        Debug.Log($"---------------------> countDestroy color {color} {countDestroy}");
    }
    public void AddItemToSelectedItems(Item item, bool change = true)
    {
        item.SetMes("_AddItemToSelectedItems");
        Debug.Log($"AddItemToSelectedItems {item.gameObject.name}");
        selectedItems.Add(item.square);
        EffectSelectedItem(item,()=> {
            if(itemSwitch is ActionItem && change) item.square.BombChangeItemByItem(itemSwitch);
        });
    }
    private void EffectSelectedItem(Item item, Action action)
    {
        item.EffectBombSelectDestroy();
        var effect = GameObject.Instantiate(objEffectSelectPrefab, this.transform);
        effect.transform.DOMove(item.transform.position, 0.5f).OnComplete(()=>action?.Invoke());
    }
    
}
