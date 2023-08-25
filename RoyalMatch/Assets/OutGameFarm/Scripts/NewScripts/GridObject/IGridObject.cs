using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inteface cho việc chiếm bao nhiêu diện tích là flip hay chưa cho tất cả tòa nhà::
public interface IGridObject
{
    
    event TileManager.MovedEventHandler MovedEvent;

    event TileManager.FlippedEventHandler FlippedEvent;

    GridArea Area { get; }

    bool IsFlipped { get; }
}