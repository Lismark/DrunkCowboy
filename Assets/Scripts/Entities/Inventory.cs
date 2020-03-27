using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Inventory", menuName ="Inventory/NewInventory")]
public class Inventory : ScriptableObject
{
    public List<GameObject> items;


    public void AddToInventory(GameObject item)
    {
        if (items == null)
            items = new List<GameObject>();

        items.Add(item);
    }


    public void RemoveFromInventory()
    {
        if (items == null)
            return;
    }
}
