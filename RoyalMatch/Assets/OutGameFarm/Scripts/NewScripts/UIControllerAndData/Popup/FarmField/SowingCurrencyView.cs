using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SowingCurrencyView : InteractiveCurrencyView<ProductProperties>,IPointerClickHandler
{
    public event Action ClickEvent;
    public Image Background;
    public void Init(ProductProperties properties, bool dragging = false)
    {
        Background.gameObject.SetActive(false);
        InitInternal(properties, dragging);
    }

    //SẼ TỪ SỰ KIỆN DRAGEVENT BÊN NÀY INVOKE NGỢC CHO POPUP QUẢN LÍ VÀ GỌI DRAG CHỨ K DRAG LẺ VÌ K
    //KIỂM SOÁT ĐƯỢC CÁC THẰNG KHÁC CÓ THỂ CÙNG DRAG:::
    public void Drop()
    {
        //CHẠY ANIMATION NHƯNG NÀY CHẢ CẦN CHẢ LÀM GÌ CẢ...
    }
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (ClickEvent != null)
        {
            ClickEvent.Invoke();
        }
    }

 
}