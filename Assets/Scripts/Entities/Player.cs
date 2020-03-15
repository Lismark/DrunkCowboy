using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayer", menuName ="PlayerType/Player")]
public class Player : ScriptableObject
{
    public int maxHealth;
    public int currentHealth;
    public float fireRate;
}
