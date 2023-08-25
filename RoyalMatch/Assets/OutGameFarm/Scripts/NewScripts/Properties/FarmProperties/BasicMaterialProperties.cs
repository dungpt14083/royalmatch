using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMaterialProperties : ProductProperties
{
    //tang giá trị vĩnh viễn cái này buff tính sau:::
    private const string PermanentBoostCostKey = "permanentBoostCost";
    public Currency PermanentBoostCost { get; private set; }
    

    public BasicMaterialProperties(PropertiesDictionary propsDict, string baseKey)
        : base(propsDict, baseKey)
    {
        Currency result;
    }
}