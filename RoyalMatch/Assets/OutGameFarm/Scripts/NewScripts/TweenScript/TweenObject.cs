using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;

public class TweenObject : MonoBehaviour
{
    private Tween _tween;

    public Transform[] objectTween;
    public Transform ArrowNW; 
    public Transform ArrowNE;
    public Transform ArrowSW;
    public Transform ArrowSE;
    public GameObject panel;
    
    public Transform BuildingView;
    private bool isTweening = false;
    private Vector3 initiScale;
    private Vector3 initiPos;
    private Vector3 initialSize;
    private void Start()
    {
        
        initiScale = panel.transform.localScale;
        initiPos = BuildingView.transform.localPosition;
        initialSize = panel.transform.GetComponent<SpriteRenderer>().bounds.size;
    }

    private void OnEnable()
    {
        if(!isTweening)
          startTween();
    }

    private void startTween()
    {
       // BuildingView.DOLocalMoveY(offsetPosBuilding, .3f);
       // BuildingView.DOScaleY(1.1f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        // foreach (Transform obj in objectTween)
        // {
        //     obj.DOScale(1.2f, 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        // }

        isTweening = true;
    }
    public void ScalePlane(float scaleValue)
    {
        // Scale tấm plane
        panel.transform.localScale = initiScale * scaleValue;

        // Tính toán kích thước mới của tấm plane
        Vector3 newSize = initialSize * scaleValue;

        // Cập nhật vị trí cho 4 đối tượng hình mũi tên
        Vector3[] arrowPositions = CalculateArrowPositions(newSize);

        for (int i = 0; i < objectTween.Length; i++)
        {
            objectTween[i].transform.position = arrowPositions[i];
        }
    }

    private Vector3[] CalculateArrowPositions(Vector3 newSize)
    {
        Vector3[] positions = new Vector3[4];
        float halfWidth = newSize.x / 2f;
        float halfHeight = newSize.y / 2f;

        // Xác định vị trí cho 4 đối tượng hình mũi tên
        positions[0] = new Vector3(-halfWidth, 0f, halfHeight); // Top-left
        positions[1] = new Vector3(halfWidth, 0f, halfHeight); // Top-right
        positions[2] = new Vector3(-halfWidth, 0f, -halfHeight); // Bottom-left
        positions[3] = new Vector3(halfWidth, 0f, -halfHeight); // Bottom-right

        return positions;
    }
    private void Update()
    {
    }

    private void OnDisable()
    {
        KillTween();
    }
    public void KillTween()
    {
        BuildingView.position = initiPos;
        BuildingView.localScale = initiScale;
        BuildingView.DOComplete();
        BuildingView.DOKill();
        foreach(Transform obj in objectTween)
        {
            obj.localScale = initiScale;
            obj.DOComplete();
            obj.DOKill();
        }
        isTweening = false;
    }
}
