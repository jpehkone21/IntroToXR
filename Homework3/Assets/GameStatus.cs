using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStatus : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text score_text;

    void Awake(){
        score = 0;
    }
   
   public void AddScore(){
    score++;
    score_text.SetText(score.ToString());
   }

   public void LoseScore(){
    score--;
    score_text.SetText(score.ToString());
   }

   public int GetScore(){
    return score;
   }

}
