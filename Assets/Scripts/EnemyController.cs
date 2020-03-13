using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] public Enemies enemy;
    [SerializeField] private GameObject explosion;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Scores pooScore;
    private GameObject explo;
    private int fullHealth;
    private int currentHealth;
    private int damageModifier; 


    private void Start()
    {
        fullHealth = enemy.health;
        currentHealth = fullHealth;
        damageModifier = FindObjectOfType<BuffReciever>().buffDamage;
    }
    void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            var damage = other.GetComponent<Bullet>().bulletEntity.damage;
            currentHealth -=  damage;
            healthBar.value = ((float)currentHealth / (float)fullHealth);
            Destroy(other.gameObject);
        }

        explo = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        if(currentHealth <= 0)
        {
            SpawnScores();
            Destroy(gameObject);
        }
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemy.speed);
    }

    private void SpawnScores()
    {
        for (int i = 0; i < enemy.scoresAmountDrop; i++)
        {
            Instantiate(pooScore.scoreObject, new Vector3(gameObject.transform.position.x + Random.Range(0, 1f),
                gameObject.transform.position.y, gameObject.transform.position.z + Random.Range(0, 1f)),
                Quaternion.Euler(0, Random.Range(0, 360), 0));
        }
    }
}
