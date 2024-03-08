using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonPress : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    public timer timer;

    
    void Start()
    {
        isPressed = false;
        
    }
    private void OnTriggerEnter(Collider other){
        if(!isPressed){
            button.transform.localPosition = new Vector3(0, 0.4f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            isPressed = true;
        }
    }
    private void OnTriggerExit(Collider other){
        if (other.gameObject == presser){
            //Debug.Log("trigger exit");
            button.transform.localPosition += new Vector3(0, 0.4f, 0); 
            Invoke("movePlayer", 1);
            timer.timerIsRunning = true;
            isPressed = false;
        }
    }
    public GameObject player;
    public void movePlayer(){
        player.transform.position = new Vector3(0.45f, 0.5f, -0.14f); 
    }

    
}
