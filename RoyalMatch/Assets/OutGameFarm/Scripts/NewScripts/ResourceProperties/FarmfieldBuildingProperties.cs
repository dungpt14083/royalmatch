using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmfieldBuildingProperties : BuildingProperties
{
    //Propeties để mà từ ó sẽ sow lên hạt giống để mà bỏ xuống ...tất cả các cây trồng có thể trồng nó nằm ở ây truyền díc file nào
    public List<SowingMaterialProperties> SowingMaterialProperties { get; private set; }

    //truyền thàng propdict từ proteies file vào để mà từ đó sẽ lấ propeties vào cho thằng này
    public FarmfieldBuildingProperties(GeneralProperties generalProperties, PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        SowingMaterialProperties = generalProperties.GetSowingMaterialProperties(base.BuildingName);
    }
}