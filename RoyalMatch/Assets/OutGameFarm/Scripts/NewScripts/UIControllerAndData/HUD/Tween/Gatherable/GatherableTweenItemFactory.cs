using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//NÓ NẰM Ở NGOOÀI SCENE NGOÀI CÙNG::::
public class GatherableTweenItemFactory : MonoSingleton<GatherableTweenItemFactory>
{
    [SerializeField] private TweenItem _tweenItemTemplate;
    [SerializeField] private List<TweenItem> _tweenItemPool = new List<TweenItem>();
    private List<TweenItem> _activeTweens = new List<TweenItem>();


    public TweenItem GetTweenItem()
    {
        TweenItem item;
        if (_tweenItemPool.Count > 0)
        {
            item = ExtensionUtils.Pop<TweenItem>(_tweenItemPool);
        }
        else
        {
            item = UnityEngine.Object.Instantiate<TweenItem>(_tweenItemTemplate, transform);
            var childCound = transform.childCount;
            //đẩy tweeenItem xuống 1 đơn vị
            if (item != null)
            {
                item.ChildId = childCound;
            }
            else
            {
                //....
            }
        }

        _activeTweens.Add(item);
        return item;
    }

    
    //khi puzzle start thì bỏ cái này vào poool
    public void BackToPool(TweenItem tweenItem)
    {
        _activeTweens.Remove(item: tweenItem);
        this._tweenItemPool.Add(item: tweenItem);
        //this._tweenItemPool.Sort(CompareTweenItems);

    }

    public int CompareTweenItems(TweenItem lhs, TweenItem rhs)
    {
        return lhs.ChildId.CompareTo(rhs.ChildId);
    }

    private void OnPuzzleStart(bool loaded)
    {
        foreach (var tweenItem in _activeTweens)
        {
            tweenItem.gameObject.SetActive(false);
            BackToPool(tweenItem);
        }
    }

    private void KillAll()
    {
        foreach (var tweenItem in _activeTweens)
        {
            tweenItem.KillAll();
        }
    }
    
    
}


