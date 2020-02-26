using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Enemies enemy;
    [SerializeField] GameObject topBoundary;
    [SerializeField] GameObject downBoundary;
    [SerializeField] GameObject explosion;
    private GameObject explo;

    void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + enemy.score);

        explo = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public void MinusScore()
    {
        var currentScore = PlayerPrefs.GetInt("Score");

        // PlayerPrefs.SetInt("Score", currentScore - objectScore * 2);
    }
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * enemy.speed);

        if (transform.position.z > topBoundary.transform.position.z)
            Destroy(gameObject);
        else if (transform.position.z < downBoundary.transform.position.z)
        {
            MinusScore();
            Destroy(gameObject);
        }
    }
}
