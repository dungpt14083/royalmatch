
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupDetailSowingCurrencyView : MonoBehaviour
{
    public TMP_Text Txt_name;
    public Image ImageProduct;
    public TMP_Text Txt_Time;
    public TMP_Text Txt_count;
    public TMP_Text Txt_Sell;

    public void Init(string name,Sprite image,float time,int count,float sell)
    {
        Txt_name.text = name;
        ImageProduct.sprite = image;
        Txt_Time.text = ConvertToTimeFormat(time);
        Txt_count.text = count.ToString();
        Txt_Sell.text = sell.ToString();

    }
    
    private string ConvertToTimeFormat(float time)
    {
        int hours = (int)(time / 3600);
        int minutes = (int)((time % 3600) / 60);
        int seconds = (int)(time % 60);

        string formattedTime = "";

        if (hours > 0)
        {
            formattedTime += hours.ToString("00")+":" + minutes.ToString("00") ;
        }
        else
        {
            formattedTime += minutes.ToString("00") ;
        }

        if (seconds > 0 && hours == 0)
        {
            formattedTime += ":" + seconds.ToString("00") ;
        }


        return formattedTime;
    }
}
