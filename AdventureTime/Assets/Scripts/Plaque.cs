using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plaque : MonoBehaviour
{
    public Animator riddleAnim;

    public void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            riddleAnim.SetBool("isShowing", true);
        }
    }
}
