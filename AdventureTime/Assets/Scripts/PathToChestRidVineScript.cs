using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathToChestRidVineScript : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            if (StaticClass.haveAx == true)
            {
                anim.SetTrigger("VineBreak"); // vine break animation
                StaticClass.axUsed = true; // this bool checks if ax is used so that we could destroy the ax UI in "Spawn" Script.
            }
        }
    }

}
