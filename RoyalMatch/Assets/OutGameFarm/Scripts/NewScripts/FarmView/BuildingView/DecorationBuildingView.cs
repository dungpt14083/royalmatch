using UnityEngine;
using UnityEngine.EventSystems;

public class DecorationBuildingView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
    //[SerializeField]
    //private BuildingView _buildingView;
    private DecorationBuilding _building;

    public void Init(DecorationBuilding building)
    {
        _building = building;
    }

    private void OnDestroy()
    {
        _building = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }
}