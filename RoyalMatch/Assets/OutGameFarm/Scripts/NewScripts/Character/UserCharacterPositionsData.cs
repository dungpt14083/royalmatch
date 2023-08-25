using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserCharacterPositionsData : ICanSerialize
{
    public List<UserCharacterPositionData> CharacterPositions = new List<UserCharacterPositionData>();

    public UserCharacterPositionsData()
    {
        CharacterPositions.Clear();
    }

    // public void AddOrUpdateCharacterPosition(UserCharacterPositionData characterPositionData)
    // {
    //     var tmp = CharacterPositions.Find(data => data.characterId == characterPositionData.characterId);
    //     if (tmp != null)
    //     {
    //         tmp.UpdatePosition(characterPositionData.islandId, characterPositionData.position,
    //             characterPositionData.rotation, characterPositionData.idleState);
    //     }
    //     else
    //     {
    //         CharacterPositions.Add(characterPositionData);
    //     }
    // }
    //
    // public void AddOrUpdateCharacterPosition(UserCharacterPositionData characterPositionData)
    // {
    //     var tmp = CharacterPositions.Find(data => data.characterId == characterPositionData.characterId);
    //     if (tmp != null)
    //     {
    //         tmp.UpdatePosition(characterPositionData.islandId, characterPositionData.position,
    //             characterPositionData.rotation, characterPositionData.idleState);
    //     }
    //     else
    //     {
    //         CharacterPositions.Add(characterPositionData);
    //     }
    // }

    #region SAVEANDLOAD

    private StorageDictionary _storage;

    public UserCharacterPositionsData(StorageDictionary storage)
    {
        CharacterPositions.Clear();
        _storage = storage;
        CharacterPositions = storage.GetModels("CharacterPositions",
            (StorageDictionary sd) => new UserCharacterPositionData(sd));
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("CharacterPositions", CharacterPositions);

        return _storage;
    }

    #endregion
}