using UnityEngine.EventSystems;

public class ItemBonusView : BuildingView
{
    public override void OnPointerClick(PointerEventData eventData)
    {
        TileManagerView.Instance.FireTileCollectItemBonusEvent(BuildingData as ItemBonus);
    }
}
