﻿using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MobDestroyer : MonoBehaviour
{
    [SerializeField] GameObject topBoundary;
    [SerializeField] GameObject downBoundary;
    [SerializeField] GameObject explosion;
    private GameObject explo;
    void Update()
    {
        if (transform.position.z > topBoundary.transform.position.z)
            Destroy(gameObject);
        else if (transform.position.z < downBoundary.transform.position.z)
        {
            MinusScore();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        explo = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        
    }

    public void MinusScore()
    {
        var objectScore = GetComponent<Score>().score;
        var currentScore = PlayerPrefs.GetInt("Score");

        PlayerPrefs.SetInt("Score", currentScore - objectScore * 2);
    }

    private void DestroyEffect()
    {

    }
}
