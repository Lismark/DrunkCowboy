using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MobDestroyer : MonoBehaviour
{
    [SerializeField] GameObject topBoundary;
    [SerializeField] GameObject downBoundary;
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
        Destroy(gameObject);
        Destroy(other);
    }

    public void MinusScore()
    {
        var objectScore = GetComponent<Score>().score;
        var currentScore = PlayerPrefs.GetInt("Score");

        PlayerPrefs.SetInt("Score", currentScore - objectScore * 2);
    }

}
