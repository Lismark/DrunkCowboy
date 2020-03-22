using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Slider healthBar;
    [SerializeField] private Scores pooScore;
    [SerializeField] private Borders borders;
    [SerializeField] private Player player;

    private int fullHealth;
    private int enemyHealth;
    private int damageModifier;
    private Enemy enemy;


    private void Awake()
    {
        enemy = gameObject.GetComponent<Enemy>();
    }
    private void Start()
    {

        fullHealth = enemy.health;
        enemyHealth = fullHealth;
        damageModifier = FindObjectOfType<BuffReciever>().buffDamage;
    }
    void FixedUpdate()
    {
        Move();
        BottomDestroy();
        if (enemyHealth <= 0)
        {
            SpawnScores();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            var damage = other.GetComponent<Bullet>().bulletEntity.damage;
            enemyHealth -=  damage;
            //Debug.Log($"enemy name: {gameObject.name} bullet damage: {damage}, enemy health: {enemyHealth}");
            healthBar.value = ((float)enemyHealth / (float)fullHealth);
        }
        Instantiate(enemy.onDestroyEmitter, gameObject.transform.position, Quaternion.identity);
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemy.speed);
    }

    private void SpawnScores()
    {
        for (int i = 0; i < enemy.scoresAmountDrop; i++)
        {
            Instantiate(enemy.dropObjects[0], new Vector3(gameObject.transform.position.x + Random.Range(0, 1f),
                gameObject.transform.position.y, gameObject.transform.position.z + Random.Range(0, 1f)),
                Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }

    private void BottomDestroy()
    {
        if (transform.position.z < borders.downBorder)
        {
            if (gameObject.CompareTag("Enemy"))
            {
                player.currentHealth -= enemy.damage;
            }
            Destroy(gameObject);
        }
    }
}
