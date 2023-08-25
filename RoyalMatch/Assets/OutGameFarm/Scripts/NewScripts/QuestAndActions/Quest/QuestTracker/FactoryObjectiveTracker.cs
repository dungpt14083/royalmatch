using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//ĐÂY SẼ NGHE SỰ KIỆN KHI MÀ THẰNG FACTORY SẢN XUẤT RA CÁI GÌ ĐÓ:::
public class FactoryObjectiveTracker : MonoSingleton<FactoryObjectiveTracker>, IObjectiveTracker
{
    private FactoryEventData _data;
    private bool _isMade = true;


    private void Start()
    {
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.FactoryStartProduceItem, this);
        ObjectiveManager.Instance.RegisterObjectiveTracker(ObjectiveType.FactoryCollectProducedItem, this);
        ObjectiveTrackerSignals.FactoryProductionStartEvent.AddListener(OnProduce);
        ObjectiveTrackerSignals.FactoryCollectItemEvent.AddListener(OnCollect);
    }

    private void OnDestroy()
    {
        ObjectiveTrackerSignals.FactoryProductionStartEvent.RemoveListener(OnProduce);
        ObjectiveTrackerSignals.FactoryCollectItemEvent.RemoveListener(OnCollect);
    }

    private void OnProduce(FactoryEventData data)
    {
        _data = data;
        _isMade = true;
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _data = null;
    }

    private void OnCollect(FactoryEventData data)
    {
        _data = data;
        _isMade = false;
        FarmQuestManagerView.Instance.CheckQuestsProgress(this);
        _data = null;
    }


    //PHẢI BỎ VÀO ĐÂY NỮA::::::LẤY ID BAO NHIÊU À???STRING VÀ VALUE:::
    public int GetTaskProgressAmount(ObjectiveType objectiveType, int idInType, int amount)
    {
        if ((_isMade && objectiveType == ObjectiveType.FactoryStartProduceItem) || (!_isMade &&
                objectiveType == ObjectiveType.FactoryCollectProducedItem))
        {
            int tmpAmount = 0;

            if (this._data.ProductProperties != null)
            {
                for (int i = 0; i < _data.ProductProperties.Count; i++)
                {
                    var tmpProp = _data.ProductProperties[i];
                    if (tmpProp.CurrencyName == ((CurrencyType)idInType).ToCurrencyName())
                    {
                        tmpAmount += 1;
                    }
                }
            }

            return tmpAmount;
        }

        return 0;
    }


    public string GetTranslationKey(ObjectiveType objectiveType, int idInType, int amount,
        System.Collections.Generic.Dictionary<string, string> replacements)
    {
        if (objectiveType == ObjectiveType.FactoryStartProduceItem ||
            objectiveType == ObjectiveType.FactoryCollectProducedItem)
        {
            return "Factory" + ((CurrencyType)idInType).ToCurrencyName();
        }

        return "";
    }

    public UnityEngine.Sprite GetSprite(ObjectiveType objectiveType, int idInType, int amount)
    {
        if (objectiveType == ObjectiveType.FactoryStartProduceItem ||
            objectiveType == ObjectiveType.FactoryCollectProducedItem)
        {
            return SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset((CurrencyType)idInType);
        }

        return null;
    }
}