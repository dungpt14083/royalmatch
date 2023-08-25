using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LevelHeroRescues : MonoBehaviour
{
    //[HideInInspector]
    public Hero _hero;
    public GoalSpawner goalSpawner;
    public static LevelHeroRescues _instance;
    public List<PinLong> pinLongs;

    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(_hero == null) _hero = GameObject.FindGameObjectWithTag("Hero").GetComponent<Hero>();
        if (goalSpawner == null) goalSpawner = GameObject.FindObjectOfType<GoalSpawner>();
        goalSpawner.SpawnCoin(gameObject.transform);
    }
    public PinLong FindPinLongByTargetInfo(TargetInfo targetInfo)
    {
        foreach(var pinLong in pinLongs)
        {
            if(pinLong.targetInfo.targetType == targetInfo.targetType)
            {
                if(targetInfo.itemsType != ItemsTypes.NONE && pinLong.targetInfo.itemsType == targetInfo.itemsType)
                {
                    return pinLong;
                }
                else if (targetInfo.obstacleType != ObstacleTypes.None && pinLong.targetInfo.obstacleType == targetInfo.obstacleType)
                {
                    return pinLong;
                }
            }
        }
        return null;
    }
    public void SetTargetInfos(List<TargetInfo> targetInfos)
    {
        if (pinLongs == null) return;
        for(int i=0;i< pinLongs.Count; i++)
        {
            if(i < targetInfos.Count)
            {
                pinLongs[i].targetInfo = targetInfos[i];
            }
            else
            {
                pinLongs[i].targetInfo = null;
            }
        }
    }
    //public void MatchItems(List<ColorItem> items)
    //{

    //    foreach(var item in items)
    //    {
    //        MatchItem(item);
    //    }
    //}
    //public void MatchItem(ColorItem item)
    //{

    //    if (item == null) return;
    //    Debug.Log("MatchItems item.color " + item.color);
    //    if (pinLongs.ContainsKey(item.color))
    //    {
    //        Debug.Log("MatchItems item.color AddColor " + item.color);
    //        pinLongs[item.color].AddColor();
    //        if (pinLongs[item.color].CheckCompleteTarget())
    //        {
    //            Debug.Log("MatchItems item.color MovePinLong " + item.color);
    //            colorMoves.Add(item.color);
    //        }
    //    }
    //}
    //private void CheckMovePinLong()
    //{
    //    if (colorMoves.Count == 0) return;
    //    if (currentMove > 0) return;
    //    currentMove = colorMoves[0];
    //    colorMoves.RemoveAt(0);
    //    pinLongs[currentMove].MovePinLong();
    //    DG.Tweening.DOVirtual.DelayedCall(3, () => currentMove = -1);
    //}
    //private void Update()
    //{
    //    CheckMovePinLong();
    //}
}
