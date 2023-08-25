using System;
using System.Collections;
using System.Collections.Generic;
using GameCreator.Core;
using UnityEngine;

//OK
public class FarmActionCharacterCreate : IAction
{
    public int characterId;
    public Vector3 positionSpawn;

    //private float? _rotationY;
    //private string _idleState;

    public override bool InstantExecute(GameObject target, IAction[] actions, int index)
    {
        Character character = CharacterManagerView.Instance.CreateOrGetCharacter(characterId);


        if (characterId != CharacterManagerView.Instance.mainCharacterId)
        {
            character.SetPosition(positionSpawn);
        }

        //CHỈ CHO NHÂN VẬT PHỤ MỚI SET VỊ TRÍ CÒN NHÂN VẬT CHÍNH THÌ KHNG 
        return true;
    }

    //TAO NHÂN VẬT VÀ DI CHUYỂN TỚI VỊ TRÍ CÁI NY TÍN SAU::::
    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        yield return 0;
    }


#if UNITY_EDITOR
    public static new string NAME = "CharacterFarm/Create Character";
    private const string NODE_TITLE = "Create Character";
    private static readonly GUIContent GC_CANCEL = new GUIContent("Cancelable");
#endif
}