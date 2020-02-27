﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slots : MonoBehaviour
{
    private Inventory inventory;
    public int i;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void Update()
    {
        if (transform.childCount <=0) {
            inventory.isFull[i] = false;
        }
        if (Input.GetKeyDown(KeyCode.A)) // this is for a test purpose
        {
            DropItem();
        }
    }

    public void DropItem() {
           // Debug.Log("pressed??");
            foreach (Transform child in transform)
            {
                child.GetComponent<Spawn>().SpawnDroppedItem();
                GameObject.Destroy(child.gameObject);
            }
    }
}