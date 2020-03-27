using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff : Randomable
{
    public int index;
    public int spawnChanceWeigth;
    public override int SpawnChanceWeigth
    {
        get { return spawnChanceWeigth; }
        set { spawnChanceWeigth = value; }
    }
    public override int Index
    {
        get { return index; }
        set { index = value; }
    }
}
