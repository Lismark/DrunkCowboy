using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabsAnimals;
    public GameObject[] PrefabAnimals 
    {
        get { return prefabsAnimals; }
    }
    [SerializeField] private float spawnRangeX;
    [SerializeField] private float spawnPosZ;
    [SerializeField] private float spawnDelay = 0;
    [SerializeField] private float spawnInterval = 2f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, prefabsAnimals.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(prefabsAnimals[animalIndex], spawnPos, prefabsAnimals[animalIndex].transform.rotation);
    }
}
