using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WareHouseCategoryView : MonoBehaviour
{
    [SerializeField] private WareHouseCategory _category;

    public WareHouseCategory Category => _category;
    [SerializeField] private Transform holder;

    public void Init(WareHouseBuilding _warehouse,WareHouseItem prefabItem,List<EntityCurrencyProperties> propertiesList,PanalTradePopup panalTradePopup,WareHousePanalDetail wareHousePanalDetail)
    {
        SetDefault();
        ViewGrid(_warehouse,prefabItem,propertiesList,panalTradePopup,wareHousePanalDetail);
    }
    private void SetDefault()
    {
        for (int i = holder.childCount - 1; i >= 0; i--)
        {
            if (holder.GetChild(i) != null)
            {
                Destroy(holder.GetChild(i).gameObject);
            }
        }
    }
    private void ViewGrid(WareHouseBuilding _warehouse,WareHouseItem prefabItem,List<EntityCurrencyProperties> propertiesList,PanalTradePopup panalTradePopup,WareHousePanalDetail wareHousePanalDetail)
    {
        
        var tmpList = new Dictionary<EntityCurrencyProperties, long>();

        for (int i = 0; i < propertiesList.Count; i++)
        {
            var tmpValue = FarmMapController.Instance.GeneralBalance.GetValue(propertiesList[i].CurrencyName);
            if (tmpValue > 0)
            {
                tmpList.Add(propertiesList[i], tmpValue);
            }
        }

    
        foreach (var tmp in tmpList)
        {
            var tmpItem = Instantiate(prefabItem, holder);
            tmpItem.Init(tmp,panalTradePopup,wareHousePanalDetail);
          
        }
    }
}
