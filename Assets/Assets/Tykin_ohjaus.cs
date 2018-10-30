using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tykin_ohjaus : MonoBehaviour
{
    public HingeJoint2D tykki;
    public bool controlled;

    void Start()
    {
        controlled = true;
    }

    void Update()
    {
        if (controlled == true)
        {

            if (Input.GetKey(KeyCode.A))
            {
                RectTransform rectTransform = GetComponent<RectTransform>();
                rectTransform.Rotate(new Vector3(0, 0, 2));
            }
            if (Input.GetKey(KeyCode.D))
            {
                RectTransform rectTransform = GetComponent<RectTransform>();
                rectTransform.Rotate(new Vector3(0, 0, -2));
            }
        }
    }
}