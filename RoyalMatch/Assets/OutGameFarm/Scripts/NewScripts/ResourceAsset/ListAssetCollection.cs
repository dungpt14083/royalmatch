using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class
    ListAssetCollection<TSerializable, TSelf> : AssetCollection<TSerializable, string, TSerializable, TSelf>
    where TSerializable : Object where TSelf : ListAssetCollection<TSerializable, TSelf>
{
    protected override void GetAssetKeyValue(TSerializable asset, out string key, out TSerializable value)
    {
        key = asset.name;
        value = asset;
    }
}