using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] float spawnRate;
    [SerializeField] private Randomable[] enemies;
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 1, spawnRate);
    }

    void SpawnRandomEnemy()
    {
        int animalIndex = Randomizer.Randomize(enemies);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(enemies[animalIndex], spawnPos, enemies[animalIndex].transform.rotation);

    }


}
