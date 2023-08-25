using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObjectChildView : GridObjectBaseView
{
    [SerializeField] private bool _ignoreFlip;

    [SerializeField] private bool _ignoreParentSortingLayer;

    private GridObjectBaseView _parent;

    private float _initialScaleXSign;
    
    public int BaseSortingOrder { get; private set; }

    public void Init(GridObjectBaseView parent)
    {
        Init();
        _parent = parent;
        _initialScaleXSign = Mathf.Sign(base.transform.localScale.x);
        BaseSortingOrder = base.SortingOrder;
        int num = _childViews.Length;
        for (int i = 0; i < num; i++)
        {
            _childViews[i].Init(this);
        }
    }

    public void UpdateSortingOrder()
    {
        int num = ((BaseSortingOrder != 32767) ? (_parent.SortingOrder + BaseSortingOrder) : BaseSortingOrder);
        if (num > 32767)
        {
            Debug.LogErrorFormat("Sorting Order of '{0}' exceeded short.maxvalue ",base.name);
            num = 32767;
        }
        else if(num < -32768)
        {
            Debug.LogWarningFormat("Sorting Order of '{0}' exceeded short.minValue", base.name);
            num = -32768;
        }

        base.SortingOrder = num;
        if (!_ignoreParentSortingLayer && _renderer != null && _parent.HasRenderer)
        {
            _renderer.sortingLayerID = _parent.SortingLayerID;
        }

        int num2 = _childViews.Length;
        for (int i = 0; i < num2; i++)
        {
            _childViews[i].UpdateSortingOrder();
        }
    }

    public void UpdateFlip()
    {
        Vector3 localScale = _parent.transform.localScale;
        Vector3 localScale2 = base.transform.localScale;
        localScale2.x = Mathf.Abs(localScale2.x) * _initialScaleXSign;
        if (_ignoreFlip && _initialScaleXSign != localScale.x)
        {
            localScale2.x *= -1f;
        }

        base.transform.localScale = localScale2;
        int num = _childViews.Length;
        for (int i = 0; i < num; i++)
        {
            _childViews[i].UpdateFlip();
        }
    }
    
        
}
