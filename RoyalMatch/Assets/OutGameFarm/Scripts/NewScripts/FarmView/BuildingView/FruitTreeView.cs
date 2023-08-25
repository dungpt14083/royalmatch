using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class FruitTreeView : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IBeginDragHandler,IPointerClickHandler
{
    private GeneralBalance GeneralBalance;
    private bool _harvestReady;
    private int _harvestCount;
    private int _maxHarvests ;
    private float _harvestCooldown ; // Thời gian giữa mỗi lần thu hoạch (tính bằng giây)
    private Coroutine _harvestCooldownRoutine;
    private float _timeElapsed; // Thời gian đã trôi qua kể từ lúc bắt đầu tăng trưởng
    private float _timeRemain;
    private float _halfGrowthTime; // Thời gian tăng trưởng cần đạt đến 50%
    private float _timeToFirstHarvest;
    private FruitTreeSprites _fruitTreeSprites;

    
    [SerializeField] private SpriteRenderer _renderer;
    private FruitTreeBuilding _fruitTreeBuilding;
    private GrowthStageBuilding _growthStageBuilding;
     [Header("Interface")] 
     [SerializeField] private TMP_Text textRemainTime;

     [SerializeField] private Button btnBuy;
     [SerializeField] private Button btnHarvet;
     [SerializeField] private GameObject PanalGrowing;
     [SerializeField] private GameObject PanalHarvet;
     [SerializeField] private TMP_Text _textReward;

     #region Interface
     private void CompleteHarvestTime()
     {
         Currencies currencies = new Currencies("gems", int.Parse(_textReward.text));
         if (GeneralBalance.CanSpendCurrencies(currencies))
         {
             if(FarmMapController.Instance.SpendCurrencies(currencies))
             {
                 if (_harvestCooldownRoutine != null)
                 {
                     StopCoroutine(_harvestCooldownRoutine);
                     _harvestCooldownRoutine = null;
                     ResetTimeElapsed();
                     _timeElapsed = _halfGrowthTime;
                     _timeElapsed = 0;
                     TurnHarvestReadyNow(); 
                 }
             }
      
         }
       
     }

     private void UpdateRemainingTimeUI()
     {
         float remainingTime = _timeToFirstHarvest - _timeRemain;

         if (_growthStageBuilding == GrowthStageBuilding.HarvestReady)
         {
             textRemainTime.text = "Ready to Harvest!";
         }
         else if (_growthStageBuilding == GrowthStageBuilding.Withered)
         {
             textRemainTime.text = "Withered";
         }
         else
         {
           //  TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
         //    string timeFormat = (timeSpan.TotalHours >= 1) ? "hh':'mm':'ss" : "mm':'ss";
           //  textRemainTime.text = timeSpan.ToString(timeFormat);
           
           TimeSpan timeSpan = TimeSpan.FromSeconds(remainingTime);
           /*
           string formattedTime = string.Empty;
           if (timeSpan.Hours > 0)
           {
               formattedTime += $"{timeSpan.Hours}h";
           }

           if (timeSpan.Minutes > 0)
           {
               formattedTime += $"{timeSpan.Minutes}m";
           }

           if (timeSpan.Seconds > 0)
           {
               formattedTime += $"{timeSpan.Seconds}s";
           }*/
           string formattedTime = "";

           if (timeSpan.Hours > 0)
           {
               formattedTime += timeSpan.Hours.ToString("00") + "h:" + timeSpan.Minutes.ToString("00") + "m";
           }
           else
           {
               formattedTime += timeSpan.Minutes.ToString("00") + "m";
           }

           if (timeSpan.Seconds > 0 && timeSpan.Hours == 0)
           {
               formattedTime += ":" + timeSpan.Seconds.ToString("00") + "s";
           }

           textRemainTime.text = formattedTime;
         
         }
     }
     private void ResetTimeElapsed()
     {
         _timeRemain = 0f;
     }
     

     #endregion

     private void Awake()
     {
         btnHarvet.onClick.AddListener(Harvest);
         btnBuy.onClick.AddListener(CompleteHarvestTime);
     }

     public void Init(FruitTreeBuilding treeBuilding)
    {
        _fruitTreeBuilding = treeBuilding;
        _harvestReady = false;
        _harvestCount = 0;
        _timeElapsed = 0f;
        //get data
        GeneralBalance = treeBuilding.GeneralBalance;
        _fruitTreeSprites =
            SingletonMonobehaviour<FruitTreeAssetCollection>.Instance.GetAsset(_fruitTreeBuilding.Building
                .BuildingProperties.BuildingName);
        _maxHarvests = treeBuilding.FruitTreeProperties.MaxHarvests;
        _harvestCooldown = treeBuilding.FruitTreeProperties.TimeToFirstHarvest;
        _timeToFirstHarvest = treeBuilding.FruitTreeProperties.TimeToFirstHarvest;
        _halfGrowthTime = _harvestCooldown / 2f;
        StartGrowing();
        _growthStageBuilding = GrowthStageBuilding.GrowingStage1;
    }
    private void StartGrowing()
    {
        UpdateRenderer();
       // this.Invoke(TurnHarvestReadyNow, _timeToFirstHarvest); // Replace 60f and 120f with appropriate time range for the first harvest.
       StartFirstHarvestTimer();
    }

    private void StartFirstHarvestTimer()
    {
        if (_harvestCooldownRoutine == null)
        {
            ResetTimeElapsed();
            _harvestCooldownRoutine = StartCoroutine(HarvestCooldownRoutine());
        }
    }
    private void Update()
    {
        UpdateRemainingTimeUI();
        if (!_harvestReady)
        {
            _timeElapsed += Time.deltaTime;
            _timeRemain += Time.deltaTime;
            if (_timeElapsed >= _halfGrowthTime && _growthStageBuilding == GrowthStageBuilding.GrowingStage1)
            {
                _growthStageBuilding = GrowthStageBuilding.GrowingStage2;
                UpdateRenderer();
                Debug.Log( this.gameObject.name+"đã chạy được nửa thời gian");
            }
        }
    }

    private void TurnHarvestReadyNow()
    {
        _harvestReady = true;
        _harvestCount++;

        if (_harvestCount > _maxHarvests)
        {
            _growthStageBuilding = GrowthStageBuilding.Withered;
            UpdateRenderer();
            return;
        }
       
        _growthStageBuilding = GrowthStageBuilding.HarvestReady;
        UpdateRenderer();
    }
    
    private void Harvest()
    { 
        Currencies currencies = new Currencies(_fruitTreeBuilding.FruitTreeProperties.rewards);
        if (FarmMapController.Instance.GeneralBalance.CanEarnCurrencies(currencies))
        {
            if (FarmMapController.Instance.EarnCurrencies(currencies))
            {
                _harvestReady = false;
                _harvestCooldownRoutine ??= StartCoroutine(HarvestCooldownRoutine());
                if (_growthStageBuilding == GrowthStageBuilding.HarvestReady)
                {
                    _timeElapsed = 0;
                    _growthStageBuilding = GrowthStageBuilding.GrowingStage1;
                }
                UpdateRenderer();
            }
        }
        else
        {
            Debug.Log("không đủ chỗ chứa");
        }


    }
    
    private IEnumerator HarvestCooldownRoutine()
    {
        if (_harvestCount < _maxHarvests)
        {
            yield return new WaitForSeconds(_harvestCooldown);
            
        }
        _harvestCooldownRoutine = null;
        TurnHarvestReadyNow();
        if (_harvestCount > _maxHarvests)
        {
            _growthStageBuilding = GrowthStageBuilding.Withered;
            UpdateRenderer();
        }
       
    }

    private void UpdateRenderer()
    {
        switch (_growthStageBuilding)
        {
            case GrowthStageBuilding.GrowingStage1:
                _renderer.sprite = _fruitTreeSprites.GrowingStage1Sprite;
                PanalHarvet.SetActive(false);
                break;
            case GrowthStageBuilding.GrowingStage2:
                _renderer.sprite = _fruitTreeSprites.GrowingStage2Sprite;
                PanalHarvet.SetActive(false);
                break;
            case GrowthStageBuilding.HarvestReady:
                _renderer.sprite = _fruitTreeSprites.HarvestReadySprites;
                PanalHarvet.SetActive(true);
                PanalGrowing.SetActive(false);
                break;
            case GrowthStageBuilding.Withered:
                _renderer.sprite = _fruitTreeSprites.WitheredSprite;
                PanalHarvet.SetActive(false);
                break;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("state building: "+_growthStageBuilding+" thời gian còn lại "+(_timeToFirstHarvest-_timeElapsed));
        if (_growthStageBuilding == GrowthStageBuilding.HarvestReady)
        {
            Harvest();
            Debug.Log("thu hoạch thành công");
            Debug.Log("số lần còn lại " + (_maxHarvests - _harvestCount));
        }else if (_growthStageBuilding == GrowthStageBuilding.Withered)
        {
            DestroyBuilding();
        }
        else
        {
            Debug.Log("chưa sẵn sàng để thu hoạch");
            bool panalGrowingActive = PanalGrowing.activeSelf;
            PanalGrowing.SetActive(!panalGrowingActive);
        }
    }

    private void DestroyBuilding()
    {
        if (_fruitTreeBuilding != null)
        {
            if(_fruitTreeBuilding.IsProcessCollect)return;
            if (TileManagerView.Instance == null ||
                !TileManagerView.Instance.IsTileReached(_fruitTreeBuilding.Building.Area))
            {
                return;
            }

            if (_fruitTreeBuilding.CanSpendCurrencies())
            {
                TileManagerView.Instance.FireTileCollectTreeFruitEvent(_fruitTreeBuilding);
            }
        }
    }

}