using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//REQUESST CHO VIỆC MỞ SCENE NÀO
public abstract class SceneRequest
{
    public abstract string SceneName { get; set; }

    //LOADING SCENE TÊN LÀ ĐÊ TRUNG GIAN LOADING:::
    public virtual string LoaderSceneName
    {
        get { return "FirstLoading"; }
    }

    public virtual string ResourceSceneName
    {
        get { return null; }
    }

    //% LOADING BAO NHIÊU % RỒI
    public abstract float LoadingWeight { get; }

    public float Progress { get; protected set; }

    public bool HasCompleted { get; protected set; }

    public SceneRequest()
    {
        Progress = 0f;
        HasCompleted = false;
    }

    public abstract IEnumerator LoadDuringSceneSwitch();
}