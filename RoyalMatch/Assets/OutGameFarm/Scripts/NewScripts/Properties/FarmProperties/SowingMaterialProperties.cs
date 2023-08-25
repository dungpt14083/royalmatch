using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SowingMaterialProperties : BasicMaterialProperties
{
    //time dẫn tói héo, thằng farm 
    private const string WitherTimeSecondsKey = "witherTimeSeconds";

    private const string FarmfieldTemplateTypeKey = "farmfieldTemplateType";

    //thằng loại nhóm cây là bao nhiêu cây 3 5 7 9...
    private const string CropSpriteReferenceKey = "cropSpriteReference";

    public static readonly Dictionary<string, FarmfieldTemplateType> FarmfieldTemplateLookup =
        new Dictionary<string, FarmfieldTemplateType>
        {
            {
                "oneCrop",
                FarmfieldTemplateType.OneCrop
            },
            {
                "fourCrops",
                FarmfieldTemplateType.FourCrops
            },
            {
                "fiveCrops",
                FarmfieldTemplateType.FiveCrops
            },
            {
                "sixCrops",
                FarmfieldTemplateType.SixCrops
            },
            {
                "nineCrops",
                FarmfieldTemplateType.NineCrops
            },
            {
                "twelveCrops",
                FarmfieldTemplateType.TwelveCrops
            }
        };

    public float WitherTimeSeconds { get; private set; }


    public FarmfieldTemplateType FarmfieldTemplate { get; private set; }
    public string CropSpriteReference { get; private set; }

    public int IdItemFarm { get; private set; }


    public SowingMaterialProperties(PropertiesDictionary propsDict, string baseKey)
        : base(propsDict, baseKey)
    {
        IdItemFarm = GetProperty("idItemFarm", 0);
        WitherTimeSeconds = GetProperty("witherTimeSeconds", float.MaxValue);
        string property = GetProperty("farmfieldTemplateType", string.Empty);
        if (FarmfieldTemplateLookup.ContainsKey(property))
        {
            FarmfieldTemplate = FarmfieldTemplateLookup[property];
        }
        else
        {
            FarmfieldTemplate = FarmfieldTemplateType.FiveCrops;
            Debug.LogErrorFormat("Cannot find FarmfieldTemplate: {0} using {1} as default.", property,
                FarmfieldTemplate);
        }

        CropSpriteReference = GetProperty("cropSpriteReference", string.Empty);
    }
}