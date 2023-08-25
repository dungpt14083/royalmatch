using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBonusManager : SingletonMonobehaviour<ItemBonusManager>
{
    private List<ItemBonusRepeatProperties> allItemBonusRepeat = new ();
    public Dictionary<string, UpspeedableProcess> listResetItemBonusRepeatProcess = new Dictionary<string, UpspeedableProcess>();
    public List<GridIndex> allPositionEmpty = new();

    private void Start()
    {
        
    }
    public void Init()
    {
        allPositionEmpty.Add(new GridIndex(66 - 4, 0 + 2));
        allPositionEmpty.Add(new GridIndex(66 - 4, 1 + 2));
        allPositionEmpty.Add(new GridIndex(67 - 4, 0 + 2));
        allPositionEmpty.Add(new GridIndex(67 - 4, 1 + 2));
        allPositionEmpty.Add(new GridIndex(68 - 4, 0 + 2));
        allPositionEmpty.Add(new GridIndex(68 - 4, 1 + 2));
        allPositionEmpty.Add(new GridIndex(68 - 4, 2 + 2));
        allPositionEmpty.Add(new GridIndex(69 - 4, 1 + 2));
        allPositionEmpty.Add(new GridIndex(69 - 4, 2 + 2));
        allPositionEmpty.Add(new GridIndex(69 - 4, 3 + 2));
        allPositionEmpty.Add(new GridIndex(69 - 4, 4 + 2));
        allPositionEmpty.Add(new GridIndex(70 - 4, 3 + 2));
        allPositionEmpty.Add(new GridIndex(70 - 4, 4 + 2));
        allPositionEmpty.Add(new GridIndex(70 - 4, 5 + 2));
        allPositionEmpty.Add(new GridIndex(70 - 4, 6 + 2));

        if (FarmMapController.Instance == null) Debug.Log("ItemBonusManager FarmMapController.Instance null");
        var IslandFarmProperties = FarmMapController.Instance.GetIslandFarmProperties();
        if (IslandFarmProperties == null) Debug.Log("ItemBonusManager GetIslandFarmProperties null");
        allItemBonusRepeat = IslandFarmProperties.GetItemBonusRepeatProperties();
        CreateRandomItemBonusRepeat();
    }
    public void CreateRandomItemBonusRepeat()
    {
        Debug.Log("CreateRandomItemBonusRepeat");
        foreach(var item in allItemBonusRepeat)
        {
            CreateItemBonusRepeat(item);
        }
    }
    public GridIndex GetRandomGridIndexEmpty()
    {
        int index = Random.Range(0, allPositionEmpty.Count);
        GridIndex grid = allPositionEmpty[index];
        return grid;
    }
    public void AddGridIndexEmpty(GridIndex grid)
    {
        allPositionEmpty.Add(grid);
    }
    public void RemoveGridIndexEmpty(GridIndex grid)
    {
        allPositionEmpty.Remove(grid);
    }
    public void CreateItemBonusRepeat(ItemBonusRepeatProperties itemBonusRepeatProperties)
    {
        var pos = GetRandomGridIndexEmpty();
        RemoveGridIndexEmpty(pos);
        FarmMapController.Instance.IsLandInfo.PlaceBuildingWithProperties(itemBonusRepeatProperties, pos, PopupManagerView.Instance.PopupManager, FarmMapController.Instance.TimeKeeper);
    }
    public void CreateItemBonusRepeatProcess(ItemBonusRepeatProperties itemBonusRepeatProperties)
    {
        if (listResetItemBonusRepeatProcess.ContainsKey(itemBonusRepeatProperties.BuildingName))
        {
            listResetItemBonusRepeatProcess.Remove(itemBonusRepeatProperties.BuildingName);
        }
        var process = new UpspeedableProcess(FarmMapController.Instance.GetIslandFarmProperties(), FarmMapController.Instance.GetTimeKeeper(), itemBonusRepeatProperties.timeReset,
                    1.0,
                    1f, () => { CreateItemBonusRepeat(itemBonusRepeatProperties); }, FarmMapController.Instance.GetGeneralProperties());
        listResetItemBonusRepeatProcess.Add(itemBonusRepeatProperties.BuildingName, process);
    }
}
