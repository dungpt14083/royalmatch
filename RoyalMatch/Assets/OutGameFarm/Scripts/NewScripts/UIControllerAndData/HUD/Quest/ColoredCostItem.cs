using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ColoredCostItem : MonoBehaviour
{
    [SerializeField] private List<Sprite> BackgroundSprites;
    [SerializeField] private Button ForwardButton;
    [SerializeField] private Image TaskImage;
    [SerializeField] private Image TaskBackgroundImage;
    [SerializeField] private TMP_Text ColoredProgressText;

    private TradeInfo _costInfo;
    private int _taskIndex;
    private int _progress;

    public void SetCostInfo(TradeInfo costInfo)
    {
        this._costInfo = costInfo;
        this.Refresh();
    }

    private void Refresh()
    {
        ForwardButton.gameObject.SetActive(true);
        //NẾU NHƯ LÀ CANREMOVE TỨC LÀ LỚN HƠN NVU YÊU CẦU THÌ SẼ K HIỆN NÚT FORWARD TỚI TÀI NGUYÊN NỮA::
        if (TradeManager.Instance.CanRemove(_costInfo))
        {
            this.ForwardButton.gameObject.SetActive(value: false);
        }

        TaskImage.sprite = TradeManager.Instance.GetSprite(_costInfo);
        //lấy inventory ra lấy ố lượng chia trên thằng max của nhiệm vụ 
        ColoredProgressText.text =
            InventoryManagerView.Instance.GeneralBalance.GetValue((CurrencyType)_costInfo.IdInType) + "/" +
            _costInfo.Amount.ToString();
    }
}