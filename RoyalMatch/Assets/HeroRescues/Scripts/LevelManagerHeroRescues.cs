using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerHeroRescues : MonoBehaviour
{

    public static LevelManagerHeroRescues _instance;
    public LevelHeroRescues currentLevelObj;
    public int currentLevel;

    public enum LEVEL_TYPE
    {
        COIN,
        BIG_COIN,
        GOBLIN,
        PRINCESS
    };

    public LEVEL_TYPE[] levelTypeLst;
    

    private void Awake()
    {
        _instance = this;
        //LoadLevel();
    }

    public void LoadLevel(Vector3 scaleXY, Vector3 _pos ,int _currentLevel = 1,int targetLevel = 1, Transform parent = null)
    {
        //currentLevel = PlayerPrefs.GetInt("CurrentLevel");
        Debug.Log("LoadLevel " + currentLevel);
        currentLevel = _currentLevel;
        currentLevelObj = Instantiate(Resources.Load<LevelHeroRescues>("levels/Level " + currentLevel.ToString()), _pos, Quaternion.identity, parent);
        currentLevelObj.transform.localScale = scaleXY;
        var TargetLevel = Resources.Load<JellyGarden.Scripts.Targets.TargetLevel>("Targets/miniGameLevelTarget" + targetLevel);
        currentLevelObj.SetTargetInfos(TargetLevel.targets);
    }

    public void CleanLevel()
    {
        Destroy(currentLevelObj);
        LevelPool._instance.CleanAlllObjects();
    }    
}
