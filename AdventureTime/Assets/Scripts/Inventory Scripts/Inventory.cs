using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public enum pickupTypes { Ax, Clover, Amaranthus, Mushroom };

    public bool[] isFull;
    public GameObject[] slots;

    static Inventory _instance;

    //public GameObject pickupUI; // place UI

    [Header("UI icons")]
    public GameObject cloverUI;
    public GameObject axUI;
    public GameObject mushroomUI;
    public GameObject amaranthusUI;

    void Awake()
    {
        if (_instance == null) // if inventory is empty
        {
            _instance = this; // inventory in the current scene
        }
        else {
            Destroy(this.gameObject); // this destorys the new inventory that does not store information
        }

        DontDestroyOnLoad(this.gameObject); // next scene this inventory script won't be destoryed and keep the info

        /*
        cloverUI.SetActive(false);
        axUI.SetActive(false);
        amaranthusUI.SetActive(false);
        mushroomUI.SetActive(false);
        */
    }
    /// <summary>
    /// This function checks the object is picked up and spawns the icon on inventory and also checks that inventory is occupied
    /// </summary>
    /// <param name="pickedupitem"></param>
    public void PickedUp(pickupTypes pickedupitem) {

            for (int i = 0; i < slots.Length; i++)
            {
                if (isFull[i] == false) // this means inventory has more space to add items  //not full!!//
                {
                    isFull[i] = true; // this slot is full

                switch(pickedupitem){
                    case pickupTypes.Ax:
                        StaticClass.haveAx = true;
                        axUI.transform.position = slots[i].transform.position;
                        axUI.transform.parent = slots[i].transform;   // this sets the the slot as a parent // Since in "Slots script" it is using 
                        axUI.SetActive(true);                         // child of the slot to check that space is full or not
                        break;
                    case pickupTypes.Clover:
                        StaticClass.haveClover = true;
                        cloverUI.transform.position = slots[i].transform.position;
                        cloverUI.transform.parent = slots[i].transform;
                        cloverUI.SetActive(true);
                        break;

                    case pickupTypes.Amaranthus:
                        StaticClass.haveAmaranthus = true;
                        amaranthusUI.transform.position = slots[i].transform.position;
                        amaranthusUI.transform.parent = slots[i].transform;
                        amaranthusUI.SetActive(true);
                        break;

                    case pickupTypes.Mushroom:
                        StaticClass.haveMushroom = true;
                        mushroomUI.transform.position = slots[i].transform.position;
                        mushroomUI.transform.parent = slots[i].transform;
                        mushroomUI.SetActive(true);
                        break;
                }

                    break; // this break the for loop of checking empty slots
                }
            }
       


    }

}

