using System.Collections;
using System.Threading;
using GameCreator.Core;
using UnityEngine;

//OK
public class FarmActionCharacterWalkTo : IAction
{
    public int characterId;
    public bool waitUntilArrives = true;
    public bool cancelable = false;
    public float cancelDelay = 1.0f;
    public Vector3 position;
    
    //Tên của moveClip nữa::
    public string moveClipName;


    private Character character = null;


    private bool _forceStop = false;
    private bool _wasControllable = false;
    private bool _isCharacterMoving = false;
    private bool destinationReached = false;

    public override bool InstantExecute(GameObject target, IAction[] actions, int index)
    {
        if (this.waitUntilArrives) return false;
        this.character = CharacterManagerView.Instance.CreateOrGetCharacter(characterId);
        character.SetDestination(position, null);
        return true;
    }

    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        _forceStop = false;
        _isCharacterMoving = true;


        this.character = CharacterManagerView.Instance.CreateOrGetCharacter(characterId);
        character.SetDestination(position, CharacterArrivedCallback);

        while (!destinationReached)
        {
            yield return null;
        }
        
        //character.CancelDestination();
        yield return 0;


        // bool canceled = false;
        // float initTime = Time.time;
        //
        // while (this._isCharacterMoving && !canceled && !_forceStop)
        // {
        //     if (this.cancelable && (Time.time - initTime) >= this.cancelDelay)
        //     {
        //         canceled = Input.anyKey;
        //     }
        //
        //     yield return null;
        // }
        //
        // if (canceled) yield return 999999;
        // else yield return 0;
    }


    public void CharacterArrivedCallback()
    {
        destinationReached = true;
    }


    public override void Stop()
    {
        this._forceStop = true;
        if (this.character == null) return;
        character.CancelDestination();
        destinationReached = true;
    }


#if UNITY_EDITOR
    public static new string NAME = "CharacterFarm/Walk Character";
    private const string NODE_TITLE = "Walk {0} to {1} {2}";
    private static readonly GUIContent GC_CANCEL = new GUIContent("Cancelable");
#endif
}