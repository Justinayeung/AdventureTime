using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPickedUp : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Player")) {
            StaticClass.mushObtained = true;
        }
    }
}
