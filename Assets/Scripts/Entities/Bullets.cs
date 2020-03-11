using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewBullet", menuName ="Bullets/NewBullet")]
public class Bullets : ScriptableObject
{
    public int damage;
    public GameObject bulletPrefab;
    public int speed;
    //public float fireRate;
}
