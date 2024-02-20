using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClawGrab : MonoBehaviour
{
    public InputActionReference action;
    public Transform grabbedObject = null;
    bool grabbing = false;
    
    
    private void OnTriggerEnter(Collider collider)
    {
        if( collider.gameObject.tag == "Valuable"){
             grabbing = action.action.IsPressed();
            if (grabbing)
            {
                collider.gameObject.transform.position = transform.position;
            }
        }
    }
}
