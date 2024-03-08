using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectDrop : MonoBehaviour
{
    public GameStatus status;
    private void OnTriggerEnter(Collider collider)
    {
        if( collider.gameObject.tag == "Droppable"){
            Debug.Log("droppable item in drop zone");
            //get points
            status.AddScore();
            //Destroy(collider);
        }
        if (collider.gameObject.tag == "Valuable"){
            Debug.Log("valuable item in drop zone");
            //lose points
            status.LoseScore();
        }
        //if (collider.gameObject.tag == "Candle"){

        //}
    }
}
