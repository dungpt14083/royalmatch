using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventCollectPopup : Popup
{
   [SerializeField] private RectTransform _Content;
   [SerializeField] private ItemEventCollect _itemEventCollect; 
   public GameObject notification;
   [SerializeField] private TMP_Text txtNotification;
   public List<EventCollect> ListData;
   
   [SerializeField]private bool isAnimatingSliders = false;
   private List<ItemEventCollect> collectItems = new List<ItemEventCollect>();
   private int currentProgress = 0;

   [SerializeField] private Slider _sliderSubProgress;
   [SerializeField] private TMP_Text txtSubProgress;
   [SerializeField] private TMP_Text txtCurrentProgress;
   private int currentSubProgress;
  // private int maxSubProgress =30;
   
   public override void Init(GameData game, IsLandInfo isLandInfo)
   {
      base.Init(game, isLandInfo);
   }
 
   public override void Open(PopupRequest request)
   {
      base.Open(request);
      EventCollectRequestPopup eventCollectRequestPopup = GetRequest<EventCollectRequestPopup>();
      SetDefault();
      for (int i = 0; i < ListData.Count; i++)
      {
         EventCollect collect = ListData[i];
         collect.id = i + 1;
         var tmp = Instantiate(_itemEventCollect, _Content);
         tmp.Init(this,collect);
         tmp.OnFreeButtonClicked += SetupNotification;
         tmp.OnStatusChanged += CollectItemStatusChanged;
         tmp.OnUpdateUIButtonClicked += CollectItemProgressChanged;
         collectItems.Add(tmp);
      }
      StartAnimatingSliders();
      UpdateUISubProgress();
   }
   
   private void SetDefault()
   {
      for (int i = _Content.childCount - 1; i >= 0; i--)
      {
         if (_Content.GetChild(i) != null)
         {
            Destroy(_Content.GetChild(i).gameObject);
         }
      }
      collectItems.Clear();
   }
   
   public void SetupNotification(string txt="")
   {
      notification.gameObject.SetActive(!notification.activeSelf);
      txtNotification.text = txt;
   }
   
   private void StartAnimatingSliders()
   {
      if (!isAnimatingSliders)
      {
         StartCoroutine(AnimateSlidersSequentially());
      }
   }

   //animation chạy slider
   private IEnumerator AnimateSlidersSequentially()
   {
      isAnimatingSliders = true;

      foreach (var item in collectItems.Where(item => item.CanReceiveReward()))
      {
         if (item.StartSliderAnimation())
         {
            yield return new WaitForSeconds(1.0f);
         }
         else
         {
            yield return new WaitForSeconds(0f);
         }
         
         
      }

      isAnimatingSliders = false;
   }
   //đổi trạng thái item trong list
   private void CollectItemStatusChanged(ItemEventCollect sender)
   {
      int index = ListData.FindIndex(collect => collect.id == sender._eventCollect.id);

      if (index != -1)
      {
         ListData[index].statusReward = sender._statusEventCollect;
      }
   }
   //mỗi lần progress++ thì cập nhật stt
   private void CollectItemProgressChanged(ItemEventCollect sender)
   {
      int index = ListData.FindIndex(collect => collect.id == sender._eventCollect.id);

      if (index == -1) return;
      if (ListData[index].id > currentProgress) return;
      if (ListData[index].statusReward == StatusEventCollect.Rewarded) return;
      sender._statusEventCollect = StatusEventCollect.CanReward;
      CollectItemStatusChanged(sender);
   }

   [Button]
   private void AddProgress()
   {
      currentProgress++;
      foreach (var item in collectItems)
      {
         item.UpdateUIClickEvent();
         item.UpdateUI();
      }
      StartAnimatingSliders();
   }

   [Button]
   private void AddCurrentProgress()
   {
      currentSubProgress++;
      UpdateUISubProgress();
   }

   private void UpdateUISubProgress()
   {
      _sliderSubProgress.maxValue = maxSubProgress;
      _sliderSubProgress.value = currentSubProgress;
      
      if (_sliderSubProgress.value == _sliderSubProgress.maxValue)
      {
         currentSubProgress = 0;
         _sliderSubProgress.value = currentSubProgress;
         AddProgress();
      }

      txtSubProgress.text = $"{_sliderSubProgress.value}/{_sliderSubProgress.maxValue}";
      txtCurrentProgress.text = (currentProgress).ToString();
   }

   private int _maxSubProgress;
   public int maxSubProgress
   {
      get
      {
         _maxSubProgress = currentProgress switch
         {
            >= 0 and <= 5 => 5,
            >= 6 and <= 10 => 6,
            >= 11 and <= 14 => 10,
            >= 15 and <= 19 => 15,
            >= 20 and <= 24 => 20,
            _ => 30
         };

         return _maxSubProgress;
      }
   }
}
