using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropView : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private bool _active;
    private bool _visible;
    private IEnumerator _growRoutine;
    private CropSprites _sprites;
    private FarmFieldBuilding _farmFieldBuilding;

    public void Init(FarmFieldBuilding farmFieldBuilding, FarmfieldTemplateType farmFieldTemplate)
    {
        _farmFieldBuilding = farmFieldBuilding;
        _active = false;
        _visible = false;
    }

    public void SetVisible(bool visible)
    {
        _visible = visible;
        UpdateRenderer();
    }

    public void Activate()
    {
        _sprites = SingletonMonobehaviour<CropsAssetCollection>.Instance.GetAsset(_farmFieldBuilding.SowedMaterial
            .CropSpriteReference);
        Debug.LogError(_sprites.ToString());
    }

    public void Deactivate()
    {
        StopCoroutines();
        _active = false;
        UpdateRenderer();
    }

    public void StartGrowing()
    {
        _sprites = SingletonMonobehaviour<CropsAssetCollection>.Instance.GetAsset(_farmFieldBuilding.SowedMaterial
            .CropSpriteReference);
        this.Invoke(StartGrowingNow, Random.Range(0f, 1f));
    }

    private void StartGrowingNow()
    {
        _active = true;
        UpdateRenderer();
        double num = (double)_farmFieldBuilding.SowedMaterial.ProductionTimeSeconds / 2.0;
        if (_farmFieldBuilding.FieldProcess.RemainingTimeSeconds < num)
        {
            _renderer.sprite = _sprites.GrowingStage2Sprite;
            return;
        }

        _renderer.sprite = _sprites.GrowingStage1Sprite;
        double timeLeftInSeconds = _farmFieldBuilding.FieldProcess.RemainingTimeSeconds - num;
        StartCoroutine(_growRoutine = GrowToSecondStageRoutine(timeLeftInSeconds));
    }

    private IEnumerator GrowToSecondStageRoutine(double timeLeftInSeconds)
    {
        yield return _farmFieldBuilding.FieldProcess.WaitForProcessSeconds(timeLeftInSeconds);
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        _renderer.sprite = _sprites.GrowingStage2Sprite;
        _growRoutine = null;
    }

    public void TurnHarvestReady()
    {
        if (this.IsInvoking(StartGrowingNow))
        {
            this.CancelInvoke(StartGrowingNow);
        }

        if (_growRoutine != null)
        {
            StopCoroutine(_growRoutine);
        }

        this.Invoke(TurnHarvestReadyNow, Random.Range(0f, 1f));
    }

    private void TurnHarvestReadyNow()
    {
        _active = true;
        UpdateRenderer();
        _renderer.sprite = _sprites.HarvestReadySprites[0];
    }

    public void TurnWithered()
    {
        if (this.IsInvoking(TurnHarvestReadyNow))
        {
            this.CancelInvoke(TurnHarvestReadyNow);
        }

        this.Invoke(TurnWitheredNow, Random.Range(0f, 1f));
    }

    private void TurnWitheredNow()
    {
        _active = true;
        UpdateRenderer();
        _renderer.sprite = _sprites.WitheredSprite;
    }

    private void UpdateRenderer()
    {
        _renderer.enabled = _active && _visible;
    }

    private void StopCoroutines()
    {
        if (this.IsInvoking(TurnHarvestReadyNow))
        {
            this.CancelInvoke(TurnHarvestReadyNow);
        }

        if (this.IsInvoking(TurnWitheredNow))
        {
            this.CancelInvoke(TurnWitheredNow);
        }

        if (this.IsInvoking(StartGrowingNow))
        {
            this.CancelInvoke(StartGrowingNow);
        }

        if (_growRoutine != null)
        {
            StopCoroutine(_growRoutine);
        }
    }
}