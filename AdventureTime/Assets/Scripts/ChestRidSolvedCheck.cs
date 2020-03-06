using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRidSolvedCheck : MonoBehaviour
{
    SphereCollider chestCollider;

    void Start() {
        chestCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update() {
        if (StaticClass.ChestRidSolved) {
            chestCollider.enabled = false;
        }
    }
}
