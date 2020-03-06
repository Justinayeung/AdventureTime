using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <=0) { // this checks if a slot is an empty 
            inventory.isFull[i] = false; // if the slot is empty, the player can collect staff
        }
    }

}
