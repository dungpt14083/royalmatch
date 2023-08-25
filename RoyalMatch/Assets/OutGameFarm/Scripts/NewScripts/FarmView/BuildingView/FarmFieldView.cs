using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmFieldView : MonoBehaviour
{
    [SerializeField] private FarmfieldTemplateType _type;
    [SerializeField] private CropView[] _crops;

    private FarmFieldBuilding _farmFieldBuilding;

    public FarmfieldTemplateType TemplateType
    {
        get { return _type; }
    }

    public void Init(FarmFieldBuilding farmFieldBuilding)
    {
        _farmFieldBuilding = farmFieldBuilding;
        int num = _crops.Length;
        for (int i = 0; i < num; i++)
        {
            _crops[i].Init(_farmFieldBuilding, TemplateType);
        }
    }

    public void Activate()
    {
        base.gameObject.SetActive(true);
        int num = _crops.Length;
        for (int i = 0; i < num; i++)
        {
            _crops[i].Activate();
        }
    }

    public void Deactivate()
    {
        int num = _crops.Length;
        for (int i = 0; i < num; i++)
        {
            _crops[i].Deactivate();
        }

        base.gameObject.SetActive(false);
    }

    public void ActivateAndStartGrowing()
    {
        base.gameObject.SetActive(true);
        int num = _crops.Length;
        for (int i = 0; i < num; i++)
        {
            _crops[i].StartGrowing();
        }
    }

    public void HarvestReady()
    {
        if (base.gameObject.activeInHierarchy)
        {
            int num = _crops.Length;
            for (int i = 0; i < num; i++)
            {
                _crops[i].TurnHarvestReady();
            }
        }
    }

    public void Wither()
    {
        if (base.gameObject.activeInHierarchy)
        {
            int num = _crops.Length;
            for (int i = 0; i < num; i++)
            {
                _crops[i].TurnWithered();
            }
        }
    }

    public void SetVisible(bool visible)
    {
        int i = 0;
        for (int num = _crops.Length; i < num; i++)
        {
            _crops[i].SetVisible(visible);
        }
    }
}