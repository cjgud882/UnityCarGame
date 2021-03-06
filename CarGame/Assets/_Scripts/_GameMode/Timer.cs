using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 11;
    public bool timerEnabled = true;

    public Text timeText;
    public Text endScoreW;
    public Text endScoreL;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    public _physicsPlayer movementScript;

    public bool playerLost = false;
    public bool playerWon = false;

    public int pizzasDelivered;


    public void Awake()
    {
        playerLost = false;
        pizzasDelivered = 0;
    }
    public void Start()
    {
        movementScript.enabled = true;
        playerLost = false;
        pizzasDelivered = 0;
        
    }
    private void Update()
    {
       
        if(pizzasDelivered >= 3)
        {
            timerEnabled = false;

        }


        if (timerEnabled)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                movementScript.enabled = true;
                
            }
            else
            {
                Debug.Log("Timer Done...");
                timeLeft = 0;
                
                movementScript.enabled = false;
                timerEnabled = false;
                playerLost = true;
            }

        } else
        {
            if (playerLost == false)
            {
                winScreen.active = true;
                movementScript.enabled = false;
                Debug.Log("W");
                endScoreW.text = pizzasDelivered.ToString();
            } else if(playerLost == true)
            {
                Debug.Log("L");
                gameOverScreen.active = true;
                endScoreL.text = pizzasDelivered.ToString();
            }
        }



        DisplayTime(timeLeft);
        



    }

    void DisplayTime(float timeToDisplay)
    {

         
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
