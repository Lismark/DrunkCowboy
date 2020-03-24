using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Randomizer
{
    public static int Randomize(Randomable[] objects)
    {
        List<int> table = new List<int>();
        int index = 0;
        for (int i = 0; i < objects.Length; i++)
        {
            for (int j = 0; j < objects[i].SpawnChanceWeigth; j++)
            {
                table.Add(index);
            }
            index++;
        }

        int randomItem = Random.Range(0, table.Count);
        return table[randomItem];
    }
}
