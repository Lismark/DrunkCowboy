using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] public Bullets bulletEntity;
    [SerializeField] private Borders borders;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * bulletEntity.speed);
    }

    private void Update()
    {
        TopDestroyer();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        Destroy(gameObject);
    }
    public void TopDestroyer()
    {
        if (transform.position.z > borders.topBorder)
            Destroy(gameObject);
    }
}
