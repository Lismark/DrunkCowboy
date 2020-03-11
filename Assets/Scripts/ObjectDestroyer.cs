using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField] private static float topBoundary = 23f;
    public static float TopBoundary
    {
        get { return topBoundary; }
    }
    [SerializeField] private static float downBoundary = -3f;
    public static float DownBoundary
    {
        get { return downBoundary; }
    }
    void Update()
    {
        if (transform.position.z > topBoundary)
            Destroy(gameObject);
        else if (transform.position.z < downBoundary)
            Destroy(gameObject);
    }
}
