using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] float EnemySpawnRate;
    [SerializeField] float BuffSpawnRate;
    [SerializeField] private Randomable[] enemies;
    [SerializeField] private Randomable[] buffs;
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 1, EnemySpawnRate);
        InvokeRepeating("SpawnRandomBuff", 1, BuffSpawnRate);
        
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int randomIndex = Randomizer.Randomize(enemies);
            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].transform.rotation);

    }
    void SpawnRandomBuff()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int randomIndex = Randomizer.Randomize(buffs);
            Instantiate(buffs[randomIndex], spawnPos, enemies[randomIndex].transform.rotation);
            Debug.Log("Buff Spawned!" + randomIndex);

    }


}
