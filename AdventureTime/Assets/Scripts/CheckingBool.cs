using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingBool : MonoBehaviour
{
    public static bool sceneChanged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StaticClass.sceneChanged = true;
        }

    }
}
