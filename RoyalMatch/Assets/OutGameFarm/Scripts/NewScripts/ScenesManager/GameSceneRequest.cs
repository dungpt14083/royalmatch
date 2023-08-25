using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneRequest : SceneRequest
{
    private bool _newGame;

    public override string SceneName
    {
        get { return "Game"; }
        set {}
    }

    //scene chứa tileassetcollection chứa asset của tilemap cái này bỏ qua / K CÓ THÌ BỎ QUA K LOAD RESOURCE
    public override string ResourceSceneName
    {
        get { return null; }
    }

    public override float LoadingWeight
    {
        get { return 0.4f; }
    }

    public FarmIsLandData CityIsland { get; private set; }

    public GameSceneRequest(FarmIsLandData cityIsland, bool newGame = false)
    {
        CityIsland = cityIsland;
        _newGame = newGame;
    }

    //TỪ ĐÂY SẼ tạo map xong thì mới coi như load xong cái map game luôn mình sẽ là map world
    public override IEnumerator LoadDuringSceneSwitch()
    {
        yield return new WaitForEndOfFrame();
        if (_newGame)
        {
            CityIsland.NewGame();
        }

        //GeneratedIsland = new GeneratedIsland(CityIsland.Game.Island.IslandTiles);
        //yield return GeneratedIsland.Generate();
        base.Progress = 0.4f;
        yield return new WaitForEndOfFrame();
        //Yield return CityIsland.Store.LoadProducts(CityIsland.Game.GameStats.Collect());
        base.Progress = 1f;
        base.HasCompleted = true;
    }
}