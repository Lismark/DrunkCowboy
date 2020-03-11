using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public Bullets bulletEntity;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletEntity.speed);
    }
}
