using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuhoutuminen : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D node)
    {
        if (node.gameObject.tag.Equals("Monster_2"))
        {
            Destroy(this.gameObject);

        }
    }
}
