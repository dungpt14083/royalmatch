using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField]
    private TargetUI targetUIPrefab;
    [SerializeField]
    private Transform parent;
    List<TargetUI> targetUIs = new List<TargetUI>();
    public MovesUI movesUI;
    public void Init(List<TargetInfo> targetInfos, int moveLimit)
    {
        movesUI.Init(moveLimit);
        ClearTargetUIs();
        if (targetInfos == null || targetInfos.Count < 1) return;

        foreach (var targetInfo in targetInfos)
        {
            var targetUI = Instantiate(targetUIPrefab, parent);
            targetUI.Init(targetInfo);
            targetUIs.Add(targetUI);
        }
    }
    public void ClearTargetUIs()
    {
        foreach(var target in targetUIs)
        {
            Destroy(target.gameObject);
        }
        targetUIs.Clear();
    }
    public bool IsDone()
    {
        if(GameManagerHeroRecues.instance != null)
        {
            if (GameManagerHeroRecues.instance.isGameWin == false) return false;
        }
        return targetUIs.All(target => target.IsDone());
    }
    public TargetUI GetTargetUI(Item item)
    {
        var target = targetUIs.FirstOrDefault(targetUI => targetUI.info.targetType == TargetTypes.CollectItem && targetUI.info.itemsType == item.GetItemType());
        return target;
    }
    public TargetUI GetTargetUI(ObstacleBase obstacle)
    {
        var target = targetUIs.FirstOrDefault(targetUI => targetUI.info.targetType == TargetTypes.CollectObstacle && targetUI.info.obstacleType == obstacle.GetObstacleType());
        return target;
    }
    public void MoveItem()
    {
        movesUI.OffSet(-1);
        if(movesUI.GetCount() <= 0)
        {
            LevelManager.Instance.CheckWinLose();
        }
    }

}
