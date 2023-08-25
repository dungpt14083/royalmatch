public class ColorBoxObstacle : ObstacleChangeState
{
    public int color;

    public override bool IsCanChangeState(ChangeStateTypes type, int _color = -1)
    {
        if (_color != color) return false;
        return base.IsCanChangeState(type);
    }

}