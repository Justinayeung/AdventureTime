using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clover_UI : MonoBehaviour
{
    void Update()
    {
        if (StaticClass.cloverUsed == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
