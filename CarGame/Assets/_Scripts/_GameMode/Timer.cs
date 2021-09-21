using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 11;
    public bool timerEnabled = true;

    public Text timeText;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    public _physicsPlayer movementScript;




    public void Start()
    {
        movementScript.enabled = true;

    }
    private void Update()
    {
        if (timerEnabled)
        {
            if (timeLeft > 0)
            {
                gameOverScreen.active = false;
                timeLeft -= Time.deltaTime;
                winScreen.active = false;
                movementScript.enabled = true;
            }
            else
            {
                Debug.Log("Timer Done...");
                timeLeft = 0;
                gameOverScreen.active = true;
                winScreen.active = false;
                movementScript.enabled = false;
            }

        } else
        {
            if(gameOverScreen.active = false)
            {
                winScreen.active = true;
                
            }
            movementScript.enabled = false;


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
