using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _cannonAiming : MonoBehaviour
{
    public float moveSpeed = 5;
    public Rigidbody2D rb;
    public Camera cam;
    public Transform anchorPos;
    public Transform cannonPos;

    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Update()
    {
        // moves cam to where mouse is pointing
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
    }
    
    void FixedUpdate()
    {
        cannonPos.position = anchorPos.position;
        // moves cursor to where mouse is pointing (aiming)
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;

        cannonPos.position = anchorPos.position;
    }
}
