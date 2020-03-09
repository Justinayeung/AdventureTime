using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom_UI : MonoBehaviour
{
    void Update()
    {
        if (StaticClass.mushroomUsed == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
