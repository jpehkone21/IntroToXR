using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class squeeze : MonoBehaviour
{
    public GameObject mouse;
    //public UnityEvent onPress;
    //public UnityEvent onRelease;
    GameObject presser;
    bool isSqueezed;
    private Vector3 scaleChange = new Vector3(0f, 0f, -0.03f);
    private Vector3 positionChange = new Vector3(0.0f, -0.005f, 0.0f);
    public GameStatus status;

    
    void Start()
    {
        isSqueezed = false;
        
    }
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Hand"){
            if(!isSqueezed){
            mouse.transform.localScale += scaleChange;
            //mouse.transform.position += positionChange;
            //presser = other.gameObject;
            //onPress.Invoke();
            isSqueezed = true;
            status.AddScore();
            mouse.transform.parent = null;
        }
        }
        
    }/*
    private void OnTriggerExit(Collider other){
        //if (other.gameObject == presser){
           button.transform.localPosition = new Vector3(0, 1f, 0); 
            onRelease.Invoke();
            isPressed = false;
        //}
    }*/
}
