using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] float enemySpawnRate;
    [SerializeField] Player player;

    [SerializeField] private Randomable[] enemies;
    [SerializeField] private Randomable[] buffs;
    [SerializeField] int buffSpawnChance;

    [SerializeField] private Randomable[] pots;
    [SerializeField] int potSpawnChance;

    int potSpawnCurrentChance;
    float buffSpawnRate = 1;
    float potSpawnRate = 1;
    void Start()
    {
        potSpawnCurrentChance = potSpawnChance;
        InvokeRepeating("SpawnRandomEnemy", 1, enemySpawnRate);
        InvokeRepeating("SpawnRandomBuff", 1, buffSpawnRate);
        InvokeRepeating("SpawnRandomPot", 1, potSpawnRate);

    }

    private void FixedUpdate()
    {
        if (player.CurrentHealth >= player.MaxHealth)
            potSpawnCurrentChance = -1;
        else potSpawnCurrentChance = potSpawnChance;
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        if(enemies.Length != 0)
        { 
        int randomIndex = Randomizer.Randomize(enemies);
            Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].transform.rotation);
        }

    }
    void SpawnRandomBuff()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        if(buffs.Length != 0 && Spawner(buffSpawnChance))
        { 
        int randomIndex = Randomizer.Randomize(buffs);
            Instantiate(buffs[randomIndex], spawnPos, Quaternion.identity);
            Debug.Log("Buff Spawned!" + randomIndex);
        }

    }

    void SpawnRandomPot()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        if(pots.Length != 0 && (Spawner(potSpawnCurrentChance)))
        { 
        int randomIndex = Randomizer.Randomize(pots);
        Instantiate(pots[randomIndex], spawnPos, Quaternion.identity);
        }
    }

     bool Spawner(int chance)
    {
        int spawn = Random.Range(0, 100);
        if (spawn < chance)
            return true;
        else return false;
    }

}
