using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auton_ohjaus : MonoBehaviour
{

    public float speed = 2500f;
    public float rotationSpeed = 15f;

    public WheelJoint2D Etu_rengas;
    public WheelJoint2D Taka_rengas;

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
            Etu_rengas.useMotor = false;
            Taka_rengas.useMotor = false;
        }
        else
        {
            Etu_rengas.useMotor = true;
            Taka_rengas.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = movement, maxMotorTorque = 10000 };
            Etu_rengas.motor = motor;
            Taka_rengas.motor = motor;
        }
        rb.AddTorque(-rotation * rotationSpeed * Time.fixedDeltaTime);
    }
}