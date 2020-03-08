using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathToChestRidVineScript : MonoBehaviour
{

    private Animator anim;
    public PickUp pickup;
    public Collider thisCollider;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            if (StaticClass.haveAx == true)
            {
                //play cutting animation of the player

                //vine cutting sound

                //vine destroy animation
                anim.SetTrigger("VineBreak"); // vine break animation

                //goes to next scene

                StaticClass.axUsed = true; // this bool checks if ax is used so that we could destroy the ax UI in "Spawn" Script.
            }

            thisCollider.enabled = false;
        }
    }

}
