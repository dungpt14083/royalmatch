using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Sau này cái này sẽ chỉnh hành vi của cả từng cái bây h chơi cả
public class TilePlaneValidPreBuilder : MonoBehaviour
{
    [SerializeField] private TypeTilePlaneValidPreviewBuilder typeTilePlaneValidPreviewBuilder;
    public TypeTilePlaneValidPreviewBuilder TypeTilePlaneValidPreviewBuilder => typeTilePlaneValidPreviewBuilder;

    [SerializeField] private SpriteRenderer[] spriteRenderers;


    private Color _colorNormal = new Color(255, 255, 255);
    private Color _colorNotConfirm = new Color(188, 0, 0, 0.7f);
    

    //SET VALID ĐỎ XANH
    public void SetValid(bool isValid)
    {
        for (int i = 0; i < spriteRenderers.Length; i++)
        {
            spriteRenderers[i].color = isValid ? _colorNormal : _colorNotConfirm;
        }
    }
}