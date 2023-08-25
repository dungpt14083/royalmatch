using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class NotEnoughEnergyPopup : Popup
{
    [SerializeField] private Button CloseButton;
    [SerializeField] private Button OkayButton;

    private NotEnoughEnergyPopupRequest _confirmRequest;

    private void Start()
    {
        CloseButton.onClick.AddListener(ClosePopup);
        OkayButton.onClick.AddListener(ClosePopup);
    }

    protected override void OnDestroy()
    {
        base.OnDestroy();
        CloseButton.onClick.RemoveListener(ClosePopup);
        OkayButton.onClick.RemoveListener(ClosePopup);
    }

    private void ClosePopup()
    {
        OnCloseClicked();
    }

    public override void Open(PopupRequest request)
    {
        base.Open(request);
        _confirmRequest = GetRequest<NotEnoughEnergyPopupRequest>();

    }
    
}
