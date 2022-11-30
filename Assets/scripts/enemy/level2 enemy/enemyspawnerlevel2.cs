using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawnerlevel2 : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    float maxSpawnRateInSeconds = 5f;
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawnRateInSeconds);

        InvokeRepeating("IncreaseSpawnRate", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject anEnemy = (GameObject)Instantiate(enemy);
        anEnemy.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
        ScheduleNextenemySpawn();
    }

    void ScheduleNextenemySpawn()
    {
        float spawninseconds;
        if (maxSpawnRateInSeconds > 1f)
        {
            spawninseconds = Random.Range(1f, maxSpawnRateInSeconds);
        }
        else
            spawninseconds = 1f;

        Invoke("SpawnEnemy", spawninseconds);

    }
    void IncreaseSpawnRate()
    {
        if (maxSpawnRateInSeconds > 1f)
        {
            maxSpawnRateInSeconds--;
        }
        if (maxSpawnRateInSeconds == 1f) CancelInvoke("IncreaseSpawnRate");

    }
}
