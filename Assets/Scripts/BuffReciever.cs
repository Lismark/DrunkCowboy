using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffReciever : MonoBehaviour
{
    private float buffTime;
    private PlayerController playerController;

    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Buff"))
        {
            playerController.shootingTypes = PlayerController.ShootingTypes.tripple;
            buffTime = other.GetComponent<BuffEmitter>().buff.time;
            StartCoroutine(Debuffer(other));
        }

    }
    IEnumerator Debuffer(Collider other)
    {

        yield return new WaitForSeconds(buffTime);
        transform.localScale = Vector3.one;
        playerController.shootingTypes = 0;
    }
}
