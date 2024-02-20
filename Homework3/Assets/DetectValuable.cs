using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectValuable : MonoBehaviour
{
    public GameStatus status;
    private void OnTriggerEnter(Collider collider)
    {
        if( collider.gameObject.tag == "Valuable"){
            Debug.Log("valuable item in valuable zone");
            //get points
            status.AddScore();
            Destroy(collider);
        }
        if (collider.gameObject.tag == "Droppable"){
            Debug.Log("droppable item in valuable zone");
            //lose points
            status.LoseScore();
        }
    }
}
