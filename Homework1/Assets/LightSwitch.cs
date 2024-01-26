using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        light = GetComponent<Light>();
        action.action.performed += (ctx) =>
        {
            if(light.color == Color.cyan){
                light.color = Color.yellow;
            }
            else{
                light.color = Color.cyan;
            }
        };
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
