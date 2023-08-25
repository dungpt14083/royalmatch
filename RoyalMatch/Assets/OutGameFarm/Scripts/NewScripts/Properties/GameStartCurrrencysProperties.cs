using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CÁC PROPPETIES TRONG GAME DÂN CƯ BẮT ĐẦU:::????
public class GameStartCurrrencysProperties : EntityProperties
{
    
    public Currencies StartCurrencies { get; private set; }

    
    //chỉ quan tâm startCurrency  
    public GameStartCurrrencysProperties(PropertiesDictionary propDict, string baseKey)
        : base(propDict, baseKey)
    {
        Currencies result;
        if (Currencies.TryParse(GetProperty("startCurrencies", string.Empty), out result))
        {
            StartCurrencies = result;
        }
    }
    

}
