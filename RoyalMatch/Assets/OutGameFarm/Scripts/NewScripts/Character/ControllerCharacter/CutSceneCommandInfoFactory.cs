using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneCommandInfoFactory : MonoSingleton<CutSceneCommandInfoFactory>
{
    //Tạo ra data cho thằng 
    public CutsceneCommandInfo GetNewCharacterFreeWalkCommandInfo(int characterId, UnityEngine.Vector3 position,
        int pressCount = 1)
    {
        List<ParameterInfo> tmpParameters = new List<ParameterInfo>();
        ParameterInfo tmp = new ParameterInfo("characterId", characterId.ToString());
        tmpParameters.Add(tmp);

        ParameterInfo tmp1 = new ParameterInfo("position", position.GetParameterInfoFormat());
        tmpParameters.Add(tmp1);

        CutsceneCommandInfo commandInfo = new CutsceneCommandInfo(tmpParameters, "CharacterFreeWalk");
        return commandInfo;
    }

    public CutsceneCommandInfo GetNewCharacterCollectGatherableInfo(int characterId, GridIndex gatherablePosition)
    {
        List<ParameterInfo> tmpParameters = new List<ParameterInfo>();
        ParameterInfo tmp = new ParameterInfo("characterId", characterId.ToString());
        tmpParameters.Add(tmp);

        ParameterInfo tmp1 = new ParameterInfo("gatherablePosition", gatherablePosition.GetParameterVector2IntFormat());
        tmpParameters.Add(tmp1);

        CutsceneCommandInfo commandInfo = new CutsceneCommandInfo(tmpParameters, "CharacterCollectGatherable");
        return commandInfo;
    }
    
    public CutsceneCommandInfo GetNewCharacterCollectFruitTreeInfo(int characterId, GridIndex gatherablePosition)
    {
        List<ParameterInfo> tmpParameters = new List<ParameterInfo>();
        ParameterInfo tmp = new ParameterInfo("characterId", characterId.ToString());
        tmpParameters.Add(tmp);

        ParameterInfo tmp1 = new ParameterInfo("gatherablePosition", gatherablePosition.GetParameterVector2IntFormat());
        tmpParameters.Add(tmp1);

        CutsceneCommandInfo commandInfo = new CutsceneCommandInfo(tmpParameters, "CharacterCollectFruitTree");
        return commandInfo;
    }

    public CutsceneCommandInfo GetNewCharacterCollectItemBonusInfo(int characterId, GridIndex gatherablePosition)
    {
        List<ParameterInfo> tmpParameters = new List<ParameterInfo>();
        ParameterInfo tmp = new ParameterInfo("characterId", characterId.ToString());
        tmpParameters.Add(tmp);

        ParameterInfo tmp1 = new ParameterInfo("itemBonusPosition", gatherablePosition.GetParameterVector2IntFormat());
        tmpParameters.Add(tmp1);

        CutsceneCommandInfo commandInfo = new CutsceneCommandInfo(tmpParameters, "CharacterCollectItemBonus");
        return commandInfo;
    }
    public CutsceneCommandInfo GetNewCharacterCollectBonusTreeInfo(int characterId, GridIndex gatherablePosition)
        {
            List<ParameterInfo> tmpParameters = new List<ParameterInfo>();
        ParameterInfo tmp = new ParameterInfo("characterId", characterId.ToString());
        tmpParameters.Add(tmp);

        ParameterInfo tmp1 = new ParameterInfo("gatherablePosition", gatherablePosition.GetParameterVector2IntFormat());
        tmpParameters.Add(tmp1);

        CutsceneCommandInfo commandInfo = new CutsceneCommandInfo(tmpParameters, "CharacterCollectBonusTree");
        return commandInfo;
    }
}