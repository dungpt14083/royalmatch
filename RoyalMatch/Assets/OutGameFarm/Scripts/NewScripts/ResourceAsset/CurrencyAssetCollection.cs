using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyAssetCollection : ListAssetCollection<Sprite, CurrencyAssetCollection>
{
    public Sprite GetAsset(CurrencyType currencyType)
    {
        return GetAsset(currencyType.ToCurrencyName());
    }

    public Sprite GetAsset(Currency currency)
    {
        return GetAsset(currency.Name);
    }
}
