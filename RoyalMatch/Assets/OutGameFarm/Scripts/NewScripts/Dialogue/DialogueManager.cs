using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoSingleton<DialogueManager>
{
    [SerializeField] private DialogueInfoCollection dialogueInfoCollection;

    public DialogueInfoCollection DialogueInfoCollection => dialogueInfoCollection;
}