using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    public float speed;
    Animator animator;
    private float gripTarget;
    private float triggerTarget;
    private float gripCurrent;
    private float triggerCurrent;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimateHand();
        
    }

    internal void SetGrip(float v){
        gripTarget = v;
        //Debug.Log(gripTarget);

    }

    internal void SetTrigger(float v){
        triggerTarget = v;

    }
    void AnimateHand(){
        if (gripCurrent != gripTarget){
            gripCurrent = Mathf.MoveTowards(gripCurrent, gripTarget, Time.deltaTime * speed);
            //Debug.Log(gripCurrent);
            animator.SetFloat("grip", gripCurrent);
        }
        if (triggerCurrent != triggerTarget){
            triggerCurrent = Mathf.MoveTowards(triggerCurrent, triggerTarget, Time.deltaTime * speed);
            Debug.Log(triggerCurrent);
            animator.SetFloat("trigger", triggerCurrent);
        }

    }

}
