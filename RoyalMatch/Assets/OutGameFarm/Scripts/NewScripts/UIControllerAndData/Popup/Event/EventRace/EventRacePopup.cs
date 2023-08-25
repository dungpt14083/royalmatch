using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRacePopup : Popup
{
    [SerializeField]private List<RaceScript> ListData;
    [SerializeField] private ItemEventRace _itemEventRace;
    [SerializeField] private RectTransform content;
    [SerializeField] private PopupDetailEventRank _detailEventRank;
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        base.Init(game, isLandInfo);
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        EventRaceRequestPopup eventRaceRequestPopup = GetRequest<EventRaceRequestPopup>();
        InitData();
    }

    private void InitData()
    {
        SetDefault();
        int reward= Random.Range(10, 20);
        for (int i = 0; i < ListData.Count; i++)
        {
            RaceScript race = ListData[i];
            race.currentProgress = Random.Range(1, 25);
            race.namePlayer = "player" + i;
            race.reward = reward;

        }
        ListData.Sort((race1, race2) => race2.currentProgress.CompareTo(race1.currentProgress));
        foreach (RaceScript race in ListData)
        {
            var item = Instantiate(_itemEventRace, content);
            item.Init(race,_detailEventRank);
            item.OnFreeButtonClicked += ShowPopupDetail;
        }

    }
    private void SetDefault()
    {
        for (int i = content.childCount - 1; i >= 0; i--)
        {
            if (content.GetChild(i) != null)
            {
                Destroy(content.GetChild(i).gameObject);
            }
        }
    }
    public void ShowPopupDetail(string desc,Sprite icon,int reward)
    {
        bool isActive = _detailEventRank.gameObject.activeSelf;
        _detailEventRank.gameObject.SetActive(!isActive);
        _detailEventRank.Init(desc,icon,reward);
    }

    public void ActivePopupDetail()
    {
        bool isActive = _detailEventRank.gameObject.activeSelf;
        _detailEventRank.gameObject.SetActive(!isActive);
    }
}
