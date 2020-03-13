using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
    [SerializeField] private Player player;
    private int gameObjectDamage;
    [SerializeField] private Borders borders;

    private void Start()
    {
        gameObjectDamage = gameObject.GetComponent<EnemyController>().enemy.damage; 
    }
    void Update()
    {
        DestroyObject();
    }

    private void DestroyObject()
    {
        if (transform.position.z < borders.downBorder)
        {
            if (gameObject.CompareTag("Enemy"))
            {
                // set damage to player
                player.health -= gameObjectDamage;
            }
            Destroy(gameObject);
        }
    }
}
