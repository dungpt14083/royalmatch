using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ItemEventCollect : MonoBehaviour
{
  //free
  [SerializeField] private Button btnFree;
  [SerializeField] private TMP_Text txtCountFree;
  [SerializeField] private Image iconRewardFree;
  [SerializeField] private Image iconStatusFree;

  [SerializeField] private Image IconClaim;
  //vip
  [SerializeField] private Button btnVip;
  [SerializeField] private TMP_Text txtCountVip;
  [SerializeField] private Image iconRewardVip;
  [SerializeField] private Image iconStatusVip;
  //
  [SerializeField] private Slider _slider;
  [SerializeField] private TMP_Text txtTitle;

  [SerializeField] private Sprite[] spriteStt;
  public EventCollect _eventCollect;
  private EventCollectPopup _eventCollectPopup;
  public StatusEventCollect _statusEventCollect;
  
  private Coroutine sliderCoroutine;


  public delegate void UpdateUIButtonClickedHandler(ItemEventCollect sender);
  public event UpdateUIButtonClickedHandler OnUpdateUIButtonClicked;

  public void UpdateUIClickEvent()
  {
    if (OnUpdateUIButtonClicked != null)
    {
      OnUpdateUIButtonClicked(this);
    }
  }
  
  public delegate void FreeButtonClickedHandler(string sender);
  public event FreeButtonClickedHandler OnFreeButtonClicked;
  
  public void RaiseFreeButtonClickedEvent(string txt)
  {
    if (OnFreeButtonClicked != null)
    {
      OnFreeButtonClicked(txt);
    }
  }
  
  //collect
  public delegate void StatusChangedHandler(ItemEventCollect sender);
  public event StatusChangedHandler OnStatusChanged;

  private void RaiseStatusChangedEvent()
  {
    OnStatusChanged?.Invoke(this);
  }
  
  public void Init(EventCollectPopup eventCollectPopup,EventCollect eventCollect)
  {
    _eventCollectPopup = eventCollectPopup;
    _eventCollect = eventCollect;
    txtCountFree.text = _eventCollect.countFree.ToString();
    iconRewardFree.sprite = _eventCollect.IconRewardFree;
    _statusEventCollect = _eventCollect.statusReward;
    txtCountVip.text = _eventCollect.countVip.ToString();
    iconRewardVip.sprite = _eventCollect.IconRewardVip;
    txtTitle.text = _eventCollect.id.ToString();
   // btnVip.interactable = _eventCollect.UnlockVip;
    btnFree.onClick.AddListener(OnclickBtnFree); 
    btnVip.onClick.AddListener(OnclickBtnVip);
    switch (_statusEventCollect)
    {
      case StatusEventCollect.Rewarded:
        iconStatusFree.gameObject.SetActive(true);
        IconClaim.gameObject.SetActive(false);
        iconStatusFree.sprite = spriteStt[1];
        _slider.value = 1;
       
        break;
      case StatusEventCollect.CanRewardWatched:
        iconStatusFree.gameObject.SetActive(false);
        IconClaim.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(EarnReward);
        break;
      case StatusEventCollect.CanReward:
        iconStatusFree.gameObject.SetActive(false);
        IconClaim.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(EarnReward);
        break;
      case StatusEventCollect.NotCanReward:
        iconStatusFree.gameObject.SetActive(true);
        IconClaim.gameObject.SetActive(false);
        iconStatusFree.sprite = spriteStt[0];
        _slider.value = 0;
      
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  public void UpdateUI()
  {
    switch (_statusEventCollect)
    {
      case StatusEventCollect.Rewarded:
        iconStatusFree.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(OnclickBtnFree);
        IconClaim.gameObject.SetActive(false);
        iconStatusFree.sprite = spriteStt[1];
        _slider.value = 1;
       
        break;
      case StatusEventCollect.CanRewardWatched:
        iconStatusFree.gameObject.SetActive(false);
        IconClaim.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(EarnReward);
        break;
      case StatusEventCollect.CanReward:
        iconStatusFree.gameObject.SetActive(false);
        IconClaim.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(EarnReward);
        break;
      case StatusEventCollect.NotCanReward:
        iconStatusFree.gameObject.SetActive(true);
        btnFree.onClick.RemoveAllListeners();
        btnFree.onClick.AddListener(OnclickBtnFree);
        IconClaim.gameObject.SetActive(false);
        iconStatusFree.sprite = spriteStt[0];
        _slider.value = 0;
        break;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }
  private IEnumerator AnimateSliderFill()
  {
    
    float duration = 1.0f; 
    float elapsedTime = 0.0f;
    float startValue = 0.0f;
    float endValue = 1.0f;

    while (elapsedTime < duration)
    {
      _slider.value = Mathf.Lerp(startValue, endValue, elapsedTime / duration);
      elapsedTime += Time.deltaTime;
      yield return null;
    }

    _slider.value = endValue;
  }

  private void OnclickBtnFree()
  {
    _eventCollectPopup.notification.transform.position = btnFree.transform.position;
    string txt = _statusEventCollect switch
    {
      StatusEventCollect.Rewarded => "received the reward",
      StatusEventCollect.NotCanReward => "Collect more Item to unlock this stage and get the reward!",
      StatusEventCollect.CanReward => "",
      StatusEventCollect.CanRewardWatched=>"",
      _ => ""
    };
    RaiseFreeButtonClickedEvent(txt);
  }
  private void OnclickBtnVip()
  {
    _eventCollectPopup.notification.transform.position = btnVip.transform.position;
    string txt = _eventCollect.UnlockVip switch
    {
      true => "",
      false => " unlock Vip this stage and get the reward!"
    };
    RaiseFreeButtonClickedEvent(txt);
  }

  private void EarnReward()
  {
    if (_statusEventCollect != StatusEventCollect.CanReward) return;
    _statusEventCollect = StatusEventCollect.Rewarded;
    
    UpdateUI();
    RaiseStatusChangedEvent();
  }
  public bool StartSliderAnimation()
  {
    if (sliderCoroutine != null)
    {
      StopCoroutine(sliderCoroutine);
      return false;
    }

    if (_slider.value < 1)
    {
      sliderCoroutine = StartCoroutine(AnimateSliderFill());
      return true;
    }
    btnFree.onClick.RemoveAllListeners();
    btnFree.onClick.AddListener(EarnReward);
    return false;
  }
  public bool CanReceiveReward()
  {
    return _statusEventCollect == StatusEventCollect.CanReward;
  }
}
