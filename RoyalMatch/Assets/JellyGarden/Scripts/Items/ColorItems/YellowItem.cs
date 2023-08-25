using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowItem : ColorItem
{
    public override ItemsTypes GetItemType()
    {
        return ItemsTypes.YELLOW;
    }
}
