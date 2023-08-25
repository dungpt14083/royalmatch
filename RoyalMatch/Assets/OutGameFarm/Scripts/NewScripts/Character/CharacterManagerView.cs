using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

//CHỈ QUẢN LÍ THAWFNG TẠO RA NHÂN VẬT Ở ĐẦU TRẬN:::
//TAO NHÂN VT CHÍNH VÀ CÁC NHÂN VẬT PHỤ Ở TRONG MAP HIỆN TẠI CÓ LƯU:::TRÙNG THÌ PHẢI HỦY 
public class CharacterManagerView : MonoSingleton<CharacterManagerView>
{
    #region ACTIONEVENT::::

    public delegate void CharacterCreatedEventHandler(int idCharacter);

    public delegate void CharacterCreationFinishedEventHandler(int idCharacter);

    public event CharacterCreatedEventHandler CharacterCreatedEvent;
    public event CharacterCreationFinishedEventHandler CharacterCreationFinishedEvent;

    private void FireCharacterCreatedEvent(int id)
    {
        if (this.CharacterCreatedEvent != null)
        {
            this.CharacterCreatedEvent(id);
        }
    }

    private void FireCharacterCreationFinishedEvent(int id)
    {
        if (this.CharacterCreationFinishedEvent != null)
        {
            this.CharacterCreationFinishedEvent(id);
        }
    }

    #endregion

    public int mainCharacterId = 1;
    [SerializeField] private CharacterInfoCollection characterInfoCollection;
    [SerializeField] private TileAccessManagerView tileAccessManagerView;


    private Dictionary<int, Character> _activeCharacters = new Dictionary<int, Character>();
    private CharacterPositionManager _characterPositionManager;
    private IslandId _islandId;

    public CharacterInfoCollection CharacterInfoCollection { get; private set; }

    public void Init(CharacterPositionManager characterPositionManager, IsLandInfo isLandInfo)
    {
        CharacterInfoCollection = characterInfoCollection;
        _characterPositionManager = characterPositionManager;
        _islandId = isLandInfo.IslandId;
        CreateInitialCharacters();
    }

    //KHI VÀO GAME TTHIFSEX TẠO RA ĐỐNG CHARACTER KHI VÀO GAME ẦU TIỀN TƯƠNG ỨNG VỚI ADVENTURE:::
    private void CreateInitialCharacters()
    {
        bool hasMainCharacter = false;
        var tmpListCharacterPositions = _characterPositionManager.Data.CharacterPositions;
        for (int i = 0; i < tmpListCharacterPositions.Count; i++)
        {
            if (tmpListCharacterPositions[i].islandId == (int)_islandId)
            {
                CreateCharacter(tmpListCharacterPositions[i].characterId, tmpListCharacterPositions[i].position,
                    new Vector3(0, tmpListCharacterPositions[i].rotation, 0), tmpListCharacterPositions[i].idleState);
                if (tmpListCharacterPositions[i].characterId == mainCharacterId)
                {
                    hasMainCharacter = true;
                }
            }
        }

        if (!hasMainCharacter)
        {
            Executors.Instance.StartCoroutine(StartCreateCharacter(mainCharacterId));
        }
    }

    private IEnumerator StartCreateCharacter(int mainCharacterId)
    {
        yield return new WaitForSeconds(0.2f);
        CreateOrGetCharacter(mainCharacterId);
    }

    public Character CreateOrGetCharacter(int id)
    {
        //return null;
        if (_activeCharacters.TryGetValue(id, out Character character))
        {
            return character;
        }

        var startPoint = tileAccessManagerView.StartPoint;
        return CreateCharacter(id, startPoint, new Vector3(0, 0, 0), "IdleCharacter");
    }


    //Khi tạo ra nhân vật thì lấy vị trí lưu cuối cùng của nó
    public Character CreateCharacter(int id, Vector3 position, Vector3 rotation, string idleState = "IdleCharacter")
    {
        //Tạo instance prefab từ collection::
        var characterInfo = characterInfoCollection.GetCharacterInfo(id);
        var tmpPrefab = characterInfo.character;

        var tmpCharacter = Instantiate(tmpPrefab, position, quaternion.identity);

        //NẾU KHÔNG C DATA THÌ TẠO ỚI VÀ SET VÀO TRONG KIA 
        if (!_characterPositionManager.TryGetCharacterPosition(id, (int)_islandId,
                out UserCharacterPositionData characterPosition))
        {
            var tmpData = _characterPositionManager.CreateCharacterPositionData(
                id, (int)_islandId,
                position, 0, idleState);

            tmpCharacter.SetPosition(position);
            tmpCharacter.Init(characterInfo, tmpData);
        }
        //NẾU CÓ VỊ TRÍ THÌ LẤY VỊ TRÍ CŨ LÊN
        else
        {
            tmpCharacter.SetPosition(characterPosition.position);
            tmpCharacter.Init(characterInfo, characterPosition);
        }

        _activeCharacters.Add(id, tmpCharacter);
        return tmpCharacter;
    }

    //Hủy character bởi id
    public void DestroyCharacter(int id)
    {
        Character tmpCharacter = _activeCharacters[id];
        _activeCharacters.Remove(id);
        DestroyImmediate(tmpCharacter.gameObject);
    }

    //BUILDINGCHARRACER SPAWW TẠO RA THẰNG NGƯỜI KHI NÓ ĐƯỢC TẠO:::
    public Character CreateCharacterFromBaseId(int prefabId, int baseId, UnityEngine.Vector3 position,
        UnityEngine.Vector3 rotation, string idleState = "Idle")
    {
        return null;
    }

    public bool IsCharacterCreated(int id)
    {
        if (_activeCharacters != null)
        {
            return _activeCharacters.ContainsKey(key: id);
        }

        return _activeCharacters.ContainsKey(key: id);
    }


    public void SetCharacter(int id, Character character)
    {
        if (!_activeCharacters.ContainsKey(id))
        {
            _activeCharacters.Add(id, character);
        }
    }

    public Character GetCharacter(int id)
    {
        if (this._activeCharacters != null)
        {
            return this._activeCharacters[id];
        }

        return null;
    }

    public string GetNameCharacter(int id)
    {
        var tmp = CharacterInfoCollection.GetCharacterInfo(id);
        return tmp != null ? tmp.name : "null";
    }
}