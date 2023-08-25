using System;
using UnityEngine;

//các ảnh các giai oạn của việc stage1 stage2 v sẵn sàng và héo thì ntn
[Serializable]
public class CropSprites
{
    [SerializeField] private Sprite _growingStage1Sprite;

    [SerializeField] private Sprite _growingStage2Sprite;

    [SerializeField] private Sprite[] _harvestReadySprites;

    [SerializeField] private Sprite _witheredSprite;

    public Sprite GrowingStage1Sprite
    {
        get { return _growingStage1Sprite; }
    }

    public Sprite GrowingStage2Sprite
    {
        get { return _growingStage2Sprite; }
    }

    public Sprite WitheredSprite
    {
        get { return _witheredSprite; }
    }

    public Sprite[] HarvestReadySprites
    {
        get { return _harvestReadySprites; }
    }

    public CropSprites(Sprite stage1, Sprite stage2, Sprite withered, Sprite[] ready)
    {
        _growingStage1Sprite = stage1;
        _growingStage2Sprite = stage2;
        _witheredSprite = withered;
        _harvestReadySprites = ready;
    }
}