using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableACollider : MonoBehaviour
{

    public  bool SceneChanged = false;
    public GameObject beforeScene;
    public GameObject afterScene;
   
    void Update()
    {
      if(SceneChanged == false)
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
