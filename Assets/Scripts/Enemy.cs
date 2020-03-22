using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int index;
    public string enemyName;
    public int spawnChanceWeigth;
    public int damage;
    public int speed;
    public int scoresAmountDrop;
    public int health;
    public GameObject onDestroyEmitter;
    public DropObject[] dropObjects;
}
