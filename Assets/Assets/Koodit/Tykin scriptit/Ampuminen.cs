using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ampuminen : MonoBehaviour {

    public GameObject projectilePrefab;
    public Transform bulletSpawn;

    private List<GameObject> Projectiles = new List<GameObject>();

    private float projectileVelocity;

    void Start()
    {
        projectileVelocity = 3;
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {
            GameObject bullet = Instantiate(projectilePrefab, bulletSpawn.position, Quaternion.identity);
            Projectiles.Add(bullet);
        }

        for(int i = 0; i < Projectiles.Count; i++)
        {
            GameObject goBullet = Projectiles[i];
            if (goBullet != null)
            {
                goBullet.transform.Translate(new Vector3(3, 0) * Time.deltaTime * projectileVelocity);

                Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
                if(bulletScreenPos.y >= Screen.height || bulletScreenPos.y <= 0)
                {
                    DestroyObject(goBullet);
                    Projectiles.Remove(goBullet);
                }
            }
        }
    }
}

