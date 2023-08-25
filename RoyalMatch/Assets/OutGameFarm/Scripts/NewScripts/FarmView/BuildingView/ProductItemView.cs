using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProductItemView : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private SpriteRenderer icon;
    [SerializeField] private BoxCollider collider;
    Action addProductToInventory;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick ProductItemView");
        addProductToInventory?.Invoke();
    }

    public void Show(ProductProperties product,Action _addProductToInventory)
    {
        addProductToInventory = _addProductToInventory;
        gameObject.SetActive(true);
        icon.sprite = SingletonMonobehaviour<CurrencySpritesAssetCollection>.Instance.GetAsset(Currency.GetCurrencyTypeByName(product.CurrencyName));
    }
    public void EnableCollider(bool status)
    {
        collider.enabled = status;
    }
}
