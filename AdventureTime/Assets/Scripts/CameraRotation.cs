using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float t;
    public float speed;
    public GameObject CameraRotator;

    void Start()
    {
        t = Time.deltaTime;
    }

    void Update()
    {
        if(t < 1f)
        {
            transform.Rotate(0, speed * t, 0);

        }
        else
        {
            transform.Rotate(0, 0 * t, 0);
        }

    }

    
}
