using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour

{
    public GameObject zoomCamera;
    public GameObject mainCamera;
    private float fixedRotation = 0;

    //private Vector3 fixRotation = new Vector3(0, 180, 0);

    // Update is called once per frame
    void Update()
    {
        Vector3 mainCamRotation = mainCamera.transform.eulerAngles;
        zoomCamera.transform.eulerAngles = new Vector3(mainCamRotation.x,  mainCamRotation.y, fixedRotation);
        //zoomCamera.transform.rotation = mainCamera.transform.rotation;
    }
}
