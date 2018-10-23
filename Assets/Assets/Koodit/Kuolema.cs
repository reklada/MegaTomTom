using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kuolema : MonoBehaviour
{

    public GameObject explosion;

    void OnCollisionEnter2D(Collision2D node)
    {
        if (node.gameObject.tag.Equals  ("Player"))
        {
            StartCoroutine(MyMethod());
            
        }
        if (node.gameObject.tag.Equals ("Ranaatti"))
        {
            GetComponent<Collider2D>().enabled = false;
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(expl, 0.5f);
        }
    }
    IEnumerator MyMethod()
    {
        yield return new WaitForSeconds(0.1F);
        GetComponent<Collider2D>().enabled = false;
    }
}