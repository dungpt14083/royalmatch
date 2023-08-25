using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySpritesAssetCollection : DictionaryAssetCollection<
    CurrencySpritesAssetCollection.CurrencySpritesDictionary, CurrencyType,
    Sprite, CurrencySpritesAssetCollection>
{
    [Serializable]
    public class CurrencySpritesDictionary : SerializableDictionary
    {
        public CurrencySpritesDictionary(Sprite value)
        {
            _value = value;
        }
    }
}
