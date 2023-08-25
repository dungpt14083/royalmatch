using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Loader.LoadScene(new WelcomeSceneRequest());
    }
}