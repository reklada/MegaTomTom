using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kavely : MonoBehaviour {
    public float xMove;
    private void Update()
    {
        transform.Translate(Vector3.left * xMove);
    }
}
