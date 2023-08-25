using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPopup : Popup
{
    //LIST TẤT CẢ LOA CATEGORY ĐỂ HIỂN THỊ LÊN NÚT BẤM LOẠI SHOP
    [SerializeField] private ShopCategoryButtonView[] _shopCategoryButtons;
    [SerializeField] private TabsUIHorizontal _tabsUIHorizontal;


    //KHI VÀO GAME ĐƯỢC INIT ĐẦU TIÊN ĐÃ
    public override void Init(GameData game, IsLandInfo isLandInfo)
    {
        //ĐÂY LÀ DATA SHOP ĐI
        base.Init(game, isLandInfo);

     
    }

    //22 SAU ĐÓ THÌ ĐƯỢC OPEN MỞ LÊN....
    public override void Open(PopupRequest request)
    {
        //SETACTIVE TẠM XONG SAU ĐÓ XỬ LÍ
        base.Open(request);

        //SAU ĐÓ LẤY SHOPREQUEST ĐỂ XỬ LÍ::
        ShopPopupRequest request2 = GetRequest<ShopPopupRequest>();
        int num = _shopCategoryButtons.Length;
        for (int i = 0; i < num; i++)
        {
            _shopCategoryButtons[i].Init(_game,_isLandInfo);
        }
    }

    public void OnClickedShopCategory(ShopCategoryButtonView button)
    {
        
        _game.PopupManager.RequestPopup(new BuildingsShopPopupRequest(button.Category, null));
    }

    public override void OnCloseClicked()
    {  
        base.OnCloseClicked();
      
    }

    private void OnDisable()
    {
        SetDefault();
    }

    private void SetDefault()
    {
        _tabsUIHorizontal.OnTabButtonClicked(0);
    }
}