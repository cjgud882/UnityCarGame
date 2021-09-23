using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class _Score : MonoBehaviour
{

    public int playScore = 0;
    public int afterScore = 0;

    public Text scoreText;

    public Timer timerScript;

    public void Start()
    {
        

    }


    public void Update()
    {
        afterScore = Mathf.RoundToInt(timerScript.timeLeft * 100);

        scoreText.text = playScore.ToString();

        


    }



}
