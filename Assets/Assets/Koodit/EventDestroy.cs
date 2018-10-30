using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EventDestroy : MonoBehaviour {

    void Update () {
         GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
    }

    

void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            //Time.timeScale = 0; 
            SceneManager.LoadScene("Ampuminen");
            Destroy(this.gameObject);
        }
    }
}
