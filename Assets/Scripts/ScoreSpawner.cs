using UnityEngine;
using System.Collections;

public class ScoreSpawner : MonoBehaviour
{
    [SerializeField] private Scores pooScore;
    [SerializeField] private Enemies enemy;



    private void OnDestroy()
    {

        for (int i = 0; i < enemy.scoresAmount; i++)
        {
            Instantiate(pooScore.scoreObject, new Vector3(gameObject.transform.position.x + Random.Range(0, 1f),
                gameObject.transform.position.y, gameObject.transform.position.z + Random.Range(0, 1f)),
                Quaternion.Euler(0, Random.Range(0,360), 0));
        }

    }
}
