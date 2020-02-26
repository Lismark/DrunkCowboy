using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{
    private float buffTime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Buff"))
        {
        StartCoroutine(Debuffer(other));
        buffTime = other.GetComponent<BuffEmitter>().buff.time;
        }

    }
    IEnumerator Debuffer(Collider other)
    {
        yield return new WaitForSeconds(buffTime);
        transform.localScale = Vector3.one;
    }
}
