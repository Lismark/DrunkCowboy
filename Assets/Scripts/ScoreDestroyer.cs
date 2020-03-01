using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDestroyer : MonoBehaviour
{

    private Transform destroyPoint;
    public float speed = 5;

    private void Start()
    {
        destroyPoint = FindObjectOfType<scorePoint>().transform;
    }

    private void Update()
    {
        DestroyScore();
    }
    public void DestroyScore()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, destroyPoint.position, speed * Time.deltaTime);
        var distance = gameObject.transform.position.x - destroyPoint.position.x;
        if ( distance < 0.2f)
        {
            Destroy(gameObject);
        }
        
    }

}
