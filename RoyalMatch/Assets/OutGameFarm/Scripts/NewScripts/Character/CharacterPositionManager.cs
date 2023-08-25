using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterPositionManager : ICanSerialize
{
    //Được lưu và load lên lại::chứa Data của 1 đống nhân vật trong scene::
    public UserCharacterPositionsData Data { get; private set; }

    private void LoadData()
    {
        CheckCompleteAdventureDeletedFromData();
    }

    private void CheckCompleteAdventureDeletedFromData()
    {
        // List<UserCharacterPositionData> positionsToRemove = new List<UserCharacterPositionData>();
        //
        // foreach (UserCharacterPositionData position in Data.CharacterPositions)
        // {
        //     if (!AdventureService.IsAdventureActive(position.adventureId))
        //     {
        //         positionsToRemove.Add(position);
        //     }
        // }
        //
        // foreach (UserCharacterPositionData position in positionsToRemove)
        // {
        //     _data.CharacterPositions.Remove(position);
        // }
        //
        // DataService.SaveUserCharacterPositionsData(_data);
    }

    public UserCharacterPositionData GetCharacterPositionData(int characterId, int adventureId)
    {
        return Data.CharacterPositions.Find(position =>
            position.characterId == characterId && position.islandId == adventureId);
    }

    public bool TryGetCharacterPosition(int characterId, int adventureId,
        out UserCharacterPositionData characterPosition)
    {
        characterPosition = Data.CharacterPositions.Find(position =>
            position.characterId == characterId && position.islandId == adventureId);

        return characterPosition != null;
    }

    public Vector3 GetCharacterPosition(int characterId, int adventureId)
    {
        UserCharacterPositionData characterPosition = GetCharacterPositionData(characterId, adventureId);

        return characterPosition != null ? characterPosition.position : Vector3.zero;
    }

    
    
    
    //TẠO MỚI DATA BAN ĐẦU NẾU CHƯA CÓ
    public UserCharacterPositionData CreateCharacterPositionData(int characterId, int adventureId, Vector3 position,
        float rotation, string idleState = "Idle")
    {
        UserCharacterPositionData characterPosition =
            new UserCharacterPositionData(characterId, adventureId, position, rotation, idleState);
        Data.CharacterPositions.Add(characterPosition);
        return characterPosition;
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    public CharacterPositionManager UpdatePosition(UserCharacterPositionData data, Vector3 position)
    {
        data.position = position;
        return this;
    }

    public CharacterPositionManager UpdateRotation(UserCharacterPositionData data, float rotation)
    {
        data.rotation = rotation;
        return this;
    }

    public CharacterPositionManager UpdateIdleState(UserCharacterPositionData data, string idleState)
    {
        data.idleState = idleState;
        return this;
    }

    public void DeleteCharacterPosition(int characterId, int adventureId)
    {
        UserCharacterPositionData position = GetCharacterPositionData(characterId, adventureId);

        if (position != null)
        {
            Data.CharacterPositions.Remove(position);
        }
    }

    public bool HasPositionData(int characterId, int adventureId)
    {
        return Data.CharacterPositions.Exists(position =>
            position.characterId == characterId && position.islandId == adventureId);
    }

    public string GetExistingCharactersOfAdventureAsCsv(int adventureId)
    {
        List<int> characterIds = Data.CharacterPositions
            .Where(position => position.islandId == adventureId)
            .Select(position => position.characterId)
            .ToList();

        return string.Join(",", characterIds);
    }


    #region SAVEANDLOADDATA

    //NẾU TẠO MỚI HOÀN TOÀN THÌ LÀ 
    public CharacterPositionManager()
    {
        Data = new UserCharacterPositionsData();
    }

    private StorageDictionary _storage;

    public CharacterPositionManager(StorageDictionary storage)
    {
        _storage = storage;
        Data = new UserCharacterPositionsData(storage.GetStorageDict("UserCharacterPositionsData"));
    }

    public StorageDictionary Serialize()
    {
        if (_storage == null)
        {
            _storage = new StorageDictionary();
        }

        _storage.Set("UserCharacterPositionsData", Data);

        return _storage;
    }

    #endregion
}