using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class _homingMissile : MonoBehaviour
{
    public Vector2 mousePos;
    public Camera cam;

    public float speed = 10;
    public float rotateSpeed = 400;

    public GameObject explosionEffect;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (Vector2)mousePos - rb.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.right).z;

        rb.angularVelocity = -rotateAmount * rotateSpeed;
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
