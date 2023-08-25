using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    private bool isDone;
    public Image icon;
    public TMP_Text txtCount;
    public GameObject check;
    public TargetInfo info;
    public void Init(TargetInfo _info)
    {
        info = _info;
        icon.sprite = GetSprIcon();
        UpdateUI();
    }
    public void UpdateUI()
    {
        if(info.count > 0)
        {
            check.SetActive(false);
            txtCount.gameObject.SetActive(true);
            txtCount.text = info.count.ToString();
        }
        else
        {
            check.SetActive(true);
            txtCount.gameObject.SetActive(false);
        }
    }
    public void OffSet(int offset)
    {
        if (info.count > 0) info.count += offset;
        if (info.count < 1) CompleteTarget();
        else isDone = false;
        UpdateUI();
    }
    public void CompleteTarget()
    {
        isDone = true;
        
    }
    public bool IsDone()
    {
        return isDone;
    }
    public Sprite GetSprIcon()
    {
        switch (info.targetType)
        {
            case TargetTypes.CollectItem:
                var item = LevelManager.Instance.GetItemByType(info.itemsType);
                return item?.GetTargetIcon();
            case TargetTypes.CollectObstacle:
                var obstacle = LevelManager.Instance.GetObstacleByType(info.obstacleType);
                return obstacle?.GetTargetIcon();
        }
        return null;
    }
    public void Collect()
    {
        OffSet(-1);
    }
}
