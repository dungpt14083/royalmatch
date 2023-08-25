using System;

public class CropsAssetCollection : DictionaryAssetCollection<CropsAssetCollection.CropSpritesDictionary, string,
    CropSprites, CropsAssetCollection>
{
    [Serializable]
    public class CropSpritesDictionary : SerializableDictionary
    {
        public CropSpritesDictionary(string key, CropSprites value)
        {
            _key = key;
            _value = value;
        }
    }
}