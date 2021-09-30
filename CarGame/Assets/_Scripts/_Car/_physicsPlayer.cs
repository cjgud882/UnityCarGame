using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _physicsPlayer : MonoBehaviour
{
    private float speed = 0f;
    private float maxSpeed = 5f;
    private float startAngDrag;
    private float startOrthoSize;

    public float boostSpeed = 10f;

    public Camera mainCamera;

    public TrailRenderer rearWheelL;
    public TrailRenderer rearWheelR;
    public TrailRenderer frontwheelL;
    public TrailRenderer frontwheelR;

    private void Start()
    {
        startOrthoSize = Camera.main.orthographicSize;
        startAngDrag = GetComponent<Rigidbody2D>().angularDrag;

        mainCamera.fieldOfView = 60.0f;
    }

    public void Update()
    {



    }


    void FixedUpdate()
    {
        Boost();
        CameraFunctions();
        InputHandlingKB();
        MovementHandlersRigid();
    }


    //a sexy smooth camera follow
    private void CameraFunctions()
    {
        if (speed > startOrthoSize)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, 5f, Time.deltaTime * 0.5f); //complex math shit
        }
        else
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, startOrthoSize, Time.deltaTime * 0.5f);
        }
        Camera.main.transform.position -= (Camera.main.transform.position - new Vector3(transform.position.x, transform.position.y, -10f)) * Time.deltaTime * 10f;
    }

    //input from keyboard and gamepad because why tf not
    private void InputHandlingKB()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetAxisRaw("Fire2") > 0f)
        {
            if (speed < maxSpeed)
            {
                speed += 0.1f;
            }
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetAxisRaw("Fire3") > 0f)
        {
            if (speed > 0f)
            {
                speed -= 0.3f;
            }
        }
        else
        {
            if (speed > 0f)
            {
                speed -= 0.2f;
            }
        }
        if (speed < 0f)
        {
            speed = 0f;
        }
    }
    //rigidbody2d shit
    private void MovementHandlersRigid()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
        if (GetComponent<Rigidbody2D>().velocity.magnitude > 1f)
        {
            GetComponent<Rigidbody2D>().angularDrag = startAngDrag;
            GetComponent<Rigidbody2D>().AddTorque(-Input.GetAxisRaw("Horizontal") * 15);
        }
        else
        {
            GetComponent<Rigidbody2D>().angularDrag = 10f;
        }
    }

    public void Boost()
    {
        float savedSpeed = 5f;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            savedSpeed = speed;
            maxSpeed = 10f;
            speed = boostSpeed;
            mainCamera.fieldOfView = 90;

        } else if(Input.GetKey(KeyCode.W))
        {
            maxSpeed = 5f;
            speed = savedSpeed;
            

       } else
        {
            speed = 0f;
            Camera.main.fieldOfView = 60.0f;
        }



    }
   
}
