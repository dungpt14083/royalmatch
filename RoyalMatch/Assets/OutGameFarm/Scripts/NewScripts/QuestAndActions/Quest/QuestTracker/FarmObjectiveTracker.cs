using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmObjectiveTracker : MonoSingleton<FarmObjectiveTracker>, IObjectiveTracker
{
    private void Start()
    {
        ObjectiveTrackerSignals.FarmPlantEvent.AddListener(OnFarmPlant);
        ObjectiveTrackerSignals.FarmHarvestEvent.AddListener(OnFarmHarvest);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.PlantItem, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.HarvestItem, this);
    }

    private void OnDestroy()
    {
        ObjectiveTrackerSignals.FarmPlantEvent.RemoveListener(OnFarmPlant);
        ObjectiveTrackerSignals.FarmHarvestEvent.RemoveListener(OnFarmHarvest);
    }


    private FarmFieldBuilding _data;
    private bool _isPlant = true;

    //KHI TRỒNG CÂY THÌ SẼ TRUYỀN BUILDING FARM VÀO ĐÂY:::
    private void OnFarmPlant(FarmPlantEventData data)
    {
        _data = data.FarmFieldBuilding;
        _isPlant = true;
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _data = null;
    }

    private void OnFarmHarvest(FarmPlantEventData data)
    {
        _data = data.FarmFieldBuilding;
        _isPlant = false;
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _data = null;
    }


    public int GetTaskProgressAmount(ObjectiveType objectiveType, int idInType, int amount)
    {
        //NẾU LÀ LOẠI THU HOẠCH HOẶC LÀ TRỒNG THÌ MỚI TÍNH Ở ĐÂY
        if ((_isPlant && objectiveType == ObjectiveType.PlantItem) ||
            (!_isPlant && objectiveType == ObjectiveType.HarvestItem))
        {
            if (_data == null)
            {
                return 0;
            }

            return _data.SowedMaterial.CurrencyName == ((CurrencyType)idInType).ToCurrencyName() ? 1 : 0;
        }

        return 0;
    }

    public string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount,
        Dictionary<string, string> replacements)
    {
        if (objectiveType == ObjectiveType.PlantItem || objectiveType == ObjectiveType.HarvestItem)
        {
            return "Farm" + ((CurrencyType)idInType).ToCurrencyName();
        }

        return "";
    }

    public Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (objectiveType == ObjectiveType.PlantItem || objectiveType == ObjectiveType.HarvestItem)
        {
            return SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset((CurrencyType)idInType);
        }

        return null;
    }
}