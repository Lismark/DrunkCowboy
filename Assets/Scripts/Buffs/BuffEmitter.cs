using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEmitter : MonoBehaviour
{
     public Buffs buff;
    [HideInInspector] public GameObject particle;
    [HideInInspector] public int objectBuffType;
    [SerializeField] private Borders borders;

    private void Start()
    {
        particle = buff.particleCollision;
        objectBuffType = (int)buff.shootingTypes;
    }

    private void Update()
    {
        DownDestroyer();
    }

    public void DownDestroyer()
    {
        if (transform.position.z < borders.downBorder)
            Destroy(gameObject);
    }
}

