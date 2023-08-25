using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBalloonWithTextManager : MonoSingleton<SpeechBalloonWithTextManager>
{
    //CURRENT TEMPLATE VÀ LIST
    [SerializeField] private SpeechBalloonWithText SpeechBalloonWithTextTemplate;
    private Queue<SpeechBalloonWithText> IdleItems;

    private void Start()
    {
        IdleItems = new Queue<SpeechBalloonWithText>();
    }

    //TỪ CHARACTER GỌI SHOWW ????CHARACTER GỌI TỚI LẤY CÁI NÀY ĐỂ SHOW HAY GÌ GÌ::
    public SpeechBalloonWithText GetSpeechBalloonWithText()
    {
        if (IdleItems != null)
        {
            return IdleItems.Dequeue();
        }

        return Instantiate(SpeechBalloonWithTextTemplate, this.transform);
    }

    //ĐƯA VÀO TRONG BACKPOOOL ĐỂ SAU NAFY XÀI??
    //GỌI BỞI SPEECHBALLONWITHTEXT HIDE VÀO
    public void BackToPool(SpeechBalloonWithText speechBalloonWithText)
    {
        IdleItems.Enqueue(speechBalloonWithText);
    }
}