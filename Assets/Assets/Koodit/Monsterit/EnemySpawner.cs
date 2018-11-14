﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

    public GameObject Auto; 
    public GameObject enemy;
    float randX;
    float xxx;
    float z;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                randX = Random.Range(10f, 40f);
                xxx = Auto.transform.position.x + randX;
                whereToSpawn = new Vector2(xxx, 0.5f);
                Instantiate(enemy, whereToSpawn, Quaternion.identity);
            }
	}
}
