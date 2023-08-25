using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeUserRankingdata : MonoBehaviour
{
    public string UserId1
    {
        get => UserId;
        set => UserId = value;
    }

    public string HcUserName
    {
        get => hcUserName;
        set => hcUserName = value;
    }

    public int Value
    {
        get => value;
        set => this.value = value;
    }

    public int Rank
    {
        get => rank;
        set => rank = value;
    }

    public string Avatar
    {
        get => avatar;
        set => avatar = value;
    }

    public int Reward
    {
        get => reward;
        set => reward = value;
    }

    public int TypeReward
    {
        get => typeReward;
        set => typeReward = value;
    }

    private string UserId;
    private string hcUserName;
    private int value;
    private int rank;
    private string avatar;
    private int reward;
    private int typeReward;

    public FakeUserRankingdata(string userId, string hcUserName, int value, int rank, string avatar, int reward, int typeReward)
    {
        UserId = userId;
        this.hcUserName = hcUserName;
        this.value = value;
        this.rank = rank;
        this.avatar = avatar;
        this.reward = reward;
        this.typeReward = typeReward;
    }
    
}

public class FakeListUserRanking
{
    public FakeUserRankingdata FakeUserRankingdata;
}
