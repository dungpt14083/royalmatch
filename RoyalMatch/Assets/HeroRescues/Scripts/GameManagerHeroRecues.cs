using UnityEngine;

public class GameManagerHeroRecues : MonoBehaviour
{
    public static GameManagerHeroRecues instance;

    public bool isGameOver, isGameWin = false;

    public int /*currentCoin,bonusCoin, _life,*/ _totalGoblin,_totalGoblinKilled; 

    private void Awake()
    {
        instance = this;
        isGameOver = false;
        isGameWin = false;
        //bonusCoin = 0;
        ResetCollision();
    }
    // Start is called before the first frame update
    void Start()
    {
        //currentCoin = PlayerPrefs.GetInt("Coin");
        //_life = PlayerPrefs.GetInt("Life");
        //_totalGoblinKilled = 0;
        //if(GameObject.FindGameObjectWithTag("Goblin") != null)
        //_totalGoblin = GameObject.FindGameObjectsWithTag("Goblin").Length;
        //UIManager._instance.ShowCoinText(UIManager._instance.coinGamePlayText, currentCoin);
        //UIManager._instance.UpdateLife(_life);
        //StartGame();
    }
    public void StartGame(Vector3 scale, Vector3 pos, int level, int levelTarget)
    {
        _totalGoblinKilled = 0;
        LevelManagerHeroRescues._instance.LoadLevel(scale, pos,level, levelTarget,gameObject.transform);
        if (GameObject.FindGameObjectWithTag("Goblin") != null)
            _totalGoblin = GameObject.FindGameObjectsWithTag("Goblin").Length;
    }
    public void AddCoin(int add)
    {
        //currentCoin += add;
        //UIManager._instance.ShowCoinText(UIManager._instance.coinGamePlayText, currentCoin);
    }    

    public void GameOver()
    {
        if (isGameOver)
            return;
        isGameOver = true;
        //LevelManager.Instance.PreFailed();
        //UIManager._instance.ShowGameOver();
        LevelManager.Instance.CheckWinLose();
    }

    public void GameWin()
    {
        if (isGameWin)
            return;
        isGameWin = true;
        LevelManager.Instance.CheckWinLose();
        //UIManager._instance.ShowGameClear();
    }

    public void ResetPara()
    {
        isGameWin = false;
        isGameOver = false;
    }

    public void ResetCollision()
    {
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Hero"), LayerMask.NameToLayer("Goblin"),false);
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Hero"), LayerMask.NameToLayer("Lava"),false);
    }    
}
