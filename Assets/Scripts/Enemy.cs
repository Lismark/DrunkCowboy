using UnityEngine;


public class Enemy : Randomable
{
    public int index;
    public string enemyName;
    public int spawnChanceWeigth;
    public override int SpawnChanceWeigth 
    {
        get { return spawnChanceWeigth; }
    }
    public int damage;
    public int speed;
    public int scoresAmountDrop;
    public int health;
    public GameObject onDestroyEmitter;
    public float dropBoxChance;
    public float dropHealthChance;
    public GameObject[] dropObjects;
}
