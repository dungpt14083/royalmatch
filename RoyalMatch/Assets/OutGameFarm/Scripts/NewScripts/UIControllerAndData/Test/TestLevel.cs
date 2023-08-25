using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestLevel : MonoBehaviour
{
    public Button btLevelUp;
    public Button btLevelDown;

    private void Start()
    {
        btLevelUp.onClick.AddListener(() => FarmMapController.Instance.UpLevelPlayer());
        btLevelDown.onClick.AddListener(() => FarmMapController.Instance.DownLevelPlayer());
    }
}
