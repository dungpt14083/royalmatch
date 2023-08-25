using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;
using JellyGarden.Scripts.Targets;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;
using DG.Tweening;

public class SquareBlocks
{
    public List<ItemsTypes> GenItems = new List<ItemsTypes>();
    public SquareTypes squareType;
    public ItemsTypes itemsType;
    public ObstacleTypes obstacleType;

}

public enum GameState
{
    Map,
    PrepareGame,
    Playing,
    Highscore,
    GameOver,
    Pause,
    PreWinAnimations,
    Win,
    WaitForPopup,
    WaitAfterClose,
    BlockedGame,
    Tutorial,
    PreTutorial,
    WaitForPotion,
    PreFailed,
    RegenLevel
}


public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    #region Items
    public BlueItem itemBluePrefab;
    public GreenItem itemGreenPrefab;
    public RedItem itemRedPrefab;
    public PinkItem itemPinkPrefab;
    public YellowItem itemYellowPrefab;

    public HorizontalItem itemHorizontalPrefab;
    public VerticalItem itemVerticalPrefab;
    public PackageItem itemPackagePrefab;
    public BombItem itemBombPrefab;
    public PropellerItem itemPropellerPrefab;

    public EggItem itemEggPrefab;
    public DiamonItem itemDiamonPrefab;

    public PiggyItem itemPiggyPrefab;
    public PiggyHelmetItem itemPiggyHelmetPrefab;
    public PumpkinItem itemPumpkinPrefab;
    public VaseItem itemVasePrefab;

    #endregion Items

    #region DestroyItems
    public VerticalDestroy verticalDestroyPrefab;
    public HorizontalDestroy horizontalDestroyPrefab;
    public BombDestroy bombDestroyPrefab;
    #endregion DestroyItems

    public Square squarePrefab;

    #region Obstacles
    public BoxObstacle boxObstaclePrefab;
    public BlueBoxObstacle blueBoxObstaclePrefab;
    public GreenBoxObstacle greenBoxObstaclePrefab;
    public PinkBoxObstacle pinkBoxObstaclePrefab;
    public RedBoxObstacle redBoxObstaclePrefab;
    public YellowBoxObstacle yellowBoxObstaclePrefab;
    public CupboardObstacle cupboardObstaclePrefab;
    public DogBoxObstacle dogBoxPrefab;
    public GardenObstacle gardenPrefab;
    public GrassObstacle grassPrefab;
    public HatObstacle hatPrefab;
    public LanternObstacle lanternObstaclePrefab;
    public MailBoxObstacle mailBoxPrefab;
    public MoleObstacle moleObstaclePrefab;
    public PotObstacle potPrefab;
    public RockGemObstacle rockGemObstaclePrefab;
    public RockOwlObstacle rockOwlObstaclePrefab;
    public SafeObstacle safeObstaclePrefab;
    public SoilObstacle soilPrefab;
    #endregion Obstacles

    public Sprite squareSprite;
    public Sprite squareSprite1;
    public Sprite outline1;
    public Sprite outline2;
    public Sprite outline3;
    public LifeShop lifeShop;
    public Transform GameField;
    public bool enableInApps;
    public int maxRows = 9;
    public int maxCols = 9;
    public float squareWidth = 2f;
    public float squareHeight = 2f;
    public Vector2 firstSquarePosition;
    public Square[] squaresArray;
    public List<ObstacleBase> obstacleItems = new List<ObstacleBase>();
    List<List<Item>> combinedItems = new List<List<Item>>();
    public Item lastDraggedItem;
    public Item lastSwitchedItem;
    public List<Item> destroyAnyway = new List<Item>();
    public GameObject popupScore;
    public int scoreForItem = 10;
    public int scoreForBlock = 100;
    public int scoreForWireBlock = 100;
    public int scoreForSolidBlock = 100;
    public int scoreForThrivingBlock = 100;
    public LIMIT limitType;
    public int Limit = 30;
    public int TargetScore = 1000;
    public int currentLevel = 1;
    public int FailedCost;
    public int ExtraFailedMoves = 5;
    public int ExtraFailedSecs = 30;
    public int miniGameLevelNumber = 0;
    public int miniGameLevelTarget = 0;
    public List<GemProduct> gemsProducts = new List<GemProduct>();
    public string[] InAppIDs;
    public string GoogleLicenseKey;
    LineRenderer line;
    public bool thrivingBlockDestroyed;
    List<List<Item>> newCombines;
    //private bool dragBlocked;
    public string androidSharingPath;
    public string iosSharingPath;
    public Item itemTestPrefab;
    public GameManagerHeroRecues gameManagerHeroRecuesPrefab;
    public List<Square> squareCanGenItem;
    public List<BombDestroy> bombDestroys = new List<BombDestroy>();
    public BootersController bootersController;
    public TargetController targetController;
    SquareBlocks[] levelSquaresFile = new SquareBlocks[81];
    public int targetBlocks;

    public GameObject[] itemExplPool = new GameObject[20];
    private int linePoint;
    public bool showPopupScores;

    public GameObject stripesEffect;
    
    public GameObject snowParticle;
    public Color[] scoresColors;
    public Color[] scoresColorsOutline;
    
    public GameObject scoreTargetObject;
    public GameObject[] gratzWords;

    public GameObject Level;
    public GameObject LevelsMap;

    public BoostIcon[] InGameBoosts;
    public int passLevelCounter;
    public WinLosePopup winLosePopup;
    public int TargetBlocks
    {
        get
        {
            return targetBlocks;
        }
        set
        {
            if (targetBlocks < 0)
                targetBlocks = 0;
            targetBlocks = value;
        }
    }

    //public bool DragBlocked
    //{
    //    get
    //    {
    //        return dragBlocked;
    //    }
    //    set
    //    {
    //        dragBlocked = value;
    //    }
    //}
    public BombDestroy CreatBombDestroy(Square square)
    {
         var bomb = Instantiate(bombDestroyPrefab, square.transform.position,Quaternion.identity, square.transform.parent);
        bombDestroys.Add(bomb);
         return bomb;
    }
    public BombDestroy FindBombDestroy(int color)
    {
        if (bombDestroys.Count == 0) return null;
        var result = bombDestroys.FirstOrDefault(b => b.color == color);
        return result;
    }
    public bool CanGenItem()
    {
        return squareCanGenItem.Any(s => s.isCanGenItemNew());
    }
    private GameState GameStatus;
    //public bool itemsHided;
    public int moveID;
    //public int lastRandColor;
    public bool onlyFalling;
    public bool levelLoaded;
    public Hashtable countedSquares;
    public Sprite doubleBlock;
    public bool FacebookEnable;
    internal int latstMatchColor;
    public CombineManager combineManager;
    //public TargetObject[] targetObject;

    #region EVENTS

    public delegate void GameStateEvents();

    public static event GameStateEvents OnMapState;
    public static event GameStateEvents OnEnterGame;
    public static event GameStateEvents OnLevelLoaded;
    public static event GameStateEvents OnMenuPlay;
    public static event GameStateEvents OnMenuComplete;
    public static event GameStateEvents OnStartPlay;
    public static event GameStateEvents OnWin;
    public static event GameStateEvents OnLose;

    public GameState gameStatus
    {
        get
        {
            return GameStatus;
        }
        set
        {
            GameStatus = value;
            InitScript.Instance.CheckAdsEvents(value);
        }
    }
    public void WinGame()
    {
        gameStatus = GameState.Win;
        winLosePopup.Show("You Win");
        //InitScript.THIS.AddGems(1);//Add coins after win
        if (!InitScript.Instance.losingLifeEveryGame)
            InitScript.Instance.AddLife(1);
        OnMenuComplete();

#if PLAYFAB || GAMESPARKS
                NetworkManager.dataManager.SetPlayerScore(currentLevel, Score);
                NetworkManager.dataManager.SetPlayerLevel(currentLevel + 1);
                NetworkManager.dataManager.SetStars();
#endif
        //GameObject.Find("CanvasGlobal").transform.Find("MenuComplete").gameObject.SetActive(true);
        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.complete[1]);
        OnWin();
    }
    public void PreWin()
    {
        gameStatus = GameState.PreWinAnimations;
        //StartCoroutine(PreWinAnimationsCor());
    }
    public void GameOver()
    {
        gameStatus = GameState.GameOver;
        winLosePopup.Show("You Lose");
        //GameObject.Find("CanvasGlobal").transform.Find("MenuFailed").gameObject.SetActive(true);
        //OnLose();
    }
    public void PlayGame()
    {
        gameStatus = GameState.Playing;
        Time.timeScale = 1;
        return;
        //Todo : lam sau
        //StartCoroutine(AI.THIS.CheckPossibleCombines());
    }
    public void PauseGame()
    {
        gameStatus = GameState.Pause;
        Time.timeScale = 0;
    }
    public void PreFailed()
    {
        gameStatus = GameState.PreFailed;
        GameObject.Find("CanvasGlobal").transform.Find("PreFailed").gameObject.SetActive(true);
    }
    public void LoadMap()
    {
        gameStatus = GameState.Map;
        if (PlayerPrefs.GetInt("OpenLevelTest") <= 0)
        {
            MusicBase.Instance.GetComponent<AudioSource>().Stop();
            MusicBase.Instance.GetComponent<AudioSource>().loop = true;
            MusicBase.Instance.GetComponent<AudioSource>().clip = MusicBase.Instance.music[0];
            MusicBase.Instance.GetComponent<AudioSource>().Play();
            //EnableMap(true);
            OnMapState();
            PrepareGame();
            PlayerPrefs.SetInt("OpenLevelTest", 0);
            PlayerPrefs.Save();
        }
        else
        {
            PrepareGame();
            PlayerPrefs.SetInt("OpenLevelTest", 0);
            PlayerPrefs.Save();
        }
        //if (passLevelCounter > 0 && InitScript.Instance.ShowRateEvery > 0)
        //{
        //    if (passLevelCounter % InitScript.Instance.ShowRateEvery == 0 && InitScript.Instance.ShowRateEvery > 0 && PlayerPrefs.GetInt("Rated", 0) == 0)
        //        InitScript.Instance.ShowRate();
        //}
    }
    public void MenuPlayEvent()
    {
        OnMenuPlay();
    }


    #endregion

    public void LoadLevel(out List<ObstacleMapConfig> obstacles)
    {
        currentLevel = PlayerPrefs.GetInt("OpenLevel");// TargetHolder.level;
        if (currentLevel == 0)
            currentLevel = 1;
        LoadDataFromLocal(currentLevel, out List<ObstacleMapConfig> _obstacles);
        obstacles = _obstacles;
        var tar = Resources.Load<TargetLevel>("Targets/Level" + currentLevel);
        targetController.Init(tar.targets, Limit);
    }

    public void EnableMap(bool enable)
    {
        float aspect = (float)Screen.height / (float)Screen.width;//2.1.4
        GetComponent<Camera>().orthographicSize = 5.3f;
        aspect = (float)Math.Round(aspect, 2);
        //GameObject.Find("CanvasGlobal").GetComponent<GraphicRaycaster>().enabled = false;
        //GameObject.Find("CanvasGlobal").GetComponent<GraphicRaycaster>().enabled = true;
        if (enable)
        {
            // if (aspect == 1.6f)
            //     GetComponent<Camera>().orthographicSize = 6.25f;                    //16:10
            // else if (aspect == 1.78f)
            //     GetComponent<Camera>().orthographicSize = 7f;    //16:9
            // else if (aspect == 1.5f)
            //     GetComponent<Camera>().orthographicSize = 5.9f;                  //3:2
            // else if (aspect == 1.33f)
            //     GetComponent<Camera>().orthographicSize = 5.25f;                  //4:3
            // else if (aspect == 1.67f)
            //     GetComponent<Camera>().orthographicSize = 6.6f;                  //5:3
            // else if (aspect == 1.25f)
            //     GetComponent<Camera>().orthographicSize = 4.9f;                  //5:4
            // else if (aspect == 2.06f)
            //     GetComponent<Camera>().orthographicSize = 8.2f;                  //2960:1440
            // else if (aspect == 2.17f)
            //     GetComponent<Camera>().orthographicSize = 8.7f;                  //iphone x
            GetComponent<Camera>().GetComponent<MapCamera>().SetPosition(new Vector2(0, GetComponent<Camera>().transform.position.y));
        }
        else
        {
            InitScript.DateOfExit = DateTime.Now.ToString();  //1.4

            LevelManager.Instance.latstMatchColor = -1;

            //GetComponent<Camera>().orthographicSize = 6.5f;
            GetComponent<Camera>().orthographicSize = 9f;
            Level.transform.Find("Canvas/Panel").GetComponent<RectTransform>().anchoredPosition = Vector3.zero;//2.2
            if (aspect == 2.06f)
                GetComponent<Camera>().orthographicSize = 7.6f;                  //2960:1440
            else if (aspect == 2.17f)
            {
                GetComponent<Camera>().orthographicSize = 8.1f;                  //iphone x
                Level.transform.Find("Canvas/Panel").GetComponent<RectTransform>().anchoredPosition = Vector3.down * 50;//2.2

            }

            Level.transform.Find("Canvas").GetComponent<GraphicRaycaster>().enabled = false;
            Level.transform.Find("Canvas").GetComponent<GraphicRaycaster>().enabled = true;

        }
        Camera.main.GetComponent<MapCamera>().enabled = enable;
        //LevelsMap.SetActive(!enable);
        //LevelsMap.SetActive(enable);
        Level.SetActive(!enable);

        if (enable)
            GameField.gameObject.SetActive(false);

        if (!enable)
            Camera.main.transform.position = new Vector3(0, 0, -10);
        foreach (Transform item in GameField.transform)
        {
            Destroy(item.gameObject);
        }
    }
    private void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start()
    {
        List<BooterInfo> booterInfos = new List<BooterInfo> { { new BooterInfo { booterType = BootersType.Hammer,count = 10} },
        { new BooterInfo { booterType = BootersType.Arrow,count = 5} },
        { new BooterInfo { booterType = BootersType.Cannon,count = 4} },
        };
        bootersController.Init(booterInfos);

        
        
#if FACEBOOK
        FacebookEnable = true;//1.6.2
        if (FacebookEnable)
            FacebookManager.THIS.CallFBInit();
#else
        FacebookEnable = false;

#endif
#if UNITY_INAPPS

        gameObject.AddComponent<UnityInAppsIntegration>();
        enableInApps = true;//1.6.1
#else
        enableInApps = false;

#endif
        combineManager = new CombineManager();
        
        LoadMap();
        for (int i = 0; i < 20; i++)
        {
            itemExplPool[i] = Instantiate(Resources.Load("Prefabs/Effects/ItemExpl"), transform.position, Quaternion.identity) as GameObject;
            itemExplPool[i].GetComponent<SpriteRenderer>().enabled = false;
        }
        passLevelCounter = 0;
    }
    //public void WaitForPopup()
    //{
    //    gameStatus = GameState.WaitForPopup;
    //    InitLevel(new Vector3(4,0,0), new HeroRecuesData {scale = new Vector3(1,1,1),pos = new Vector3(-4.4f,0,0),level = 81 });
    //    OnLevelLoaded();
    //}
    //public void InitLevel(Vector3 posGameField, HeroRecuesData heroRecuesData)
    //{
    //    GameField.gameObject.SetActive(true);
    //    GenerateLevel();
    //    GenerateOutline();
    //    GameField.transform.position = posGameField;
    //    //ReGenLevel();
    //    //ReGenLevelNew();
    //    gameStatus = GameState.Playing;
        
    //    if (heroRecuesData != null)
    //    {
    //        GameManagerHeroRecues gameManagerHeroRecues = Instantiate(gameManagerHeroRecuesPrefab, GameField.parent);
    //        gameManagerHeroRecues.StartGame(heroRecuesData.scale, heroRecuesData.pos, heroRecuesData.level);
    //    }
        
    //    return;
        
        
    //    //if (limitType == LIMIT.TIME)
    //    //{
    //    //    StopCoroutine(TimeTick());
    //    //    StartCoroutine(TimeTick());
    //    //}
        
        
    //}
    public List<Square> SetSquareGenItem()
    {
        List<Square> squaresCanGenItem = new List<Square>();
        for(int col = 0; col< maxCols; col++)
        {
            for(int row = 0; row < maxCols; row++)
            {
                var square = GetSquare(col, row);
                if (square == null) break;
                if(square.type != SquareTypes.NONE)
                {
                    square.isCanGenItem = true;
                    squaresCanGenItem.Add(square);
                    break;
                }
            }
        }
        return squaresCanGenItem;
    }
    public ObstacleBase GetObstacleByType(ObstacleTypes type)
    {
        ObstacleBase obstacle = null;
        switch (type)
        {
            case ObstacleTypes.Box:
                obstacle = boxObstaclePrefab;
                break;
            case ObstacleTypes.BlueBox:
                obstacle = blueBoxObstaclePrefab;
                break;
            case ObstacleTypes.GreenBox:
                obstacle = greenBoxObstaclePrefab;
                break;
            case ObstacleTypes.PinkBox:
                obstacle = pinkBoxObstaclePrefab;
                break;
            case ObstacleTypes.RedBox:
                obstacle = redBoxObstaclePrefab;
                break;
            case ObstacleTypes.YellowBox:
                obstacle = yellowBoxObstaclePrefab;
                break;
            case ObstacleTypes.Cupboard:
                obstacle = cupboardObstaclePrefab;
                break;
            case ObstacleTypes.DogBox:
                obstacle = dogBoxPrefab;
                break;
            case ObstacleTypes.Garden:
                obstacle = gardenPrefab;
                break;
            case ObstacleTypes.Grass:
                obstacle = grassPrefab;
                break;
            case ObstacleTypes.Hat:
                obstacle = hatPrefab;
                break;
            case ObstacleTypes.Lantern:
                obstacle = lanternObstaclePrefab;
                break;
            case ObstacleTypes.MailBox:
                obstacle = mailBoxPrefab;
                break;
            case ObstacleTypes.Mole:
                obstacle = moleObstaclePrefab;
                break;
            case ObstacleTypes.Pot:
                obstacle = potPrefab;
                break;
            case ObstacleTypes.RockGem:
                obstacle = rockGemObstaclePrefab;
                break;
            case ObstacleTypes.RockOwl:
                obstacle = rockOwlObstaclePrefab;
                break;
            case ObstacleTypes.Safe:
                obstacle = safeObstaclePrefab;
                break;
            case ObstacleTypes.Soil:
                obstacle = soilPrefab;
                break;
        }
        return obstacle;
    }
    public Item GetItemByType(ItemsTypes type)
    {
        Item item;
        switch (type)
        {
            case ItemsTypes.BLUE:
                item = itemBluePrefab;
                break;
            case ItemsTypes.GREEN:
                item = itemGreenPrefab;
                break;
            case ItemsTypes.PINK:
                item = itemPinkPrefab;
                break;
            case ItemsTypes.RED:
                item = itemRedPrefab;
                break;
            case ItemsTypes.YELLOW:
                item = itemYellowPrefab;
                break;
            case ItemsTypes.HORIZONTAL_STRIPPED:
                item = itemHorizontalPrefab;
                break;
            case ItemsTypes.VERTICAL_STRIPPED:
                item = itemVerticalPrefab;
                break;
            case ItemsTypes.PACKAGE:
                item = itemPackagePrefab;
                break;
            case ItemsTypes.BOMB:
                item = itemBombPrefab;
                break;
            case ItemsTypes.PROPELLER:
                item = itemPropellerPrefab;
                break;
            case ItemsTypes.Egg:
                item = itemEggPrefab;
                break;
            case ItemsTypes.Diamon:
                item = itemDiamonPrefab;
                break;
            case ItemsTypes.Piggy:
                item = itemPiggyPrefab;
                break;
            case ItemsTypes.PiggyHelmet:
                item = itemPiggyHelmetPrefab;
                break;
            case ItemsTypes.Pumpkin:
                item = itemPumpkinPrefab;
                break;
            case ItemsTypes.Vase:
                item = itemVasePrefab;
                break;
            default:
                item = null;
                break;
        }
        return item;
    }
    public void GenerateObstacle(List<ObstacleMapConfig> obstacles)
    {
        foreach(var ob in obstacles)
        {
            var obstaclePrefab = GetObstacleByType(ob.obstacleType);
            var listSquare = GetSquaresObstacle(ob, obstaclePrefab.size);
            var obstacle = Instantiate(obstaclePrefab, GameField);
            var pos = firstSquarePosition + new Vector2((ob.colum + (obstaclePrefab.size.y - 1) / 2f) * squareWidth, -(ob.row + (obstaclePrefab.size.x - 1) / 2f) * squareHeight);
            obstacle.transform.localPosition = pos;
            obstacle.columStart = ob.colum;
            obstacle.rowStart = ob.row;
            obstacle.Init(listSquare);

            foreach (var square in listSquare)
            {
                //if (square.item != null) GameObject.Destroy(square.item.gameObject);
                //if(square.type != SquareTypes.NONE) square.type = SquareTypes.SOLIDBLOCK;
                square.obstacle = obstacle;
            }
            obstacleItems.Add(obstacle);
        }
    }
    public List<Square> GetSquaresObstacle(ObstacleMapConfig obstacle, Vector2Int size)
    {
        List<Square> squares = new List<Square>();
        int countRow = size.x;
        int countColum = size.y;
        for(int r = 0; r< countRow; r++)
        {
            for (int c = 0; c < countColum; c++)
            {
                var square = GetSquare(obstacle.colum + c, obstacle.row + r, true);
                squares.Add(square);
            }
        }
        Debug.Log("GetSquaresObstacle " + squares.Count);
        return squares;
    }
    public void ReplaceObstacle(ObstacleBase obstacle, List<Square> _squares)
    {
        foreach(var square in _squares)
        {
            if (square.type == SquareTypes.NONE) continue;
            if (square.item != null)
            {
                Destroy(square.item.gameObject);
            }
            var obstacleNew = Instantiate(obstacle, square.transform.position,Quaternion.identity, GameField);
            obstacleNew.Init(new List<Square> { square });
            obstacleNew.columStart = square.col;
            obstacleNew.rowStart = square.row;
            LevelManager.Instance.SquareSetItem(square, null);
            square.obstacle = obstacleNew;
            //square.type = SquareTypes.SOLIDBLOCK;
        }
    }
    public List<ObstacleBase> FindObstacle<T>(int col, int row)
    {
        List<ObstacleBase> result = new List<ObstacleBase>();
        var ObstacleLeft = GetObstaclesLeft<T>(col,row);
        var ObstacleRight = GetObstaclesRight<T>(col, row);
        result.AddRange(ObstacleLeft);
        result.AddRange(ObstacleRight);
        return result;
    }
    public void GenerateTagert(ObstacleBase obstacle, List<Square> squares)
    {

    }
    public void GenerateRandomItem(int count, Item item)
    {

    }
    public void PrepareGame()
    {
        LevelManager.Instance.gameStatus = GameState.PrepareGame;
        passLevelCounter++;
        MusicBase.Instance.GetComponent<AudioSource>().Stop();
        MusicBase.Instance.GetComponent<AudioSource>().loop = true;
        MusicBase.Instance.GetComponent<AudioSource>().clip = MusicBase.Instance.music[1];
        MusicBase.Instance.GetComponent<AudioSource>().Play();
        moveID = 0;

        scoreTargetObject.SetActive(false);

        TargetBlocks = 0;
        EnableMap(false);


        GameField.transform.position = Vector3.zero;
        
        LoadLevel(out List<ObstacleMapConfig> obstacles);
        var posInitX = maxCols % 2 == 0 ? (-maxCols / 2) * squareWidth + squareWidth / 2 : (-maxCols + 1) / 2 * squareWidth;
        var posInitY = maxRows % 2 == 0 ? (maxRows / 2) * squareHeight - squareHeight / 2 : (maxRows - 1) / 2 * squareHeight;
        //firstSquarePosition = GameField.transform.position;
        firstSquarePosition = new Vector2(posInitX, posInitY);
        if (limitType == LIMIT.MOVES)
        {
            InGameBoosts[0].gameObject.SetActive(true);
            InGameBoosts[1].gameObject.SetActive(false);
        }
        else
        {
            InGameBoosts[0].gameObject.SetActive(false);
            InGameBoosts[1].gameObject.SetActive(true);

        }
        OnEnterGame();

        GameField.gameObject.SetActive(true);
        GenerateLevel();
        GenerateOutline();
        GameField.transform.position = new Vector3(0, 0, 0);
        //ReGenLevel();
        GenerateObstacle(obstacles);
        gameStatus = GameState.Playing;
        if(miniGameLevelNumber > 0)
        {
            GameField.transform.position = new Vector3(4, 0, 0);
            var heroRecuesData = new HeroRecuesData
            {
                scale = new Vector3(1, 1, 1),
                pos = new Vector3(-4.4f, 0, 0),
                level = miniGameLevelNumber
            };
            GameManagerHeroRecues gameManagerHeroRecues = Instantiate(gameManagerHeroRecuesPrefab, GameField.parent);
            gameManagerHeroRecues.StartGame(heroRecuesData.scale, heroRecuesData.pos, miniGameLevelNumber, miniGameLevelTarget);
        }
        
        for (int row = maxRows-1; row >= 0; row--)
        {
            for (int col = 0; col < maxCols; col++)
            {
                var square = squaresArray[row * maxCols + col];
                if (square == null || square.item == null) continue;
                LevelManager.Instance.CheckFalling(square.item);
            }
        }
        foreach (var square in squareCanGenItem)
        {
            square.GenItem();
        }
        OnLevelLoaded();

    }

    //public void CheckCollectedTarget(GameObject _item)
    //{
    //    _item.GetComponent<Item>();
    //    void AnimateCollectedItem(Vector2 pos)
    //    {
    //        GameObject item = new GameObject();
    //        item.transform.position = _item.transform.position;
    //        item.transform.localScale = Vector3.one / 2f;
    //        SpriteRenderer spr = item.AddComponent<SpriteRenderer>();
    //        var spriteRenderer = _item.GetComponentInChildren<SpriteRenderer>();
    //        spr.sprite = spriteRenderer.sprite;
    //        spr.sortingLayerName = "UI";
    //        spr.sortingOrder = 1;

    //        StartCoroutine(StartAnimateIngredient(item, pos));
    //    }

    //    foreach (var objectTarget in targetObject)
    //    {
    //        if(!objectTarget.Done())
    //        {
    //            if(objectTarget.SetOff(_item))     
    //                AnimateCollectedItem(objectTarget.guiObj.transform.position);
    //        }
    //    }
    //}

    public GameObject GetExplFromPool()
    {
        for (int i = 0; i < itemExplPool.Length; i++)
        {
            if (!itemExplPool[i].GetComponent<SpriteRenderer>().enabled)
            {
                itemExplPool[i].GetComponent<SpriteRenderer>().enabled = true;
                StartCoroutine(HideDelayed(itemExplPool[i]));
                return itemExplPool[i];
            }

        }
        return null;
    }

    IEnumerator HideDelayed(GameObject gm)
    {
        yield return new WaitForSeconds(1f);
        gm.GetComponent<Animator>().SetTrigger("stop");
        gm.GetComponent<Animator>().SetInteger("color", 10);
        gm.GetComponent<SpriteRenderer>().enabled = false;
    }
    public void CheckWinLose()
    {
        if(targetController.movesUI.GetCount() > 0)
        {
            if (GameManagerHeroRecues.instance != null && GameManagerHeroRecues.instance.isGameWin)
            {
                if (targetController.IsDone())
                {
                    WinGame();
                }
            }else if(GameManagerHeroRecues.instance != null && GameManagerHeroRecues.instance.isGameOver)
            {
                GameOver();
            }
        }
        else
        {
            if (GameManagerHeroRecues.instance != null)
            {
                if (targetController.IsDone() && GameManagerHeroRecues.instance.isGameWin)
                {
                    WinGame();
                }
                else
                {
                    GameOver();
                }
            }
            else
            {
                if (targetController.IsDone())
                {
                    WinGame();
                }
                else
                {
                    GameOver();
                }
            }
        }
        
    }
    
    IEnumerator PreWinAnimationsCor()
    {
        //GameObject.Find("Canvas").transform.Find("CompleteLabel").gameObject.SetActive(true);
        yield return new WaitForSeconds(1);

        //Todo : lam sau
        //List<Item> items = GetRandomItems(Mathf.Clamp(limitType == LIMIT.MOVES ? Limit : 8, 0, 15)); //2.2.2
        //foreach (Item item in items)
        //{
        //    if (limitType == LIMIT.MOVES)
        //        Limit--;
        //    item.NextType = (ItemsTypes)UnityEngine.Random.Range(1, 3);
        //    item.ChangeType();
        //    yield return new WaitForSeconds(0.5f);
        //}
        //yield return new WaitForSeconds(0.3f);
        //while (GetAllExtaItems().Count > 0 && gameStatus != GameState.Win)
        //{ //1.6
        //    Item item = GetAllExtaItems()[0];
        //    item.DestroyItem();
        //    dragBlocked = true;
        //    yield return new WaitForSeconds(0.1f);
        //    FindMatches();
        //    yield return new WaitForSeconds(1f);
        //    while (dragBlocked)
        //        yield return new WaitForFixedUpdate();
        //}
        yield return new WaitForSeconds(1f);
        //while (dragBlocked || GetMatches().Count > 0)
        //    yield return new WaitForSeconds(0.2f);

        GameObject.Find("Canvas").transform.Find("CompleteLabel").gameObject.SetActive(false);
        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.complete[0]);

        GameObject.Find("Canvas").transform.Find("PreCompleteBanner").gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        GameObject.Find("Canvas").transform.Find("PreCompleteBanner").gameObject.SetActive(false);
        WinGame();
    }
    //public Item FindItemBomb()
    //{
    //    Dictionary<int, List<Item>> countColor = new Dictionary<int, List<Item>>();
    //    foreach(var squares in squaresArray)
    //    {
    //        if (squares.item == null) continue;
    //        if (squares.item.currentType != ItemsTypes.NONE) continue;

    //        if (countColor.ContainsKey(squares.item.color)) countColor[squares.item.color].Add(squares.item);
    //        else countColor[squares.item.color] = new List<Item> { squares.item };
    //    }

    //    List<Item> listMax = new List<Item>();
    //    foreach(var list in countColor)
    //    {
    //        if (listMax.Count < list.Value.Count) listMax = list.Value;
    //    }
    //    if (listMax.Count == 0) return null;
    //    return listMax[0];
    //}
    void Update()
    {
        //  AvctivatedBoostView = ActivatedBoost;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NoMatches();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            PreWin();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Limit = 1;
        }

        //if (Input.GetKeyDown(KeyCode.F2))
        //{   //save items state
        //    print("Saving items...");
        //    int[] items = new int[99];

        //    for (int row = 0; row < maxRows; row++)
        //    {
        //        for (int col = 0; col < maxCols; col++)
        //        {
        //            if (GetSquare(col, row, false) != null)
        //            {
        //                if (GetSquare(col, row, false).item != null)
        //                    items[row * maxCols + col] = GetSquare(col, row, false).item.color;
        //            }
        //            else
        //                items[row * maxCols + col] = -1;

        //        }
        //    }
        //    LevelDebugger.SaveMap(items, maxCols, maxRows);
        //}

        //if (Input.GetKeyDown(KeyCode.F3))
        //{   //load items state
        //    print("load items...");

        //    int[] items = new int[99];
        //    items = LevelDebugger.LoadMap(maxCols, maxRows);
        //    for (int row = 0; row < maxRows; row++)
        //    {
        //        for (int col = 0; col < maxCols; col++)
        //        {
        //            if (items[row * maxCols + col] > -1)
        //            {
        //                if (GetSquare(col, row).item != null)
        //                    GetSquare(col, row).item.SetColor(items[row * maxCols + col]);
        //            }
        //        }
        //    }
        //}

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (LevelManager.Instance.gameStatus == GameState.Playing)
                GameObject.Find("CanvasGlobal").transform.Find("MenuPause").gameObject.SetActive(true);
            else if (LevelManager.Instance.gameStatus == GameState.Map)
                Application.Quit();

        }


        if (LevelManager.Instance.gameStatus == GameState.Playing)
        {
            if (bombDestroys.Count > 0) return;
            if (Input.GetMouseButtonDown(0))
            {
                OnStartPlay();
                if (bootersController.currentBootersUse != null) return;
                Collider2D hit = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                if (hit != null)
                {
                    Item item = hit.gameObject.GetComponent<Item>();
                    if (item != null && LevelManager.Instance.gameStatus == GameState.Playing)
                    {
                        if (item.itemStatus == ItemStatus.Idle)
                        {
                            item.mousePos = item.GetMousePosition();
                            item.deltaPos = Vector3.zero;
                            item.dragThis = true;
                        }
                    }
                }

            }
            else if (Input.GetMouseButtonUp(0))
            {
                Collider2D[] hits = Physics2D.OverlapPointAll(Camera.main.ScreenToWorldPoint(Input.mousePosition));
                Square square = null;
                Item item = null;
                foreach (var hit in hits)
                {
                    if (bootersController.currentBootersUse != null)
                    {
                        if (square == null) square = hit.gameObject.GetComponent<Square>();
                        if (square != null) break;
                    }
                    else
                    {
                        item = hit.gameObject.GetComponent<Item>();
                        if (item != null) break;
                    }
                }
                if(square != null && bootersController.currentBootersUse != null)
                {
                    bootersController.UseBooter(square);
                }
                else if(item != null && bootersController.currentBootersUse == null)
                {
                    item.dragThis = false;
                    item.switchDirection = Vector3.zero;
                    item.Click();
                }
            }
        }
    }
    public TargetUI FindTaget(Item item)
    {
        return targetController.GetTargetUI(item);
    }
    
    public void DestroyItem(Item item, TargetUI targetUI, bool isMoveToTarget)
    {
        try
        {
            item.DestroyObj(targetUI, isMoveToTarget);
        }
        catch (Exception e)
        {
            Debug.LogError(e.StackTrace);
        }
    }
    public void SquareSetItem(Square square, Item item)
    {
        lock (objLock)
        {
            square.SetItem(item);
        }
    }
    public void DelayedCall(float time,Action action)
    {
        DOVirtual.DelayedCall(time, () => action?.Invoke());
    }
    public void DestroyPackage(Square square, int range)
    {
        lock (objLock)
        {
            Debug.Log($"DestroyPackage square col {square.col} row {square.row} range = {range}");
            var squares = LevelManager.Instance.GetSquaresInRange(square.col, square.row, range);
            var sqList = LevelManager.Instance.GetPackageSquaresObstacles(square.col, square.row, range);
            LevelManager.Instance.CheckObstacles(sqList, ChangeStateTypes.PowerUp);
            foreach (var s in squares)
            {
                s?.AttackItem();
            }
        }

    }
    //public void DestroyBomb(Square square)
    //{
    //}
    //public void DestroyVertical(int col, int row)
    //{
    //    SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.strippedExplosion);
    //    LevelManager.Instance.StrippedShow(gameObject, false);
    //    List<Item> itemsList = LevelManager.Instance.GetColumn(col);
    //    List<Square> sqList = LevelManager.Instance.GetColumnSquaresObstacles(col);
    //    LevelManager.Instance.CheckObstacles(sqList, ChangeStateTypes.PowerUp);
    //    LevelManager.Instance.CheckItemSpecial(itemsList, ChangeStateTypes.PowerUp);
    //    foreach (Item item in itemsList)
    //    {
    //        if (item != null)
    //        {
    //            item.DestroyNew();
    //        }
    //    }
    //    //foreach (Square item in sqList)
    //    //{
    //    //    if (item != null)
    //    //        item.DestroyBlock();
    //    //}

    //    //LevelHeroRescues._instance.MatchItems(itemsList);
    //}
    
    //public void DestroyHorizontal(int col, int row)
    //{
    //    lock (objLock)
    //    {
    //        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.strippedExplosion);
    //        LevelManager.Instance.StrippedShow(gameObject, true);
    //        List<Item> itemsList = LevelManager.Instance.GetRow(row);
    //        List<Square> sqList = LevelManager.Instance.GetRowSquaresObstacles(row);

    //        LevelManager.Instance.CheckObstacles(sqList, ChangeStateTypes.PowerUp);
    //        LevelManager.Instance.CheckItemSpecial(itemsList, ChangeStateTypes.PowerUp);
    //        foreach (Item item in itemsList)
    //        {
    //            if (item != null)
    //            {
    //                item.DestroyNew();

    //            }
    //        }
    //        //foreach (Square item in sqList)
    //        //{
    //        //    if (item != null)
    //        //        item.DestroyBlock();
    //        //}

    //        //LevelHeroRescues._instance.MatchItems(itemsList);
    //    }

    //}
    IEnumerator TimeTick()
    {
        while (true)
        {
            if (gameStatus == GameState.Playing)
            {
                if (LevelManager.Instance.limitType == LIMIT.TIME)
                {
                    LevelManager.Instance.Limit--;
                    //Todo : lam sau
                    //if (IsAllItemsFallDown())
                    //    CheckWinLose();
                }
            }
            if (gameStatus == GameState.Map)
                yield break;
            yield return new WaitForSeconds(1);
        }
    }

    private void GenerateLevel()
    {
        bool chessColor = false;
        //Vector3 fieldPos = new Vector3(-maxCols / 2.75f, maxRows / 2.75f, -10);
        for (int row = 0; row < maxRows; row++)
        {
            if (maxCols % 2 == 0)
                chessColor = !chessColor;
            for (int col = 0; col < maxCols; col++)
            {
                CreateSquare(col, row, chessColor);
                chessColor = !chessColor;
            }

        }
        //AnimateField(Vector3.zero);
        //LevelManager.Instance.gameStatus = GameState.Playing;
    }

    void AnimateField(Vector3 pos)
    {

        float yOffset = 0;
        //if (target == Target.INGREDIENT)
        //    yOffset = 0.3f;
        //Animation anim = GameField.GetComponent<Animation>();
        //AnimationClip clip = new AnimationClip();
        //AnimationCurve curveX = new AnimationCurve(new Keyframe(0, pos.x + 15), new Keyframe(0.7f, pos.x - 0.2f), new Keyframe(0.8f, pos.x));
        //AnimationCurve curveY = new AnimationCurve(new Keyframe(0, pos.y + yOffset), new Keyframe(1, pos.y + yOffset));
        //clip.legacy = true;//2.1.6
        //clip.SetCurve("", typeof(Transform), "localPosition.x", curveX);
        //clip.SetCurve("", typeof(Transform), "localPosition.y", curveY);
        //clip.AddEvent(new AnimationEvent() { time = 1, functionName = "EndAnimGamField" });
        //anim.AddClip(clip, "appear");
        //anim.Play("appear");
        //GameField.transform.position = new Vector2(pos.x + 15, pos.y + yOffset);
        GameField.transform.position = new Vector2(pos.x, pos.y + yOffset);

    }

    void CreateSquare(int col, int row, bool chessColor = false)
    {
        var squareConfig = levelSquaresFile[row * maxCols + col];
        var square = Instantiate(squarePrefab, firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight), Quaternion.identity);
        if (chessColor)
        {
            square.GetComponent<SpriteRenderer>().sprite = squareSprite1;
        }
        square.transform.SetParent(GameField);
        square.transform.localPosition = firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight);
        squaresArray[row * maxCols + col] = square;
        square.row = row;
        square.col = col;
        square.type = SquareTypes.EMPTY;
        square.GenItems = squareConfig.GenItems;
        if(square.GenItems !=null && square.GenItems.Count > 0)
        {
            squareCanGenItem.Add(square);
        }
        if (squareConfig.squareType == SquareTypes.EMPTY)
        {
            if (squareConfig.itemsType != ItemsTypes.NONE)
            {
                var itemNew = GetItemByType(squareConfig.itemsType);
                if (itemNew == null) return;
                var _item = Instantiate(itemNew, square.transform.parent);
                _item.square = square;
                _item.transform.localScale = Vector3.one * 0.6f;
                _item.Init(square.transform.position);
                square.item = _item;
            }
        }
        else if (squareConfig.squareType == SquareTypes.NONE)
        {
            square.GetComponent<SpriteRenderer>().enabled = false;
            square.type = SquareTypes.NONE;
        }
    }

    void GenerateOutline()
    {
        int row = 0;
        int col = 0;
        for (row = 0; row < maxRows; row++)
        { //down
            SetOutline(col, row, 0);
        }
        row = maxRows - 1;
        for (col = 0; col < maxCols; col++)
        { //right
            SetOutline(col, row, 90);
        }
        col = maxCols - 1;
        for (row = maxRows - 1; row >= 0; row--)
        { //up
            SetOutline(col, row, 180);
        }
        row = 0;
        for (col = maxCols - 1; col >= 0; col--)
        { //left
            SetOutline(col, row, 270);
        }
        col = 0;
        for (row = 1; row < maxRows - 1; row++)
        {
            for (col = 1; col < maxCols - 1; col++)
            {
                SetOutline(col, row, 0);
            }
        }
    }


    void SetOutline(int col, int row, float zRot)
    {
        Square square = GetSquare(col, row, true);
        if (square.type != SquareTypes.NONE)
        {
            if (row == 0 || col == 0 || col == maxCols - 1 || row == maxRows - 1)
            {
                GameObject outline = CreateOutline(square);
                SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                outline.transform.localRotation = Quaternion.Euler(0, 0, zRot);
                if (zRot == 0)
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.425f;
                if (zRot == 90)
                    outline.transform.localPosition = Vector3.zero + Vector3.down * 0.425f;
                if (zRot == 180)
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.425f;
                if (zRot == 270)
                    outline.transform.localPosition = Vector3.zero + Vector3.up * 0.425f;
                if (row == 0 && col == 0)
                {   //top left
                    spr.sprite = outline3;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 180);
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.015f + Vector3.up * 0.015f;
                }
                if (row == 0 && col == maxCols - 1)
                {   //top right
                    spr.sprite = outline3;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 90);
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.015f + Vector3.up * 0.015f;
                }
                if (row == maxRows - 1 && col == 0)
                {   //bottom left
                    spr.sprite = outline3;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, -90);
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.015f + Vector3.down * 0.015f;
                }
                if (row == maxRows - 1 && col == maxCols - 1)
                {   //bottom right
                    spr.sprite = outline3;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.015f + Vector3.down * 0.015f;
                }
            }
            else
            {
                //top left
                if (GetSquare(col - 1, row - 1, true).type == SquareTypes.NONE && GetSquare(col, row - 1, true).type == SquareTypes.NONE && GetSquare(col - 1, row, true).type == SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    spr.sprite = outline3;
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.015f + Vector3.up * 0.015f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 180);
                }
                //top right
                if (GetSquare(col + 1, row - 1, true).type == SquareTypes.NONE && GetSquare(col, row - 1, true).type == SquareTypes.NONE && GetSquare(col + 1, row, true).type == SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    spr.sprite = outline3;
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.015f + Vector3.up * 0.015f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 90);
                }
                //bottom left
                if (GetSquare(col - 1, row + 1, true).type == SquareTypes.NONE && GetSquare(col, row + 1, true).type == SquareTypes.NONE && GetSquare(col - 1, row, true).type == SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    spr.sprite = outline3;
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.015f + Vector3.down * 0.015f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 270);
                }
                //bottom right
                if (GetSquare(col + 1, row + 1, true).type == SquareTypes.NONE && GetSquare(col, row + 1, true).type == SquareTypes.NONE && GetSquare(col + 1, row, true).type == SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    spr.sprite = outline3;
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.015f + Vector3.down * 0.015f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }


            }
        }
        else
        {
            bool corner = false;
            if (GetSquare(col - 1, row, true).type != SquareTypes.NONE && GetSquare(col, row - 1, true).type != SquareTypes.NONE)
            {
                GameObject outline = CreateOutline(square);
                SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                spr.sprite = outline2;
                outline.transform.localPosition = Vector3.zero;
                outline.transform.localRotation = Quaternion.Euler(0, 0, 0);
                corner = true;
            }
            if (GetSquare(col + 1, row, true).type != SquareTypes.NONE && GetSquare(col, row + 1, true).type != SquareTypes.NONE)
            {
                GameObject outline = CreateOutline(square);
                SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                spr.sprite = outline2;
                outline.transform.localPosition = Vector3.zero;
                outline.transform.localRotation = Quaternion.Euler(0, 0, 180);
                corner = true;
            }
            if (GetSquare(col + 1, row, true).type != SquareTypes.NONE && GetSquare(col, row - 1, true).type != SquareTypes.NONE)
            {
                GameObject outline = CreateOutline(square);
                SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                spr.sprite = outline2;
                outline.transform.localPosition = Vector3.zero;
                outline.transform.localRotation = Quaternion.Euler(0, 0, 270);
                corner = true;
            }
            if (GetSquare(col - 1, row, true).type != SquareTypes.NONE && GetSquare(col, row + 1, true).type != SquareTypes.NONE)
            {
                GameObject outline = CreateOutline(square);
                SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                spr.sprite = outline2;
                outline.transform.localPosition = Vector3.zero;
                outline.transform.localRotation = Quaternion.Euler(0, 0, 90);
                corner = true;
            }


            if (!corner)
            {
                if (GetSquare(col, row - 1, true).type != SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    outline.transform.localPosition = Vector3.zero + Vector3.up * 0.395f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 90);
                }
                if (GetSquare(col, row + 1, true).type != SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    outline.transform.localPosition = Vector3.zero + Vector3.down * 0.395f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 90);
                }
                if (GetSquare(col - 1, row, true).type != SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    outline.transform.localPosition = Vector3.zero + Vector3.left * 0.395f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
                if (GetSquare(col + 1, row, true).type != SquareTypes.NONE)
                {
                    GameObject outline = CreateOutline(square);
                    SpriteRenderer spr = outline.GetComponent<SpriteRenderer>();
                    outline.transform.localPosition = Vector3.zero + Vector3.right * 0.395f;
                    outline.transform.localRotation = Quaternion.Euler(0, 0, 0);
                }
            }
        }
    }

    GameObject CreateOutline(Square square)
    {
        GameObject outline = new GameObject();
        outline.name = "outline";
        outline.transform.SetParent(square.transform);
        outline.transform.localPosition = Vector3.zero;
        outline.transform.localScale = Vector3.one;
        SpriteRenderer spr = outline.AddComponent<SpriteRenderer>();
        spr.sprite = outline1;
        spr.sortingOrder = 1;
        return outline;
    }

    //void CreateObstacles(int col, int row, GameObject square, SquareTypes type)
    //{
    //    if ((levelSquaresFile[row * maxCols + col].obstacle == SquareTypes.WIREBLOCK && type == SquareTypes.NONE) || type == SquareTypes.WIREBLOCK)
    //    {
    //        GameObject block = Instantiate(wireBlockPrefab, firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight), Quaternion.identity) as GameObject;
    //        block.transform.SetParent(square.transform);
    //        block.transform.localPosition = new Vector3(0, 0, -0.5f);
    //        square.GetComponent<Square>().block.Add(block);
    //        square.GetComponent<Square>().type = SquareTypes.WIREBLOCK;
    //        block.GetComponent<SpriteRenderer>().sortingOrder = 3;
    //    }
    //    else if ((levelSquaresFile[row * maxCols + col].obstacle == SquareTypes.SOLIDBLOCK && type == SquareTypes.NONE) || type == SquareTypes.SOLIDBLOCK)
    //    {
    //        GameObject block = Instantiate(solidBlockPrefab, firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight), Quaternion.identity) as GameObject;
    //        block.transform.SetParent(square.transform);
    //        block.transform.localPosition = new Vector3(0, 0, -0.5f);
    //        square.GetComponent<Square>().block.Add(block);
    //        block.GetComponent<SpriteRenderer>().sortingOrder = 3;
    //        square.GetComponent<Square>().type = SquareTypes.SOLIDBLOCK;
    //    }
    //    else if ((levelSquaresFile[row * maxCols + col].obstacle == SquareTypes.UNDESTROYABLE && type == SquareTypes.NONE) || type == SquareTypes.UNDESTROYABLE)
    //    {
    //        GameObject block = Instantiate(undesroyableBlockPrefab, firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight), Quaternion.identity) as GameObject;
    //        block.transform.SetParent(square.transform);
    //        block.transform.localPosition = new Vector3(0, 0, -0.5f);
    //        square.GetComponent<Square>().block.Add(block);
    //        square.GetComponent<Square>().type = SquareTypes.UNDESTROYABLE;
    //    }
    //    else if ((levelSquaresFile[row * maxCols + col].obstacle == SquareTypes.THRIVING && type == SquareTypes.NONE) || type == SquareTypes.THRIVING)
    //    {
    //        GameObject block = Instantiate(thrivingBlockPrefab, firstSquarePosition + new Vector2(col * squareWidth, -row * squareHeight), Quaternion.identity) as GameObject;
    //        block.transform.SetParent(square.transform);
    //        block.transform.localPosition = new Vector3(0, 0, -0.5f);
    //        block.GetComponent<SpriteRenderer>().sortingOrder = 3;
    //        if (square.GetComponent<Square>().item != null)
    //            Destroy(square.GetComponent<Square>().item.gameObject);
    //        square.GetComponent<Square>().block.Add(block);
    //        square.GetComponent<Square>().type = SquareTypes.THRIVING;
    //    }

    //}

    //void GenerateNewItems(bool falling = true)
    //{
    //    for (int col = 0; col < maxCols; col++)
    //    {
    //        for (int row = maxRows - 1; row >= 0; row--)
    //        {
    //            var square = GetSquare(col, row);
    //            if (square != null)
    //            {
    //                if (!square.IsNone() && square.CanGoInto() && square.item == null)
    //                {
    //                    if ((square.item == null && !square.IsHaveSolidAbove()) || !falling)
    //                    {
    //                        square.GenItem(falling);
    //                    }
    //                }
    //            }
    //        }
    //    }

    //}

    public void NoMatches()
    {
        StartCoroutine(NoMatchesCor());
    }

    IEnumerator NoMatchesCor()
    {
        if (gameStatus == GameState.Playing)
        {
            SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.noMatch);

            GameObject.Find("Canvas").transform.Find("NoMoreMatches").gameObject.SetActive(true);
            gameStatus = GameState.RegenLevel;
            yield return new WaitForSeconds(1);
            //Todo : làm sau 
            //ReGenLevel();
        }
    }
    public Square GetSquareCanGenItem(int col)
    {
        var square = squareCanGenItem.FirstOrDefault(s => s.col == col);
        return square;
    }
    public void ReGenLevelNew()
    {
        //List<ObstacleMapConfig> obstacles = new List<ObstacleMapConfig>();
        ////for(int i = 0; i < maxCols; i++)
        ////{
        ////    obstacles.Add(new ObstacleMapConfig { colum = i, row = 5, obstacleType = ObstacleTypes.Soil });
        ////}
        //obstacles.Add(new ObstacleMapConfig { colum = 4, row = 0, obstacleType = ObstacleTypes.Pot });
        //obstacles.Add(new ObstacleMapConfig { colum = 0, row = 0, obstacleType = ObstacleTypes.Cupboard });
        //GenerateObstacle(obstacles);
        //var squareGenItem = SetSquareGenItem();
        //squareCanGenItem = squareGenItem;
        //foreach (var square in squareGenItem)
        //{
        //    square.GenItem();
        //}
        //StartCoroutine(GenItemWithColumn(0));
        //for (int col = 0; col < maxCols; col++)
        //{
        //    CheckGenItem(col);
        //}
        //CheckGenItem(0);
        return;
        var items = LevelManager.Instance.GetSquares().Where(i => i != null).Where(i => i != null);
        float topY = items.Max(i => i.transform.position.y);
        float bottomY = items.Min(i => i.transform.position.y);
        float leftX = items.Min(i => i.transform.position.x);
        float rightX = items.Max(i => i.transform.position.x);

        float fieldHeight = topY - bottomY;
        float fielgWidth = rightX - leftX;
        Rect fieldRect = new Rect(leftX, topY, fielgWidth, fieldHeight);
        //float fraq = (fielgWidth > fieldHeight ? fielgWidth : fieldHeight);
        int width = Screen.width;
        int height = Screen.height;

        //var h = fieldRect.width * height / width / 2 + 1.5f;
        //var w = (fieldRect.height + 2.5f * 2) / 2 + 2f;

        var h = fieldRect.width * height / width / 2 + 1.5f;
        var w = (fieldRect.height + 2.5f * 2) / 2 + 2f;

        var maxLength = Mathf.Max(h, w);

        Camera.main.orthographicSize = Mathf.Clamp(maxLength, 4, maxLength);
    }
    public void GetItemFallOrGenItem(Square square)
    {
        lock (objLock)
        {
            if(square.item == null)
            {
                square.GetItemFallOrGenItem();
            }
            else
            {
                if(square.item.itemStatus == ItemStatus.Destroyed)
                {
                    square.SetItem(null);
                    square.GetItemFallOrGenItem();
                }
                else
                {
                    CheckFalling(square.item);
                }
            }
        }
    }
    public void SwitchItemAction(ActionItem item1, ActionItem item2)
    {
        lock (objLock)
        {
            var target1 = FindTaget(item1);
            var target2 = FindTaget(item2);
            if (item1 is BombItem && item2 is BombItem)
            {
                StartCoroutine(BombAndBomb((BombItem)item1, (BombItem)item2, target1, target2));
            }
            else if (item1 is BombItem || item2 is BombItem)
            {
                if (item1 is BombItem)
                {
                    BombItemAndOther((BombItem)item1, item2, target1);
                }
                else
                {
                    BombItemAndOther((BombItem)item2, item1, target2);
                }
            }
            else if (item1 is PackageItem && item2 is PackageItem)
            {
                item1.itemStatus = ItemStatus.Destroying;
                item2.itemStatus = ItemStatus.Destroying;

                PackageAndPackage(item1.square, item2.square, 3);
            }
            else if (item1 is HorizontalItem && item2 is HorizontalItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                item1.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                item2.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                DestroyItem(item1, target1, false);
                DestroyItem(item2, target2,false);
                var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square1.transform.parent);
                horizontalDestroy.Init(square1.transform.position, square1);
                var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square2.transform.parent);
                verticalDestroy.Init(square2.transform.position, square2);
            }
            else if (item1 is VerticalItem && item2 is VerticalItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                item1.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                item2.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                
                DestroyItem(item1, target1, false);
                DestroyItem(item2, target1, false);
                var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square1.transform.parent);
                verticalDestroy.Init(square1.transform.position, square1);
                var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square2.transform.parent);
                horizontalDestroy.Init(square2.transform.position, square2);
            }
            else if (item1 is PropellerItem && item2 is PropellerItem)
            {
                //create new 3 PropellerDestroy 
                var square1 = item1.square;
                var square2 = item2.square;
                item1.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                item2.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                var item3 = GameObject.Instantiate(item1, item1.transform.position, Quaternion.identity, item1.transform.parent);
                item3.transform.localScale = Vector3.zero;
                item3.transform.DOScale(Vector3.one * 0.6f, 0.5f);
                (item1 as PropellerItem).UsePropeller();
                (item2 as PropellerItem).UsePropeller();
                (item3 as PropellerItem).UsePropeller();
                GetItemFallOrGenItem(square1);
                GetItemFallOrGenItem(square2);
            }
            else if (item1 is PropellerItem || item2 is PropellerItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                item1.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                item2.SetItemStatus(ItemStatus.Destroyed, "SwitchItemAction");
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                GetItemFallOrGenItem(square1);
                GetItemFallOrGenItem(square2);
                var target = GetSquareTarget();
                if (item1 is PropellerItem)
                {
                    item2.transform.DOMove(target.transform.position, 1f).SetEase(Ease.Linear).OnComplete(() => {
                        item2.UsedAtSquare(target);
                        Destroy(item2.gameObject);
                    });
                    item1.transform.DOMove(target.transform.position, 1f).SetEase(Ease.Linear).OnComplete(() => {
                        Destroy(item1.gameObject);
                    });
                }
                else
                {
                    item2.transform.DOMove(target.transform.position, 1f).SetEase(Ease.Linear).OnComplete(() => {
                        Destroy(item2.gameObject);
                    });
                    item1.transform.DOMove(target.transform.position, 1f).SetEase(Ease.Linear).OnComplete(() => {
                        item1.UsedAtSquare(target);
                        Destroy(item1.gameObject);
                    });
                }
            }
            else if (item1 is PackageItem || item2 is PackageItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);

                DestroyItem(item1, target1, false);
                DestroyItem(item2, target2,false);
                if (item1 is PackageItem)
                {
                    for (int r = square1.row - 1; r <= square1.row + 1; r++)
                    {
                        var square = GetSquare(square1.col, r);
                        if (square != null)
                        {
                            var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square.transform.parent);
                            horizontalDestroy.Init(square.transform.position, square);
                        }
                    }
                    for (int c = square1.col - 1; c <= square1.col + 1; c++)
                    {
                        var square = GetSquare(c, square1.row);
                        if (square != null)
                        {
                            var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square.transform.parent);
                            verticalDestroy.Init(square.transform.position, square);
                        }
                    }
                }
                else
                {
                    for (int r = square2.row - 1; r <= square2.row + 1; r++)
                    {
                        var square = GetSquare(square2.col, r);
                        if (square != null)
                        {
                            var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square.transform.parent);
                            horizontalDestroy.Init(square.transform.position, square);
                        }
                    }
                    for (int c = square2.col - 1; c <= square2.col + 1; c++)
                    {
                        var square = GetSquare(c, square2.row);
                        if (square != null)
                        {
                            var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square.transform.parent);
                            verticalDestroy.Init(square.transform.position, square);
                        }
                    }
                }
            }
            else if (item1 is VerticalItem || item2 is VerticalItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                DestroyItem(item1, target1, false);
                DestroyItem(item2, target2, false);
                if (item1 is VerticalItem)
                {
                    var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square1.transform.parent);
                    horizontalDestroy.Init(square1.transform.position, square1);
                    var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square1.transform.parent);
                    verticalDestroy.Init(square1.transform.position, square1);
                }
                else
                {
                    var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square2.transform.parent);
                    horizontalDestroy.Init(square2.transform.position, square2);
                    var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square2.transform.parent);
                    verticalDestroy.Init(square2.transform.position, square2);
                }
            }
            else if (item1 is HorizontalItem || item2 is HorizontalItem)
            {
                var square1 = item1.square;
                var square2 = item2.square;
                SquareSetItem(square1, null);
                SquareSetItem(square2, null);
                DestroyItem(item1, target1, false);
                DestroyItem(item2, target2, false);
                if (item1 is HorizontalItem)
                {
                    var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square1.transform.parent);
                    horizontalDestroy.Init(square1.transform.position, square1);
                    var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square1.transform.parent);
                    verticalDestroy.Init(square1.transform.position, square1);
                }
                else
                {
                    var horizontalDestroy = GameObject.Instantiate(LevelManager.Instance.horizontalDestroyPrefab, square2.transform.parent);
                    horizontalDestroy.Init(square2.transform.position, square2);
                    var verticalDestroy = GameObject.Instantiate(LevelManager.Instance.verticalDestroyPrefab, square2.transform.parent);
                    verticalDestroy.Init(square2.transform.position, square2);
                }
            }
        }
    }
    public void UsePackageAtSquare(Square square)
    {
        LevelManager.Instance.DestroyPackage(square, 2);
    }
    public Square GetSquareTarget()
    {
        var squares = LevelManager.Instance.GetSquares().Where(s => s.type != SquareTypes.NONE).ToList();
        int rd = UnityEngine.Random.Range(0, squares.Count);
        var target = squares[rd];
        return target;
    }
    private IEnumerator BombAndBomb(BombItem bomb1, BombItem bomb2, TargetUI target1, TargetUI target2)
    {
        var square1 = bomb1.square;
        bomb1.itemStatus = ItemStatus.Destroying;
        bomb2.itemStatus = ItemStatus.Destroying;
        DestroyItem(bomb1, target1, false);
        DestroyItem(bomb2, target2,false);
        //create effect 

        yield return new WaitForSeconds(2);

        for(int col = 0; col < maxCols; col++)
        {
            for (int row = 0; row < maxRows; row++)
            {
                var square = GetSquare(col, row);
                if (square == null) continue;
                if (square.item == null) continue;
                square.item.itemStatus = ItemStatus.Destroying;
            }
        }

        //start destroy all
        int rangeLeft = square1.col;
        int rangeRight = maxCols - square1.col;
        int rangeTop = square1.row;
        int rangeBottom = maxRows - square1.row;
        int maxRange = Math.Max(rangeLeft, rangeRight);
        maxRange = Math.Max(rangeTop, maxRange);
        maxRange = Math.Max(rangeBottom, maxRange);
        int count = 0;
        Dictionary<int, ObstacleBase> OobstacleBases = new Dictionary<int, ObstacleBase>();
        while (count<= maxRange)
        {
            //get squares left
            if(square1.col - count >= 0)
            {
                for (int row = square1.row - count; row <= square1.row + count; row++)
                {
                    if (row < 0) continue;
                    if (row >= maxRows) break;
                    var square = GetSquare(square1.col - count, row);
                    if (square == null) continue;
                    if (square.obstacle != null)
                    {
                        if (OobstacleBases.ContainsKey(square.obstacle.GetInstanceID())) continue;
                        square.obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
                        OobstacleBases.Add(square.obstacle.GetInstanceID(), square.obstacle);
                        continue;
                    }
                    if (square.item != null)
                    {
                        square.item.AttackItem();
                    }
                }
            }
            //get squares Right
            if (square1.col + count < maxCols)
            {
                for (int row = square1.row - count; row <= square1.row + count; row++)
                {
                    if (row < 0) continue;
                    if (row >= maxRows) break; 
                    var square = GetSquare(square1.col + count, row);
                    if (square == null) continue;
                    if (square.obstacle != null)
                    {
                        if (OobstacleBases.ContainsKey(square.obstacle.GetInstanceID())) continue;
                        square.obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
                        OobstacleBases.Add(square.obstacle.GetInstanceID(), square.obstacle);
                        continue;
                    }
                    if (square.item != null)
                    {
                        square.item.AttackItem();
                    }
                }
            }
            //get squares Top
            if (square1.row - count >= 0)
            {
                for (int col = square1.col - count; col <= square1.col + count; col++)
                {
                    if (col < 0) continue;
                    if (col >= maxCols) break;
                    var square = GetSquare(col, square1.row - count);
                    if (square == null) continue;
                    if (square.obstacle != null)
                    {
                        if (OobstacleBases.ContainsKey(square.obstacle.GetInstanceID())) continue;
                        square.obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
                        OobstacleBases.Add(square.obstacle.GetInstanceID(), square.obstacle);
                        continue;
                    }
                    if (square.item != null)
                    {
                        square.item.AttackItem();
                    }
                }
            }
            //get squares bottom
            if (square1.row + count < maxRows)
            {
                for (int col = square1.col - count; col <= square1.col + count; col++)
                {
                    if (col < 0) continue;
                    if (col >= maxCols) break;
                    var square = GetSquare(col, square1.row + count);
                    if (square == null) continue;
                    if (square.obstacle != null)
                    {
                        if (OobstacleBases.ContainsKey(square.obstacle.GetInstanceID())) continue;
                        square.obstacle.OnMatchesOrPowerUp(ChangeStateTypes.PowerUp);
                        OobstacleBases.Add(square.obstacle.GetInstanceID(), square.obstacle);
                        continue;
                    }
                    if (square.item != null)
                    {
                        square.item.AttackItem();
                    }
                }
            }
            count++;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void BombItemAndOther(BombItem bombItem, ActionItem other, TargetUI target1)
    {
        other.itemStatus = ItemStatus.Destroying;
        bombItem.SetItemNew(other);
        bombItem.Use();
        LevelManager.Instance.DestroyItem(bombItem, target1, false);
    }
    private void PackageAndPackage(Square package1, Square package2,int range)
    {
        LevelManager.Instance.DestroyPackage(package1, range);
        LevelManager.Instance.DestroyPackage(package2, range);
    }
    
    private object objLock = new object();
    public void CheckFalling(Item item)
    {
        lock (objLock)
        {
            if (item == null) return;
            if (item.itemStatus == ItemStatus.Destroyed) return;
            if (!item.square.CanGoOut()) return;
            if (item.itemStatus == ItemStatus.Destroying)
            {
                if (item.bombDestroy != null)
                {
                    item.bombDestroy.AddItemToSelectedItems(item);
                }
                return;
            }
            Debug.Log($"CheckFalling {item.name} item.square col = {item.square.col} row {item.square.row}");
            var _square = item.square;
            var squareNext = LevelManager.Instance.GetNextSquareCanGoInto(_square.col, _square.row);
            bool isFalling = false;
            if (squareNext != null)
            {
                SquareSetItem(squareNext, item);
                SquareSetItem(_square, null);
                isFalling = true;
            }
            else
            {
                var squareNeighborBottom = _square.GetNeighborBottom();
                if (squareNeighborBottom != null)
                {
                    var squareBottomLeft = squareNeighborBottom == null ? null : squareNeighborBottom.GetNeighborLeft();
                    var canMoveLeft = squareBottomLeft == null ? false : LevelManager.Instance.CheckCanGenItemByColumn(squareBottomLeft.col, squareBottomLeft.row);
                    if (squareBottomLeft != null && squareBottomLeft.CanGoInto() && squareBottomLeft.item == null && !canMoveLeft)
                    {
                        SquareSetItem(squareBottomLeft, item);
                        SquareSetItem(_square, null);
                        isFalling = true;
                    }
                    else
                    {
                        var squareBottomRight = squareNeighborBottom == null ? null : squareNeighborBottom.GetNeighborRight();
                        var canMoveRight = squareBottomRight == null ? false : LevelManager.Instance.CheckCanGenItemByColumn(squareBottomRight.col, squareBottomRight.row);
                        if (squareBottomRight != null && squareBottomRight.CanGoInto() && squareBottomRight.item == null && !canMoveRight)
                        {
                            SquareSetItem(squareBottomRight, item);
                            SquareSetItem(_square, null);
                            isFalling = true;
                        }
                    }
                }
            }
            if (isFalling)
            {
                item.SetItemStatus(ItemStatus.Moving, "CheckFalling");
                item.StartFalling();
                GetItemFallOrGenItem(_square);
            }
            else
            {
                item.EndFall();
                if(item.bombDestroy != null)
                {
                    item.itemStatus = ItemStatus.Destroying;
                    item.bombDestroy.AddItemToSelectedItems(item);
                }
                else
                {
                    DOVirtual.DelayedCall(0.2f, ()=> CheckMatches(item)) ;
                }
                
            }
            Debug.Log($"----------------->CheckFalling {item.name} item.square col = {item.square.col} row {item.square.row}");
        }
    }
    
    //public void CheckGenItem(int col)
    //{
    //    var square = GetSquare(col, 0);
    //    if (square == null) return;
    //    if (square.item != null) return;
    //    if (!square.CanGoInto()) return;
    //    int color = UnityEngine.Random.Range(1, 6);
    //    var itemNew = GetItemByType((ItemsTypes) color);
    //    if (itemNew == null) return;
    //    var item = Instantiate(itemNew, square.transform.parent);
    //    item.square = square;
    //    item.transform.localScale = Vector3.one * 0.6f;
    //    item.transform.position = square.transform.position + Vector3.back * 0.2f + Vector3.up * 9f;
    //    item.SetItemStatus(ItemStatus.Moving, "CheckGenItem");
    //    item.Init(item.transform.position);
    //    square.SetItem(item);
    //    item.StartFalling();
    //    if (!square.CanGoOut()) return;
    //}
    public bool CheckCanGenItemByColumn(int col, int row)
    {
        for(int r = row; r > -1; r--)
        {
            var square = GetSquare(col, r);
            if (square == null) return false;
            if (square.IsNone()) continue;
            if (!square.CanGoInto()) return false;
            if (!square.CanGoOut()) return false;
        }
        return true;
    }
    public Square GetNextSquareCanGoInto(int col, int row)
    {
        Square result = null;
        for (int r = row+1; r < maxRows; r++)
        {
            var square = GetSquare(col, r);
            if (square == null) return result;
            if (square.IsNone()) continue;
            if (!square.CanGoInto()) return result;
            if (square.item != null) return result;
            result = square;
            return result;
        }
        return result;
    }
    public bool CheckMatches(Square square)
    {
        if (square == null) return false;
        if (square.type == SquareTypes.NONE) return false;
        if (square.item == null) return false;
        if (square.item.itemStatus != ItemStatus.Idle) return false;
        return CheckMatches(square.item);
    }
    public bool CheckMatches(Item item)
    {
        lock (objLock)
        {
            if (item == null) return false;
            if (item.square == null) return false;
            if (item.itemStatus == ItemStatus.Moving || item.itemStatus == ItemStatus.Destroying) return false;
            if (item is ActionItem) return true;
            if (item is ItemChangeState) return false;
            if (!(item is ColorItem)) return false;

            ColorItem colorItem = (ColorItem)item;
            int color = colorItem.color;
            List<List<ColorItem>> matches = new List<List<ColorItem>>();
            List<int> horizontalChecked = new List<int>();
            List<int> verticalChecked = new List<int>();
            CheckMatchesHorizontal(colorItem, ref matches, ref horizontalChecked, ref verticalChecked);
            //if (stopCheck) return;
            int countMax = 1;
            List<ColorItem> matchCountMax;
            for (int i = matches.Count - 1; i > -1; i--)
            {
                if (matches[i].Count > countMax)
                {
                    matchCountMax = matches[i];
                    countMax = matches[i].Count;
                }
                if (matches[i].Count < 2) matches.RemoveAt(i);
            }
            if (matches.Count == 0) return false;
            if (countMax >= 5)
            {
                for (int i = matches.Count - 1; i > -1; i--)
                {
                    if (matches[i].Count < 3) matches.RemoveAt(i);
                }
                CheckDestroyMatches(matches, item,ItemsTypes.BOMB);
                return true;
            }
            else if (countMax == 4)
            {
                List<ColorItem> match4 = null;
                for (int i = matches.Count - 1; i > -1; i--)
                {
                    if (matches[i].Count == 4 && match4 == null) match4 = matches[i];
                    if (matches[i].Count < 3) matches.RemoveAt(i);
                }
                if(matches.Count > 1)
                {
                    CheckDestroyMatches(matches, item, ItemsTypes.PACKAGE);
                }
                else
                {
                    int col = match4[0].square.col;
                    bool isVertical = match4.All(x => x.square.col == col);
                    if (isVertical) CheckDestroyMatches(matches, item, ItemsTypes.HORIZONTAL_STRIPPED);//VERTICAL_STRIPPED
                    else CheckDestroyMatches(matches, item, ItemsTypes.VERTICAL_STRIPPED);//HORIZONTAL_STRIPPED
                }
                
                return true;
            }
            else if (countMax == 3 && matches.Count >= 4)
            {
                int countMatch3 = 0;
                for (int i = matches.Count - 1; i > -1; i--)
                {
                    if (matches[i].Count == 3) countMatch3 +=1;
                }
                if(countMatch3 > 1)
                {
                    for (int i = matches.Count - 1; i > -1; i--)
                    {
                        if (matches[i].Count < 3) matches.RemoveAt(i);
                    }
                    CheckDestroyMatches(matches, item, ItemsTypes.PACKAGE);
                    return true;
                }
                if (CheckPropller(matches, item, color))
                {
                    return true;
                }
                for (int i = matches.Count - 1; i > -1; i--)
                {
                    if (matches[i].Count < 3) matches.RemoveAt(i);
                }
                if (matches.Count > 0)
                {
                    CheckDestroyMatches(matches, item, ItemsTypes.NONE);
                }
                return true;
            }
            else if (countMax == 2 && matches.Count >= 4)
            {
                return CheckPropller(matches, item, color);
                //List<int> itemIds = new List<int>();
                //foreach(var match in matches)
                //{
                //    foreach(var _colorItem in match)
                //    {
                //        var id = _colorItem.GetInstanceID();
                //        if (itemIds.Contains(id)) continue;
                //        itemIds.Add(id);
                //    }
                //}
                ////check top right
                //Square squareTopRight = GetSquare(item.square.col + 1, item.square.row - 1);
                //if(squareTopRight != null && squareTopRight.obstacle == null && squareTopRight.item != null && squareTopRight.item is ColorItem && (squareTopRight.item as ColorItem).color == color)
                //{
                //    if (itemIds.Contains(squareTopRight.item.GetInstanceID()))
                //    {
                //        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                //        return true;
                //    }
                //}

                ////check top left
                //Square squareTopLeft = GetSquare(item.square.col - 1, item.square.row - 1);
                //if (squareTopLeft != null && squareTopLeft.obstacle == null && squareTopLeft.item != null && squareTopLeft.item is ColorItem && (squareTopLeft.item as ColorItem).color == color)
                //{
                //    if (itemIds.Contains(squareTopLeft.item.GetInstanceID()))
                //    {
                //        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                //        return true;
                //    }
                //}

                ////check bottom right
                //Square squareBottomRight = GetSquare(item.square.col + 1, item.square.row + 1);
                //if (squareBottomRight != null && squareBottomRight.obstacle == null && squareBottomRight.item != null && squareBottomRight.item is ColorItem && (squareBottomRight.item as ColorItem).color == color)
                //{
                //    if (itemIds.Contains(squareBottomRight.item.GetInstanceID()))
                //    {
                //        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                //        return true;
                //    }
                //}

                ////check bottom left
                //Square squareBottomLeft = GetSquare(item.square.col - 1, item.square.row + 1);
                //if (squareBottomLeft != null && squareBottomLeft.obstacle == null && squareBottomLeft.item != null && squareBottomLeft.item is ColorItem && (squareBottomLeft.item as ColorItem).color == color)
                //{
                //    if (itemIds.Contains(squareBottomLeft.item.GetInstanceID()))
                //    {
                //        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                //        return true;
                //    }
                //}
                //return false;
            }
            else if (countMax == 3)
            {
                for (int i = matches.Count - 1; i > -1; i--)
                {
                    if (matches[i].Count < 3) matches.RemoveAt(i);
                }
                if(matches.Count > 1)
                {
                    CheckDestroyMatches(matches, item, ItemsTypes.PACKAGE);
                }
                else if(matches.Count > 0)
                {
                    CheckDestroyMatches(matches, item, ItemsTypes.NONE);
                }
                return true;
            }
        }
        return false;
    }

    public bool CheckPropller(List<List<ColorItem>> matches, Item item, int color)
    {
        List<int> itemIds = new List<int>();
        foreach (var match in matches)
        {
            foreach (var _colorItem in match)
            {
                var id = _colorItem.GetInstanceID();
                if (itemIds.Contains(id)) continue;
                itemIds.Add(id);
            }
        }
        Square squareTop = GetSquare(item.square.col, item.square.row - 1);
        Square squareRight = GetSquare(item.square.col + 1, item.square.row);
        Square squareLeft = GetSquare(item.square.col - 1, item.square.row);
        Square squareBottom = GetSquare(item.square.col, item.square.row + 1);

        Square squareTopRight = GetSquare(item.square.col + 1, item.square.row - 1);

        if (squareTopRight != null && squareTopRight.obstacle == null && squareTopRight.item != null && squareTopRight.item is ColorItem && (squareTopRight.item as ColorItem).color == color)
        {
            if (squareRight != null && squareRight.obstacle == null && squareRight.item != null && squareRight.item is ColorItem && (squareRight.item as ColorItem).color == color)
            {
                if (squareTop != null && squareTop.obstacle == null && squareTop.item != null && squareTop.item is ColorItem && (squareTop.item as ColorItem).color == color)
                {
                    if (itemIds.Contains(squareTopRight.item.GetInstanceID()) && itemIds.Contains(squareRight.item.GetInstanceID()) && itemIds.Contains(squareTop.item.GetInstanceID()))
                    {
                        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                        return true;
                    }
                }
            }

        }

        //check top left
        Square squareTopLeft = GetSquare(item.square.col - 1, item.square.row - 1);

        if (squareTopLeft != null && squareTopLeft.obstacle == null && squareTopLeft.item != null && squareTopLeft.item is ColorItem && (squareTopLeft.item as ColorItem).color == color)
        {
            if (squareLeft != null && squareLeft.obstacle == null && squareLeft.item != null && squareLeft.item is ColorItem && (squareLeft.item as ColorItem).color == color)
            {
                if (squareTop != null && squareTop.obstacle == null && squareTop.item != null && squareTop.item is ColorItem && (squareTop.item as ColorItem).color == color)
                {
                    if (itemIds.Contains(squareTopLeft.item.GetInstanceID()) && itemIds.Contains(squareLeft.item.GetInstanceID()) && itemIds.Contains(squareTop.item.GetInstanceID()))
                    {
                        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                        return true;
                    }
                }
            }
        }

        //check bottom right
        Square squareBottomRight = GetSquare(item.square.col + 1, item.square.row + 1);
        if (squareBottomRight != null && squareBottomRight.obstacle == null && squareBottomRight.item != null && squareBottomRight.item is ColorItem && (squareBottomRight.item as ColorItem).color == color)
        {
            if (squareRight != null && squareRight.obstacle == null && squareRight.item != null && squareRight.item is ColorItem && (squareRight.item as ColorItem).color == color)
            {
                if (squareBottom != null && squareBottom.obstacle == null && squareBottom.item != null && squareBottom.item is ColorItem && (squareBottom.item as ColorItem).color == color)
                {
                    if (itemIds.Contains(squareBottomRight.item.GetInstanceID()) && itemIds.Contains(squareRight.item.GetInstanceID()) && itemIds.Contains(squareBottom.item.GetInstanceID()))
                    {
                        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                        return true;
                    }
                }
            }
        }

        //check bottom left
        Square squareBottomLeft = GetSquare(item.square.col - 1, item.square.row + 1);

        if (squareBottomLeft != null && squareBottomLeft.obstacle == null && squareBottomLeft.item != null && squareBottomLeft.item is ColorItem && (squareBottomLeft.item as ColorItem).color == color)
        {
            if (squareLeft != null && squareLeft.obstacle == null && squareLeft.item != null && squareLeft.item is ColorItem && (squareLeft.item as ColorItem).color == color)
            {
                if (squareBottom != null && squareBottom.obstacle == null && squareBottom.item != null && squareBottom.item is ColorItem && (squareBottom.item as ColorItem).color == color)
                {
                    if (itemIds.Contains(squareBottomLeft.item.GetInstanceID()) && itemIds.Contains(squareLeft.item.GetInstanceID()) && itemIds.Contains(squareBottom.item.GetInstanceID()))
                    {
                        CheckDestroyMatches(matches, item, ItemsTypes.PROPELLER);
                        return true;
                    }
                }
            }
        }
        return false;
    }
    private void CheckDestroyMatches(List<List<ColorItem>> matches, Item item, ItemsTypes itemType)
    {
        Dictionary<int, Item> destroyItems = new Dictionary<int, Item>();
        foreach (var match in matches)
        {
            foreach (var _item in match)
            {
                destroyItems[_item.GetInstanceID()] = _item;
            }
        }
        Square squareMove = null;
        if(itemType != ItemsTypes.NONE)
        {
            if (destroyItems.ContainsKey(item.GetInstanceID()))
            {
                squareMove = item.square;
            }
            else
            {
                squareMove = destroyItems.Values.FirstOrDefault().square;
            }
        }

        Dictionary<int,Square> allSquareNeghbors = new();

        foreach (var _item in destroyItems)
        {
            var square = _item.Value.square;
            var squareNeghbors = square.GetAllNeghbors();
            foreach (var _square in squareNeghbors)
            {
                allSquareNeghbors[_square.GetInstanceID()] = _square;
            }
            _item.Value.SetItemStatus(ItemStatus.Destroyed, "CheckDestroyMatches");
            //square.SetItem(null);
            if (squareMove != null)
            {
                _item.Value.transform.DOMove(squareMove.transform.position, 0.3f).SetEase(Ease.Linear);
            }
        }
        if (squareMove != null)
        {
            SquareChangeItem(squareMove, itemType);
        }
        CheckItemSpecial(allSquareNeghbors, ChangeStateTypes.Matches);
        CheckObstacles(allSquareNeghbors, ChangeStateTypes.Matches);

        var targetUI = FindTaget(item);
        DOVirtual.DelayedCall(0.4f, () => {
            
            StartCoroutine(DestroyItems(destroyItems, squareMove, targetUI, item is ColorItem));
        });
    }
    private IEnumerator DestroyItems(Dictionary<int, Item> destroyItems,Square squareMove, TargetUI targetUI, bool isMoveToTarget)
    {
        List<Square> squares = new List<Square>();
        foreach (var _item in destroyItems)
        {
            squares.Add(_item.Value.square);
            LevelManager.Instance.DestroyItem(_item.Value, targetUI, isMoveToTarget);
            if (squareMove != null) yield return new WaitForSeconds(0.1f);
        }
        lock (objLock)
        {
            
        }
        foreach (var square in squares)
        {
            LevelManager.Instance.DelayedCall(0.3f, () => LevelManager.Instance.GetItemFallOrGenItem(square));
            //if (squareMove != null && square.GetInstanceID() == squareMove.GetInstanceID())
            //{
            //    CheckFalling(squareMove.item);
            //}
            //else
            //{
            //    //square.SetItem(null);
            //    GetItemFallOrGenItem(square);
            //}
        }
    }
    public void SquareChangeItem(Square square, ItemsTypes itemsType)
    {
        lock (objLock)
        {
            square.ChangeItemByType(itemsType);
        }
    }
    public void FindItemFall(Square square)
    {
        lock (objLock)
        {
            if (square.isCanGenItem || square.item != null) return;
            var squareNotEmpty = GetSquareNotEmptyTop(square.col, square.row);
            if (squareNotEmpty == null)
            {
                return;
            }
            if (squareNotEmpty.item != null)
            {
                if(squareNotEmpty.item.itemStatus == ItemStatus.Idle) CheckFalling(squareNotEmpty.item);
            }
            else if (squareNotEmpty.obstacle != null)
            {
                var itemLeft = squareNotEmpty.GetNeighborLeft()?.item;
                if (itemLeft != null) CheckFalling(itemLeft);
                var itemRight = squareNotEmpty.GetNeighborRight()?.item;
                if (itemRight != null) CheckFalling(itemRight);
            }
        }
    }
    public Square GetSquareNotEmptyTop(int col, int row)
    {
        Square resut = null;
        for(int r = row-1; r >=0; r--)
        {
            var square = GetSquare(col, r, true);
            if(square.item != null || square.obstacle != null)
            {
                resut = square;
                break;
            }
        }
        return resut;
    }
    //public void CheckFallByColumn(int col)
    //{
    //    return;
    //    for (int r= maxRows - 1; r >= 0; r--){
            
    //        var square = GetSquare(col, r);
    //        if (square == null) return;
    //        if (!square.CanGoInto() || !square.CanGoOut())
    //        {
    //            var squareLeft = square.GetNeighborLeft();
    //            if(squareLeft != null && squareLeft.item != null )
    //            {
    //                var itemleft = squareLeft.item;
    //                CheckFalling(itemleft);
    //            }
    //            var squareRight = square.GetNeighborRight();
    //            if (squareRight != null && squareRight.item != null)
    //            {
    //                var itemRight = squareRight.item;
    //                CheckFalling(itemRight);
    //            }
    //            continue;
    //        }

    //        if (square.item == null)
    //        {
    //            if (square.isCanGenItem) square.GenItem();
    //            continue;
    //        }
    //        if (square.item.itemStatus != ItemStatus.Idle) continue;
    //        var itemCache = square.item;
    //        CheckFalling(itemCache);
    //    }
    //}
    public void CheckMatchesHorizontal(ColorItem item, ref List<List<ColorItem>> matches, ref List<int> horizontalChecked, ref List<int> verticalChecked)
    {
        if (horizontalChecked.Contains(item.GetInstanceID())) return;
        List<ColorItem> result = new List<ColorItem>();
        var resultLeft = GetAllItemByColorLeft(item.square.col, item.square.row, item.color);
        var resultRight = GetAllItemByColorRight(item.square.col, item.square.row, item.color);
        result.AddRange(resultLeft);
        result.AddRange(resultRight);
        result.Add(item);
        matches.Add(result);
        foreach (var itemChecked in result)
        {
            horizontalChecked.Add(itemChecked.GetInstanceID());
        }
        foreach (var itemChecked in result)
        {
            CheckMatchesVertical(itemChecked, ref matches, ref horizontalChecked, ref verticalChecked);
        }
    }
    public void CheckMatchesVertical(ColorItem item, ref List<List<ColorItem>> matches, ref List<int> horizontalChecked, ref List<int> verticalChecked)
    {
        if (verticalChecked.Contains(item.GetInstanceID())) return;
        List<ColorItem> result = new List<ColorItem>();
        var resultTop = GetAllItemByColorTop(item.square.col, item.square.row, item.color);
        var resultBottom = GetAllItemByColorBottom(item.square.col, item.square.row, item.color);
        result.AddRange(resultTop);
        result.AddRange(resultBottom);
        result.Add(item);
        matches.Add(result);
        foreach (var itemChecked in result)
        {
            verticalChecked.Add(itemChecked.GetInstanceID());
        }
        foreach (var itemChecked in result)
        {
            CheckMatchesHorizontal(itemChecked, ref matches, ref horizontalChecked, ref verticalChecked);
        }
    }
    public List<ColorItem> GetAllItemByColorLeft(int col, int row, int color)
    {
        List<ColorItem> result = new List<ColorItem>();
        for(int i= col-1; i > -1; i--)
        {
            var square = GetSquare(i, row);
            if (square == null) break;
            if (square.item == null) break;
            //if (square.item.color != color) break;
            if (!(square.item is ColorItem)) break;
            if (((ColorItem)square.item).color != color) break;
            if (square.item.itemStatus == ItemStatus.Destroying || square.item.itemStatus == ItemStatus.Destroyed) break;
            if (square.item.itemStatus == ItemStatus.Moving || square.item.itemStatus == ItemStatus.Creating) break;
            result.Add((ColorItem)square.item);
        }
        return result;
    }
    public List<ColorItem> GetAllItemByColorRight(int col, int row, int color)
    {
        List<ColorItem> result = new List<ColorItem>();
        for (int i = col + 1; i < maxCols; i++)
        {
            var square = GetSquare(i, row);
            if (square == null) break;
            if (square.item == null) break;
            //if (square.item.color != color) break;
            if (!(square.item is ColorItem)) break;
            if (((ColorItem)square.item).color != color) break;
            if (square.item.itemStatus == ItemStatus.Destroying || square.item.itemStatus == ItemStatus.Destroyed) break;
            if (square.item.itemStatus == ItemStatus.Moving || square.item.itemStatus == ItemStatus.Creating) break;
            result.Add((ColorItem)square.item);
        }
        return result;
    }
    
    public List<ColorItem> GetAllItemByColorTop(int col, int row, int color)
    {
        List<ColorItem> result = new List<ColorItem>();
        for (int i = row - 1; i > -1; i--)
        {
            var square = GetSquare(col, i);
            if (square == null) break;
            if (square.item == null) break;
            if (!(square.item is ColorItem)) break;
            if (((ColorItem)square.item).color != color) break;
            if (square.item.itemStatus == ItemStatus.Destroying || square.item.itemStatus == ItemStatus.Destroyed) break;
            if (square.item.itemStatus == ItemStatus.Moving || square.item.itemStatus == ItemStatus.Creating) break;
            result.Add((ColorItem)square.item);
        }
        return result;
    }
    public List<ColorItem> GetAllItemByColorBottom(int col, int row, int color)
    {
        List<ColorItem> result = new List<ColorItem>();
        for (int i = row + 1; i < maxRows; i++)
        {
            var square = GetSquare(col, i);
            if (square == null) break;
            if (square.item == null) break;
            //if (square.item.color != color) break;
            if (!(square.item is ColorItem)) break;
            if (((ColorItem)square.item).color != color) break;
            if (square.item.itemStatus == ItemStatus.Destroying || square.item.itemStatus == ItemStatus.Destroyed) break;
            if (square.item.itemStatus == ItemStatus.Moving || square.item.itemStatus == ItemStatus.Creating) break;
            result.Add((ColorItem)square.item);
        }
        return result;
    }

    //public IEnumerator GenItemWithColumn(int col)
    //{

    //    for (int row = 0; row < maxRows; row++)
    //    {
    //        var square = GetSquare(col, row);
    //        if (square == null) break;
    //        if (!square.CanGoInto()) break;
    //        var item = GameObject.Instantiate(GetItemByType(ItemsTypes.NONE), square.transform.parent).GetComponent<Item>();
    //        item.square = square;
    //        item.transform.localScale = Vector3.one * 0.6f;
    //        item.transform.position = square.transform.position + Vector3.back * 0.2f + Vector3.up * 9f;
    //        item.SetItemStatus(ItemStatus.Moving, "GenItemWithColumn");
    //        square.SetItem(item);
    //        item.StartFalling();
    //        if (!square.CanGoOut()) break;
    //        yield return new WaitForSeconds(1f);
    //    }
    //}
    //public void ReGenLevel()
    //{
    //    //itemsHided = false;
    //    DragBlocked = true;
    //    if (gameStatus != GameState.Playing && gameStatus != GameState.RegenLevel)
    //        DestroyItems();
    //    else if (gameStatus == GameState.RegenLevel)
    //        DestroyItems(true);
    //    OnLevelLoaded();
    //    StartCoroutine(RegenMatches());
    //    OnLevelLoaded();
    //}

    //IEnumerator RegenMatches(bool onlyFalling = false)
    //{
    //    if (gameStatus == GameState.RegenLevel)
    //    {
    //        yield return new WaitForSeconds(0.5f);
    //    }
    //    if (!onlyFalling)
    //        GenerateNewItems(false);
    //    else
    //        LevelManager.Instance.onlyFalling = true;
    //    yield return new WaitForFixedUpdate();

    //    List<List<Item>> combs = GetMatches();
    //    do
    //    {
    //        foreach (List<Item> comb in combs)
    //        {
    //            int colorOffset = 0;
    //            foreach (Item item in comb)
    //            {
    //                item.GenColor(item.color + colorOffset);
    //                colorOffset++;
    //            }
    //        }
    //        combs = GetMatches();
    //    } while (combs.Count > 0);
    //    yield return new WaitForFixedUpdate();
    //    SetPreBoosts();
    //    LevelManager.Instance.onlyFalling = false;
    //    if (gameStatus == GameState.RegenLevel)
    //        PlayGame();
    //    if (!onlyFalling)//2.1.5 prevents early move
    //        DragBlocked = false;
    //    StartCoroutine(AI.THIS.CheckPossibleCombines());//2.1.5 prevents early move
    //}

    //void SetPreBoosts()
    //{
    //    if (BoostPackage > 0)
    //    {
    //        InitScript.Instance.SpendBoost(BoostType.Packages);
    //        foreach (Item item in GetRandomItems(BoostPackage))
    //        {
    //            item.NextType = ItemsTypes.PACKAGE;
    //            item.ChangeType();
    //            item.boost = true;
    //        }
    //        BoostPackage = 0;
    //    }
    //    if (BoostColorfullBomb > 0)
    //    {
    //        InitScript.Instance.SpendBoost(BoostType.Colorful_bomb);
    //        foreach (Item item in GetRandomItems(BoostColorfullBomb))
    //        {
    //            item.NextType = ItemsTypes.BOMB;
    //            item.ChangeType();
    //            item.boost = true;
    //        }
    //        BoostColorfullBomb = 0;
    //    }
    //    if (BoostStriped > 0)
    //    {
    //        InitScript.Instance.SpendBoost(BoostType.Stripes);
    //        foreach (Item item in GetRandomItems(BoostStriped))
    //        {
    //            item.NextType = (ItemsTypes)UnityEngine.Random.Range(1, 3);
    //            item.ChangeType();
    //            item.boost = true;
    //        }
    //        BoostStriped = 0;
    //    }
    //}


    //public List<Item> GetRandomItems(int count)
    //{
    //    List<Item> list = new List<Item>();
    //    List<Item> list2 = new List<Item>();
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    if (items.Length < count)
    //        count = items.Length;
    //    foreach (GameObject item in items)
    //    {
    //        if (item.GetComponent<Item>().currentType == ItemsTypes.NONE && item.GetComponent<Item>().NextType == ItemsTypes.NONE && !item.GetComponent<Item>().destroying)
    //        {
    //            list.Add(item.GetComponent<Item>());
    //        }
    //    }

    //    while (list2.Count < count)
    //    {

    //        try
    //        {
    //            Item newItem = list[UnityEngine.Random.Range(0, list.Count)];
    //            if (list2.IndexOf(newItem) < 0)
    //            {
    //                list2.Add(newItem);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            WinGame();
    //        }
    //    }
    //    return list2;
    //}

    public Dictionary<int, ObstacleBase> FindObstaclesInListSquare(List<Square> squares)
    {
        Dictionary<int, ObstacleBase> result = new Dictionary<int, ObstacleBase>();
        foreach(var square in squares)
        {
            if (square.obstacle == null) continue;
            result[square.obstacle.GetInstanceID()] = square.obstacle;
        }
        return result;
    }
    public Dictionary<int, ObstacleBase> FindObstaclesInListSquare(Dictionary<int,Square> squares)
    {
        Dictionary<int, ObstacleBase> result = new Dictionary<int, ObstacleBase>();
        foreach (var square in squares)
        {
            if (square.Value.obstacle == null) continue;
            result[square.Value.obstacle.GetInstanceID()] = square.Value.obstacle;
        }
        return result;
    }
    public Dictionary<int, Item> FindItemSpecialInListSquare(List<Square> squares)
    {
        Dictionary<int, Item> result = new Dictionary<int, Item>();
        foreach (var square in squares)
        {
            if (square.item == null) continue;
            if (square.obstacle != null) continue;
            result[square.item.GetInstanceID()] = square.item;
        }
        return result;
    }
    public Dictionary<int, Item> FindItemSpecialInListItem(List<Item> items)
    {
        Dictionary<int, Item> result = new Dictionary<int, Item>();
        foreach (var item in items)
        {
            if (item == null) continue;
            if (item.square.obstacle != null) continue;
            result[item.GetInstanceID()] = item;
        }
        return result;
    }
    public Dictionary<int, ObstacleBase> FindObstaclesInListItem(List<Item> items)
    {
        Dictionary<int, ObstacleBase> result = new Dictionary<int, ObstacleBase>();
        foreach (var item in items)
        {
            if (item == null || item.square == null || item.square.obstacle == null) continue;
            result[item.square.obstacle.GetInstanceID()] = item.square.obstacle;
        }
        return result;
    }
    public void CheckObstacles(List<Square> squares, ChangeStateTypes type)
    {
        var result = FindObstaclesInListSquare(squares);
        foreach(var obstacle in result)
        {
            obstacle.Value.OnMatchesOrPowerUp(type);
        }
    }
    public void CheckObstacles(Dictionary<int,Square> squares, ChangeStateTypes type)
    {
        var result = FindObstaclesInListSquare(squares);
        foreach (var obstacle in result)
        {
            obstacle.Value.OnMatchesOrPowerUp(type);
        }
    }
    public void CheckItemSpecial(Dictionary<int, Square> squares, ChangeStateTypes type)
    {
        foreach (var square in squares)
        {
            square.Value.ItemOnMatchesOrPowerUp(type);
        }
    }
    public void CheckItemSpecial(List<Square> squares, ChangeStateTypes type)
    {
        var result = FindItemSpecialInListSquare(squares);
        foreach (var item in result)
        {
            item.Value.OnMatchesOrPowerUp(type);
        }
    }
    public void CheckItemSpecial(List<Item> items, ChangeStateTypes type)
    {
        var result = FindItemSpecialInListItem(items);
        foreach (var item in result)
        {
            item.Value.OnMatchesOrPowerUp(type);
        }
    }
    public void CheckObstacles(List<Item> items, ChangeStateTypes type)
    {
        var result = FindObstaclesInListItem(items);
        foreach (var obstacle in result)
        {
            obstacle.Value.OnMatchesOrPowerUp(type);
        }
    }
    //List<Item> GetAllExtaItems()
    //{
    //    List<Item> list = new List<Item>();
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        if (item.GetComponent<Item>().currentType != ItemsTypes.NONE)
    //        {
    //            list.Add(item.GetComponent<Item>());
    //        }
    //    }

    //    return list;
    //}

    public int GetIngredientsCount(string spritename)
    {
        return FindObjectsOfType<SpriteRenderer>().Count(i => i.sprite.name==spritename);
    }
    //public void DestroyItems(bool withoutEffects = false)
    //{
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        if (item != null)
    //        {
    //            if (item.GetComponent<Item>().currentType == ItemsTypes.NONE)
    //            {
    //                item.GetComponent<Item>().DestroyItem();
    //            }
    //        }
    //    }

    //}
    public void BombDestroySelected(List<Square> selectedItems, float timeDelay)
    {
        try
        {
            Debug.Log("----------------AllEndSelect");
            if(timeDelay > 0)
            {
                StartCoroutine(DestroyAllItemSelected(selectedItems, timeDelay));
            }
            else
            {
                foreach (var item in selectedItems)
                {
                    item.Attack();
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError(e.StackTrace);
        }

    }
    private IEnumerator DestroyAllItemSelected(List<Square> selectedItems, float timeDelay)
    {
        Debug.Log("---------DestroyAllItemSelected");
        foreach (var square in selectedItems)
        {
            square.Attack();
            yield return new WaitForSeconds(timeDelay);
        }
    }
    public IEnumerator FindMatchDelay()
    {
        yield return new WaitForSeconds(0.2f);
        LevelManager.Instance.FindMatches();

    }

    public void FindMatches()
    {
        return;
        //StartCoroutine(FallingDown());
    }

    //public List<List<Item>> GetMatches(FindSeparating separating = FindSeparating.NONE, int matches = 3)
    //{
    //    newCombines = new List<List<Item>>();
    //    countedSquares = new Hashtable();
    //    countedSquares.Clear();
    //    for (int col = 0; col < maxCols; col++)
    //    {
    //        for (int row = 0; row < maxRows; row++)
    //        {
    //            var square = GetSquare(col, row);
    //            if (square != null)
    //            {
    //                if (!countedSquares.ContainsValue(square.item))
    //                {
    //                    List<Item> newCombine = square.FindMatchesAround(separating, matches/*, countedSquares*/);
    //                    if (newCombine.Count >= matches)
    //                        newCombines.Add(newCombine);
    //                }
    //            }
    //        }
    //    }
    //    return newCombines;
    //}

    //IEnumerator GetMatchesCor(FindSeparating separating = FindSeparating.NONE, int matches = 3, bool Smooth = true)
    //{
    //    Hashtable countedSquares = new Hashtable();
    //    for (int col = 0; col < maxCols; col++)
    //    {
    //        for (int row = 0; row < maxRows; row++)
    //        {

    //            if (GetSquare(col, row) != null)
    //            {
    //                if (!countedSquares.ContainsValue(GetSquare(col, row).item))
    //                {
    //                    List<Item> newCombine = GetSquare(col, row).FindMatchesAround(separating, matches/*, countedSquares*/);
    //                    if (newCombine.Count >= matches)
    //                        newCombines.Add(newCombine);
    //                }
    //            }
    //        }
    //    }
    //    matchesGot = true;
    //    yield return new WaitForFixedUpdate();

    //}

    //IEnumerator CheckFallingAtStart()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    while (!IsAllItemsFallDown())
    //    {
    //        yield return new WaitForSeconds(0.1f);
    //    }
    //    FindMatches();
    //}

    //public bool CheckExtraPackage(List<List<Item>> rowItems)
    //{
    //    foreach (List<Item> items in rowItems)
    //    {
    //        foreach (Item item in items)
    //        {
    //            if (item.square.FindMatchesAround(FindSeparating.VERTICAL).Count > 2)
    //            {
    //                if (LevelManager.Instance.lastDraggedItem == null)
    //                    LevelManager.Instance.lastDraggedItem = item;
    //                LevelManager.Instance.latstMatchColor = item.color;
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}


    //IEnumerator FallingDown()
    //{
    //    bool nearEmptySquareDetected = false;
    //    int combo = 0;
    //    AI.THIS.allowShowTip = false;
    //    List<Item> it = GetItems();

    //    while (true)
    //    {
    //        //find matches
    //        yield return new WaitForSeconds(0.1f);

    //        combinedItems.Clear();
    //        combinedItems = combineManager.GetCombine(); //GetMatches();  //1.6

    //        if (combinedItems.Count > 0)
    //            combo++;
    //        foreach (List<Item> desrtoyItems in combinedItems)
    //        {
    //            //if (quest != null) quest.CheckTarget(desrtoyItems);
    //            //LevelHeroRescues._instance.MatchItems(desrtoyItems);
    //            var squareNeghbors = GetAllNeghbors(desrtoyItems);
    //            CheckObstacles(squareNeghbors,ChangeStateTypes.Matches);
    //            CheckItemSpecial(squareNeghbors, ChangeStateTypes.Matches);
    //            foreach (Item item in desrtoyItems)
    //            {//TODO items not destroy

    //                if (item.currentType != ItemsTypes.NONE)
    //                    yield return new WaitForSeconds(0.1f);
    //                item.DestroyItem(true);  //destroy items safely
    //            }
    //        }

    //        foreach (Item item in destroyAnyway)
    //        {
    //            item.DestroyItem(true, "", true);  //destroy items safely
    //        }
    //        destroyAnyway.Clear();

    //        if (lastDraggedItem != null)
    //        {
    //            if (lastDraggedItem.NextType != ItemsTypes.NONE)
    //            {
    //                yield return new WaitForSeconds(0.5f);
    //            }
    //            lastDraggedItem = null;
    //        }

    //        while (!IsAllDestoyFinished())
    //        {
    //            yield return new WaitForSeconds(0.1f);
    //        }

    //        //falling down
    //        for (int i = 0; i < 20; i++)
    //        {   //just for testing
    //            for (int col = 0; col < maxCols; col++)
    //            {
    //                for (int row = maxRows - 1; row >= 0; row--)
    //                {   //need to enumerate rows from bottom to top
    //                    if (GetSquare(col, row) != null)
    //                        GetSquare(col, row).FallOut();
    //                }
    //            }
    //        }
    //        if (!nearEmptySquareDetected)
    //            yield return new WaitForSeconds(0.2f);

    //        CheckIngredient();
    //        for (int col = 0; col < maxCols; col++)
    //        {
    //            for (int row = maxRows - 1; row >= 0; row--)
    //            {
    //                if (GetSquare(col, row) != null)
    //                {
    //                    if (!GetSquare(col, row).IsNone())
    //                    {
    //                        if (GetSquare(col, row).item != null)
    //                        {
    //                            GetSquare(col, row).item.StartFalling();
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        yield return new WaitForSeconds(0.2f);
    //        GenerateNewItems();
    //        StartCoroutine(RegenMatches(true));
    //        yield return new WaitForSeconds(0.1f);
    //        while (!IsAllItemsFallDown())
    //        {
    //            yield return new WaitForSeconds(0.1f);
    //        }

    //        //detect near empty squares to fall into
    //        nearEmptySquareDetected = false;

    //        for (int col = 0; col < maxCols; col++)
    //        {
    //            for (int row = maxRows - 1; row >= 0; row--)
    //            {
    //                if (GetSquare(col, row) != null)
    //                {
    //                    if (!GetSquare(col, row).IsNone())
    //                    {
    //                        if (GetSquare(col, row).item != null)
    //                        {
    //                            if (GetSquare(col, row).item.GetNearEmptySquares())
    //                                nearEmptySquareDetected = true;

    //                        }
    //                    }
    //                }
    //            }
    //        }
            
    //        while (!IsAllItemsFallDown())
    //        {//2.0
    //            yield return new WaitForSeconds(0.1f);
    //        }

    //        if (destroyAnyway.Count > 0)
    //            nearEmptySquareDetected = true;
    //        if (GetMatches().Count <= 0 && !nearEmptySquareDetected)
    //            break;
    //    }

    //    List<Item> item_ = GetItems();
    //    for (int i = 0; i < item_.Count; i++)//2.1.5 
    //    {
    //        Item item1 = item_[i];
    //        if (item1 != null)
    //        {
    //            if (item1 != item1.square.item)
    //            {
    //                Destroy(item1.gameObject);
    //            }
    //        }
    //    }

    //    //thrive thriving blocks
    //    if (!thrivingBlockDestroyed)
    //    {
    //        bool thrivingBlockSelected = false;
    //        for (int col = 0; col < maxCols; col++)
    //        {
    //            if (thrivingBlockSelected)
    //                break;
    //            for (int row = maxRows - 1; row >= 0; row--)
    //            {
    //                if (thrivingBlockSelected)
    //                    break;
    //                if (GetSquare(col, row) != null)
    //                {
    //                    if (GetSquare(col, row).type == SquareTypes.THRIVING)
    //                    {
    //                        List<Square> sqList = GetSquare(col, row).GetAllNeghbors();
    //                        foreach (Square sq in sqList)
    //                        {
    //                            if (sq.CanGoInto() && UnityEngine.Random.Range(0, 1) == 0 && sq.type == SquareTypes.EMPTY)
    //                            {
    //                                if (sq.item != null)
    //                                {//1.6.1
    //                                    if (sq.item.currentType == ItemsTypes.NONE)
    //                                    {//1.6.1
    //                                        CreateObstacles(sq.col, sq.row, sq.gameObject, SquareTypes.THRIVING);

    //                                        thrivingBlockSelected = true;
    //                                        break;
    //                                    }
    //                                }
    //                            }
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //    }


    //    thrivingBlockDestroyed = false;

    //    if (gameStatus == GameState.Playing && !ingredientFly)
    //        LevelManager.Instance.CheckWinLose();

    //    if (combo > 2 && gameStatus == GameState.Playing)
    //    {
    //        gratzWords[UnityEngine.Random.Range(0, gratzWords.Length)].SetActive(true);
    //        combo = 0;
    //    }
    //    LevelManager.Instance.latstMatchColor = -1;
    //    CheckItemsPositions();//1.6.1
    //    DragBlocked = false;//2.1.5 prevents early move
    //    if (gameStatus == GameState.Playing)
    //        StartCoroutine(AI.THIS.CheckPossibleCombines());
    //}
    public Square GetSquareCanGoToInCloumn(int col, int row)
    {
        Square square = null;
        for (int i = row + 1; i < maxRows; i++)
        {
            var _square = GetSquare(col, i);
            if (_square == null) break;
            if (_square.item != null) break;
            if (!_square.CanGoInto()) break;
            if (_square.IsNone()) continue;
            square = _square;
        }
        return square;
    }
    //public void CheckFallColumn(int col, int row)
    //{
    //    for(int r = row; r > -1; r--)
    //    {
    //        var s = GetSquare(col, r);
    //        if (s == null) continue;
    //        if (s.item == null) continue;
    //        if (!s.CanGoOut()) return;
    //        if (s.CanGoInto()) return;
    //        var square = GetSquareCanGoToInCloumn(col, r);
    //        if (square == null) continue;
    //        square.item = s.item;
    //        s.item = null;
    //        square.item.StartFalling();
    //    }
    //}
    public List<Square> GetAllNeghbors(List<Item> items)
    {
        Dictionary<int, Square> result = new Dictionary<int, Square>();

        foreach(var item in items)
        {
            if (item == null || item.square == null) continue;
            var squareNeghbors = item.square.GetAllNeghbors();
            foreach(var square in squareNeghbors)
            {
                result[square.GetInstanceID()] = square;
            }
        }
        return result.Values.ToList();
    }
    void CheckItemsPositions()
    {//1.6.1
        List<Item> items = GetItems();
        foreach (var item in items)
        {
            if (item)
                item.transform.position = item.square.transform.position + Vector3.back * 0.2f;
        }
    }


    //public void DestroyDoubleBomb(int col)
    //{
    //    StartCoroutine(DestroyDoubleBombCor(col));
    //    StartCoroutine(DestroyDoubleBombCorBack(col));
    //}

    //IEnumerator DestroyDoubleBombCor(int col)
    //{
    //    for (int i = col; i < maxCols; i++)
    //    {
    //        List<Item> list = GetColumn(i);
    //        foreach (Item item in list)
    //        {
    //            if (item != null)
    //                item.DestroyItem(true, "", true);
    //        }
    //        yield return new WaitForSeconds(0.3f);
    //    }
    //    if (col <= maxCols - col - 1)
    //        FindMatches();
    //}

    //IEnumerator DestroyDoubleBombCorBack(int col)
    //{
    //    for (int i = col - 1; i >= 0; i--)
    //    {
    //        List<Item> list = GetColumn(i);
    //        foreach (Item item in list)
    //        {
    //            if (item != null)
    //                item.DestroyItem(true, "", true);
    //        }
    //        yield return new WaitForSeconds(0.3f);
    //    }
    //    if (col > maxCols - col - 1)
    //        FindMatches();
    //}


    public Square GetSquare(int col, int row, bool safe = false)
    {
        if (!safe)
        {
            if (row >= maxRows || col >= maxCols || row < 0 || col < 0)
                return null;
            return squaresArray[row * maxCols + col];
        }
        else
        {
            row = Mathf.Clamp(row, 0, maxRows - 1);
            col = Mathf.Clamp(col, 0, maxCols - 1);
            return squaresArray[row * maxCols + col];
        }
    }

    //bool IsAllDestoyFinished()
    //{
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        Item itemComponent = item.GetComponent<Item>();
    //        if (itemComponent == null)
    //        {
    //            return false;
    //        }
    //        if (itemComponent.destroying /*&& !itemComponent.animationFinished*/)
    //            return false;
    //    }
    //    return true;
    //}

    //bool IsIngredientFalling()
    //{//1.6.1
    //    if (gameStatus == GameState.PreWinAnimations)
    //        return true;
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        Item itemComponent = item.GetComponent<Item>();
    //        if (itemComponent != null)
    //        {
    //            if (itemComponent.falling && itemComponent.currentType == ItemsTypes.INGREDIENT)
    //                return true;
    //        }
    //    }
    //    return false;

    //}

    //bool IsAllItemsFallDown()
    //{
    //    if (gameStatus == GameState.PreWinAnimations)
    //        return true;
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        Item itemComponent = item.GetComponent<Item>();
    //        if (itemComponent == null)
    //        {
    //            return false;
    //        }
    //        if (itemComponent.falling)
    //            return false;
    //    }
    //    return true;
    //}

    //public Vector2 GetPosition(Item item)
    //{
    //    return GetPosition(item.square);
    //}

    //public Vector2 GetPosition(Square square)
    //{
    //    return new Vector2(square.col, square.row);
    //}

    public List<Item> GetRow(int row)
    {
        List<Item> itemsList = new List<Item>();
        for (int col = 0; col < maxCols; col++)
        {
            itemsList.Add(GetSquare(col, row, true).item);
        }
        return itemsList;
    }

    public List<Item> GetColumn(int col)
    {
        List<Item> itemsList = new List<Item>();
        for (int row = 0; row < maxRows; row++)
        {
            itemsList.Add(GetSquare(col, row, true).item);
        }
        return itemsList;
    }

    public List<Square> GetColumnSquaresObstacles(int col)
    {
        List<Square> itemsList = new List<Square>();
        for (int row = 0; row < maxRows; row++)
        {
            if (GetSquare(col, row, true).IsHaveDestroybleObstacle())
                itemsList.Add(GetSquare(col, row, true));
        }
        return itemsList;
    }
    public List<Square> GetPackageSquaresObstacles(int colCenter,int rowCenter, int range)
    {
        List<Square> itemsList = new List<Square>();
        if (range < 1) return itemsList;
        int rowMin = Mathf.Clamp(rowCenter - range-1, 0, maxRows - 1);
        int rowMax = Mathf.Clamp(rowCenter + range+1, 0, maxRows - 1);
        int colMin = Mathf.Clamp(colCenter-range-1, 0, maxCols - 1);
        int colMax = Mathf.Clamp(colCenter+range+1, 0, maxCols - 1);
        for (int row = rowMin; row < rowMax+1; row++)
        {
            for (int col = colMin; col < colMax + 1; col++)
            {
                if (GetSquare(col, row, true).IsHaveDestroybleObstacle())
                   itemsList.Add(GetSquare(col, row, true));
            }
        }
        return itemsList;
    }
    public List<Square> GetSquaresAroundRange(int colCenter, int rowCenter, int range)
    {
        List<Square> itemsList = new List<Square>();
        if (range < 0) return itemsList;
        int rowMin = Mathf.Clamp(rowCenter - range, 0, maxRows - 1);
        int rowMax = Mathf.Clamp(rowCenter + range, 0, maxRows - 1);
        int colMin = Mathf.Clamp(colCenter - range, 0, maxCols - 1);
        int colMax = Mathf.Clamp(colCenter + range, 0, maxCols - 1);
        for (int row = rowMin; row < rowMax + 1; row++)
        {
            for (int col = colMin; col < colMax + 1; col++)
            {
                if (row != rowMin && row != rowMax && col != colMin && col != colMax) continue;
                itemsList.Add(GetSquare(col, row, true));
            }
        }
        return itemsList;
    }
    public List<Square> GetSquaresInRange(int colCenter, int rowCenter, int range)
    {
        List<Square> itemsList = new List<Square>();
        if (range < 0) return itemsList;
        int rowMin = Mathf.Clamp(rowCenter - range, 0, maxRows - 1);
        int rowMax = Mathf.Clamp(rowCenter + range, 0, maxRows - 1);
        int colMin = Mathf.Clamp(colCenter - range, 0, maxCols - 1);
        int colMax = Mathf.Clamp(colCenter + range, 0, maxCols - 1);
        for (int row = rowMin; row < rowMax + 1; row++)
        {
            for (int col = colMin; col < colMax + 1; col++)
            {
                    itemsList.Add(GetSquare(col, row, true));
            }
        }
        return itemsList;
    }
    public List<Square> GetRowSquaresObstacles(int row)
    {
        List<Square> itemsList = new List<Square>();
        for (int col = 0; col < maxCols; col++)
        {
            if (GetSquare(col, row, true).IsHaveDestroybleObstacle())
                itemsList.Add(GetSquare(col, row, true));
        }
        return itemsList;
    }
    public List<ObstacleBase> GetObstaclesLeft<T>(int colStart, int row)
    {
        List<ObstacleBase> result = new List<ObstacleBase>();
        for(int col=colStart-1; col>-1; col--)
        {
            var square = GetSquare(col, row);
            if (square == null) break;
            if (square.obstacle == null) break;
            if(square.obstacle is T)
            {
                result.Add(square.obstacle);
            }
            else
            {
                break;
            }
        }
        return result;
    }
    public List<ObstacleBase> GetObstaclesRight<T>(int colStart, int row)
    {
        List<ObstacleBase> result = new List<ObstacleBase>();
        for (int col = colStart + 1; col < maxCols; col++)
        {
            var square = GetSquare(col, row);
            if (square == null) break;
            if (square.obstacle == null) break;
            if (square.obstacle is T)
            {
                result.Add(square.obstacle);
            }
            else
            {
                break;
            }
        }
        return result;
    }
    public List<Item> GetItemsAround(Square square)
    {
        int col = square.col;
        int row = square.row;
        List<Item> itemsList = new List<Item>();
        for (int r = row - 1; r <= row + 1; r++)
        {
            for (int c = col - 1; c <= col + 1; c++)
            {
                itemsList.Add(GetSquare(c, r, true).item);
            }
        }
        return itemsList;
    }

    //public List<Item> GetItemsCross(Square square, List<Item> exceptList = null, int COLOR = -1)
    //{
    //    if (exceptList == null)
    //        exceptList = new List<Item>();
    //    int c = square.col;
    //    int r = square.row;
    //    List<Item> itemsList = new List<Item>();
    //    Item item = null;
    //    item = GetSquare(c - 1, r, true).item;
    //    if (exceptList.IndexOf(item) <= -1)
    //    {
    //        if (item.color == COLOR || COLOR == -1)
    //            itemsList.Add(item);
    //    }
    //    item = GetSquare(c + 1, r, true).item;
    //    if (exceptList.IndexOf(item) <= -1)
    //    {
    //        if (item.color == COLOR || COLOR == -1)
    //            itemsList.Add(item);
    //    }
    //    item = GetSquare(c, r - 1, true).item;
    //    if (exceptList.IndexOf(item) <= -1)
    //    {
    //        if (item.color == COLOR || COLOR == -1)
    //            itemsList.Add(item);
    //    }
    //    item = GetSquare(c, r + 1, true).item;
    //    if (exceptList.IndexOf(item) <= -1)
    //    {
    //        if (item.color == COLOR || COLOR == -1)
    //            itemsList.Add(item);
    //    }

    //    return itemsList;
    //}

    public List<Item> GetItems()
    {
        List<Item> itemsList = new List<Item>();
        for (int row = 0; row < maxRows; row++)
        {
            for (int col = 0; col < maxCols; col++)
            {
                if (GetSquare(col, row) != null)
                    itemsList.Add(GetSquare(col, row, true).item);
            }
        }
        return itemsList;
    }
    public List<Item> GetColorItemsByColor(int color)
    {
        List<Item> itemsList = new List<Item>();
        for (int row = 0; row < maxRows; row++)
        {
            for (int col = 0; col < maxCols; col++)
            {
                var square = GetSquare(col, row);
                if (square == null) continue;
                if (square.item == null) continue;
                if(square.item is ColorItem)
                {
                    if(((ColorItem)square.item).color == color)
                    {
                        itemsList.Add(square.item);
                    }
                }
            }
        }
        return itemsList;
    }
    public List<Square> GetSquares()
    {
        List<Square> itemsList = new List<Square>();
        for (int row = 0; row < maxRows; row++)
        {
            for (int col = 0; col < maxCols; col++)
            {
                if (GetSquare(col, row) != null)
                    itemsList.Add(GetSquare(col, row, true));
            }
        }
        return itemsList;
    }
    //public void SetTypeByColor(int p, ItemsTypes nextType)
    //{
    //    GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
    //    foreach (GameObject item in items)
    //    {
    //        if (item.GetComponent<Item>().color == p)
    //        {
    //            if (nextType == ItemsTypes.HORIZONTAL_STRIPPED || nextType == ItemsTypes.VERTICAL_STRIPPED)
    //                item.GetComponent<Item>().NextType = (ItemsTypes)UnityEngine.Random.Range(1, 3);
    //            else
    //                item.GetComponent<Item>().NextType = nextType;

    //            item.GetComponent<Item>().ChangeType();
    //            if (nextType == ItemsTypes.NONE)
    //                destroyAnyway.Add(item.GetComponent<Item>());
    //        }
    //    }
    //}

    //public void CheckIngredient()
    //{
    //    List<Square> sqList = GetBottomRow();
    //    foreach (Square sq in sqList)
    //    {
    //        if (sq.item != null)
    //        {
    //            if (sq.item.currentType == ItemsTypes.INGREDIENT)
    //            {
    //                destroyAnyway.Add(sq.item);
    //            }
    //        }
    //    }
    //}

    public List<Square> GetBottomRow()
    {
        List<Square> itemsList = new List<Square>();
        int listCounter = 0;
        for (int col = 0; col < maxCols; col++)
        {
            for (int row = maxRows - 1; row >= 0; row--)
            {
                Square square = GetSquare(col, row, true);
                if (square.type != SquareTypes.NONE)
                {
                    itemsList.Add(square);
                    listCounter++;
                    break;
                }
            }
        }
        return itemsList;
    }

    public void StrippedShow(GameObject obj, bool horrizontal)
    {
        GameObject effect = Instantiate(stripesEffect, obj.transform.position, Quaternion.identity) as GameObject;
        if (!horrizontal)
            effect.transform.Rotate(Vector3.back, 90);
        Destroy(effect, 1);
    }

    //void UpdateBar()
    //{
    //    ProgressBarScript.Instance.UpdateDisplay((float)Score * 100f / ((float)star1 / ((star1 * 100f / star3)) * 100f) / 100f);

    //}
    public void LoadDataFromLocal(int currentLevel, out List<ObstacleMapConfig> obstacles)
    {
        levelLoaded = false;
        //Read data from text file
        TextAsset mapText = Resources.Load("Levels/" + currentLevel) as TextAsset;
        if (mapText == null)
        {
            mapText = Resources.Load("Levels/" + currentLevel) as TextAsset;
        }
        ProcessGameDataFromString(mapText.text, out List<ObstacleMapConfig> _obstacles);
        obstacles = _obstacles;
    }

    void ProcessGameDataFromString(string mapText, out List<ObstacleMapConfig> obstacles)
    {
        obstacles = new List<ObstacleMapConfig>();
        string[] lines = mapText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

        int mapLine = 0;
        foreach (string line in lines)
        {
            //check if line is game mode line
            if (line.StartsWith("MODE"))
            {
                //Replace GM to get mode number, 
                //string modeString = line.Replace("MODE", string.Empty).Trim();
                //then parse it to interger
                //target = (Target)int.Parse(modeString);
                //Assign game mode
            }
            else if (line.StartsWith("SIZE "))
            {
                string blocksString = line.Replace("SIZE", string.Empty).Trim();
                string[] sizes = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                maxCols = int.Parse(sizes[0]);
                maxRows = int.Parse(sizes[1]);
                squaresArray = new Square[maxCols * maxRows];
                levelSquaresFile = new SquareBlocks[maxRows * maxCols];
                for (int i = 0; i < levelSquaresFile.Length; i++)
                {
                    SquareBlocks sqBlocks = new SquareBlocks();
                    sqBlocks.squareType = SquareTypes.EMPTY;
                    sqBlocks.obstacleType = ObstacleTypes.None;

                    levelSquaresFile[i] = sqBlocks;
                }
            }
            else if (line.StartsWith("LIMIT"))
            {
                string blocksString = line.Replace("LIMIT", string.Empty).Trim();
                string[] sizes = blocksString.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                limitType = (LIMIT)int.Parse(sizes[0]);
                Limit = int.Parse(sizes[1]);
            }
            else if (line.StartsWith("MiniGameLevel "))
            {
                string MiniGameLevelString = line.Replace("MiniGameLevel", string.Empty).Trim();
                miniGameLevelNumber = int.Parse(MiniGameLevelString);
            }
            else if (line.StartsWith("MiniGameLevelTarget "))
            {
                string miniGameLevelTargetString = line.Replace("MiniGameLevelTarget", string.Empty).Trim();
                miniGameLevelTarget = int.Parse(miniGameLevelTargetString);
            }
            else
            { //Maps
              //Split lines again to get map numbers
                string[] st = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < st.Length; i++)
                {
                    string[] stCell = st[i].Split(new string[] { "_" }, StringSplitOptions.RemoveEmptyEntries);
                    if (stCell.Length >= 1) levelSquaresFile[mapLine * maxCols + i].squareType = (SquareTypes)int.Parse(stCell[0].ToString());
                    if (stCell.Length >= 2) levelSquaresFile[mapLine * maxCols + i].itemsType = (ItemsTypes)int.Parse(stCell[1].ToString());
                    if (stCell.Length >= 3)
                    {
                        ObstacleTypes obstacleTypes = (ObstacleTypes)int.Parse(stCell[2].ToString());
                        if(obstacleTypes != ObstacleTypes.None)
                        {
                            levelSquaresFile[mapLine * maxCols + i].obstacleType = obstacleTypes;
                            ObstacleMapConfig obstacleMapConfig = new ObstacleMapConfig
                            {
                                colum = i,
                                row = mapLine,
                                obstacleType = obstacleTypes
                            };
                            obstacles.Add(obstacleMapConfig);
                        }
                        
                    }
                    if (stCell.Length >= 4)
                    {
                        levelSquaresFile[mapLine * maxCols + i].GenItems = new List<ItemsTypes>();
                        string[] stGen = stCell[3].Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                        for (int g = 0; g < stGen.Length; g++)
                        {
                            int.TryParse(stGen[g], out int result);
                            if (result == 0) continue;
                            levelSquaresFile[mapLine * maxCols + i].GenItems.Add((ItemsTypes)result);
                        }
                    }
                }
                mapLine++;
            }
            
        }
        levelLoaded = true;
    }

}

[System.Serializable]
public class GemProduct
{
    public int count;
    public float price;
}
