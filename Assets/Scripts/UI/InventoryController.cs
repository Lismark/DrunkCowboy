using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryController : MonoBehaviour
{
    [SerializeField] private GameObject[] cells;
    public GameObject[] items;

    private Sprite[] cellsBg;
    private void FixedUpdate()
    {
       foreach(var i in items)
        {
            Debug.Log(i.name);
        }
    }
}
