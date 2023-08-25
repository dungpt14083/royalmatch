using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class DaillyRewardItem : MonoBehaviour
{
    public bool showRewardName;

    public TMP_Text txtDay;
    public TMP_Text txtReward;
    public Image imageRewardBackground;
    public Image ImageReward;
    public Sprite Imageclaimed; 
    public Sprite ImageUnclaimed;
    public Sprite SpriteReward;
    public Sprite SpriteRewardDefalut;
    public Color colorClaim;
    private Color colorUnclaimed = new Color(0,0,0,255);
    
    public int day;
    public RewardDailyReward reward;
    public List<RewardDailyReward> RewardsDay7;
    public DailyRewardState state;
    
    [Header("color ")]
    public Color ColorUNCLAIMED_AVAILABLE =Color.blue;
    public Color ColorUNCLAIMED_UNAVAILABLE=Color.white;
    public Color ColorSKIPPED=Color.red;
    public Color ColorCLAIMED=Color.white;
    [Header("Item Day 7")]
    public TMP_Text txtReward1,txtReward2,txtReward3;

    public Image ImageReward1, ImageReward2, ImageReward3;
    public enum DailyRewardState
    {
        UNCLAIMED_AVAILABLE,
        UNCLAIMED_UNAVAILABLE,
        SKIPPED,
        CLAIMED
    }

    //hàm này dùng để Interface set name, sprite , int reward cho item
    public void Init(int _day,RewardDailyReward _reward)
    {
        day = _day;
        reward = _reward;
        txtDay.text = string.Format("Day {0}", day.ToString());
        if (reward.reward > 0)
        {
            if (showRewardName)
            {
                string rewardText = string.Join(", ", reward.type.Select(type => type.ToString()).ToArray());
                txtReward.text = rewardText;
            }
            else
            {
                txtReward.text = reward.reward.ToString();
            }
        }
        else
        {
            txtReward.text = reward.type.ToString();
        }

        ImageReward.sprite = reward.Sprite;
    }
    
    // đối với ngày thứ 7 sẽ khởi tạo khác ngày thường
    public void InitDay7(int _day,List<RewardDailyReward> _reward)
    {
        if (_day != 7)
        {
            return;
        }
        day = _day;
        RewardsDay7 = _reward;
        txtDay.text = string.Format("Day {0}", day.ToString());
        if (RewardsDay7.Count > 0)
        {
            if (showRewardName)
            {
                string rewardText1 = RewardsDay7.Count >= 1 ? string.Join(", ", RewardsDay7[0].type.Select(type => type.ToString())) : "";
                string rewardText2 = RewardsDay7.Count >= 2 ? string.Join(", ", RewardsDay7[1].type.Select(type => type.ToString())) : "";
                string rewardText3 = RewardsDay7.Count >= 3 ? string.Join(", ", RewardsDay7[2].type.Select(type => type.ToString())) : "";
            
                txtReward1.text = rewardText1;
                txtReward2.text = rewardText2;
                txtReward3.text = rewardText3;
            }
            else
            {
                string rewardText1 = RewardsDay7.Count >= 1 ? RewardsDay7[0].reward.ToString() : "";
                string rewardText2 = RewardsDay7.Count >= 2 ? RewardsDay7[1].reward.ToString() : "";
                string rewardText3 = RewardsDay7.Count >= 3 ? RewardsDay7[2].reward.ToString() : "";
            
                txtReward1.text = rewardText1;
                txtReward2.text = rewardText2;
                txtReward3.text = rewardText3;
            }
        }
        else
        {
            txtReward1.text = "";
            txtReward2.text = "";
            txtReward3.text = "";
        }

        // Assuming there is only one ImageReward element
        if (RewardsDay7.Count > 0)
        {
            ImageReward1.sprite = RewardsDay7[0].Sprite;
            ImageReward2.sprite = RewardsDay7[1].Sprite;
            ImageReward3.sprite = RewardsDay7[2].Sprite;
        }
    }

    // cập nhật lại giao diện của Item
    public void Refresh()
    {
        switch (state)
        {
            case DailyRewardState.UNCLAIMED_AVAILABLE:
                imageRewardBackground.sprite = ImageUnclaimed;
                imageRewardBackground.color = ColorUNCLAIMED_AVAILABLE;
                ImageReward.sprite = reward.Sprite;
                
                if (RewardsDay7.Count > 0)
                {
                    ImageReward1.sprite = RewardsDay7[0].Sprite;
                    ImageReward2.sprite = RewardsDay7[1].Sprite;
                    ImageReward3.sprite = RewardsDay7[2].Sprite;
                }
                break;
            case DailyRewardState.UNCLAIMED_UNAVAILABLE:
                imageRewardBackground.sprite = ImageUnclaimed;
                imageRewardBackground.color = ColorUNCLAIMED_UNAVAILABLE;
                ImageReward.sprite = reward.Sprite;
                //đối với Item day 7 sẽ khác
                if (RewardsDay7.Count > 0)
                {
                    ImageReward1.sprite = RewardsDay7[0].Sprite;
                    ImageReward2.sprite = RewardsDay7[1].Sprite;
                    ImageReward3.sprite = RewardsDay7[2].Sprite;
                }
                break;
            case DailyRewardState.SKIPPED:
                imageRewardBackground.sprite =Imageclaimed;
                imageRewardBackground.color = ColorSKIPPED;
                ImageReward.color =ColorSKIPPED;
                ImageReward.sprite = reward.Sprite;
                break;
            case DailyRewardState.CLAIMED:
                imageRewardBackground.sprite =Imageclaimed;
                imageRewardBackground.color = ColorCLAIMED;
                ImageReward.sprite = SpriteReward;
                //đối với Item day 7 sẽ khác
                if (ImageReward1 != null && ImageReward2 != null && ImageReward3 != null)
                {
                    ImageReward1.sprite = SpriteReward;
                    ImageReward2.sprite = SpriteReward;
                    ImageReward3.sprite = SpriteReward;
                }
                break;
        }
    }

    
}
