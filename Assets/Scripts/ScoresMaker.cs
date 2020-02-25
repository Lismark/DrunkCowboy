using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoresMaker : MonoBehaviour
{
    private int allScore;
    
    private void OnTriggerEnter(Collider other)
    {

        AddScore(other);
    }

    private void AddScore(Collider other)
    {
        var score = other.GetComponent<Score>().score;
        allScore += score;
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + allScore);
        Debug.Log(PlayerPrefs.GetInt("Score"));
    }
}
