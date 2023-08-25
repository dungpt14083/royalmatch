using System;

public class UpgradeBuildingSpritesAssetCollection : DictionaryAssetCollection<
    UpgradeBuildingSpritesAssetCollection.UpgradeBuildingSpritesDictionary, string,
    UpgradeBuildingSprites, UpgradeBuildingSpritesAssetCollection>
{
    [Serializable]
    public class UpgradeBuildingSpritesDictionary : SerializableDictionary
    {
        public UpgradeBuildingSpritesDictionary(string key, UpgradeBuildingSprites value)
        {
            _key = key;
            _value = value;
        }
    }
}