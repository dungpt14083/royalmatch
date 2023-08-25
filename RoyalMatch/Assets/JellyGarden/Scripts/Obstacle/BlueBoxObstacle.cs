using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBoxObstacle : ColorBoxObstacle
{
    public override ObstacleTypes GetObstacleType()
    {
        return ObstacleTypes.BlueBox;
    }
}
