using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public Inventory.pickupTypes thisitempickuptype;

    public AudioSource PickUpSound;
    public AudioClip PickedUpClip;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
        if (StaticClass.haveAx == true) {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inventory.PickedUp(thisitempickuptype);
            //add ax pick up sound
            Destroy(this.gameObject);
        }

    }
}

