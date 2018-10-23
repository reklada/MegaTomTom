using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera_ohjaus : MonoBehaviour
{

    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = -10;

        transform.position = newPosition;

    }
}
