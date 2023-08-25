
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemEventRace : MonoBehaviour
{
    [SerializeField] private Image borderAvatar;
    [SerializeField] private Image iconAvatar;
    [SerializeField] private Image borderName;
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private TMP_Text txtProgress;
    [SerializeField] private Slider sliderProgress;
    [SerializeField] private Button btnReward;
    private PopupDetailEventRank panalDetail;
    private RaceScript _race;
    
    public delegate void FreeButtonClickedHandler(string desc,Sprite icon,int reward);
    public event FreeButtonClickedHandler OnFreeButtonClicked;
  
    public void RaiseFreeButtonClickedEvent(string desc,Sprite icon,int reward)
    {
        if (OnFreeButtonClicked != null)
        {
            OnFreeButtonClicked(desc,icon,reward);
        }
    }
    
    public void Init(RaceScript race,PopupDetailEventRank detailEventRank)
    {
        btnReward.onClick.RemoveAllListeners();
        btnReward.onClick.AddListener(OnDetail);
        panalDetail = detailEventRank;
        _race = race;
        borderAvatar.sprite = _race.borderAvatar;
        iconAvatar.sprite = _race.iconAvatar;
        borderName.sprite = _race.borderName;
        txtName.text = _race.namePlayer;
        txtProgress.text = _race.currentProgress.ToString();
        sliderProgress.maxValue = _race.GetMaxProgress();
        sliderProgress.value = _race.currentProgress;
    }
    public void OnDetail()
    {
        RaiseFreeButtonClickedEvent(_race.descDetail, _race.sprRewardDetail, _race.reward);
        Vector3 pos = btnReward.transform.position;
        pos = new Vector3(pos.x, pos.y + 100, pos.z);
        panalDetail.transform.position = pos;
    }
}
