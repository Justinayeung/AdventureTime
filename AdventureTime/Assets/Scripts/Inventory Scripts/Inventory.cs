using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum pickupTypes { Ax, Clover, Posion };

    public bool[] isFull;
    public GameObject[] slots;

    static Inventory _instance;

    //public GameObject pickupUI; // place UI

    [Header("UI icons")]
    public GameObject cloverUI;
    public GameObject axUI;
    //public GameObject posionUI;

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
        cloverUI.SetActive(false);
        axUI.SetActive(false);
    }

    public void Update()
    {
        //PickedUp(itemPickedUp);
    }
    public void PickedUp(pickupTypes pickedupitem) {
        //itemPickedUp = _pickedUp;

            for (int i = 0; i < slots.Length; i++)
            {
                if (isFull[i] == false) // this means inventory has more space to add items
                {
                    isFull[i] = true; // inventory is full

                switch(pickedupitem){
                    case pickupTypes.Ax:
                        StaticClass.haveAx = true;
                        axUI.transform.position = slots[i].transform.position;
                        axUI.transform.parent = slots[i].transform;
                        axUI.SetActive(true);
                        break;
                    case pickupTypes.Clover:
                        StaticClass.haveClover = true;
                        cloverUI.transform.position = slots[i].transform.position;
                        cloverUI.transform.parent = slots[i].transform;
                        cloverUI.SetActive(true);
                        break;

                    case pickupTypes.Posion:
                        StaticClass.havePosion = true;
                        //posionUI.transform.position = slots[i].transform.position;
                        //posionUI.SetActive(true);
                        break;
                }

                    break; // this break the for loop of checking empty slots
                }
            }
       


    }

}

