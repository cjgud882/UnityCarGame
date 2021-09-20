using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BulletMove : MonoBehaviour
{
    public float moveSpeed = 20;

    private void Update()
    {

        
        transform.Translate((transform.right * moveSpeed * Time.deltaTime));

    }




}
