using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    #region VARIABLES
    public float speed;
    Rigidbody rb;
    Vector3 vel;
    public float acceleration;
    public float deceleration;
    float lateral;
    float forward;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = vel;
        Acceleration();
        Movement();
    }

    void Movement()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
            
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
            Acceleration();
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
        }
      

    }

    
    void Acceleration()
    {
        forward = Input.GetAxis("Forward");
        lateral = Input.GetAxis("Lateral");

        if (Input.GetAxis("Lateral") != 0)
        {
            vel.x = acceleration * lateral;
        }
        else if (Input.GetAxis("Lateral") ==0 )
        {
            vel.x = deceleration * lateral;
        }
        if (Input.GetAxis("Forward") != 0)
        {
            vel.z = acceleration * forward;
        }
        else if (Input.GetAxis("Forward") == 0)
        {
            vel.z = deceleration * forward;
        }

        vel.x = Mathf.Clamp(vel.x, -speed, speed);
        vel.z = Mathf.Clamp(vel.z, -speed, speed);

    }
    
}
