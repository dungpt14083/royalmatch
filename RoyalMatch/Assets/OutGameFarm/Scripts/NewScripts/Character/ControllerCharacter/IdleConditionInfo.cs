using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
//ĐIỀU KIỆN CHO ĐỂ MÀ KÍCH HOẠT IDLECUTSCEN
public class IdleConditionInfo 
{
    public IdleConditionType Type;
    public int IdInType;
    public int Value;
    
    // Methods
    public IdleConditionInfo()
    {
    
    }
    
    public IdleConditionInfo(IdleConditionType type, int idInType, int value)
    {
        this.Type = type;
        this.IdInType = idInType;
        this.Value = value;
    }
}
