using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScripableSingleton<T> : ScriptableObject where T : ScriptableObject
{
    private static T instance = null;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = Resources.Load<T>(typeof(T).Name);

                if (instance == null)
                {
                    Debug.LogError("Could not find an instance of " + typeof(T).Name + " in resources.");
                }
            }

            return instance;
        }
    }
}