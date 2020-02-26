using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{
    private float buffTime;
    private void OnTriggerEnter(Collider other)
    {
        buffTime = other.GetComponent<BuffEmitter>().buff.time;
        if (other.CompareTag("Buff"))
        {
            Debug.Log("UnBuff");
            StartCoroutine(Debuffer());
        }

    }
    IEnumerator Debuffer()
    {
        yield return new WaitForSeconds(buffTime);
        transform.localScale = Vector3.one;
        Destroy(gameObject);
    }
}
