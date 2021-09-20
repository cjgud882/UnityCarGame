using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 11;
    private bool timerEnabled = true;

    public Text timeText;

    public GameObject gameOverScreen;
    public GameObject winScreen;

    private void Update()
    {
        if (timerEnabled)
        {
            if (timeLeft > 0)
            {
                gameOverScreen.active = false;
                timeLeft -= Time.deltaTime;
                winScreen.active = false;
            }
            else
            {
                Debug.Log("Timer Done...");
                timeLeft = 0;
                gameOverScreen.active = true;
                winScreen.active = false;

            }

        } else
        {
            winScreen.active = true;


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
