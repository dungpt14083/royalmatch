using System.Collections.Generic;

public class GardenObstacle : ObstacleChangeState
{
    public override void EndStateAction(List<Square> _squares)
    {
        base.EndStateAction(_squares);
        var squares = LevelManager.Instance.GetSquaresInRange(columStart, rowStart, 2);
        var prefab = LevelManager.Instance.GetObstacleByType(ObstacleTypes.Grass);
        LevelManager.Instance.ReplaceObstacle(prefab,squares);
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.GreenBox;
    }
}