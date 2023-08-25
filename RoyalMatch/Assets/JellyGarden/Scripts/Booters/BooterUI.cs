using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BooterUI : MonoBehaviour
{
    [SerializeField]
    private Sprite[] ions;
    public Image icon;
    public TMP_Text count;
    public Button btPlus;
    public Button btUse;
    private BooterInfo info;
    public void Init(BooterInfo _info)
    {
        info = _info;
        icon.sprite = GetSpriteByBooterType(info.booterType);
        btPlus.onClick.AddListener(PlusClick);
        btUse.onClick.AddListener(Use);
        UpdateUI();
    }
    public void OffSet(int offset)
    {
        info.count += offset;
        UpdateUI();
    }
    public Sprite GetSpriteByBooterType(BootersType boostType)
    {
        int index = (int)boostType;
        if (ions.Length == 0 || index < 1 || index >= ions.Length) return null;
        return ions[index-1];
    }
    private void UpdateUI()
    {
        if (info.count > 0)
        {
            count.gameObject.SetActive(true);
            btPlus.gameObject.SetActive(false);
            count.text = info.count.ToString();
        }
        else
        {
            count.gameObject.SetActive(false);
            btPlus.gameObject.SetActive(true);
        }
    }
    public void PlusClick()
    {
        //Todo : show shop booster
    }
    public void Use()
    {
        if (info.count < 1) return;
        LevelManager.Instance.bootersController.SelectBooter(info.booterType);
        //switch (info.booterType)
        //{
        //    case BootersType.Arrow:
        //        break;
        //    case BootersType.Cannon:

        //        break;
        //    case BootersType.Hammer:

        //        break;
        //    case BootersType.JesterHat:
        //        break;
        //}
    }
}
