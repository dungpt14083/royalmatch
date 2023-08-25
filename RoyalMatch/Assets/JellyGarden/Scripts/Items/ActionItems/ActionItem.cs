using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionItem : Item, UseItem
{
    public bool isUsed = false;
    public override void Click()
    {
        if (itemStatus == ItemStatus.Idle)
        {
            Use();
        }
    }
    public virtual void Use()
    {
        
    }
    public virtual void UsedAtSquare(Square square)
    {
        
    }
    //public override void Package()
    //{
    //    Use();
    //}
    //public override void Propeller()
    //{
    //    Use();
    //}
    public override void ColiderWithObjDestroy()
    {
        AttackItem();
    }
    public override void AttackItem()
    {
        Use();
    }
}
