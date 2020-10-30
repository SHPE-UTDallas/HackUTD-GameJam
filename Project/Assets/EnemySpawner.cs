using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;


    [SerializeField]
    private Transform spawner;

    private float spawnTimer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0.0f)
        {
            SpawnEnemy();
            spawnTimer = 1f;
        }
    }

    void SpawnEnemy() {
        Debug.Log("Spawning new enemy");

        GameObject newEnemy = Instantiate(enemy, spawner.position, spawner.rotation);
    }
}
