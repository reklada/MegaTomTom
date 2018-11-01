using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeLaunch : MonoBehaviour
{

    public GameObject Granade;
    public Transform Cannon;
    public Rigidbody2D myRB;
    private float attackTimer = 0;
    private float attackCd = 1;

    private float forceIncrease = 2;
    private float force = 4;

    void Start()
    {

    }

    void Update()
    {
        HandleAttacks();
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log(force);
            force += Time.deltaTime * 25;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (attackTimer <= 0)
            {
                Rigidbody2D Granade;
                Granade = Instantiate(myRB, Cannon.position, Cannon.rotation) as Rigidbody2D;
                Granade.AddForce(Cannon.right * force);

                attackTimer = attackCd;
                force = 0;
                Destroy(Granade, 5f);
            }
        }
    }


    private void HandleAttacks()
    {

        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }

    }
}