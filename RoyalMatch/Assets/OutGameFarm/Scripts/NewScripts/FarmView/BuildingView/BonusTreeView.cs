using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BonusTreeView : MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IBeginDragHandler,IPointerClickHandler
{
   private GeneralBalance _generalBalance;
   private bool _harvestReady;
   private int _harvestCount;
   private int _maxHarvests ;
   private float _harvestCooldown ; // Thời gian giữa mỗi lần thu hoạch (tính bằng giây)
   private Coroutine _harvestCooldownRoutine;
  
   private FruitTreeSprites _fruitTreeSprites;

   [SerializeField] private SpriteRenderer _renderer;
   private BonusTreeBuilding _bonusTreeBuilding;
   private GrowthStageBuilding _growthStageBuilding;
   [Header("Interface")] 

   [SerializeField] private Button btnBuy;
   [SerializeField] private Button btnHarvet;
   [SerializeField] private GameObject PanalGrowing;
   [SerializeField] private GameObject PanalHarvet;
   [SerializeField] private TMP_Text _textReward;

   
   
   

    private void Awake()
     {
         btnHarvet.onClick.AddListener(Harvest);
     }

     public void Init(BonusTreeBuilding treeBuilding)
    {
        _bonusTreeBuilding = treeBuilding;
        _harvestReady = false;
        _harvestCount = 0;
        //get data
        _generalBalance = treeBuilding.GeneralBalance;
        _fruitTreeSprites =
            SingletonMonobehaviour<BonusTreeAssetCollection>.Instance.GetAsset(_bonusTreeBuilding.Building
                .BuildingProperties.BuildingName);
        _maxHarvests = treeBuilding.BonusTreeProperties.MaxHarvests;
        _harvestCooldown = treeBuilding.BonusTreeProperties.TimeToFirstHarvest;
        _growthStageBuilding = GrowthStageBuilding.HarvestReady;
        UpdateRenderer();
    }


    private void Update()
    {
       
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
        Currencies currencies = new Currencies(_bonusTreeBuilding.BonusTreeProperties.rewards);
        if (FarmMapController.Instance.GeneralBalance.CanEarnCurrencies(currencies))
        {
            if (FarmMapController.Instance.EarnCurrencies(currencies))
            {
                _harvestReady = false;
                _harvestCooldownRoutine ??= StartCoroutine(HarvestCooldownRoutine());
                if (_growthStageBuilding == GrowthStageBuilding.HarvestReady)
                {
                    _growthStageBuilding = GrowthStageBuilding.Withered;
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
        if (_growthStageBuilding == GrowthStageBuilding.HarvestReady)
        {
            Harvest();
        }else if (_growthStageBuilding == GrowthStageBuilding.Withered)
        {
            DestroyBuilding();
        }
    }

    private void DestroyBuilding()
    {
        if (_bonusTreeBuilding != null)
        {
            if(_bonusTreeBuilding.IsProcessCollect)return;
            if (TileManagerView.Instance == null ||
                !TileManagerView.Instance.IsTileReached(_bonusTreeBuilding.Building.Area))
            {
                return;
            }

            if (_bonusTreeBuilding.CanSpendCurrencies())
            {
                TileManagerView.Instance.FireTileCollectBonusTreeEvent(_bonusTreeBuilding);
            }
        }
    }
}
