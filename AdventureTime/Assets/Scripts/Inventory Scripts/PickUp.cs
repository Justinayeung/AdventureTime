using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    [Header("Picked up UIs")]
    public GameObject itemThatPickedUp; // place UI

    private bool haveAx;
    public AudioSource axPickUpSound;  // this should be changed to just pickup sound
    public AudioClip axPickedUpClip;
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
                    //Instantiate(itemThatPickedUp, inventory.slots[i].transform, false);

                    if (gameObject.CompareTag("Ax") && inventory.isFull[i] == true)
                    {
                        axPickUpSound.PlayOneShot(axPickedUpClip);
                        haveAx = true;
                        StaticClass.haveAx = true;
                    }
                    /*

                    if (gameObject.CompareTag("Posion")) {
                        //sound

                        //bool
                        StaticClass.havePosion = true;
                    }
                    */

                    if (gameObject.CompareTag("Clover") && inventory.isFull[i] == true)
                    {
                        //sound
                        
                        //bool
                        StaticClass.haveClover = true;
                    }

                    Instantiate(itemThatPickedUp, inventory.slots[i].transform, false);

                    Destroy(gameObject);
                    break; // this break the for loop of checking empty slots
                }
            }
        }

    }
    /// <summary>
    /// Function that checks the ax is picked up or not
    /// </summary>
    /// <param name="pickedUp"></param>
    /// <returns></returns>
    public bool PickedUpTheAx(bool pickedUp) {
        if (haveAx == true && StaticClass.haveAx == true)
        {
            pickedUp = true;
        }
        else {
            pickedUp = false;
        }
        return pickedUp;
    }

    public bool PickedUpThePosion(bool pickedUp)
    {
        if (StaticClass.havePosion == true)
        {
            pickedUp = true;
        }
        else
        {
            pickedUp = false;
        }
        return pickedUp;
    }

    public bool PickedUpTheClover(bool pickedUp)
    {
        if (StaticClass.haveClover == true)
        {
            pickedUp = true;
        }
        else
        {
            pickedUp = false;
        }
        return pickedUp;
    }
}

