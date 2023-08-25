using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloundGameState
{
    public string SaveGame { get; private set; }
    public string UserId { get; private set; }
    public string SaveGuid { get; private set; }
    public string DeviceLastPushedSaveStateGuid { get; private set; }
    public string SaveStateGuid { get; private set; }
    public long PlayerLevel { get; private set; }
    public string DisplayName { get; private set; }

    //????????
    //public GameSparksGameVersion GameVersion { get; private set; }

    public CloundGameState(string saveGame, string serverUserId, string serverSaveGuid,
        string deviceLastPushedSaveStateGuid, string serverSaveStateGuid, long playerLevel,
        string displayName /*, GameSparksGameVersion gameVersion*/)
    {
        SaveGame = saveGame;
        UserId = serverUserId;
        SaveGuid = serverSaveGuid;
        DeviceLastPushedSaveStateGuid = deviceLastPushedSaveStateGuid;
        SaveStateGuid = serverSaveStateGuid;
        PlayerLevel = playerLevel;
        DisplayName = displayName;
        //GameVersion = gameVersion;
    }
}