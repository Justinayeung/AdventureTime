using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestRidSolvedCheck1 : MonoBehaviour
{
    SphereCollider chestCollider;

    void Start() {
        chestCollider = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update() {
        if (StaticClass.chestSolved) {
            chestCollider.enabled = false;
        }
    }
}
