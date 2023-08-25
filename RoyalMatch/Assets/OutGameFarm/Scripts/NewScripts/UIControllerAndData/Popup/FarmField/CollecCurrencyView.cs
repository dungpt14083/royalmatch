using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CollecCurrencyView : InteractiveCurrencyView<ProductProperties>,IPointerClickHandler
{

    public event Action ClickEvent;
    public Image Background;

    public void Init(bool dragging =false)
    {
    
     InitInternalCollec(null, dragging); 
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (ClickEvent != null)
        {
            ClickEvent.Invoke();
        }
    }
}
