using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxDestroy : MonoBehaviour
{
    void Start()
    {
        if (StaticClass.haveAx == true)
        {
            Destroy(this.gameObject);
        }
    }

}
