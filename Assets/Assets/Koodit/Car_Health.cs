using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

public class Car_Health : MonoBehaviour
{
    public GameObject HealtBar;

    public float Health = 100;
    private float _currentHealth;


    void Start()
    {
        _currentHealth = Health;
    }

    public void OnCollisionEnter2D(Collision2D node)
    {
        if (node.gameObject.tag.Equals("Big_Monster"))
        {
            _currentHealth -= 50;
            HealtBar.transform.localScale = new Vector3(_currentHealth / Health, HealtBar.transform.localScale.y, HealtBar.transform.localScale.z);
        }
        if (node.gameObject.tag.Equals("Monster_2"))
        {
            _currentHealth -= 10;
            HealtBar.transform.localScale = new Vector3(_currentHealth / Health, HealtBar.transform.localScale.y, HealtBar.transform.localScale.z);
        }
        if (_currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
