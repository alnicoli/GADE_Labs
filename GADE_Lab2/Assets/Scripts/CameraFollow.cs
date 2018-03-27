using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform target;
    public Vector3 offset;
    private Vector3 _velocity = Vector3.zero;
    
    private float _smoothSpeed = 0.125f;

    private void Start() {
        offset = new Vector3(0,0,-10);
    }
    
    private void LateUpdate() {
        Vector3 targetPos = target.position + offset;
        Vector3 targetPosSmoothed = Vector3.SmoothDamp(transform.position, targetPos, ref _velocity, _smoothSpeed);
        
        transform.position = targetPosSmoothed;
    }
}