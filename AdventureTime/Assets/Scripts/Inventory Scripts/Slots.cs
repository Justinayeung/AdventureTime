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
        if (transform.childCount <=0) { // this checks that if a slot is empty boolean checks false so that
            inventory.isFull[i] = false; // the player can collect staff
        }
    }

}
