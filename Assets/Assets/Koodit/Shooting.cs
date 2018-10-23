using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
	}

    void Fire()
    {
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 6;

        Destroy(bullet, 2.0f);
    }
}
