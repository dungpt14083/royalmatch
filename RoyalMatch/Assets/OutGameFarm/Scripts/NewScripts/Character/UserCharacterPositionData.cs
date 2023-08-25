using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CHỈ LƯU TRỮ VI TRÍ CHARACTERID...
public class UserCharacterPositionData : ICanSerialize
{
    public int characterId;

    public int islandId;

    public Vector3 position;

    public string idleState;

    public float rotation;

    public void UpdatePosition(int islandIdX, Vector3 positionX, float rotationX,
        string idleStateX)
    {
        islandId = islandIdX;
        position = positionX;
        idleState = idleStateX;
        rotation = rotationX;
    }

    public UserCharacterPositionData(int characterIdX, int islandIdX, Vector3 positionX, string idleStateX)
    {
        characterId = characterIdX;
        islandId = islandIdX;
        position = positionX;
        idleState = idleStateX;
    }

    public UserCharacterPositionData(int characterIdX, int islandIdX, Vector3 positionX, float rotationX,
        string idleStateX)
    {
        characterId = characterIdX;
        islandId = islandIdX;
        position = positionX;
        idleState = idleStateX;
        rotation = rotationX;
    }

    #region SAVEANDLOAD

    private StorageDictionary _storage;

    public UserCharacterPositionData(StorageDictionary storage)
    {
        _storage = storage;
        characterId = _storage.Get("characterId", 0);
        islandId = _storage.Get("islandId", 0);
        position = new Vector3(_storage.Get("positionX", 0.0f), _storage.Get("positionY", 0.0f),
            _storage.Get("positionZ", 0.0f));
        idleState = _storage.Get("idleState", "");
        rotation = _storage.Get("rotation", 0.0f);
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("characterId", characterId);
        _storage.Set("islandId", islandId);
        _storage.Set("positionX", position.x);
        _storage.Set("positionY", position.y);
        _storage.Set("positionZ", position.z);
        _storage.Set("idleState", idleState);
        _storage.Set("rotation", rotation);
        return _storage;
    }

    #endregion
}