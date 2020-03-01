using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [CreateAssetMenu(fileName = "newBuff", menuName = "Buffs/New buff")]
public class Buffs: ScriptableObject
{
    public float buffTime = 2;
    public float fireRateModifier = 1;
    public float playerSizeModifier = 1;
    public float bulletSizeModifier = 1;
    public GameObject particleCollision;

    public enum ShootingTypes
    {
        single, tripple, bigShot
    }
    public ShootingTypes shootingTypes;
}
