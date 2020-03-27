using UnityEngine;


public class Enemy : Randomable
{
    public string enemyName;
    public int index;
    public int spawnChanceWeigth;

    public override int SpawnChanceWeigth {
        get { return spawnChanceWeigth; }
        set { spawnChanceWeigth = value; }
    }
    public override int Index
    {
        get { return index; }
        set { index = value; }
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
