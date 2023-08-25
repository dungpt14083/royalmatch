using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicRaycastTarget : Graphic
{
    protected override void Awake()
    {
        base.Awake();
        raycastTarget = true;
    }

    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();
    }
}