using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopupDetailEventRank : MonoBehaviour
{
   [SerializeField] private TMP_Text txtdesc;
   [SerializeField] private Image _icon;
   [SerializeField] private TMP_Text txtReward;

   public void Init(string desc, Sprite icon, int reward)
   {
      txtdesc.text = desc;
      _icon.sprite = icon;
      txtReward.text = reward.ToString();
   }
}
