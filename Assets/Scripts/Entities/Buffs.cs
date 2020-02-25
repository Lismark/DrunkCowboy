using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 [CreateAssetMenu(fileName = "newBuff", menuName = "Buffs/New buff")]
public class Buffs : ScriptableObject
{
    public string type;
    public string info;
    public float value;
    public float time;
    public float speed;
}
