using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathToChestRidVineScript : MonoBehaviour
{

    private Animator anim;
    public PickUp pickup;

    void Start()
    {
        anim = GetComponent<Animator>();
        //pickup = GameObject.FindGameObjectWithTag("Ax").GetComponent<PickUp>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            if (pickup.PickedUpTheAx(true))
            {
                //play cutting animation
                //cutting sound
                //vine destroy
                anim.SetTrigger("VineBreak");
                //goes to next scene
            }
            
        }
    }

}
