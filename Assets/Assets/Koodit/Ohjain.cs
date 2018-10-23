using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ohjain : MonoBehaviour
{

    public float speed = 2500f;
    public float rotationSpeed = 15f;

    public WheelJoint2D rengas;
    public WheelJoint2D eturengas;

    public Rigidbody2D rb;

    private float movement = 0f;
    private float rotation = 0f;

    // Update is called once per frame
    void Update()
    {
        movement = -Input.GetAxisRaw("Vertical") * speed;
        rotation = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        if (movement == 0f)
        {
            rengas.useMotor = false;
            eturengas.useMotor = false;
        }else
        {
            rengas.useMotor = true;
            eturengas.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            rengas.motor = motor;
            eturengas.motor = motor;
        }
        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }
}
