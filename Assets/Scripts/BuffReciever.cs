using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{
    private float buffTime;
    private PlayerController playerController;
    private GameObject particle;


    private void Start()
    {
        playerController = GetComponent<PlayerController>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Buff"))
        {
            var buffEmitter = other.GetComponent<BuffEmitter>();
            Debug.Log(buffEmitter.objectBuffType);
            playerController.shootingType = buffEmitter.objectBuffType;
            buffTime = buffEmitter.buff.buffTime;
            Instantiate(buffEmitter.buff.particleCollision, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            StartCoroutine(Debuffer(other));
        }

    }
    IEnumerator Debuffer(Collider other)
    {

        yield return new WaitForSeconds(buffTime);
        transform.localScale = Vector3.one;
        playerController.shootingType = 0;
    }
}
