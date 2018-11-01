using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tykin_ohjaus : MonoBehaviour
{
    public bool controlled;

    private float minRotation = -20;
    private float maxRotation = 20;

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
                rectTransform.Rotate(new Vector3(0, 0, 1));
            }
            if (Input.GetKey(KeyCode.D))
            {
                RectTransform rectTransform = GetComponent<RectTransform>();
                rectTransform.Rotate(new Vector3(0, 0, -1));
            }
        }
    }
}