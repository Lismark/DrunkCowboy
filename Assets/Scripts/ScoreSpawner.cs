using UnityEngine;
using System.Collections;

public class ScoreSpawner : MonoBehaviour
{
    [SerializeField] private Scores pooScore;
    private int pooCount = 4;



    private void OnDestroy()
    {

        for (int i = 0; i < pooCount; i++)
        {
            Instantiate(pooScore.scoreObject, gameObject.transform.position, Quaternion.Euler(0, Random.Range(0,360), 0));
        }

    }
}
