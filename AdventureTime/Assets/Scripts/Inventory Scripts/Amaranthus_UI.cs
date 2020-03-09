using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amaranthus_UI : MonoBehaviour
{
    void Update()
    {
        if (StaticClass.amaranthusUsed == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
