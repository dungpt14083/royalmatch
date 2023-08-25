using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBuildingProperties : EntityProperties
{
    public const string ElementKey = "elementId";

    //CÁC PROPETIES BAN ĐẦU TỌA ĐỘ VÀ TÊN NHÀ VÀ FLIP HAY K 
    public const string GridUKey = "gridU";

    public const string GridVKey = "gridV";

    public const string BuildingNameKey = "buildingName";

    public const string IsFlippedKey = "isFlipped";

    public const string IsGatherableKey = "isGatherable";

    public const string RequirementForDestroyGatherable = "requirementForDestroy";

    public int ElementId { get; private set; }

    public GridIndex Position { get; private set; }

    public string BuildingName { get; private set; }

    public bool IsFlipped { get; private set; }

    public bool IsGatherable { get; private set; }

    public List<RequirementInfo> RequirementInfosForDestroyGatherable { get; private set; }
    public List<TradeInfo>  AdditionalReward { get; private set; }


    public StartBuildingProperties(PropertiesDictionary propsDict, string key)
        : base(propsDict, key)
    {
        Position = new GridIndex(GetProperty("gridU", -1), GetProperty("gridV", -1));
        BuildingName = GetProperty("buildingName", "unknown");
        IsFlipped = GetProperty("isFlipped", false);
        ElementId = GetProperty("elementId", 0);
        IsGatherable = GetProperty("isGatherable", false);
        IsGatherable = GetProperty("isGatherable", false);
        if (IsGatherable)
        {
            RequirementInfosForDestroyGatherable =
                TradeExtensions.ParseRequirementInfoList(GetProperty("requirementForDestroy", ""));
        }

        AdditionalReward = TradeExtensions.ParseTradeInfoList(GetProperty("additionalReward", ""));
    }
    public void SetBuildingName(string buildingName)
    {
        BuildingName = buildingName;
    }
}