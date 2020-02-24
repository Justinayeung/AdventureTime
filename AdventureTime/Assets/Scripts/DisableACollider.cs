using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableACollider : MonoBehaviour
{

    public static bool sceneChanged;
    public GameObject beforeScene;
    public GameObject afterScene;
   
    void Update()
    {
      if(StaticClass.sceneChanged == false)
        {
           beforeScene.SetActive(true);
            afterScene.SetActive(false);
        }
        else
        {
            beforeScene.SetActive(false);
            afterScene.SetActive(true);
        }
    }

   
}
