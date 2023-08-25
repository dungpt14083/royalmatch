using System.Linq;
using UnityEngine;

public abstract class ScriptableResourcesSingleton<T> : ScriptableObject where T : ScriptableObject
{
    private static T _Instance;
    private static bool _IsInitialized;

    public static T GetInstance()
    {
        if (!_IsInitialized)
        {
            string text = "ShopDatas\\";
            var temps = Resources.Load<T>(text + "ShopDatas");
            _Instance = temps as T;
            _IsInitialized = true;
        }

        return _Instance;
    }
}