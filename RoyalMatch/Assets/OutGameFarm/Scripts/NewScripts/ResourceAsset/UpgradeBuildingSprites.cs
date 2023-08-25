using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UpgradeBuildingSprites
{
    [SerializeField] private List<Sprite> listBuildingSprites;

    public Sprite GetBuildingSpritesWithLevel(int index)
    {
        if (index > listBuildingSprites.Count - 1)
        {
            index = listBuildingSprites.Count - 1;
        }

        if (index < 0) index = 0;
        return listBuildingSprites[index];
    }
}