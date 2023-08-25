using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DaillyRewardsInterface : MonoBehaviour
{
    public DaillyRewardPopup DaillyRewardPopup;
    public GameObject dailyRewardPrefab;
    public GeneralBalance _generalBalance;
    [Header("Progress Bar")] public Slider progressSlider;
    private DateTime startDate;
    private DateTime currentDay;
    public TMP_Text txt_textProgress;
    public ItemRewardProgressDays itemReward;
    private List<ItemRewardProgressDays> _listItemRewardProgressDays = new List<ItemRewardProgressDays>();

    [Header("Panel Reward Message")] public GameObject panelReward;
    public TMP_Text textReward;
    public Button buttonCloseReward;
    public Image imageReward;
    public Button btndebug;

    [Header("Panel Reward")] public Button buttonClaim;
    public Button buttonClose;
    public Button buttonCloseWindow;
    public Text textTimeDue;
    public GridLayoutGroup dailyRewardsGroup;
    private List<Sprite> SpritesDay7 = new List<Sprite>();
    public List<Image> ListspriteDays7;

    private bool readyToClaim;
    public List<DaillyRewardItem> dailyRewardsUI;
    public DaillyRewardItem DaillyRewardItemDay7;

    private TypePopupDailyRewardInterface _typePopup;

    private DailyRewards dailyRewards;
    private DaillyReward30Days _dailyReward30Days;

    void Awake()
    {
        dailyRewards = GetComponent<DailyRewards>();
        _dailyReward30Days = GetComponent<DaillyReward30Days>();
    }

    void Start()
    {
        InitializeDailyRewardsUI();
        InitDally30dayUI();
        DaillyRewardPopup = gameObject.transform.parent.GetComponent<DaillyRewardPopup>();
        _generalBalance = DaillyRewardPopup.GameData.GeneralBalance;
        buttonClaim.onClick.AddListener(() =>
        {
            //phần nhận thưởng của ngày thường và ngày thứ 7 khác nhau
            if (readyToClaim)
            {
                dailyRewards.ClaimPrize();
                readyToClaim = false;
                UpdateUI();
            }
            else if (DaillyRewardItemDay7.state == DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE)
            {
                ClaimDay7Reward();
            }
        });

        btndebug.onClick.AddListener(DebugTime);
        buttonCloseReward.onClick.AddListener(() =>
        {
            var keepOpen = dailyRewards.keepOpen;
            panelReward.SetActive(false);
            //    DaillyRewardPopup.OnCloseClicked();
            //     canvas.gameObject.SetActive(keepOpen);
        });


        UpdateUI();
    }

    void OnEnable()
    {
        dailyRewards.onClaimPrize += OnClaimPrize;
        dailyRewards.onInitialize += OnInitialize;
        _dailyReward30Days.oncompleteWeed += ResetReward;
        _dailyReward30Days.CheckLogin();
        UpdateUI();
    }

   

    void OnDisable()
    {
        if (dailyRewards != null)
        {
            dailyRewards.onClaimPrize -= OnClaimPrize;
            dailyRewards.onInitialize -= OnInitialize;
            UpdateUI();
        }

        _dailyReward30Days.oncompleteWeed += ResetReward;
        _dailyReward30Days.CheckLogin();
    }

    //khởi tạo UI phần thưởng 30days
    private void InitDally30dayUI()
    {
        _dailyReward30Days.CheckLogin();
        for (int i = 0; i < _dailyReward30Days._listReward30day.Count; i++)
        {
            var reward = _dailyReward30Days._listReward30day[i];
            intiReward30Days(reward);
            _listItemRewardProgressDays[i].onClaimPrize += Claim30Days;
        }
    }

    //khởi tạo UI các ngày hiển thị day , sprite , int reward
    private void InitializeDailyRewardsUI()
    {
        for (int i = 0; i < dailyRewards.rewards.Count; i++)
        {
            int day = i + 1;
            var reward = dailyRewards.GetReward(day);
            dailyRewardsUI[i].Init(day, reward);
        }

        InitDailyReward7();
    }

    //khởi tạo đối với ngày thứ 7
    private void InitDailyReward7()
    {
        int day = 7;
        List<RewardDailyReward> rewards = new List<RewardDailyReward>();
        for (int i = 0; i < dailyRewards.RewardsDay7.Count; i++)
        {
            rewards.Add(dailyRewards.RewardsDay7[i]);
        }

        DaillyRewardItemDay7.InitDay7(day, rewards);
    }

    public void UpdateUI()
    {
        dailyRewards.CheckRewards(); // kiểm tra trạng thái phần thưởng

        bool isRewardAvailableNow = false;

        var lastReward = dailyRewards.lastReward; // đã nhận
        var availableReward = dailyRewards.availableReward; //có sẵn

        // đây là phần thưởng 30 ngày
        progressSlider.value = _dailyReward30Days.dayPassed;

        for (int i = 0; i < _dailyReward30Days._listReward30day.Count(); i++)
        {
            if (progressSlider.value == _dailyReward30Days._listReward30day[i].day &&
                _dailyReward30Days.isClaim == true)
            {
                ItemRewardProgressDays itemRewardProgressDays = _listItemRewardProgressDays[i];
                // for (int j = 0; j < _listItemRewardProgressDays.Count; j++)
                // {
                   
                    if (itemRewardProgressDays.day == _dailyReward30Days._listReward30day[i].day)
                    {
                        CheckClaim(itemRewardProgressDays);
                    }
              //  }
            }
        }

        txt_textProgress.text = String.Format("{0}/30", progressSlider.value);
        //end phần thưởng 30 ngày

        foreach (var dailyRewardUI in dailyRewardsUI)
        {
            var day = dailyRewardUI.day;

            if (day == availableReward)
            {
                dailyRewardUI.state = DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE;

                isRewardAvailableNow = true; // phần thưởng hiện tại có thể nhận
            }
            else if (day <= lastReward)
            {
                dailyRewardUI.state = DaillyRewardItem.DailyRewardState.CLAIMED;
            }
            else if (day > availableReward && day < lastReward)
            {
                dailyRewardUI.state =
                    DaillyRewardItem.DailyRewardState.SKIPPED; //phần thưởng bị bỏ qua nhưng đã xóa case này
            }
            else
            {
                dailyRewardUI.state = DaillyRewardItem.DailyRewardState.UNCLAIMED_UNAVAILABLE;
            }

            dailyRewardUI.Refresh(); // F5 lại giao diện
        }

        //đoạn này là check trạng thái của riêng ngày thứ 7
        if (availableReward >= 7)
        {
            DaillyRewardItemDay7.state = DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE;
            isRewardAvailableNow = true;
        }
        else if (7 < lastReward + 1)
        {
            DaillyRewardItemDay7.state = DaillyRewardItem.DailyRewardState.CLAIMED;
        }
        else
        {
            DaillyRewardItemDay7.state = DaillyRewardItem.DailyRewardState.UNCLAIMED_UNAVAILABLE;
        }

        DaillyRewardItemDay7.Refresh();
        //end
        bool isDay7RewardAvailable =
            DaillyRewardItemDay7.state == DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE;
        buttonClaim.gameObject.SetActive(isRewardAvailableNow || isDay7RewardAvailable);
        if (isRewardAvailableNow)
        {
            SnapToReward();
        }

        readyToClaim = isRewardAvailableNow;
    }

    public void SnapToReward()
    {
        var lastRewardIdx = dailyRewards.lastReward;
        if (lastRewardIdx >= dailyRewardsUI.Count)
            lastRewardIdx = dailyRewardsUI.Count - 1;
        if (lastRewardIdx < 6 && DaillyRewardItemDay7.state == DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE)
            lastRewardIdx = 6;
        lastRewardIdx = Mathf.Clamp(lastRewardIdx, 0, dailyRewardsUI.Count - 1);
    }


    void Update()
    {
        dailyRewards.TickTime();
        // Updates the time due
        CheckTimeDifference();
        CheckTimeDifference30Day();
    }

    //check thời gian giữa lần nhận thưởng và hiện taại
    private void CheckTimeDifference()
    {
        if (!readyToClaim)
        {
            TimeSpan difference = dailyRewards.GetTimeDifference();

            // Nếu đồng hồ đếm nhỏ hơn hoặc bằng 0 thì có một phần thưởng mới để nhận
            if (difference.TotalSeconds <= 0)
            {
                readyToClaim = true;
                UpdateUI();
                SnapToReward();
                return;
            }
        }
    }

    private void CheckTimeDifference30Day()
    {
        string currentDate = System.DateTime.Now.ToString("dd/MM/yyyy");

        int timeDifference = _dailyReward30Days.GetTimeDifference(_dailyReward30Days.lastLoginDate, currentDate);
        if (timeDifference > 0)
        {
            _dailyReward30Days.CheckLogin();
            UpdateUI();
        }
    }

    // Delegate
    //invoke nhận thưởng
    private void OnClaimPrize(int day)
    {
        if (day == 7)
        {
            panelReward.SetActive(true);
            imageReward.gameObject.SetActive(false);
            var reward = dailyRewards.RewardsDay7;
            StringBuilder textBuilder = new StringBuilder();
            for (int i = 0; i < reward.Count; i++)
            {
                string rewardText =
                    string.Join(", ", reward[i].type.Select(type => type.ToString()).ToArray()); //name type
                var Reward = reward[i].reward; // int reward
                SpritesDay7.Add(reward[i].Sprite); // add sprite reward to list
                EarnCurrency(rewardText.ToLower(), Reward);
                textBuilder.AppendLine(rewardText + " + " + Reward);
            }

            for (int i = 0; i < ListspriteDays7.Count; i++) //set sprite to element
            {
                ListspriteDays7[i].gameObject.SetActive(true);
                ListspriteDays7[i].sprite = SpritesDay7[i];
            }

            textReward.text = textBuilder.ToString().Trim();
            StartCoroutine(ClosePopupAfter(1, TypePopupDailyRewardInterface.PanelReward));
        }
        else
        {
            panelReward.SetActive(true);
            imageReward.gameObject.SetActive(true);
            for (int i = 0; i < ListspriteDays7.Count; i++)
            {
                ListspriteDays7[i].gameObject.SetActive(false);
            }

            var reward = dailyRewards.GetReward(day);
            string rewardText = string.Join(", ", reward.type.Select(type => type.ToString()).ToArray());
            var unit = rewardText;
            var rewardQt = reward.reward;
            imageReward.sprite = reward.Sprite;
            EarnCurrency(rewardText.ToLower(), rewardQt);
            if (rewardQt > 0)
            {
                textReward.text = string.Format("You got {0} {1}!", reward.reward, unit);
            }
            else
            {
                textReward.text = string.Format("You got {0}!", unit);
            }

            // Lưu giá trị tiến trình vào PlayerPrefs
            PlayerPrefs.SetString("StartDate", startDate.ToString());
            int daysPassed = (currentDay - startDate).Days;
            int cappedDays = daysPassed % 30;
            PlayerPrefs.SetInt("CurrentDay", cappedDays);
            PlayerPrefs.Save();
            StartCoroutine(ClosePopupAfter(1, TypePopupDailyRewardInterface.PanelReward));
        }

        StartCoroutine(ClosePopupAfter(6, TypePopupDailyRewardInterface.DailyRewardPopup));
    }


    //nhân thưởng 7 ngày
    private void ClaimDay7Reward()
    {
        if (DaillyRewardItemDay7.state == DaillyRewardItem.DailyRewardState.UNCLAIMED_AVAILABLE)
        {
            OnClaimPrize(7);
            DaillyRewardItemDay7.state = DaillyRewardItem.DailyRewardState.CLAIMED;
            DaillyRewardItemDay7.Refresh();
        }
    }

    //Nhận thưởng 30 ngày 
    private void CheckClaim(ItemRewardProgressDays itemRewardProgressDays)
    {
        itemRewardProgressDays.isReward = false;
        itemRewardProgressDays.SaveIsReward(itemRewardProgressDays.isReward);
        itemRewardProgressDays.UpdateUI();

    }

    private void Claim30Days(ItemRewardProgressDays itemRewardProgressDays)
    {
        panelReward.SetActive(true);
        _dailyReward30Days.isClaim = false;
        imageReward.sprite = itemRewardProgressDays._reward30Days.SpriteReward;
        textReward.text = String.Format("You claim {0} : {1}", itemRewardProgressDays._reward30Days.unit,
            itemRewardProgressDays._reward30Days.reward);
        
        EarnCurrency(itemRewardProgressDays._reward30Days.unit.ToLower(), itemRewardProgressDays._reward30Days.reward);
        itemRewardProgressDays.isReward = true;
        itemRewardProgressDays.SaveIsReward(itemRewardProgressDays.isReward);
        itemRewardProgressDays.UpdateUI();
        StartCoroutine(ClosePopupAfter(1, TypePopupDailyRewardInterface.PanelReward));
    }

    //hàm này dùng đễ nhận thưởng giờ chỉ có tiền nên viết như này
    public void EarnCurrency(String name, int amount)
    {
        Currency currency = new Currency(name, amount);
        bool success = FarmMapController.Instance.EarnCurrencies(currency);
        Debug.Log(success ? "{0} gems đã được cộng vào hệ thống game." : "Không thể cộng 30 gems vào hệ thống game.");
    }

    private void OnInitialize(bool error, string errorMessage)
    {
        if (!error)
        {
            var showWhenNotAvailable = dailyRewards.keepOpen;
            var isRewardAvailable = dailyRewards.availableReward > 0;

            UpdateUI(); //update giao diện
            SnapToReward(); //di chuyển đ giao diện phần thưởng
            CheckTimeDifference(); // kiểm tra thời gian
        }
    }

    //cái này dùng để dev debug qua ngày khi xong sẽ ẩn đi
    private void DebugTime()
    {
        dailyRewards.debugTime = dailyRewards.debugTime.Add(new TimeSpan(1, 0, 0, 0));
        _dailyReward30Days.LoadDebugTime();
        UpdateUI();
    }

    //reward 30 days
    private void intiReward30Days(Reward30Days reward)
    {
        var itemRW = Instantiate(itemReward, progressSlider.transform);
        itemRW.name = "itemReward day" + reward.day;
        itemRW.gameObject.SetActive(true);
        itemRW.Init(reward.day, reward);
        float progressBarWidth = progressSlider.GetComponent<RectTransform>().rect.width;
        RectTransform itemRewardRectTransform = itemRW.GetComponent<RectTransform>();
        float handleRectPosition = reward.day / progressSlider.maxValue * progressBarWidth;
        itemRewardRectTransform.anchoredPosition = new Vector2(handleRectPosition - progressBarWidth / 2f,
            itemRewardRectTransform.anchoredPosition.y);
        _listItemRewardProgressDays.Add(itemRW);
    }

    //hàm tự close popup theo second
    private IEnumerator ClosePopupAfter(float sec, TypePopupDailyRewardInterface TypePopup)
    {
        yield return new WaitForSeconds(sec);
        switch (TypePopup)
        {
            case TypePopupDailyRewardInterface.PanelReward:
                panelReward.SetActive(false);
                break;
            case TypePopupDailyRewardInterface.DailyRewardPopup:
                DaillyRewardPopup.OnCloseClicked();
                break;
        }
    }

    public void ResetReward()
    {
        for (int i = 0; i < _listItemRewardProgressDays.Count; i++)
        {
            Destroy(_listItemRewardProgressDays[i]);
        }

        _listItemRewardProgressDays.Clear();
        InitDally30dayUI();
        for (int i = 0; i < _listItemRewardProgressDays.Count; i++)
        {
            _listItemRewardProgressDays[i].isReward = true;
            _listItemRewardProgressDays[i].SaveIsReward(_listItemRewardProgressDays[i].isReward);
            _listItemRewardProgressDays[i].UpdateUI();
        }
    }
}

public enum TypePopupDailyRewardInterface
{
    PanelReward,
    DailyRewardPopup
}