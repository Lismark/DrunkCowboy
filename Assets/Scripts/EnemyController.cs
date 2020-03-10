using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Enemies enemy;
    [SerializeField] private GameObject explosion;
    [SerializeField] private int penaltyMultiplyer = 2;
    public GameObject explo;
    private Transform downBoundary;


    private void Start()
    {
        downBoundary = GetComponent<ObjectDestroyer>().downBoundary.transform;
    }
    void FixedUpdate()
    {
        Move();
        MinusScore();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
            Destroy(other.gameObject);

        explo = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void MinusScore()
    {
        var currentScore = PlayerPrefs.GetInt("Score");
        if (transform.position.z < downBoundary.position.z)
            PlayerPrefs.SetInt("Score", currentScore - enemy.score * penaltyMultiplyer);
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemy.speed);
    }
}
