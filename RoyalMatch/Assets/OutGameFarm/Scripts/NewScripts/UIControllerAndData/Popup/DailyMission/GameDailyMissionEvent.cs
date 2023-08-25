using UnityEngine;

public class GameDailyMissionEvent : MonoBehaviour
{
    [SerializeField] private FarmIslandBootstrapper _farmIslandBootstrapper;
    [SerializeField] private DailyMission _dailyMission;
    [SerializeField] private ProgressMission _progressMission;
    private GameData _gameData;
    private GeneralBalance _generalBalance;

    private void Start()
    {
        _gameData = _farmIslandBootstrapper.GetFarmIsLandData().GameData;
        _generalBalance = _gameData.GeneralBalance;
        _dailyMission.previousWarehouseCurrencies = new Currencies(_generalBalance.WarehouseCurrencies);
        _generalBalance.WarehouseCurrenciesChangedEvent += _dailyMission.HandleWarehouseCurrenciesChangedEvent;
        _dailyMission.EventMissionPassted += _progressMission.UpdateProgressUI;
        _dailyMission.GeneralMission();
    }
}