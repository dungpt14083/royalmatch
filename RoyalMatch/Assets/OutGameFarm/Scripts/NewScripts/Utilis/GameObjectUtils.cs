using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectUtils
{
    public static void ClearAllChild(this Transform parent)
    {
        foreach(Transform child in parent)
        {
            GameObject.Destroy(child.gameObject);
        }
    }
    public static T CreateChild<T>(this Transform parent, T prefab) where T : MonoBehaviour
    {
        var obj = GameObject.Instantiate<T>(prefab, parent);
        return obj;
    }
}
