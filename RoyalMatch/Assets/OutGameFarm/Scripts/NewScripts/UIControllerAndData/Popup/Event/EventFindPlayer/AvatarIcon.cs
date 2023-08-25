using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarIcon : MonoBehaviour
{
    [SerializeField] private Image iconAvatar;

    public bool isMainplayer { get; private set; }
    public void Init(UserEventLaval user)
    {
        iconAvatar.sprite = user.SpriteAvatar;
        isMainplayer = user.isPlayer;
    }
}
