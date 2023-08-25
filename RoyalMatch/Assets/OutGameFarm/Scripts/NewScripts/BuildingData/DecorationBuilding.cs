using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationBuilding : ICanSerialize
{
    public DecorationBuildingProperties DecorationBuildingProperties { get; private set; }

    public DecorationBuilding(DecorationBuildingProperties properties)
    {
        DecorationBuildingProperties = properties;
    }

    #region SAVE AND LOAD::

    private StorageDictionary _storage;

    public DecorationBuilding(StorageDictionary storage)
    {
        _storage = storage;
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        return _storage;
    }

    public void ResolveDependencies(GameData game, Building building)
    {
        DecorationBuildingProperties = (DecorationBuildingProperties)building.BuildingProperties;
    }
    #endregion
}