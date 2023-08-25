using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CÁC TÒA NHA SE CHUA NO CÁC THOGN TIN CO BAN::: 
//LƯU Ý ĐÂY LÀ DÀNH CHO CÁC TÒA NHÀ CHỨ K PHẢI DÀNH CHO STARTBUILDING
public class BuildingProperties : EntityProperties
{
    private const string SizeUKey = "sizeU";
    private const string SizeVKey = "sizeV";

    //GIÁ XÂY CỦA NHÀ 
    private const string ConstructionCostKey = "constructionCost";
    private const string ConstructionMinutesKey = "constructionMinutes";
    private const string StringReferenceKey = "stringReference";
    private const string SpriteReferenceKey = "spriteReference";
    private const string BuildingMaterialsKey = "buildingMaterials";
    private const string CompleteConstructionGemCostKey = "completeConstructionGemCost";
    private const string ConstructionRewardKey = "constructionRewards";
    //Nhà nà có thể move hay cố định
    private const string MoveableKey = "moveable";

    
    
    
    
    

    public string BuildingName
    {
        get { return base.BaseKey; }
    }
    public string NameItem { get; private set; }

    public GridSize BuildingSize { get; private set; }
    private Currency BaseConstructionCost { get; set; }
    public Currency ConstructionCost { get; private set; }

    public Currency CompleteConstructionGemCost { get; private set; }

    //XÂY XONG TẶNG GÌ
    public Currencies ConstructionReward { get; private set; }
    public float ConstructionTimeSeconds { get; private set; }
    public long UnlockLevel { get; private set; }
    public Currencies BuildingMaterials { get; private set; }
    public Currency CurrencyBuildComplete { get; private set; }
    public string StringReference { get; private set; }
    public string SpriteReference { get; private set; }
    public int MaxFacilities { get; private set; }
    public bool Moveable { get; private set; }
    private float _constructionCostMultiplier = 1f;


    public float ConstructionCostMultiplier
    {
        get { return _constructionCostMultiplier; }
    }

    public BuildingProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        BuildingSize = new GridSize(GetProperty("sizeU", 2), GetProperty("sizeV", 2));
        ConstructionTimeSeconds = GetProperty("constructionMinutes", 0f, true) * 60f;
        UnlockLevel = GetProperty("unlockLevel", 1L, true);
        MaxFacilities = GetProperty("maxFacilities", 1);
        StringReference = GetProperty("stringReference", key, true);
        Moveable = GetProperty("moveable", true, true);
        SpriteReference = GetProperty("spriteReference", string.Empty);
        UnlockLevel = GetProperty("unlockLevel", 1L, true);
        NameItem = GetProperty("name", base.BaseKey);

        //GIÁ XÂYĐỰNG BAN DAU
        Currency result;
        if (Currency.TryParse(GetProperty("constructionCost", string.Empty, true), out result))
        {
            BaseConstructionCost = result;
            ConstructionCost = BaseConstructionCost * ConstructionCostMultiplier;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, "constructionCost");
        }

        //GIÁ HOÀN THÀNH NÓ NHƯ SAU::
        long amount = (long)(float)GetProperty("completeConstructionGemCost", 0L, true);

        CompleteConstructionGemCost = new Currency(CurrencyType.gems, amount);

        //THỬU XEM NHÀ NÀY CÓ PHẢI XÂY BẰNG BUILDING MATERIAL HAY KHÔNG
        Currencies result2;
        if (Currencies.TryParse(GetProperty("buildingMaterials", string.Empty, true), out result2))
        {
            BuildingMaterials = result2;
        }
        else
        {
            Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, "buildingMaterials");
        }

        Currency result4;
        if (global::Currency.TryParse(GetProperty("rewardBuildCompleted", string.Empty, true), out result4))
        {
            CurrencyBuildComplete = result4;
        }
        //THƯỞNG KHI XÂY NHÀ XONG::
        Currencies result3;
        if (Currencies.TryParse(GetProperty("constructionRewards", string.Empty, true), out result3))
        {
            ConstructionReward = result3;
            return;
        }

       
        

        Debug.LogErrorFormat("Failed to parse '{0}.{1}'", key, "constructionRewards");
    }
}