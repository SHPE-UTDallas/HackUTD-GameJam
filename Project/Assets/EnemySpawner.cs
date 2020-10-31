using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;


    [SerializeField]
    private Transform spawner;

    public float spawnTimer = 5f;
    public float resetValue = 5f;
    public float timerChange = .4f;

    // Start is called before the first frame update
    void Start()
    {
        resetValue = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0.0f)
        {
            SpawnEnemy();
            spawnTimer = resetValue;
            if (resetValue >= 1) {
                resetValue -= timerChange;

            }
        }
    }

    void SpawnEnemy() {
        Debug.Log("Spawning new enemy");

        GameObject newEnemy = Instantiate(enemy, spawner.position, spawner.rotation);
    }
}
