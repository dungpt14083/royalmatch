using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildConfirmPopupRequest : PopupRequest
{
    public BuildingProperties BuildingProps { get; private set; }
    public Building Building { get; private set; }
    public ItemShop ItemShop { get; private set; }

    public SpriteRenderer spriteRenderer { get; private set; }

    //BUID MỚI
    public BuildConfirmPopupRequest(BuildingProperties props)
        : base(typeof(BuildConfirmPopup), true, false, true, false)
    {
        BuildingProps = props;
    }

    //MOVE
    public BuildConfirmPopupRequest(Building building, SpriteRenderer _spr)
        : base(typeof(BuildConfirmPopup), true, false, true, false)
    {
        Building = building;
        BuildingProps = Building.BuildingProperties;
        spriteRenderer = _spr;
    }
    //BUID Decoration
    public BuildConfirmPopupRequest(BuildingProperties props,ItemShop itemShop)
        : base(typeof(BuildConfirmPopup), true, false, true, false)
    {
        BuildingProps = props;
        ItemShop = itemShop;
    }
}