using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherableRequirementManagerView : MonoSingleton<GatherableRequirementManagerView>, IRequirementController
{
    //KHI INIT THÌ ĐẨY DATA VÀO ĐÂY NÓ SẼ LÀ REQUIREMENT CHECK:::::
    public GatherableManager GatherableManager { get; set; }

    public void Init(GatherableManager gatherableManager)
    {
        GatherableManager = gatherableManager;
    }

    public bool IsProvided(RequirementInfo requirement)
    {
        if (GatherableManager == null) return false;
        //phải LÀ LOẠI RÁC THÌ MỚI:::
        if (requirement.RequirementType != RequirementType.CollectGatherableExact) return false;
        return GatherableManager.IsCompletedGatherableWithId(requirement.Value);
    }

    public bool IsGatherableCollected(int id)
    {
        return GatherableManager.IsCompletedGatherableWithId(id);
    }
}