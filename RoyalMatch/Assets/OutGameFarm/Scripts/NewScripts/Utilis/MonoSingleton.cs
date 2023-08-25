using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _Instance;

    [SerializeField] private bool isDontDestroyOnLoad;

    public static T Instance
    {
        get
        {
            if (!_Instance)
            {
                Debug.Log($"Dont has InstanceOf {typeof(T).Name} class");
                _Instance = FindObjectOfType<T>();
                if (!_Instance)
                {
                    _Instance = new GameObject(typeof(T).Name + " Singleton").AddComponent<T>();
                }
            }
            return _Instance;
        }
    }

    protected virtual void Awake()
    {
        if (!_Instance)
        {
            _Instance = this as T;
        }

        if (isDontDestroyOnLoad)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
