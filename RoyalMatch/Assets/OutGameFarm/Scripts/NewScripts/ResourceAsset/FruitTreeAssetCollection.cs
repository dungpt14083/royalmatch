using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitTreeAssetCollection : DictionaryAssetCollection<FruitTreeAssetCollection.FruitTreeDictionary,string,FruitTreeSprites,FruitTreeAssetCollection>
{
   [Serializable]
   public class FruitTreeDictionary: SerializableDictionary
   {
      public FruitTreeDictionary(string key, FruitTreeSprites values)
      {
         _key = key;
         _value = values;
      }
      
   }
}
