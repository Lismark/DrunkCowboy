using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEnemy", menuName ="Enemy/New Enemy")]
public class Enemies : ScriptableObject
{
    public float speed = 1f;
    public int scoresAmountDrop;
    public int health;
    public int damage;
}
