using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AX_UI : MonoBehaviour
{
    private Slots slots;  /// this does not workkkkk

    void Start()
    {
        slots = GameObject.FindGameObjectWithTag("Slots").GetComponent<Slots>();
    }

    void Update()
    {
        if (StaticClass.axUsed == true) {
            slots.SlotFull();
            this.gameObject.SetActive(false);
        }
    }
}
