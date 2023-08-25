using System;
using System.Collections;
using System.Collections.Generic;
using EasyButtons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EventCollectLightBall : MonoBehaviour
{
   [SerializeField] private Slider _slider;
   private int _maxProgress = 30;
   private int _currentProgress;
   [SerializeField]  private TMP_Text _textProgress;

   private void Start()
   {
      _slider.maxValue = _maxProgress;
      UpdateUI();
   }

   private void UpdateUI()
   {
      _slider.value = _currentProgress;
      _textProgress.text = $"{_currentProgress}/{_maxProgress}";
   }
   
   [Button]
   private void AddProgress()
   {
      if (_currentProgress >= _maxProgress) return;
      _currentProgress += 1;
      UpdateUI();
   }
   
}
