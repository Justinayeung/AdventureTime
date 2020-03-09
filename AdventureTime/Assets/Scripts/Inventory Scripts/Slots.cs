using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
    }
    public void Update()
    {
        /*
        if (this.transform.childCount <=0 && inventory.isFull[i] == true) { // this checks if a slot is an empty 
            inventory.isFull[i] = false; // if the slot is empty, the player can collect staff
        }
        */
    }

}
