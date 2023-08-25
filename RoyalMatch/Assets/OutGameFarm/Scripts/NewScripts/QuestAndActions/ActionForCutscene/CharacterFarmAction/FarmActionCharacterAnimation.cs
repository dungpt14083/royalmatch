using System.Collections;
using System.Collections.Generic;
using Animancer;
using GameCreator.Core;
using UnityEngine;
using UnityEngine.Purchasing;

//2 cái nhưng chắc phải chạy kiểu chờ animation het xong::
public class FarmActionCharacterAnimation : IAction
{
    public int characterId;
    public string animationName;
    public float duration;

    private Character _character;
    private bool _animationDone = false;

    public override IEnumerator Execute(GameObject target, IAction[] actions, int index)
    {
        _character = CharacterManagerView.Instance.CreateOrGetCharacter(characterId);
        AnimancerState state = _character.Play(animationName);

        int normalizedDuration = Mathf.FloorToInt(duration / state.Duration);
        state.NormalizedEndTime = normalizedDuration;
        state.Events.Add(normalizedDuration, EndAnimation);

        while (!_animationDone)
        {
            yield return null;
        }

        yield return 0;
    }

    private void EndAnimation()
    {
        _animationDone = true;
    }

#if UNITY_EDITOR
    public static new string NAME = "CharacterFarm/Character Animation";
    private const string NODE_TITLE = "Character Animation";
#endif
}