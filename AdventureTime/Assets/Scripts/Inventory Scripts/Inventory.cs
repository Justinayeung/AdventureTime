using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    static Inventory _instance;

    void Awake()
    {
        if (_instance == null) // if inventory is empty
        {
            _instance = this; // inventory in the current scene
        }
        else {
            Destroy(this.gameObject); // this destorys the new inventory that does not store information
        }

        DontDestroyOnLoad(this.gameObject);
    }

}
