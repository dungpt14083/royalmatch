using UnityEngine;
using DG.Tweening;
public class MailBoxObstacle : ObstacleBase
{
    public GameObject mailPrefab;

    public override void MatchesOrPowerUpAction()
    {
        base.MatchesOrPowerUpAction();
        var obstacleNew = Instantiate(mailPrefab, this.transform.position, Quaternion.identity, LevelManager.Instance.GameField);
        obstacleNew.transform.DOMove(LevelManager.Instance.scoreTargetObject.transform.position, 2f).OnComplete(()=> { Destroy(obstacleNew);});
    }
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.MailBox;
    }
}
