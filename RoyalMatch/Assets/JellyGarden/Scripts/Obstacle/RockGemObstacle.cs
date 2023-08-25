public class RockGemObstacle : ObstacleChangeState
{
    public override void OnMatchesOrPowerUp(ChangeStateTypes type, int _color = -1)
    {
        if(currentState == 0)
        {
            changeStateType = ChangeStateTypes.PowerUp;
        }
        else
        {
            changeStateType = ChangeStateTypes.All;
        }
        base.OnMatchesOrPowerUp(type, _color);
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.RockGem;
    }
}
