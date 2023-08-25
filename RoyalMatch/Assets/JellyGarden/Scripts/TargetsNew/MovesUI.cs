using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovesUI : MonoBehaviour
{
    private int count;
    public TMP_Text txtCount;
    public void Init(int _count)
    {
        count = _count;
        UpdateUI();
    }
    public void UpdateUI()
    {
        txtCount.text = count.ToString();
    }
    public void OffSet(int offset)
    {
        if (count < 1) return;
        count += offset;
        if (count < 0) count = 0;
        UpdateUI();
    }
    public int GetCount()
    {
        return count;
    }
}
