


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventFindPlayerPopup : Popup
{
   public List<UserEventLaval> lavaSprites;
   [SerializeField] private AvatarIcon _itemAvatarIcon;
   [SerializeField] private RectTransform holderAvatar;
   [SerializeField] private TMP_Text _txtLevel;
   [SerializeField] private TMP_Text _txtpeople;
   [SerializeField] private TMP_Text _txtReward;
   private int currentPossition =0;
  [SerializeField] private List<Transform> _listPosition;
   private List<AvatarIcon> listUser = new List<AvatarIcon>();
   private List<AvatarIcon> listStartUser = new List<AvatarIcon>();
   AvatarIcon mainPlayerIcon = null;
   private bool isIconMove = false;
   private int maxPeople;
   private int maxLevel;
   private float reward = 1000;

   public GameObject PopupEvent;
   public GameObject StartEvent;
   private bool isFirstTime = true;

   [Header("eventStart")] 
   [SerializeField] private TMP_Text txtStartReward;

   [SerializeField] private TMP_Text txtstartPlayer;
   [SerializeField] private RectTransform startHolderAvatar;
   [SerializeField] private Button btnContinuce;
   private int currentStartPlayerCount = 0;
   private const int maxStartPlayerCount = 100;
   private int maxPlayerOnTop=15;
   public override void Init(GameData game, IsLandInfo isLandInfo)
   {
      base.Init(game, isLandInfo);
   }

   public override void Open(PopupRequest request)
   {
      base.Open(request);
      isFirstTime = PlayerPrefs.GetInt("IsFirstTime", 1) == 1;

      EventFindPlayerRequestPopup eventFindPlayerRequestPopup = GetRequest<EventFindPlayerRequestPopup>();
      if (isFirstTime)
      {
         StartEvent.SetActive(true);
         PopupEvent.SetActive(false);
         StartCoroutine(InitAvatarStart());
      }
      else
      {
         StartEvent.SetActive(false);
         PopupEvent.SetActive(true);
         InitIcon();
      }
      isFirstTime = false;
   }

   private void InitIcon()
   {
      if (listUser.Count > 0)
      {
         return;
      }
      var newpos = _listPosition[currentPossition];
      holderAvatar.gameObject.transform.position = newpos.position;

      for (int i = 0; i < lavaSprites.Count; i++)
      {
         UserEventLaval eventLaval = lavaSprites[i];
         var tmp = Instantiate(_itemAvatarIcon, holderAvatar);
         var position = tmp.transform.position;
         if (eventLaval.isPlayer)
         {
            mainPlayerIcon = tmp;
         }
         position = new Vector3(Random.Range(position.x-50f, position.x+50f),
            Random.Range(position.y-50f, position.y+50f), position.z);
         
         tmp.transform.position = position;
         tmp.Init(eventLaval);
         listUser.Add(tmp);
      }

      if (mainPlayerIcon != null)
      {
         mainPlayerIcon.transform.SetAsLastSibling();
      }

      maxLevel = _listPosition.Count -1;
      maxPeople = listUser.Count;
      UpdateUI();
   }

   private void UpdateUI()
   {
      _txtLevel.text = $"{currentPossition}/{maxLevel}";
      _txtpeople.text = $"{listUser.Count}/{maxPeople}";
      _txtReward.text = reward.ToString();
   }

   [Button]
   private void updatePosition()
   {
      currentPossition++;
      if (currentPossition >= _listPosition.Count) return;
      StartAnimatingSliders();
      UpdateUI();
   }
   
   private void StartAnimatingSliders()
   {
      if (!isIconMove)
      {
         StartCoroutine(AnimateSlidersSequentially());
      }
   }

   private IEnumerator AnimateSlidersSequentially()
   {
      
      isIconMove = true;
      List<int> indexesToRemove = new List<int>();
      Debug.Log("check trước khi xóa"+listUser.Count);
      for (int i = 0; i < listUser.Count; i++)
      {
         var item = listUser[i];
         var newpos = _listPosition[currentPossition];
         if (Random.Range(0f, 1f) < Random.Range(0.1f,0.6f)  && !item.isMainplayer)
         {
            indexesToRemove.Add(i);
         }
         else
         {
            var position = newpos.position;
            item.transform.position = new Vector3(Random.Range(position.x + 20, position.x - 20), Random.Range(position.y + 20, position.y - 20), position.z);
         }
         item.transform.SetParent(_listPosition[currentPossition]);
         if (mainPlayerIcon != null)
         {
            mainPlayerIcon.transform.SetAsLastSibling();
         }
         // yield return new WaitForSeconds(0.05f);
        
      }
      
      foreach (var index in indexesToRemove.Where(index => index >= 0 && index < listUser.Count))
      {
         Destroy(listUser[index].gameObject);
      }
      listUser.RemoveAll(item => indexesToRemove.Contains(listUser.IndexOf(item)));
      if (currentPossition >= 1)
      {
         var oldpos = _listPosition[currentPossition - 1];
         oldpos.gameObject.SetActive(false);
      }
      if (currentPossition == 7 && listUser.Count > maxPlayerOnTop)
      {
         int excessCount = listUser.Count - maxPlayerOnTop;
         for (int i = listUser.Count - 1; i >= 0 && excessCount > 0; i--)
         {
            if (listUser[i] != mainPlayerIcon) 
            {
               Destroy(listUser[i].gameObject);
               listUser.RemoveAt(i);
               excessCount--;
            }
         }
      }
      Debug.Log("check sau khi xóa2"+listUser.Count);
      if (currentPossition == 7)
      {
         EarnReward(listUser.Count);
      }
      isIconMove = false;
      yield return null;
   }

   private void EarnReward(int people)
   {
      var s = $"chia tiền cho {people} anh em mỗi anh em: {reward/people}";
      Debug.Log(s);
   }

   #region StartEvent

   private IEnumerator InitAvatarStart()
   {
      currentStartPlayerCount = 0; // Reset số lượng người chơi
      for (int i = 0; i < lavaSprites.Count; i++)
      {
         UserEventLaval eventLaval = lavaSprites[i];
         if (currentStartPlayerCount <= 20)
         {
            var tmp = Instantiate(_itemAvatarIcon, startHolderAvatar);
            var position = tmp.transform.position;

            if (eventLaval.isPlayer)
            {
               mainPlayerIcon = tmp;
            }

            listStartUser.Add(tmp);
            position = new Vector3(Random.Range(position.x - 50f, position.x + 50f),
               Random.Range(position.y - 50f, position.y + 50f), position.z);

            tmp.transform.position = position;
            tmp.Init(eventLaval);
         }

         currentStartPlayerCount++;
         txtstartPlayer.text = $"{currentStartPlayerCount}/{maxStartPlayerCount}";

         yield return new WaitForSeconds(0.02f);

         if (currentStartPlayerCount >= maxStartPlayerCount)
         {
            break;
         }
      }

      if (mainPlayerIcon != null)
      {
         mainPlayerIcon.transform.SetAsLastSibling();
      }
      btnContinuce.onClick.AddListener(ContinuceEvent);
   }

   private void ContinuceEvent()
   {
      StartEvent.SetActive(false);
      PopupEvent.SetActive(true);
      InitIcon();
      PlayerPrefs.SetInt("IsFirstTime", isFirstTime ? 1 : 0);
      PlayerPrefs.Save(); // Lưu thay đổi vào PlayerPrefs
   }
   #endregion
}
