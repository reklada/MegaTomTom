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
<<<<<<< HEAD:Assets/Assets/Koodit/GranadeLaunch.cs

    private float force;
    private float forceIncrease = 2;
=======
    private float force = 4;
>>>>>>> 35ff0e4cea61a66a4eb9ba8101eb6ff48503c395:Assets/Assets/Koodit/Tykin scriptit/GranadeLaunch.cs

    void Start()
    {

    }

    void Update()
    {
        HandleAttacks();
<<<<<<< HEAD:Assets/Assets/Koodit/GranadeLaunch.cs
        if (Input.GetKeyDown(KeyCode.Space))
=======
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log(force);
            force += Time.deltaTime * 25;
        }
        if (Input.GetKeyUp(KeyCode.Space))
>>>>>>> 35ff0e4cea61a66a4eb9ba8101eb6ff48503c395:Assets/Assets/Koodit/Tykin scriptit/GranadeLaunch.cs
        {
            Debug.Log(force);
            force += forceIncrease*Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (attackTimer <= 0)
            {
                Rigidbody2D Granade;
                Granade = Instantiate(myRB, Cannon.position, Cannon.rotation) as Rigidbody2D;
                Granade.AddForce(Cannon.right * force);

                attackTimer = attackCd;
<<<<<<< HEAD:Assets/Assets/Koodit/GranadeLaunch.cs
                forceIncrease = 0;
                DestroyObject(myRB, 1f);
=======
                force = 0;
                Destroy(Granade, 5f);
>>>>>>> 35ff0e4cea61a66a4eb9ba8101eb6ff48503c395:Assets/Assets/Koodit/Tykin scriptit/GranadeLaunch.cs
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