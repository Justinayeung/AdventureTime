using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableACollider : MonoBehaviour
{
    public GameObject beforeScene;
    public GameObject afterScene;
    public GameObject afterRid;
   
    void Update() {
        if (!StaticClass.sceneChanged) { //If plaque at chest riddle has not been visited
            beforeScene.SetActive(true);
            afterScene.SetActive(false);
            afterRid.SetActive(false);
        } else if (StaticClass.sceneChanged && !StaticClass.amaranthusObtained) { //If plaque at chest riddle has been visited and amaranthus not obtained
            beforeScene.SetActive(false);
            afterScene.SetActive(true);
            afterRid.SetActive(false);
        } else if (StaticClass.amaranthusObtained) { //If amaranthus has been obtained
            beforeScene.SetActive(false);
            afterScene.SetActive(false);
            afterRid.SetActive(true);
        }
    }

   
}
