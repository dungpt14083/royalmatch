using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusTreeAssetCollection : DictionaryAssetCollection<BonusTreeAssetCollection.BonusTreeDictionary,string,FruitTreeSprites,BonusTreeAssetCollection>
{
    [Serializable]
    public class BonusTreeDictionary:SerializableDictionary
    {
        public BonusTreeDictionary(string key, FruitTreeSprites values)
        {
            _key = key;
            _value = values;
        }
        
    }
}
