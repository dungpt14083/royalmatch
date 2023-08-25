using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuinBuilding : ICanSerialize
{
    #region SAVEANDLOAD

    private StorageDictionary _storage;

    public RuinBuilding(FarmfieldBuildingProperties farmFieldProps, ContructionSiteStating construction,
        IslandFarmProperties islandFarmProperties, GeneralBalance generalBalance, TimeKeeper time,
        PopupManager popupmanager)
    {
    }

    public RuinBuilding(StorageDictionary storage)
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

    public void ResolveDependencies(GameData game, IsLandInfo isLandInfo, Building building)
    {
    }

    #endregion
}