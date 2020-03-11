using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Enemies enemy;
    [SerializeField] private GameObject explosion;
    [SerializeField] private int penaltyMultiplyer = 2;
    [SerializeField] private Slider healthBar;
    private GameObject explo;
    private float downBoundary;
    private int fullHealth;
    private int currentHealth;
    private int damageModifier; 


    private void Start()
    {
        downBoundary = ObjectDestroyer.DownBoundary;
        fullHealth = enemy.health;
        currentHealth = fullHealth;
        damageModifier = FindObjectOfType<BuffReciever>().buffDamage;
        Debug.Log(gameObject.name + fullHealth);
    }
    void FixedUpdate()
    {
        Move();
        MinusScore();
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
        Destroy(gameObject);
    }
    public void MinusScore()
    {
        var currentScore = PlayerPrefs.GetInt("Score");
        if (transform.position.z < downBoundary)
            PlayerPrefs.SetInt("Score", currentScore - enemy.score * penaltyMultiplyer);
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemy.speed);
    }
}
