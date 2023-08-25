using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmSceneRequest : SceneRequest
{
    public override string SceneName { get; set; }

    public override string ResourceSceneName
    {
        get { return null; }
    }

    public override float LoadingWeight
    {
        get { return 0.8f; }
    }

    public FarmIsLandData CityIsland { get; private set; }
    public IslandId CurrentIslandId { get; private set; }


    public FarmSceneRequest(FarmIsLandData cityIsland, IslandId currentIslandId, string nameScene)
    {
        this.SceneName = nameScene;
        CityIsland = cityIsland;
        CurrentIslandId = currentIslandId;
    }

    public override IEnumerator LoadDuringSceneSwitch()
    {
        yield return new WaitForEndOfFrame();
        base.Progress = 1f;
        base.HasCompleted = true;
    }
}