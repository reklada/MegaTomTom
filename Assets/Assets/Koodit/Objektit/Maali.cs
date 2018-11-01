using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Maali : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D colInfo)
    {
        if(colInfo.CompareTag("Player"))
        {
            Debug.Log("PETE IS GAY!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
