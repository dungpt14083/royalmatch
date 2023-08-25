using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class DailyRewards : DaillyRewardCore<DailyRewards>
{
    public List<RewardDailyReward> rewards;
    public List<RewardDailyReward> RewardsDay7;
    public DateTime lastRewardTime;
    public int availableReward;
    public int lastReward;
    public bool keepOpen = true;
    public Slider progress;
    public delegate void OnClaimPrize(int day);                 // When the player claims the prize
    public OnClaimPrize onClaimPrize;

    // Needed Constants
    private const string LAST_REWARD_TIME = "LastRewardTime";
    private const string LAST_REWARD = "LastReward";
    private const string DEBUG_TIME = "DebugTime";
    private const string FMT = "O";

    public TimeSpan debugTime;         // For debug purposes only

        void Start()
        {
            // Initializes the timer with the current time
            InitializeTimer();
        }

        //khởi tạo bộ đếm thời gian
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
                LoadDebugTime();
                // We don't count seconds on Daily Rewards
                //now = now.AddSeconds(-now.Second);
                CheckRewards();

                if(onInitialize!=null)
                    onInitialize(); // invoke báo đã khởi tạo
			}
        }
        //tính toán giữa current time vào last reward time
        public TimeSpan GetTimeDifference()
        {
            TimeSpan difference = (lastRewardTime - now);
            difference = difference.Subtract(debugTime);
            return difference.Add(new TimeSpan(0, 24, 0, 0));
        }

        private void LoadDebugTime ()
        {
            int debugHours = PlayerPrefs.GetInt(GetDebugTimeKey(), 0);
            debugTime = new TimeSpan(debugHours, 0, 0);
        }
        
        protected override void OnApplicationPause(bool pauseStatus)
        {
            base.OnApplicationPause(pauseStatus);
            CheckRewards();
        }
        

        // Check if the player have unclaimed prizes
        public void CheckRewards()
        {
            string lastClaimedTimeStr = PlayerPrefs.GetString(GetLastRewardTimeKey());
            lastReward = PlayerPrefs.GetInt(GetLastRewardKey()); 

            // It is not the first time the user claimed.
            // We need to know if he can claim another reward or not
            if (!string.IsNullOrEmpty(lastClaimedTimeStr))
            {
                lastRewardTime = DateTime.ParseExact(lastClaimedTimeStr, FMT, CultureInfo.InvariantCulture);

                // if Debug time was added, we use it to check the difference
                DateTime advancedTime = now.AddHours(debugTime.TotalHours);

                TimeSpan diff = advancedTime - lastRewardTime;
                Debug.Log(" Last claim was " + (long)diff.TotalHours + " hours ago.");

                int days = (int)(Math.Abs(diff.TotalHours) / 24);
                if (days == 0)
                {
                    // Không có phần thưởng, ngày mai mới có
                    availableReward = 0;
                    return;
                }

                // đăng nhập vào ngày tiếp theo sẽ nhận được phần thưởng
                if (days >= 1 && days < 2)
                {
                    // nhận hết phần thưởng sẽ reset
                    if (lastReward == rewards.Count+1)
                    {
                        availableReward = 1;
                        lastReward = 0;
                        return;
                    }
                    if (lastReward == rewards.Count && days >= 1 && days < 2)
                    {
                        availableReward = 7; // Đặt `availableReward` thành giá trị tương ứng với ngày thứ 7
                        lastReward = rewards.Count; // Đặt `lastReward` thành giá trị tương ứng với ngày thứ 6
                        return;
                    }
                    availableReward = lastReward + 1;

                    Debug.Log(" Player can claim prize " + availableReward);
                    return;
                }

                if (days >= 2)
                {
                    // // không đăng nhập liên tiếp sẽ bị reset 
                    availableReward = 1;
                    lastReward = 0;
                    Debug.Log("Skipping reward of day " + lastReward + " and proceeding to day " + availableReward);
                }
            }
            else
            {
                // Is this the first time? Shows only the first reward
                availableReward = 1;
            }
        }

        // Checks if the player claim the prize and claims it by calling the delegate. Avoids duplicate call
        public void ClaimPrize()
        {
            if (availableReward > 0)
            {
                // Delegate
                if (onClaimPrize != null)
                    onClaimPrize(availableReward);
                
                PlayerPrefs.SetInt(GetLastRewardKey(), availableReward);

                // Remove seconds
                //var timerNoSeconds = now.AddSeconds(-now.Second);
                // If debug time was added then we store it
                //timerNoSeconds = timerNoSeconds.AddHours(debugTime.TotalHours);
                string lastClaimedStr = now.AddHours(debugTime.TotalHours).ToString(FMT);
                PlayerPrefs.SetString(GetLastRewardTimeKey(), lastClaimedStr);
                PlayerPrefs.SetInt(GetDebugTimeKey(), (int)debugTime.TotalHours);
            }
            else if (availableReward == 0)
            {
                Debug.LogError("Error! The player is trying to claim the same reward twice.");
            }

            CheckRewards();
        }

        

        //Returns the lastReward playerPrefs key depending on instanceId
        private string GetLastRewardKey()
        {
            return LAST_REWARD;
        }

        //Returns the lastRewardTime playerPrefs key depending on instanceId
        private string GetLastRewardTimeKey()
        {
        	return LAST_REWARD_TIME;
        }

        //Returns the advanced debug time playerPrefs key depending on instanceId
        private string GetDebugTimeKey()
        {
            return DEBUG_TIME;
        }

        // Returns the daily Reward of the day
        public RewardDailyReward GetReward(int day)
        {
            return rewards[day - 1];
        }

        // Resets the Daily Reward for testing purposes
        public void Reset()
        {
            PlayerPrefs.DeleteKey(GetLastRewardKey());
            PlayerPrefs.DeleteKey(GetLastRewardTimeKey());
            PlayerPrefs.DeleteKey(GetDebugTimeKey());
        }
    
}
