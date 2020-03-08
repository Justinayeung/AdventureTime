using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomObject : MonoBehaviour
{
    public GameObject mushroom;
    public Animator anim;
    public AudioSource chestOpenSource;
    public AudioClip chestOpenClip;


    void Awake() {
        mushroom.SetActive(false);
        anim.SetBool("CanSee", false);
    }

    /// <summary>
    /// Start chest opening animation + sound, and setting flower to active
    /// </summary>
    public void setMushroomTrue() {
        mushroom.SetActive(true);
        anim.SetBool("CanSee", true);
        chestOpenSource.PlayOneShot(chestOpenClip);
    }
}
