using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct FruitTreeCollectedEventData
{
    public FruitTreeBuilding FruitTreeBuilding;

    public FruitTreeCollectedEventData(FruitTreeBuilding fruitTreeBuilding)
    {
        FruitTreeBuilding = fruitTreeBuilding;
    }

}
