using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tykin_ohjaus : MonoBehaviour
{
    public HingeJoint2D tykki;
    public float force;
    private float acceleration;
    private float powah;

    void Update()
    {
        // up and down keys, range [-1, 1]
        acceleration = Input.GetAxis("Vertical");

        // key up is powah * 1, key down is powah * -1, no key is powah * 0
        tykki.motor.force = powah * acceleration;
    }
}