using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class itemEventRank : MonoBehaviour
{
    [SerializeField] private Image iconRank;
    [SerializeField] private Image iconAvatar;
    [SerializeField] private TMP_Text txtName;
    [SerializeField] private TMP_Text txtCount;
    [SerializeField] private PopupDetailEventRank groupDetail;
    [SerializeField] private Image iconRewardDetail;
    [SerializeField] private TMP_Text txtCountDetail;
    [SerializeField] private TMP_Text txtContentDetail;
    [SerializeField] private Button btnDetail;

    private EventRank _eventRank;

    public delegate void FreeButtonClickedHandler(string desc,Sprite icon,int reward);
    public event FreeButtonClickedHandler OnFreeButtonClicked;
  
    public void RaiseFreeButtonClickedEvent(string desc,Sprite icon,int reward)
    {
        if (OnFreeButtonClicked != null)
        {
            OnFreeButtonClicked(desc,icon,reward);
        }
    }
    public void Init(EventRank eventRank,PopupDetailEventRank detailEventRank)
    {
        
        btnDetail.onClick.RemoveAllListeners();
        btnDetail.onClick.AddListener(OnDetail);
        _eventRank = eventRank;
        groupDetail = detailEventRank;
        iconRank.sprite = _eventRank.IconRank;
        iconAvatar.sprite = _eventRank.AvatarPlayer;
        txtName.text = _eventRank.NamePlayer;
        txtCount.text = _eventRank.count.ToString();
        iconRewardDetail.sprite = _eventRank.iconDetail;
        txtCountDetail.text = _eventRank.countDetail.ToString();
        txtContentDetail.text = _eventRank.contentDetail;
    }

    public void OnDetail()
    {
        RaiseFreeButtonClickedEvent(_eventRank.contentDetail, _eventRank.iconDetail, _eventRank.countDetail);
        Vector3 pos = btnDetail.transform.position;
        pos = new Vector3(pos.x, pos.y + 100, pos.z);
        groupDetail.transform.position = pos;
    }

}
