using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
