using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveT : MonoBehaviour
{
    
    
    
    [SerializeField] private CameraControllerT Controller;
    [SerializeField] private float MaxMovePerFrame = 10f;
    [SerializeField] private float PushForce = 1000f;
    [SerializeField] private float MaxPushForce = 1000f;
    [SerializeField] private float MinPushForce = 1000f;
    [SerializeField] private float MaxForceApplyDuration;
    [SerializeField] private float MinForceApplyDuration;
    [SerializeField] private float NoPushAfterZoomDuration;
    
    [SerializeField] private float TriggerStayPushPower;
    [SerializeField] private Vector3 Force;
    [SerializeField] private float PushStartTime;
    [SerializeField] private float ZoomStartTime;



    //KHI MÀ TRIGGET VỚI THẰNG ĐƯỜNG BIÊN THÌ SẼ ::::
    private void OnTriggerStay(UnityEngine.Collider other)
    {
        
    }
}