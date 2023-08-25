using System;
using System.Collections.Generic;
using UnityEngine;
public enum ObstacleTypes
{
    None,
    Box,
    BlueBox,
    GreenBox,
    PinkBox,
    RedBox,
    YellowBox,
    Grass,
    Cupboard,
    Safe,
    Garden,
    Pot,
    Hat,
    RockGem,
    RockOwl,
    Lantern,
    MailBox,
    DogBox,
    Soil,
    ColorBox,
    Mole,
}
public enum ChangeStateTypes
{
    None,
    Matches,
    PowerUp,
    All
}
public class ObstacleBase : MonoBehaviour
{
    public int columStart;
    public int rowStart;
    public Vector2Int size;
    public List<Square> squares;
    [SerializeField]
    private SpriteRenderer sprTarget; 
    public virtual void Init(List<Square> _squares)
    {
        squares = _squares;
    }
    
    public virtual void OnMatchesOrPowerUp(ChangeStateTypes type, int _color = -1)
    {
        MatchesOrPowerUpAction();
    }
    public virtual void MatchesOrPowerUpAction()
    {

    }
    public virtual void DestroyObstacle()
    {

    }
    public virtual ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.None;
    }
    public Sprite GetTargetIcon()
    {
        return sprTarget?.sprite;
    }
    public virtual bool CanGoOut()
    {
        return false;
    }
}
