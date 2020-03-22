using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] float spawnRate;
    [SerializeField] private Enemy[] enemies; 
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 1, spawnRate);
        Randomizer();
    }

    void SpawnRandomEnemy()
    {
        int animalIndex = Randomizer();
        if (animalIndex > 0)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(enemies[animalIndex-1], spawnPos, enemies[animalIndex-1].transform.rotation);
        }
    }

    private int Randomizer()
    {
        List<int> table = new List<int>();
        for (int i = 0; i < enemies.Length; i++) 
        {
            for(int j = 0; j < enemies[i].spawnChanceWeigth; j++) 
            {
                table.Add(enemies[i].index);
            } 
        }
            
        int randomItem = Random.Range(0, table.Count);
        return table[randomItem];
    }

}
