using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ACTON TRONG GAME DÙNG ĐỂ KIỂM SOÁT VIỆC CHẠY THEO LẦN LƯỢT 
public abstract class MapAction
{
    public MapActionQueueManager MapActionQueueManager;
    public bool KeepPopups;

    protected bool Completed;

    public bool IsCompleted()
    {
        return (bool)this.Completed;
    }

    protected void Complete()
    {
        Debug.LogError("LOG RA XEM ACTION NÀO KET THUC:::");
        this.Completed = true;
        MapActionQueueManager.CurrentAction = null;
        this.MapActionQueueManager.CheckQueue();
        
    }

    public abstract void Play();
}