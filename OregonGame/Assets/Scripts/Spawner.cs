using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {


    public Transform[] spawnPoints;
    public GameObject enemy;
    public float spawnTime = 5f;
    public float spawnDelay = 3f;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("addEnemy", spawnDelay, spawnTime);

    }

    void addEnemy()
    {

        // Instantiate a random enemy.
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
