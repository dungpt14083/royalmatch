using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequirementManager : MonoSingleton<RequirementManager>
{
    //LƯU LOẠI REQUIREMENT TƯƠNG ỨNG VỚI THẰNG REQUIREMENTCONTROLLER ĐỂ KHI TRUYỀN REQUIRMENTINFO VÀO THÌ NÓ CHECK 
    private Dictionary<RequirementType, IRequirementController> _requirementControllers =
        new Dictionary<RequirementType, IRequirementController>();

    private int _requiredTradeController;


    public void Init()
    {
        Array tmpValue = System.Enum.GetValues(typeof(RequirementType));
        this._requiredTradeController = tmpValue.Length;
    }


    public bool IsRequirementsProvided(System.Collections.Generic.List<RequirementInfo> requirements)
    {
        for (int i = 0; i < requirements.Count; i++)
        {
            if (!IsRequirementProvided(requirements[i]))
            {
                return false;
            }
        }

        return true;
    }


    //Trong requirmentinfo có TYPE VÀ YEEU CẦU CỦA NÓ:::
    //YÊU CẦU NÀY ĐƯỢC CUNG CẤP???DỰA VÀO CONTROLLER CHECK BÊN CONTROLLER LUÔN
    public bool IsRequirementProvided(RequirementInfo requirement)
    {
        if (_requirementControllers.ContainsKey(requirement.RequirementType))
        {
            var tmpRequirementController = _requirementControllers[requirement.RequirementType];
            return tmpRequirementController.IsProvided(requirement);
        }

        return false;
    }


    //là yêu cầu cuối về cái mà được cung cấp:::UPDATE CÁI REQUIREMENT VỚI VALUE MỚI ???XONG ĐÓ CHECK LẠI LUÔN
    public bool IsLastRequirementAboutToBeProvided(System.Collections.Generic.List<RequirementInfo> requirements,
        RequirementType newRequirementType, int newValue)
    {
        foreach (RequirementInfo requirement in requirements)
        {
            if (requirement.RequirementType == newRequirementType)
                requirement.Value = newValue;

            if (!IsRequirementProvided(requirement))
                return false;
        }

        return true;
    }

    //CÁI THẰNG N SẼ đăng kí controller CÓ THỂ 1 TYPE 1 CONTROLLER 
    public void RegisterRequirementController(RequirementType type, IRequirementController controller)
    {
        if (!_requirementControllers.ContainsKey(type))
        {
            _requirementControllers.Add(type, controller);
        }

        //LÀ SỐ LƯỢNG TYPE KHÁC VỚI SỐ LƯỢNG REQUIRMENTCONTROLLER THÌ RETURN KHI BẰNG THÌ LÀ ĐẦY RỒI À?????
        //VẬY THÌ PHẢI CHECK K CONTAINT THÌ MS ĐẨYVÀO:::đầy requirmentt ????
        if (_requiredTradeController != _requirementControllers.Count) return;
        //NẾU??READY KHI MÀ SỐ LƯỢNG CONTROLLER ĐƯANG KÍ ĐỦ THÌ SẼ READY CH K PHẢI THIẾU CONTROLLER:::
        //this.SetReady();
    }
}