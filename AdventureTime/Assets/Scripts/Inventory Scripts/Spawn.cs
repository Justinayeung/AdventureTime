using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour // This is more like destorying UI script
{
    private Inventory inventory;
    public int i;
    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("InventoryManager").GetComponent<Inventory>();
    }
    void Update()
    {
        if (StaticClass.axUsed == true) {  // destory the ax when it is used
            //Destroy(this.gameObject, 0.5f);
            gameObject.SetActive(false);
            inventory.isFull[i] = false;
        }
        if (StaticClass.cloverUsed == true)  // destory the clover when it is used
        {
            //Destroy(this.gameObject, 0.5f);
            gameObject.SetActive(false);
            inventory.isFull[i] = false;
        }
        if (StaticClass.posionUsed == true)  // destory the posion when it is used
        {
            //Destroy(this.gameObject, 0.5f);
            gameObject.SetActive(false);
            inventory.isFull[i] = false;
        }
    }
}
