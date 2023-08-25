using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonMonobehaviour<T> : MonoBehaviour where T : SingletonMonobehaviour<T>
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if ((Object)_instance == (Object)null)
            {
                if (!Object.FindObjectOfType(typeof(T)))
                {
                    Debug.LogWarning("Make sure there is one instance of " + typeof(T).Name + " in the current scene.");
                }
                else
                {
                    if (Application.isEditor)
                    {
                        Debug.LogError("_instance is null. Did you implement Awake() without override?");
                        return Object.FindObjectOfType(typeof(T)) as T;
                    }

                    Debug.LogError("Please do not call " + typeof(T).Name + " in Awake()");
                }
            }

            return _instance;
        }
    }

    public static bool HasInstance
    {
        get { return (Object)_instance != (Object)null; }
    }

    protected virtual void Awake()
    {
        _instance = (T)this;
    }

    protected virtual void OnDestroy()
    {
        _instance = (T)null;
    }
}