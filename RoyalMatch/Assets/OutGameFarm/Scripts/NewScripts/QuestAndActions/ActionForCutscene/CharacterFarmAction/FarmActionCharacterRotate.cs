using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;

public class FarmActionCharacterRotate : IAction
{
    public int characterId;
    public float rotate;
    public bool isInstant = false;


    public override bool InstantExecute(GameObject target, IAction[] actions, int index)
    {
        if (isInstant)
        {
            Character character = CharacterManagerView.Instance.CreateOrGetCharacter(characterId);
            character.RotateTo(rotate);
            return true;
        }

        return false;
    }


#if UNITY_EDITOR
    public static new string NAME = "CharacterFarm/Character Rotate";
    private const string NODE_TITLE = "Character Rotate";
#endif
}