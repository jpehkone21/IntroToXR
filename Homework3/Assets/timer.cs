using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class timer : MonoBehaviour
{
    
    public GameObject gameEndedPlane;
    public InputActionReference action; //action to start over
    public TMP_Text final_score; //text in game ended plane
    public GameStatus status;
    public Light light;
    private float light_timer;

    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    
    public TMP_Text timer_text;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                if(timeRemaining <= 5){
                    light_timer += Time.deltaTime;
                    if (light_timer > 0.5f){
                        light.enabled = !light.enabled;
                        light_timer -= 0.5f;
                    }
                }
                
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);

            }
            else
            {
                Debug.Log("Time has run out!");
                gameEndedPlane.SetActive(true); //show game ended plane
                final_score.SetText(status.GetScore().ToString()); //set final score to game ended plane
                
                timeRemaining = 0;
                timerIsRunning = false;

                action.action.Enable();
                action.action.performed += (ctx) =>
                {
                    StartAgain(); //if button pressed, start again
                };
                


                 
            }
            
        }
    }

     void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timer_text.SetText(string.Format("{0:00}:{1:00}", minutes, seconds));
    }

    void StartAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    
}
