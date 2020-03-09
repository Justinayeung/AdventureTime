using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroomDestroy : MonoBehaviour
{
    void Start()
    {
        if (StaticClass.haveMushroom == true)
        {
            Destroy(this.gameObject);
        }
    }
}
