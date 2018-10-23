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


    void Start()
    {

    }

    void Update()
    {
        HandleAttacks();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (attackTimer <= 0)
            {
                Rigidbody2D Granade;
                Granade = Instantiate(myRB, Cannon.position, Cannon.rotation) as Rigidbody2D;
                Granade.AddForce(Cannon.right * 25);

                attackTimer = attackCd;
                DestroyObject(myRB, 1f);
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