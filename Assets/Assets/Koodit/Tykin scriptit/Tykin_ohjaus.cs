using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tykin_ohjaus : MonoBehaviour
{
    private float rotationZ;
    private float sensitivityZ = 0.5f;

    void Start()
    {
        transform.rotation = Quaternion.identity;
    }

    void Update()
    {
        LockedRotation();
    }

    void LockedRotation()
    {
        rotationZ += Input.GetAxis("Horizontal") * 2;
        rotationZ = Mathf.Clamp(rotationZ, -22f, 22f);

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, -rotationZ);
    }
}