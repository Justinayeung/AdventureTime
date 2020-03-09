using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineDestroy : MonoBehaviour
{
    void Start()
    {
        if (StaticClass.axUsed == true)
        {
            Destroy(this.gameObject);
        }
    }

}
