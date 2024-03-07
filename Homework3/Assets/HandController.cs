using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

//[RequireComponent(typeof(ActionBasedController))]
public class HandController : MonoBehaviour
{

    public InputActionReference actionGrip;
    public InputActionReference actionTrigger;
    //ActionBasedController controller;
    public Hand hand;
    // Start is called before the first frame update
    void Start()
    {
        //controller = GetComponent<ActionBasedController>();
        
    }

    // Update is called once per frame
    void Update()
    {
    
        hand.SetGrip(actionGrip.action.ReadValue<float>());
        //Debug.Log(actionTrigger.action.ReadValue<float>());
        hand.SetTrigger(actionTrigger.action.ReadValue<float>());
        //hand.SetGrip(controller.selectAction.action.ReadValue<float>());
        //hand.SetTrigger(controller.activateAction.action.ReadValue<float>());
        
    }
}
