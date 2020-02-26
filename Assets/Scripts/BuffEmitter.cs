using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEmitter : MonoBehaviour
{
    [SerializeField] public Buffs buff;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        Buff(other);
    }
    private void Buff(Collider other)
    {
        other.transform.localScale *= buff.value;
        Destroy(gameObject);
    }


}

