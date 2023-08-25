using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinLosePopup : MonoBehaviour
{
    public TMP_Text txtStatus;
    
    public void Show(string status = "")
    {
        gameObject.SetActive(true);
        txtStatus.text = status;
    }
}
