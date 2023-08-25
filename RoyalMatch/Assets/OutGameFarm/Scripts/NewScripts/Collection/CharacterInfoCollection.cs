using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "CharacterInfoCollection", menuName = "Scriptable Objects/CharacterInfoCollection")]
public class CharacterInfoCollection : ScriptableObject, ISerializationCallbackReceiver
{
    public List<CharacterInfo> characters;
    private Dictionary<int, CharacterInfo> _cache;

    public void OnAfterDeserialize()
    {
        _cache = new Dictionary<int, CharacterInfo>();
        for (int i = 0; i < characters.Count; i++)
        {
            if (!_cache.ContainsKey(characters[i].id))
            {
                _cache.Add(characters[i].id, characters[i]);
            }
        }
    }

    public void OnBeforeSerialize()
    {
    }

    public Character GetCharacterById(int id)
    {
        return characters.Find(info => info.id == id).character;
    }
    
    public CharacterInfo GetCharacterInfo(int id)
    {
        return characters.Find(info => info.id == id);
    }

    public bool ContainsId(int id)
    {
        return characters.Any(info => info.id == id);
    }

    public void QueryById(int id, List<CharacterInfo> items)
    {
    }

    public void QueryByName(string charName, List<CharacterInfo> items)
    {
    }
}