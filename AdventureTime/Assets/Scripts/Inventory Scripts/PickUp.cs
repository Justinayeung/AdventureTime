using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    [Header("Picked up UIs")]
    public GameObject itemThatPickedUp; // place UI

    public bool haveAx;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
        haveAx = false;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if (inventory.isFull[i] == false) // this means inventory has more space to add items
                {
                    inventory.isFull[i] = true; // inventory is full
                    Instantiate(itemThatPickedUp, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break; // this break the for loop of checking empty slots
                }
            }
        }
        if (gameObject.CompareTag("Ax"))
        {
            haveAx = true;
        }
    }

    public bool PickedUpTheAx(bool pickedUp) {
        haveAx = pickedUp;
        return pickedUp;
    }
}

