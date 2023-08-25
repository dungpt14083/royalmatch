using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TYPE VÀ SỐ LƯỢNG YÊU CẦU ĐỂ ĐẠT ĐƯỢC REQUIREINFO:::
[Serializable]
public class RequirementInfo
{
    public RequirementType RequirementType;

    public int Value;

    //LÀM SAO CURRENCY NÀY VỪA LÀ LOẠI 
    //public Currencies Currencies;

    public RequirementInfo()
    {
        
    }
    public RequirementInfo(RequirementType requirementType, int value/*, Currencies currencies = null*/)
    {
        RequirementType = requirementType;
        Value = value;
        //Currencies = currencies;
    }

    public bool IsSame(RequirementType requirementType, int value, Currencies currencies = null)
    {
        if (RequirementType == requirementType)
        {
            // if (requirementType == RequirementType.Currency)
            // {
            //     return Currencies == currencies;
            // }
            // else
            // {
                return Value == value;
           // }
        }

        return false;
    }
}