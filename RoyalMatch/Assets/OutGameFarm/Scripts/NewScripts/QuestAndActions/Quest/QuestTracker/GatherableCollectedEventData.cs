using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GatherableCollectedEventData
{
    public GatherableBuilding GatherableBuilding;

    public GatherableCollectedEventData(GatherableBuilding gatherableBuilding)
    {
        GatherableBuilding = gatherableBuilding;
    }
}
