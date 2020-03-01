using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEmitter : MonoBehaviour
{
     public Buffs buff;
    [HideInInspector] public GameObject particle;
    [HideInInspector] public int objectBuffType;

    private void Start()
    {
        particle = buff.particleCollision;
        objectBuffType = (int)buff.shootingTypes;
    }
}

