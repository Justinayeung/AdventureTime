using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmaranthusObject : MonoBehaviour
{
    public GameObject flower;
    public Animator anim;
    public AudioSource chestOpenSource;
    public AudioClip chestOpenClip;


    void Awake()
    {
        flower.SetActive(false);
        anim.SetBool("CanSee", false);
    }

    public void setAmaranthusTrue() {
        flower.SetActive(true);
        anim.SetBool("CanSee", true);
        chestOpenSource.PlayOneShot(chestOpenClip);
    }
}
