using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//load đầu game cho việc loader các t phụ animation chẳng hạn
public class LoaderFirst : Loader
{
    private const string SkipTrigger = "Skip";

    [SerializeField] private Slider progressbar;
    [SerializeField] private TMP_Text _txtValue;

    protected override void SetProgress(float normalisedProgress)
    {
        base.SetProgress(normalisedProgress);
        progressbar.normalizedValue = normalisedProgress;
        _txtValue.text = progressbar.normalizedValue.ToString()+"%";
    }
}