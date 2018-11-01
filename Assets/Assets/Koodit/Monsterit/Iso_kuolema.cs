using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iso_kuolema : MonoBehaviour {

    public GameObject explosion;
    int x = 0;

    void OnCollisionEnter2D(Collision2D node)
    {
        while (x != 4)
        { 
            if (node.gameObject.tag.Equals("Ranaatti"))
            {
                GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
                Destroy(expl, 0.5f);
                x++;
            }
        }
        if (x == 4)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
