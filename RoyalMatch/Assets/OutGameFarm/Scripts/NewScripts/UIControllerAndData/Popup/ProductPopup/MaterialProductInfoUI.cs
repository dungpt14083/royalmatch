using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MaterialProductInfoUI : MonoBehaviour
{
    [SerializeField] private Image iconMaterial;
    [SerializeField] private TMP_Text txtRequireInfo;
    [SerializeField] private Button btFind;

    private void Awake()
    {
        btFind.onClick.AddListener(Find);
    }
    public void Show(Currency material)
    {
        gameObject.SetActive(true);
        iconMaterial.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(material.Name));
        var currentCountMerterial = FarmMapController.Instance.GetGeneralBalanceByKey(material.Name);
        string color = currentCountMerterial < material.Amount ? "red" : "green";
        txtRequireInfo.text = $"<color={color}>{currentCountMerterial}</color>/{material.Amount}";
        // thiếu nguyên liệu thì hiện nút tìm kiếm
        btFind.gameObject.SetActive(currentCountMerterial < material.Amount);
    }
    public void Find()
    {

    }
}
