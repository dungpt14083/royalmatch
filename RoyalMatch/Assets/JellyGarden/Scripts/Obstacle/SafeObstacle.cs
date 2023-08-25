public class SafeObstacle : ObstacleChangeState
{
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.Safe;
    }
}
