using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryCollectTweenManager : MonoSingleton<InventoryCollectTweenManager>
{
    //prefab item để sau tạo ra cho nó nhảy bay lên:::
    [SerializeField]
    private InventoryCollectTweenItem InventoryCollectTweenItemPrefab = new InventoryCollectTweenItem();

    //List cache lại item tọa ra từ prefab::
    [SerializeField] private List<InventoryCollectTweenItem> ItemCache = new List<InventoryCollectTweenItem>();

    [SerializeField] private float TweenDuration = 0.5f;
    [SerializeField] private AnimationCurve TargetXCurve;
    [SerializeField] private AnimationCurve TargetYCurve;


    private InventoryManagerView _inventoryManagerView;

    private List<InventoryCollectTweenItem> _activeTweenItems;
    private Vector2 _size;
    private Vector3[] _worldCorners;

    //TẠO TWEEEN TỪ NHÀ MÁY SẢN XUẤT???? TỪ VỊ TRÍ THẾ GIỚI
    public void CreateTweenFromFactoryWorldCanvas(Vector3 worldPosition, Sprite sprite, RectTransform rectTransform,
        Action onBegin = null, Action onAnimEnd = null, bool trailActive = false)
    {
    }

    //TWEEN TỪ UI
    public void CreateTweenFromUI(Vector3 worldPosition, Sprite sprite, RectTransform rectTransform, Vector3 targetPos,
        Action onBegin = null, Action onAnimEnd = null, bool trailActive = false)
    {
    }


    //TAO TWEEN TỪ GATHERABLE
    //TRUYỀN TỪ VỊ TRÍ VECTOR3==>>> TỚI RECTTRANSFORM:::
    public void CreateTweenFromGatherables(Vector3 position, Sprite tweenSprite, RectTransform rectTransform,
        Vector3 targetPos, Action onAnimBegin = null, Action onAnimEnd = null, bool trailActive = false)
    {
        //NẾU SỐ LƯỢNG ITEMCACHE CHỨA BẰNG 0 TỨC HẾT MẤT STACK THÌ SẼ
        if (ItemCache.Count == 0)
        {
            InventoryCollectTweenItem tweenItemInstance =
                UnityEngine.Object.Instantiate<InventoryCollectTweenItem>(
                    original: this.InventoryCollectTweenItemPrefab,
                    this.transform);
            this.ItemCache.Add(tweenItemInstance);
        }

        InventoryCollectTweenItem item = ExtensionUtils.Pop<InventoryCollectTweenItem>(ItemCache);
        this._activeTweenItems.Add(item);
        item.ItemIcon.sprite = tweenSprite;
        item.TrailGameObject.SetActive(value: trailActive);


        this.SendTween(item,
            position,
            useScreenPosition: true,
            targetPos,
             onAnimBegin,  onAnimEnd);
    }

    //
    private void SendTween(InventoryCollectTweenItem tweenItem, Vector3 position, bool useScreenPosition,
        Vector3 targetPos, Action onAnimBegin = null, Action onAnimEnd = null)
    {
    }
}