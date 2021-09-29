using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _cannonShooting : MonoBehaviour
{
    private float time = 0.0f;
    public float fireRate = 1.0f;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public bool abletoshoot;
    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        // gets input from mouse to tell it to shoot
        if (Input.GetButtonDown("Fire1"))
        {
            // finds fire rate and limits player to that fire rate
            if (abletoshoot == true)
            {
                Shoot();
                abletoshoot = false;
            }
        }
        if (abletoshoot == false)
        {
            time += Time.deltaTime;
            if (time >= fireRate)
            {
                time = 0.0f;
                abletoshoot = true;
            }
        }
    }

    void Shoot()
    {
        // enables the bullet to shoot
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
    }
}
