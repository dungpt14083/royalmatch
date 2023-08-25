using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridObjectView : GridObjectBaseView
{
    //ĐẠI DIỆN VIEW CHO OBJECT DẠNG GRID VÀ MOVE BLA BLA NÓ ĐIỀU KHIỂN
    private GridIgridObjectView _gridIgridObjectView;
    private IGridObject _gridObject;

    private int _baseSortingOrder;

    private int _highestChildBaseSortingOrder;

    private void OnDestroy()
    {
        if (_gridObject != null)
        {
            _gridObject.MovedEvent -= OnMoved;
            _gridObject.FlippedEvent -= OnFlipped;
        }
    }


    public void Init(GridIgridObjectView gridIgridObjectView, IGridObject gridObject)
    {
        if (_gridObject != null)
        {
            _gridObject.MovedEvent -= OnMoved;
            _gridObject.FlippedEvent -= OnFlipped;
        }

        Init();
        _gridIgridObjectView = gridIgridObjectView;
        _gridObject = gridObject;
        _highestChildBaseSortingOrder = 0;
        int num = _childViews.Length;
        for (int i = 0; i < num; i++)
        {
            GridObjectChildView gridObjectChildView = _childViews[i];
            gridObjectChildView.Init(this);
            _highestChildBaseSortingOrder =
                Mathf.Max(_highestChildBaseSortingOrder, gridObjectChildView.BaseSortingOrder);
        }

        _baseSortingOrder = base.SortingOrder;
        //KHI INIT THÌ TRUYỀN LÕI VÔ ĐỂ NÓ ĐƯANG KÍ Ự KIỆN MOVE VÀ FLIP Ở ĐÂY
        _gridObject.MovedEvent += OnMoved;
        _gridObject.FlippedEvent += OnFlipped;
        UpdatePosition();
        UpdateFlip();
    }


    private void OnFlipped(IGridObject sender)
    {
        UpdateFlip();
    }

    //Nghe sự kiện của thằng Move để mà 
    private void OnMoved(IGridObject sender)
    {
        UpdatePosition();
        //NCH LÀM LÀM GÌ ĐÓ CÁI NÀY ĐỂ SAU
        //SingletonMonobehaviour<OverlayManager>.Instance.UpdateOverlay(base.gameObject);
    }

    private void UpdatePosition()
    {
        //LẤY VỊ TRÍ MỚI LÀ THẰNG ĐƯỜNG
        base.transform.position = _gridIgridObjectView.GridPointToWorldVector(_gridObject.Area.Index);
        UpdateSortingOrder();
    }

    private void UpdateFlip()
    {
        Transform transform = ((!(_renderer != null)) ? base.transform : _renderer.transform);
        Vector3 localScale = transform.localScale;
        if (_gridObject.IsFlipped)
        {
            localScale.x = 0f - Mathf.Abs(localScale.x);
        }
        else
        {
            localScale.x = Mathf.Abs(localScale.x);
        }

        transform.localScale = localScale;
        int num = _childViews.Length;
        for (int i = 0; i < num; i++)
        {
            _childViews[i].UpdateFlip();
        }
    }

    //UPDATE HIỂN THỊ THEO CHIỀU CAO
    private void UpdateSortingOrder()
    {
        int num;
        if (_baseSortingOrder == 32767)
        {
            num = _baseSortingOrder - _highestChildBaseSortingOrder;
        }
        else
        {
        }
    }
}