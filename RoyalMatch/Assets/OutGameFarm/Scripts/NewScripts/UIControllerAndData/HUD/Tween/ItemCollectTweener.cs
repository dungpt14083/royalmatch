using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


//SẼ LÀ NƠI ĐƯỢC GỌI QUA ĐỂ CHẠY VÀO ĐÂU VÀO TWEEN NÀO:::
public class ItemCollectTweener : MonoSingleton<ItemCollectTweener>
{
    [SerializeField] private float JumpPower;

    [SerializeField] private int NumberOfJumps;

    [SerializeField] private float Duration;

    [SerializeField] private float DelayDuration;

    [SerializeField] private float MinPositionX;

    [SerializeField] private float MaxPositionX;

    [SerializeField] private float MinYMultiplier;

    [SerializeField] private float MaxYMultiplier;

    [SerializeField] private float PerFrameSizeChange;

    [SerializeField] private int WaitForFrameCount;

    //private TradeService _tradeService;

    //private CurrencyTweenManager _currencyTweenManager;

    //private TransactionService _transactionService;

    //private TweenCurveService _tweenCurveService;

    //private GatherableTweenItemFactory _gatherableTweenItemFactory;

    //private TweenItemFactory _tweenItemFactory;

    //private SoundService _soundService;

    //private Hud _hud;

    private Vector2 _centerViewport;

    [SerializeField] public float yMult;


    //NHẬN SỐ TIỀN VÀ BỘ ĐẾM:::LỌC RA TRADETYPE TYPE VÀ SỐ LƯỢNG 
    private (Dictionary<TradeType, int>, Dictionary<TradeType, int>) GetAmountsAndCounters(
        Dictionary<TradeInfo, int> rewards)
    {
        Dictionary<TradeType, int> tmpDic1 = new Dictionary<TradeType, int>();
        Dictionary<TradeType, int> tmpDic2 = new Dictionary<TradeType, int>();

        foreach (var kvp in rewards)
        {
            //NẾU CHƯA CÓ DICTIONARY THÌ SẼ ADD SỐ LƯỢNG VÀO::::
            if (!tmpDic1.ContainsKey(kvp.Key.TradeType))
            {
                tmpDic1.Add(kvp.Key.TradeType, 0);
            }

            tmpDic1[kvp.Key.TradeType] += kvp.Value;

            //CÁ COUNTER ĐƯC ĐẾN LÊN TỪNG LẦN TỪNG LẦN SỐ LƯỢNG ĐẾM VÀ ...
            if (!tmpDic2.ContainsKey(kvp.Key.TradeType))
            {
                tmpDic2.Add(kvp.Key.TradeType, 0);
            }

            tmpDic2[kvp.Key.TradeType]++;
        }

        return (tmpDic1, tmpDic2);
    }

    //DỤA VÀO LOẠI TRADEINFO ĐỂ TỪ ĐÓ LẤY VỊ TRÍ TIỀN TỆ HOẶC VỊ TRÍ NHÀ KHO Ở TRONG ĐÓ 
    private UnityEngine.Vector3 GetTargetPosition(TradeInfo tradeInfo)
    {
        //NẾU MÀ TYPE BẰlớn hơn 3 th đi tới label 2 để tới các thứ trong maapscene truy CẬP TỚI CÁC NÚT:::


        //nếu bằng 3 THÌ LÀ CÁI THẰNG BOOTER CỦA PUZZLE

        //currentcy position trong HUB VỚI LOẠI

        return MapScene.Instance.InventoryPanel.GetTargetTransform().position;
    }


    #region MAKEITEMFLYFORCOLLECTGATHERABLE::::

    //TRUYỀN LIST REWARD VÀO VA CHẠY
    public void StartSpawnWorldJump(Vector3 worldPosition,
        Dictionary<TradeInfo, int> rewards, string reason = "")
    {
        StartCoroutine(SpawnWorldJump(worldPosition, rewards, reason));
    }

    public IEnumerator SpawnWorldJump(Vector3 worldPosition, Dictionary<TradeInfo, int> rewards, string reason = "")
    {
        //float totalRewardValue = CalculateTotalRewardValue(rewards);

        //var screenPoint = Camera.main.WorldToScreenPoint(worldPosition);

        //CỨ 1 TIME THÌ TẠO RA 1 ITEM VÀ BAY LÊN::::
        foreach (KeyValuePair<TradeInfo, int> rewardAmountPair in rewards)
        {
            var target = GetTargetPosition(rewardAmountPair.Key);
            //TỪNG MỌT TỪNG MỘT 
            for (int k = 0; k < rewardAmountPair.Value; k++)
            {
                Debug.Log("thang xx" + rewardAmountPair.Value);
                //float totalRewardValue = CalculateTotalRewardValue(rewards);
                //float halfTotalRewardValue = totalRewardValue * 0.5f;
                //var tweenCounter = Mathf.RoundToInt(this.yMult * halfTotalRewardValue);
                //var yOffset = this.yMult * halfTotalRewardValue * 0.5f;

                TweenItem itemTween = GatherableTweenItemFactory.Instance.GetTweenItem();
                //Show lên csai hình nhà kho lên::::
                itemTween.SetDefault();
                //CHO TRAIL TÍNH SAU ::::
                itemTween.SetGatherableMode(true);
                //lấy sprite từ hệ thống sprite nhét vào ::::
                Sprite spriteTrade = TradeManager.Instance.GetSprite(rewardAmountPair.Key);
                itemTween.SetSprite(spriteTrade);
                itemTween.SetSize(new Vector2(100, 100));
                itemTween.SetTrailActive(false);
                itemTween.SetStartingPosition(worldPosition);
                itemTween.SetTargetPosition(target);
                itemTween.SetActive(true);
                itemTween.SetMoveDuration(2f);
                itemTween.CreateSequence();

                //ĐOẠN NÀY CHẠY DOJUMP VÀ GÁN VÀO //DOJUMP NỮA VÀ SET EASSE::::
                //thay vị chạy apply thì chạy này vì bên kia...
                itemTween.Tween();
                itemTween.SetOnCompleteAction(() =>
                {
                    GatherableTweenItemFactory.Instance.BackToPool(itemTween);
                    itemTween.SetActive(false);
                });
                yield return new WaitForSeconds(0.2f);
            }
        }
    }

    #endregion
}