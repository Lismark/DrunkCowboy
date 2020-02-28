using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEmitter : MonoBehaviour
{
    [SerializeField] public Buffs buff;
    [SerializeField] GameObject particle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Buff(other);
            Destroy(gameObject);
        }
    }
    private void Buff(Collider other)
    {
        other.transform.localScale *= buff.value;
        Instantiate(particle, transform.position, Quaternion.identity);

    }


}

