using System;
using UnityEngine;

public class ShopSpritesAssetCollection :DictionaryAssetCollection<ShopSpritesAssetCollection.ShopSpritesDictionary,string,Sprite,ShopSpritesAssetCollection>
{
    [Serializable]
    public class ShopSpritesDictionary:SerializableDictionary
    {
        public ShopSpritesDictionary(Sprite value)
        { 
            _value = value;
        }
    }
}