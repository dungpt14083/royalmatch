using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Helper
{
    public static IEnumerator LoadAvatar(string url, Image avatar)
    {
        if (url == "")
        {
            if (avatar != null) avatar.sprite = null;
            yield return null;
        }
        else
        {
            WWW www = new WWW(url);
            yield return www;
            
            if (www == null || www.texture == null)
            {
                Debug.Log("www == null || www.texture == null");
                if (avatar != null) avatar.sprite = null;
                yield return null;
            }
            else
            {
                Texture2D profilePic = www.texture;
                avatar.sprite = Sprite.Create(profilePic, new Rect(0, 0, profilePic.width, profilePic.height),Vector2.zero);
            }
        }
    }
}

