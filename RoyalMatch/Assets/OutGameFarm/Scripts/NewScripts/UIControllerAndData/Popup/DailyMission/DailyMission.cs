using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class DailyMission : MonoBehaviour
{
    public RectTransform Rectcontent;
    public List<DailyQuest> _listDailyQuest;
    public List<DailyQuest> _DailyQuestsToday = new List<DailyQuest>();
    public ItemDailyMission ItemDailyMission;
    private List<GameObject> _listItemDailyMission = new List<GameObject>();
    private int numberOfQuestsToDay = 6;
    private DateTime previousDate;
    private string PREVIODATE = "previousDate";
    public DailyMissionPopup _dailyMissionPopup;
    private GeneralBalance _generalBalance;
    public Currencies previousWarehouseCurrencies;
    [SerializeField] private TMP_Text countdownText;
    public event Action<int> EventMissionPassted;
    private int _missionPassed;

    private void Awake()
    {
        _generalBalance = _dailyMissionPopup.gameData.GeneralBalance;
        previousWarehouseCurrencies = new Currencies(_generalBalance.WarehouseCurrencies);
        GeneralMission();
        InvokeRepeating("UpdateCountdownTime",1f,1f);
    }

    public void GeneralMission()
    {
        CheckDay();
        UpdateCountdownTime();
        if (DateTime.Now.Date > previousDate)
        {
            UpdateListQuest();
            PlayerPrefs.SetFloat(PREVIODATE,DateTime.Now.Date.Ticks);
        }
        else
        {
            if (PlayerPrefs.HasKey("DailyQuestList"))
            {
                string questListJson = PlayerPrefs.GetString("DailyQuestList");
                DailyQuestListData questListWrapper = JsonUtility.FromJson<DailyQuestListData>(questListJson);
                _DailyQuestsToday = questListWrapper.questList;
            }
            else
            {
                _DailyQuestsToday = new List<DailyQuest>();
                int listCount = _listDailyQuest.Count;
                List<int> randomIndices = new List<int>();
                for (int i = 0; i < numberOfQuestsToDay && i < _listDailyQuest.Count; i++)
                {
                    int randomIndex = Random.Range(0, listCount);
                    while (randomIndices.Contains(randomIndex))
                    {
                        randomIndex = Random.Range(0, listCount);
                    }
                    randomIndices.Add(randomIndex);

                    _DailyQuestsToday.Add(_listDailyQuest[randomIndex]);
                }    
            }
            
        }
        if (_listItemDailyMission.Count <= 0)
        {
            Init();
        }
    }

    private void RewardItemDaily(ItemDailyMission itemDailyMission)
    {
        OnItemComplete(itemDailyMission);
        var item = itemDailyMission._DailyQuest;
        var questGoal = item.QuestGoal;
        var amount = questGoal.CurrentAmount;
        foreach (var itemNotComplete in _listItemDailyMission)
        {
            var subItem = itemNotComplete.GetComponent<ItemDailyMission>();
            var subQuest = subItem._DailyQuest;
            

            if (subItem._DailyQuest.NameQuest != itemDailyMission._DailyQuest.NameQuest)
            {
                if (!subItem._DailyQuest.isclaim)
                {
                    if (subQuest.QuestGoal.unit == questGoal.unit)
                    {
                        int difference = subQuest.QuestGoal.CurrentAmount - amount;
                        subQuest.QuestGoal.CurrentAmount -= questGoal.CurrentAmount;
                        if (subQuest.QuestGoal.CurrentAmount < 0)
                        {
                            subQuest.QuestGoal.CurrentAmount = 0;
                        }
                        subItem.UpdateUI();
                        amount -= difference;
                        if (amount <= 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
        _missionPassed += 1;
        EventMissionPassted?.Invoke(_missionPassed);
        //UpdateUI();
    }
    private void OnEnable()
    {
        if (_listItemDailyMission.Count <= 0)
        {
            Init();
        }
    }
    private void CheckDay()
    {
        if (PlayerPrefs.HasKey("PreviousDate"))
        {
            float ticks = PlayerPrefs.GetFloat(PREVIODATE);
            previousDate = new DateTime((long)ticks);
        }
        else
        {
            previousDate = DateTime.Now.Date;
            PlayerPrefs.SetFloat("PreviousDate", previousDate.Ticks);
        }
    }
    private void UpdateCountdownTime()
    {
        TimeSpan timeRemaining = DateTime.Today.AddDays(1) - DateTime.Now;
        string countdownTimeString = $"{timeRemaining.Hours:D2}h{timeRemaining.Minutes:D2}m";
        countdownText.text = countdownTimeString;
    }

    private void Init()
    {
        DestroyListMission();
        for (int i = 0; i < _DailyQuestsToday.Count; i++)
        {
            if (i >= _DailyQuestsToday.Count)
            {
                break;
            }

            DailyQuest dailyQuest = _DailyQuestsToday[i];
            var item = Instantiate(ItemDailyMission, Rectcontent);
            item.Init(dailyQuest);
            item.EventReward += RewardItemDaily;
            _listItemDailyMission.Add(item.gameObject);
        }
        SaveDailyQuestList(_DailyQuestsToday);
    }

    private void OnItemComplete(ItemDailyMission completedItem)
    {
        
        int completedIndex = _listItemDailyMission.IndexOf(completedItem.gameObject);

        if (completedIndex >= 0)
        {

            var completedObject = _listItemDailyMission[completedIndex];
            var itemcopy = completedItem._DailyQuest;
            Destroy(completedObject);
            _listItemDailyMission.RemoveAt(completedIndex);
            var item = Instantiate(ItemDailyMission, Rectcontent);
            item.Init(itemcopy);
            item._DailyQuest =itemcopy;

            _listItemDailyMission.Add(item.gameObject);

         //   UpdateUI();
        }
    }
    private void UpdateUI()
    {
        foreach (var t in _listItemDailyMission)
        {
            Destroy(t);
        }


        for (int i = 0; i < _listItemDailyMission.Count; i++)
        {
            GameObject itemObject = _listItemDailyMission[i];
            var item = Instantiate(ItemDailyMission, Rectcontent);
            item.transform.SetSiblingIndex(i);
            item.Init(itemObject.GetComponent<ItemDailyMission>()._DailyQuest);
        }
    }

    [Button]
    public void UpdateListQuest()
    {
        _DailyQuestsToday = new List<DailyQuest>();
        for (int i = 0; i < numberOfQuestsToDay && i < _listDailyQuest.Count; i++)
        {
            _DailyQuestsToday.Add(_listDailyQuest[i]);
        }
        ShuffleList(_DailyQuestsToday);
        Init();
        
        SaveDailyQuestList(_DailyQuestsToday);
    }
    private void SaveDailyQuestList(List<DailyQuest> questList)
    {
        string questListJson = JsonUtility.ToJson(new DailyQuestListData(questList));
        PlayerPrefs.SetString("DailyQuestList", questListJson);
        PlayerPrefs.Save();
    }

    private void DestroyListMission()
    {
        foreach (var t in _listItemDailyMission)
        {
            Destroy(t);
        }

        _listItemDailyMission.Clear();
    }

    private void ShuffleList<T>(List<T> list)
    {
        int n = list.Count;
        System.Random random = new System.Random();

        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            (list[k], list[n]) = (list[n], list[k]);
        }
    }

    public void HandleWarehouseCurrenciesChangedEvent(Currencies currencies)
    {
        foreach (var itemdaily in _listItemDailyMission )
        {
            var item = itemdaily.GetComponent<ItemDailyMission>();
            var quest = item._DailyQuest;
            if (!quest.isCompleted)
            {
                var questGoal = quest.QuestGoal;
                var initialGoal = GetInitialGoal(quest.TypeDailyMission);

                if (initialGoal != null )
                {
                    Debug.Log(item._DailyQuest.NameQuest+(int)currencies.GetCurrency(questGoal.unit).Amount);
                    questGoal.CurrentAmount += (int)currencies.GetCurrency(questGoal.unit).Amount;
                    item.UpdateUI();
                    if (questGoal.IsReached())
                    {
                        item.Complete();
                        //UpdateUI();
                    }
                }
            }
        }
        previousWarehouseCurrencies = new Currencies(currencies);
    }
    private QuestGoal GetInitialGoal(TypeDailyMission type)
    {
        var quest = _DailyQuestsToday.Find(q => q.TypeDailyMission == type);

        if (quest != null)
        {
            return quest.QuestGoal;
        }

        return null;
    }
}