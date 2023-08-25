using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonusCollectionSprites : DictionaryAssetCollection<ItemBonusCollectionSprites.ItemBonusDictionary,string,Sprite,ItemBonusCollectionSprites>
{
    [Serializable]
    public class ItemBonusDictionary: SerializableDictionary
    {
        public ItemBonusDictionary(string key, Sprite values)
        {
            _key = key;
            _value = values;
        }
    }
}
