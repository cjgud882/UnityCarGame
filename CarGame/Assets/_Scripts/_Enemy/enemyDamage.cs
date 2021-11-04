using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    //put this script on the enemy

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Rocket")
        {
            Debug.Log("BOOOOOOM");

        }
    }



}
