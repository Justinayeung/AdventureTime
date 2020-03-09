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
    /*
    public void Update()
    {
        if (this.transform.childCount <=0 && inventory.isFull[i] == true) { // this checks if a slot is an empty 
            inventory.isFull[i] = false; // if the slot is empty, the player can collect staff
        }
    }
    */
    public void SlotFull() { // somehow this does not work
        //if (this.transform.childCount <= 0) // this checks if a slot is an empty 
        //{
        //    inventory.isFull[i] = false; // if the slot is empty, the player can collect staff
        //}

        if (inventory.isFull[i] == true)
        { // this checks if a slot is an empty 
            inventory.isFull[i] = false; // if the slot is empty, the player can collect staff
        }
    }

    /*
    /// <summary>
    /// Icon on the slot becomes setactive false, however this does not work so i am taking this out
    /// </summary>
    public void DestoryIcon() {
        foreach (Transform child in transform) {
            //GameObject.Destroy(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    */

}
