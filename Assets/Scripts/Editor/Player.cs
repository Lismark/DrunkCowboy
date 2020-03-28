using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewPlayer",menuName ="Player/NewPlayer")]
public class Player : ScriptableObject
{
    [SerializeField] private float maxHealth;
    public float MaxHealth
    {
        get { return maxHealth; }
    }
    public float fireRate;
    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }   
}
