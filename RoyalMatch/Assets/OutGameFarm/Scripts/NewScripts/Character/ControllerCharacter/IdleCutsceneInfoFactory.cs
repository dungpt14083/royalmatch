using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//IDLE CUTSCENE INFO CHỈ CÓ PRIORITY KHÔNG CHỨA GÌ CẢ:::DATABASE LOCAL
public class IdleCutsceneInfoFactory : MonoSingleton<IdleCutsceneInfoFactory>
{
    private int MainCharacterWalkPriority = 100;
    private int MainCharacterCollectPriority = 1;

    public IdleCutsceneInfo GetMainCharacterWalkIdleCutsceneInfo()
    {
        return new IdleCutsceneInfo(MainCharacterWalkPriority);
    }

    public IdleCutsceneInfo GetMainCharacterCollectIdleCutsceneInfo()
    {
        return new IdleCutsceneInfo(MainCharacterCollectPriority);
    }
    
}