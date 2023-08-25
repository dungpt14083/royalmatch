using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridObjectBaseView : MonoBehaviour
{
    [SerializeField] [Tooltip("(Optional)")]
    protected Renderer _renderer;


    [SerializeField] protected GridObjectChildView[] _childViews;
    
    private int? _sortingOrder;

    public bool HasRenderer
    {
        get { return _renderer != null; }
    }

    public int SortingLayerID
    {
        get
        {
            if (_renderer == null)
            {
                return 0;
            }

            return _renderer.sortingLayerID;
        }
    }

    public int SortingOrder
    {
        get { return _sortingOrder.Value; }
        protected set
        {
            _sortingOrder = value;
            if (_renderer != null)
            {
                _renderer.sortingOrder = _sortingOrder.Value;
            }
        }
    }

    private void Awake()
    {
        Init();
    }

    protected void Init()
    {
        if (!_sortingOrder.HasValue)
        {
            if (_renderer != null)
            {
                _sortingOrder = _renderer.sortingOrder;
            }
            else
            {
                _sortingOrder = 0;
            }
        }
    }
}