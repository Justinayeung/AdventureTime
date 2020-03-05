using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    [Header("Picked up UIs")]
    public GameObject itemThatPickedUp; // place UI

    public AudioSource axPickUpSound;  // this should be changed to just pickup sound
    public AudioClip axPickedUpClip;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
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

                    if (gameObject.CompareTag("Ax") && StaticClass.haveAx == false) // if the player picked up the ax
                    {
                        axPickUpSound.PlayOneShot(axPickedUpClip);   // play ax picking up sound 
                        StaticClass.haveAx = true;                   // and check the player picked up
                    }

                    /*
                    if (gameObject.CompareTag("Posion")  && StaticClass.havePosion == false) {
                        //sound

                        //bool
                        StaticClass.havePosion = true;
                    }
                    */

                    if (gameObject.CompareTag("Clover") && StaticClass.haveClover == false)
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
}

