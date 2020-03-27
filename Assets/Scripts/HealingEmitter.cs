using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingEmitter : MonoBehaviour
{
    [SerializeField] Pots pot;
    [SerializeField] Player player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            player.CurrentHealth += pot.addAmount;
        }
    }
}
