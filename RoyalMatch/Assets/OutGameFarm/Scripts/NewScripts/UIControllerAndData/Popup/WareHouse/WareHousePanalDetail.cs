using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WareHousePanalDetail : MonoBehaviour
{
    [SerializeField] private WareHousePopup _wareHousePopup;
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private TMP_Text txtContent;
    [SerializeField] private Button btnFind;
    private KeyValuePair<EntityCurrencyProperties, long> _Data;
    public delegate void OnPopupActiveChanged(bool active);
    public event OnPopupActiveChanged PopupActiveChanged;
    public void Init(KeyValuePair<EntityCurrencyProperties, long>  data)
    {
        _Data = data;
        txtName.text = data.Key.NameItem;
    }

    public void ClosePopup()
    {
        bool isActive = this.gameObject.activeSelf;
        this.gameObject.SetActive(!isActive);
        PopupActiveChanged?.Invoke(isActive);
    }


}
