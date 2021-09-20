using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class _turretController : MonoBehaviour
{
    Vector3 mouse_pos;
    public Transform target;  
    Vector3 object_pos;
    float angle;

    public GameObject bulletPrefab;
    

    public float fireRate = 100f;
    public float fireDelay = 100f;
    public float bulletSpeed = 0.5f;
    float nextFire = 0;

    void Update()
    {
        
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


        if(Input.GetMouseButton(0))
        {
            //Shoot();

        }
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, target.transform.position, target.transform.rotation);
  

    }
}
