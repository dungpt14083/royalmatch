using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class FruitTreeSprites 
{
   [SerializeField] private Sprite _growingStage1Sprite;

   [SerializeField] private Sprite _growingStage2Sprite;

   [SerializeField] private Sprite _harvestReadySprites;

   [SerializeField] private Sprite _witheredSprite;
   
   public Sprite GrowingStage1Sprite => _growingStage1Sprite;

   public Sprite GrowingStage2Sprite => _growingStage2Sprite;

   public Sprite WitheredSprite => _witheredSprite;

   public Sprite HarvestReadySprites => _harvestReadySprites;

   public FruitTreeSprites(Sprite growingStage1Sprite, Sprite growingStage2Sprite, Sprite harvestReadySprites, Sprite witheredSprite)
   {
      _growingStage1Sprite = growingStage1Sprite;
      _growingStage2Sprite = growingStage2Sprite;
      _harvestReadySprites = harvestReadySprites;
      _witheredSprite = witheredSprite;
   }
   
}
