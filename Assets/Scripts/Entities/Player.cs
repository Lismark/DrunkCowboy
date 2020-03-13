using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayer", menuName ="PlayerType/Player")]
public class Player : ScriptableObject
{
    public int health;
    public float fireRate;
}
