using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmaranthusPickedUp : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            StaticClass.amaranthusObtained = true;
        }
    }
}
