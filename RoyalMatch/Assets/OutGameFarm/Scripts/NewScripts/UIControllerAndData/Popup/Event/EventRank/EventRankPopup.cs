using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRankPopup : Popup

{
    [SerializeField] private itemEventRank _itemEventRank;
    public List<EventRank> ListData;
    [SerializeField] private RectTransform Content;
    [SerializeField] private PopupDetailEventRank panalDetail;
    [SerializeField] private Sprite sprRank1, sprRank2, sprRank3, sprRank4, sprRank5;
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        base.Init(game, isLandInfo);
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        EventRankRequestPopup eventRankRequestPopup = GetRequest<EventRankRequestPopup>();
        InitData();
    }

    private void InitData()
    {
        SetDefault();
        for (int i = 0; i < ListData.Count; i++)
        {
            EventRank eventRank = ListData[i]; 
            eventRank.NamePlayer = "namePlayer" + i.ToString();
            eventRank.count = Random.Range(10, 20);
            eventRank.countDetail = Random.Range(1, 20);
            
        }
        ListData.Sort((rank1, rank2) => rank2.count.CompareTo(rank1.count));
        for (int i = 0; i < ListData.Count; i++)
        {
            EventRank eventRank = ListData[i];
            eventRank.RankPlayer = i + 1;
            switch (eventRank.RankPlayer)
            {
                case 1:
                    eventRank.IconRank = sprRank1;
                    break;
                case 2:
                    eventRank.IconRank = sprRank2;
                    break;
                case 3:
                    eventRank.IconRank = sprRank3;
                    break;
                case 4:
                    eventRank.IconRank = sprRank4;
                    break;
                case 5:
                    eventRank.IconRank = sprRank5;
                    break;
                default:
                    eventRank.IconRank = sprRank5;
                    break;
            }
            
        }
        int num = 0;
        foreach (EventRank eventRank in ListData)
        {
            if(num>=5)continue;
            var tmp = Instantiate(_itemEventRank, Content);
            tmp.Init(eventRank,panalDetail);
            tmp.OnFreeButtonClicked += ShowPopupDetail;
            num++;
        }

    }
    private void SetDefault()
    {
        for (int i = Content.childCount - 1; i >= 0; i--)
        {
            if (Content.GetChild(i) != null)
            {
                Destroy(Content.GetChild(i).gameObject);
            }
        }
    }

    public void ShowPopupDetail(string desc,Sprite icon,int reward)
    {
        bool isActive = panalDetail.gameObject.activeSelf;
        panalDetail.gameObject.SetActive(!isActive);
        panalDetail.Init(desc,icon,reward);
    }

    public void ActivePopupDetail()
    {
        bool isActive = panalDetail.gameObject.activeSelf;
        panalDetail.gameObject.SetActive(!isActive);
    }
    
}
