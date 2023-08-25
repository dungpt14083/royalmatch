using System.Collections.Generic;

public class SoilObstacle : ObstacleChangeState
{
    public override void EndStateAction(List<Square> _squares)
    {
        base.EndStateAction(_squares);
        foreach(var square in _squares)
        {
            var allSoilNear = LevelManager.Instance.FindObstacle<SoilObstacle>(square.col, square.row);
            foreach (var soil in allSoilNear)
            {
                soil.DestroyObstacle();
            }
        }
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.Soil;
    }
}
