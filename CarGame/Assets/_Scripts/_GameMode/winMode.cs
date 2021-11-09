using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winMode : MonoBehaviour
{

    public Timer timerScript;
    public Text deliveredText;

    public void OnTriggerEnter(Collider other)
    {
       
        if(other.gameObject.tag=="endZone")
        {
            Debug.Log("Entered Delivery Zone");


            timerScript.pizzasDelivered += 1;
            Debug.Log(timerScript.pizzasDelivered);
            deliveredText.text = timerScript.pizzasDelivered.ToString();
        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="endZone")
        {
            Debug.Log("Left Delivery Zone");
            
            

        }
    }





}
