using DG.Tweening;
using UnityEngine;

public class DogBoxObstacle : ObstacleBase
{
    public GameObject bonePrefab;
    public override void MatchesOrPowerUpAction()
    {
        base.MatchesOrPowerUpAction();
        var obstacleNew = Instantiate(bonePrefab, this.transform.position,Quaternion.identity ,LevelManager.Instance.GameField);
        obstacleNew.transform.DOMove(LevelManager.Instance.scoreTargetObject.transform.position, 2f).OnComplete(() => { Destroy(obstacleNew); });
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.DogBox;
    }
}
