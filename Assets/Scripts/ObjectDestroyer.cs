using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] GameObject topBoundary;
    public GameObject downBoundary;
    void Update()
    {
        if (transform.position.z > topBoundary.transform.position.z)
            Destroy(gameObject);
        else if (transform.position.z < downBoundary.transform.position.z)
            Destroy(gameObject);
    }
}
