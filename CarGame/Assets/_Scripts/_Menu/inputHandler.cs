using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputHandler : MonoBehaviour
{
    public GameObject introCanvas;
    public GameObject menuCanvas;
    public GameObject levelCanvas;
    public GameObject settingsCanvas;
    public GameObject aboutCanvas;



    public void Start()
    {
        introCanvas.active = true;
        menuCanvas.active = false;
        levelCanvas.active = false;
        settingsCanvas.active = false;
        aboutCanvas.active = false;
    }
    public void Update()
    {
        if(introCanvas.active == true)
        {
            if(Input.anyKey)
            {
                startMenu();

            }


        }

    }


    public void startMenu()
    {
        introCanvas.active = false;
        menuCanvas.active = true;
        aboutCanvas.active = false;
        levelCanvas.active = false;
        settingsCanvas.active = false;
    }

    public void startLevelMenu()
    {
        introCanvas.active = false;
        menuCanvas.active = false;
        aboutCanvas.active = false;
        levelCanvas.active = true;
        settingsCanvas.active = false;
    }
    public void startSettingsMenu()
    {
        introCanvas.active = false;
        menuCanvas.active = false;
        aboutCanvas.active = false;
        levelCanvas.active = false;
        settingsCanvas.active = true;
    }
    public void startAboutMenu()
    {
        introCanvas.active = false;
        menuCanvas.active = false;
        aboutCanvas.active = true;
        levelCanvas.active = false;
        settingsCanvas.active = false;
    }

}
