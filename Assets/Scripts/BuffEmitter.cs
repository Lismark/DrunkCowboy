using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEmitter : MonoBehaviour
{
    public string buffType;
    public float buffValue;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        Buff(other);
    }
    private void Buff(Collider other)
    {
        
        Destroy(gameObject);
    }
}

