using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingsShopItemView : MonoBehaviour
{
    [SerializeField] private TMP_Text txtName;

    private BuildingProperties _props;
    private GameData _game;


    public void Init(BuildingProperties props, GameData game)
    {
        _game = game;
        _props = props;
        if (props != null)
        {
            txtName.text = props.BuildingName;
        }
        //ChooseBuildingsShopItemView();
    }

    //ẤN VÀO
    public void OnButtonClicked()
    {
        _game.PopupManager.RequestPopup(new BuildConfirmPopupRequest(_props));
        _game.PopupManager.CloseAllOpenPopups();
    }
}