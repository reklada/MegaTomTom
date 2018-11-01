using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class MonsterHealth : MonoBehaviour {

    public GameObject explosion;
    public GameObject HealtBar;

    public float Health = 100;
    private float _currentHealth;


    void Start()
    {
        _currentHealth = Health;
    }

    public void OnCollisionEnter2D(Collision2D node)
    {
        if (node.gameObject.tag.Equals("Ranaatti"))
        {
            GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            Destroy(expl, 0.5f);

            _currentHealth -= 25;
            HealtBar.transform.localScale = new Vector3(_currentHealth / Health, HealtBar.transform.localScale.y, HealtBar.transform.localScale.z);

            

        }
        if ( _currentHealth == 0)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
