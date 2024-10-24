using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;


public class SmoothRide : MonoBehaviour
{
    public XROrigin xrOrigin;
    public float sensitivity = 0f;
    public float ySettlePosition = 0f;

    float cachedOriginY = 0;
    void Start(){
        cachedOriginY = xrOrigin.transform.position.y;
       
    }
    void Update(){
        xrOrigin.CameraYOffset += cachedOriginY - xrOrigin.transform.position.y;
        xrOrigin.CameraYOffset = Mathf.Lerp(xrOrigin.CameraYOffset,ySettlePosition,Time.deltaTime*sensitivity);
        cachedOriginY = xrOrigin.transform.position.y; 
    }
}
