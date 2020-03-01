using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoresTableOne : MonoBehaviour
{
    [SerializeField] private Text scoreText;


    public void FixedUpdate()
    {
        scoreText.text = PlayerPrefs.GetInt("Score").ToString();
    }

    public void AddScore()
    {
        Debug.Log("Score added!");
    }

}
