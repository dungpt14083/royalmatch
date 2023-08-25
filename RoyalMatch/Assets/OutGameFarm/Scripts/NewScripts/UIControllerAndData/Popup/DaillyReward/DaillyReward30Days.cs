using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DaillyReward30Days : DaillyRewardCore<DaillyReward30Days>
{
    public List<Reward30Days> _listReward30day;
    public DateTime lastRewardTime;
    public bool isClaim =true;
    public delegate void OncompleteWeed();

    public OncompleteWeed oncompleteWeed;
    // Constants
    private const int MAX_REWARD_DAYS = 30;
    private const string LastLoginDatesKey = "LastLoginDate";
    private const int MaxDays = 30;
    private const string DayPassedsKey = "DayPassed";
    public int dayPassed;
    public string lastLoginDate;

    void Start()
    {
        CheckLogin();
        InitializeTimer();
    }
    public void CompleteWeek()
    {
        if (oncompleteWeed != null)
        {
            oncompleteWeed();
        }
    }

    public void CheckLogin()
    {
        dayPassed = PlayerPrefs.GetInt(DayPassedsKey, 1);

        lastLoginDate = PlayerPrefs.GetString(LastLoginDatesKey);
        if (string.IsNullOrEmpty(lastLoginDate))
        {
            lastLoginDate = System.DateTime.Now.ToString("dd/MM/yyyy");
            PlayerPrefs.SetString(LastLoginDatesKey, lastLoginDate);
        }

        string currentDate = System.DateTime.Now.ToString("dd/MM/yyyy");


        if (lastLoginDate == currentDate)
        {
            isClaim = false;
            Debug.Log("User already logged in today.");
        }
        else
        {
            dayPassed++;
            isClaim = true;
            PlayerPrefs.SetString(LastLoginDatesKey, currentDate);
            PlayerPrefs.SetInt(DayPassedsKey, dayPassed);

            if (dayPassed > MaxDays)
            {
                CompleteWeek();
                dayPassed = 1;
                PlayerPrefs.SetString(LastLoginDatesKey, currentDate);
                PlayerPrefs.SetInt(DayPassedsKey, dayPassed);
            }
            else
            {
                Debug.Log("Incremented dayPassed variable: " + dayPassed);
            }
        }
    }

    private void InitializeTimer()
    {
        base.InitializeDate();

        if (base.isErrorConnect)
        {
            if (onInitialize != null)
                onInitialize(true, base.errorMessage);
        }
        else
        {

            if (onInitialize != null)
                onInitialize();
        }
    }

    public int GetTimeDifference(string date1, string date2)
    {
        System.DateTime dateTime1 = System.DateTime.ParseExact(date1, "dd/MM/yyyy", null);
        System.DateTime dateTime2 = System.DateTime.ParseExact(date2, "dd/MM/yyyy", null);
        System.TimeSpan timeDifference = dateTime2 - dateTime1;
        return timeDifference.Days;
    }


    public void LoadDebugTime()
    {
        dayPassed++;
        isClaim = true;
        PlayerPrefs.SetInt(DayPassedsKey, dayPassed);
        if (dayPassed > MaxDays)
        {
            string currentDate = System.DateTime.Now.ToString("dd/MM/yyyy");
            CompleteWeek();
            dayPassed = 1;
            PlayerPrefs.SetString(LastLoginDatesKey, currentDate);
            PlayerPrefs.SetInt(DayPassedsKey, dayPassed);
        }
    }

    protected override void OnApplicationPause(bool pauseStatus)
    {
        base.OnApplicationPause(pauseStatus);
    }

    public void CheckRewards()
    {
        return;
    }

    public void ClaimPrize()
    {
        return;
    }

 
}