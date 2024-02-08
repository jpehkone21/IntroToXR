using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour

{
    
    public GameObject zoomCamera;
    public GameObject mainCamera;
    private float fixedRotation = 0;
    

    void Update()
    {

        Vector3 mainCamRotation = mainCamera.transform.eulerAngles;
        zoomCamera.transform.eulerAngles = new Vector3(mainCamRotation.x,  mainCamRotation.y, fixedRotation);

    }
}
