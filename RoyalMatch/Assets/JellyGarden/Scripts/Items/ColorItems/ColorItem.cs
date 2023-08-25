using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorItem : Item
{
    public int color { get { return (int)GetItemType(); } }
}
